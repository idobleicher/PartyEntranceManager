using FileUpdate.Models;
using FileUpdate.Static;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using System.Web.Security;

namespace FileUpdate.Controllers
{
    public class FilesController : Controller
    {
        [System.Web.Http.HttpGet]
        public FileContentResult Export()
        {
            var csv = new StringBuilder();
            var newlin = "שם,כמה לאדם,אנשים שהביא,בקבוקים מחיר,אחוזים מהבקבוקים,סכום כולל";
            csv.AppendLine(newlin);

            foreach (User item in JsonFile.Instance.GetAll())
            {
                var newline = string.Format("{0},{1},{2},{3},{4},{5}", item.name, item.salary, item.people, item.bottle, item.precent, item.people * item.salary + item.bottle * item.precent);
                csv.AppendLine(newline);
            }

            var data = Encoding.UTF8.GetBytes(csv.ToString());
            var result = Encoding.UTF8.GetPreamble().Concat(data).ToArray();
            return File(result, "application/csv", "יחצנים.csv");


        }
    }
}