using FileChange.Models;
using FileChange.Static;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FileChange.Controllers
{
    public class UsersController : ApiController
    {

        //[HttpGet]
        //public bool Update(string name, int howmuch)
        //{

        //    int index = JsonFile.Instance.GetAll().FindIndex(p => p.name == name);
        //    if (index != -1)
        //    {
        //        JsonFile.Instance.UpdateUser(index, howmuch);
        //    }
        //    //lstUsers.addNumber();
        //    return true;
        //}

        //[HttpGet]
        //public bool addBottle(string name, int price)
        //{

        //    int index = JsonFile.Instance.GetAll().FindIndex(p => p.name == name);
        //    if (index != -1)
        //    {
        //        JsonFile.Instance.AddBottle(index, price);
        //    }
        //    //lstUsers.addNumber();
        //    return true;
        //}
        [EnableCors(origins: "http://localhost:50720", headers: "*", methods: "*")]
        [HttpGet]
        public void Set(string name, int amount,int bottle)
        {
            int index = JsonFile.Instance.GetAll().FindIndex(p => p.name == name);
            if (index != -1)
            {
                JsonFile.Instance.SetUser(index, amount,bottle);
            }
        }

        [EnableCors(origins: "http://localhost:50720", headers: "*", methods: "*")]
        [HttpGet]
        public bool isAlive()
        {
            return true;
        }

        [EnableCors(origins: "http://localhost:50720", headers: "*", methods: "*")]
        [HttpGet]
        public void Save(int number)
        {
            JsonFile.Instance.SaveToFile();
        }

        [EnableCors(origins: "http://localhost:50720", headers: "*", methods: "*")]
        [HttpGet]
        public void Reset(int num)
        {
            JsonFile.Instance.Reset();
        }

        [EnableCors(origins: "http://localhost:50720", headers: "*", methods: "*")]
        [HttpPost]
        public HttpResponseMessage Export(int numb)
        {
            return JsonFile.Instance.Export();
        }

        [EnableCors(origins: "http://localhost:50720", headers: "*", methods: "*")]
        [HttpGet]
        public void GetFile(int n)
        {
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.BufferOutput = false;
            string archiveName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "/יחצנים.csv";

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
    }
}
