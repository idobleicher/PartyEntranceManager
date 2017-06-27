using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using FileUpdate.Models;

namespace Managing
{
    public partial class Managing : Form
    {
        //string path = @"C:\Users\ido\Desktop\Programming\SystemUsers\UserSystem\UserSystem\Users\Users.json";
        List<User> items = new List<User>();
        public Managing()
        {
            InitializeComponent();
            items = FileUpdate.Static.JsonFile.Instance.GetAll();
            UsersGrid.DataSource = items;
            UsersGrid.RightToLeft = RightToLeft.Yes;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Delete
        private void button1_Click(object sender, EventArgs e)
        {
            int index = UsersGrid.CurrentRow.Index;
            items.Remove(items[index]);
            FileUpdate.Static.JsonFile.Instance.Save(items);
            UsersGrid.DataSource = null;
            UsersGrid.DataSource = items;
            UsersGrid.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //Add
        private void button2_Click(object sender, EventArgs e)
        {
            items.Add(new User() {name= fullName.Text.ToString(),people=0,salary=int.Parse(Rent.Text.ToString()),precent=0.1,bottle=0});
            FileUpdate.Static.JsonFile.Instance.Save(items);
            UsersGrid.DataSource = null;
            UsersGrid.DataSource = items;
            UsersGrid.Refresh();
        }

        private void updateFields_Click(object sender, EventArgs e)
        {
            int index = UsersGrid.CurrentRow.Index;
            items[index].salary =int.Parse(textBox1.Text.ToString());
            items[index].precent = double.Parse(textBox3.Text.ToString());
            FileUpdate.Static.JsonFile.Instance.Save(items);
            UsersGrid.DataSource = null;
            UsersGrid.DataSource = items;
            UsersGrid.Refresh();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        OpenFileDialog Fileopener = new OpenFileDialog();
        private void FileUpload_Click(object sender, EventArgs e)
        {
            string path ="";
            Fileopener.Filter = "TXT|*.txt";
            if (Fileopener.ShowDialog() == DialogResult.OK)
            {
                path = Fileopener.FileName;
            }


            FileStream filestream = new FileStream(path, FileMode.Open, FileAccess.Read);

            string user =  "";

            using (StreamReader streamReader = new StreamReader(filestream, Encoding.UTF8))
            {
                while((user = streamReader.ReadLine()) != null)
                {
                    items.Add(new User() { name = user, people = 0, salary = 10, precent = 0.1, bottle = 0 });
                }
            }

            FileUpdate.Static.JsonFile.Instance.Save(items);
            UsersGrid.DataSource = null;
            UsersGrid.DataSource = items;
            UsersGrid.Refresh();
        }

        private void עדכן_Click(object sender, EventArgs e)
        {
            items = FileUpdate.Static.JsonFile.Instance.GetAllUpdate();
            UsersGrid.DataSource = null;
            UsersGrid.DataSource = items;
            UsersGrid.Refresh();
        }
    }
}
