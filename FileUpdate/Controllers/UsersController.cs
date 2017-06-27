using FileUpdate.Models;
using FileUpdate.Static;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FileUpdate.Controllers
{
    [System.Web.Mvc.OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
    public class UsersController : ApiController
    {
        [HttpGet]
        public void Set(string name, int amount, int bottle)
        {
            int index = JsonFile.Instance.GetAll().FindIndex(p => p.name == name);
            if (index != -1)
            {
                JsonFile.Instance.SetUser(index, amount, bottle);
            }
        }

        [HttpGet]
        public bool isAlive()
        {
            return true;
        }

        [HttpGet]
        public void Save(int number)
        {
            JsonFile.Instance.SaveToFile();
        }

        [HttpGet]
        public void SetUsers(string Json)
        {
            JsonFile.Instance.SetItems(Json);
            JsonFile.Instance.SaveToFile();
        }

        [HttpGet]
        public void Reset(int num)
        {
            JsonFile.Instance.Reset();
        }

        [HttpGet]
        public void GetFile(int n)
        {
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.BufferOutput = false;
            string archiveName = "יחצנים.csv";

            HttpContext.Current.Response.ContentType = "application/csv";
            HttpContext.Current.Response.Charset = "utf-8";
            HttpContext.Current.Response.AddHeader("content-disposition", "attachment;filename=" + archiveName);

            StreamWriter file = null;
            file = new StreamWriter(archiveName, false, Encoding.UTF8);

            var csv = new StringBuilder();
            foreach (User item in JsonFile.Instance.GetAll())
            {
                var newline = string.Format("{0},{1},{2},{3},{4},{5}", item.name, item.salary, item.people, item.bottle, item.precent, item.people * item.salary + item.bottle * item.precent);
                csv.AppendLine(newline);
            }


            file.Write(csv.ToString());

            file.Flush();
            file.Close();

            HttpContext.Current.Response.WriteFile(archiveName);
            HttpContext.Current.Response.End();
        }


        //MustWork
        [HttpPost]
        public void Opm([FromBody]List<User> value)
        {
            JsonFile.Instance.Save(value);
        }

        [HttpPost]
        public async Task<IHttpActionResult> UploadFile([FromBody]List<User> value)
        {
            if (!Request.Content.IsMimeMultipartContent())
            {
                return StatusCode(HttpStatusCode.UnsupportedMediaType);
            }

            var filesReadToProvider = await Request.Content.ReadAsMultipartAsync();

            foreach (var stream in filesReadToProvider.Contents)
            {
                var fileBytes = await stream.ReadAsByteArrayAsync();
            }

            return null;
        }
    }
}
