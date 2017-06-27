using FileUpdate.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace FileUpdate.Static
{
    public class JsonFile
    {
        string path = HttpContext.Current.Server.MapPath("~/") + "Users\\Users.json"; //@"C:\Users\ido\Desktop\Programming\SystemUsers\UserSystem\FileUpdate\Users\Users.json";// System.AppDomain.CurrentDomain.BaseDirectory + "Users//LastSave.json";
        string pathUpdate = HttpContext.Current.Server.MapPath("~/") + "Users\\LastSave.json";   // @"C:\Users\ido\Desktop\Programming\SystemUsers\UserSystem\FileUpdate\Users\LastSave.json";//System.AppDomain.CurrentDomain.BaseDirectory + "Users//Users.json";
        private static JsonFile instance;
        List<User> items = new List<User>();

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

        public List<User> GetAllUpdate()
        {
            List<User> userslist = new List<User>();
            using (StreamReader r = new StreamReader(pathUpdate))
            {
                string json = r.ReadToEnd();
                userslist = JsonConvert.DeserializeObject<List<User>>(json);
            }

            return userslist;
        }

        //public void AddItem()
        //{
        //    return items;
        //}

        //public void UpdateUser(int index, int howmuch)
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

        public void Save(List<User> users)
        {
            items = users;
            string jsonupdate = JsonConvert.SerializeObject(users);
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

        public void SetItems(string json)
        {
            items.Clear();
            items = JsonConvert.DeserializeObject<List<User>>(json);
        }
    }
}