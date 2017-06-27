using FileChange.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Web;

namespace FileChange.Static
{
    public class JsonFile
    {
        string pathUpdate = @"C:\Users\ido\Desktop\Programming\SystemUsers\UserSystem\UserSystem\Users\LastSave.json";
        string path = @"C:\Users\ido\Desktop\Programming\SystemUsers\UserSystem\UserSystem\Users\Users.json";
        private static JsonFile instance;
        static List<User> items = new List<User>();

        private JsonFile()
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<User>>(json);
            }
        }

        public static JsonFile Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JsonFile();
                }
                return instance;
            }
        }

        public List<User> GetAll()
        {
            return items;
        }

        //public void UpdateUser(int index,int howmuch)
        //{
        //    items[index].people += howmuch;

        //}
        //public void AddBottle(int index, int price)
        //{
        //    items[index].bottle += price;

        //}

        public void SetUser(int index, int howmuch, int bottle)
        {
            items[index].people = howmuch;
            items[index].bottle = bottle;
        }


        public void SaveToFile()
        {
            string jsonupdate = JsonConvert.SerializeObject(items);
            File.WriteAllText(path, jsonupdate);
            File.WriteAllText(pathUpdate, jsonupdate);
        }


        public void Reset()
        {
            foreach (User item in items)
            {
                item.people = 0;
            }

            SaveToFile();

        }

        public HttpResponseMessage Export()
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write("Hello, World!");
            writer.Flush();
            stream.Position = 0;

            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            result.Content = new StreamContent(stream);
            result.Content.Headers.ContentType = new MediaTypeHeaderValue("text/csv");
            result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment") { FileName = "יחצנים.csv" };
            return result;
        }

    }
}

//List<Pay> Paying = new List<Pay>();

//var csv = new StringBuilder();
//foreach (User item in items)
//{

//    //var newLine = string.Format("{0},{1},{2},{3},{4},{5}", item.name, item.people,item.salary,item.bottle,item.precent,item.people*item.salary+item.bottle*item.precent);
//    //csv.AppendLine(newLine);
//    var newLine = string.Format("{0},{1}", "second", "first");
//    csv.AppendLine(newLine);
//}