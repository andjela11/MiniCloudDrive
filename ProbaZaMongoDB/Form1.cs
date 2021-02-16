using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using System.IO;
using System.Configuration;
using System.Windows.Forms.VisualStyles;
using System.Runtime.CompilerServices;

namespace ProbaZaMongoDB
{
    
    public partial class Form1 : Form
    {
       
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            if(textPath.Text == "")
            {
                MessageBox.Show("Please select a path!");
            }
            else
            {
                var connectionString = "mongodb://localhost/?safe=true";
                MongoClient client = new MongoClient(connectionString);
                MongoServer server = client.GetServer();
                var database = client.GetDatabase("Proba");


                var bucket = new GridFSBucket(database, new GridFSBucketOptions
                {
                    BucketName = DisplayUser.Text
                });
                string fileToUpload = textName.Text;
                FileStream source = new FileStream(textPath.Text, FileMode.Open);
               
                var id = bucket.UploadFromStream(fileToUpload, source);
                
                Reference reference = new Reference { FileID = id.ToString(), Username = DisplayUser.Text };
                var ReferenceCollection = database.GetCollection<Reference>("reference");
                ReferenceCollection.InsertOne(reference);
                
                UpdateListBox();
                MessageBox.Show("File " + fileToUpload + " has been uploaded!");
            }
        }

        private void Download_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            var database = client.GetDatabase("Proba");

            var bucket = new GridFSBucket(database);
            string fileToDownload = listBox.GetItemText(listBox.SelectedItem);
            var collection = database.GetCollection<GridFSFileInfo>(DisplayUser.Text+".files");

            var list = collection.Find(_ => true).ToList();
            string nameToDownload = "";
            foreach (var file in list)
            {
                if (fileToDownload.Contains(file.Filename))
                {
                    nameToDownload = file.Filename;

                }
            }
            if (fileToDownload == "")
            {
                MessageBox.Show("Please select a file to download!");
            }
            else if (textPathTo.Text == "")
            {
                MessageBox.Show("Please select a download path!");
            }
            else
            { 
                string where = (textPathTo.Text + "\\" + nameToDownload);

                using (var newFs = new FileStream(where, FileMode.Create))
                {
                    var t1 = bucket.DownloadToStreamByNameAsync(nameToDownload, newFs);
                    
                    newFs.Flush();
                    newFs.Close();
                    UpdateListBox();
                    MessageBox.Show("File "+ nameToDownload + " has been downloaded!");
                }
            }
            
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textPath.Text = ofd.FileName;
                    textName.Text = ofd.SafeFileName;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    textPathTo.Text = fbd.SelectedPath;
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            var database = client.GetDatabase("Proba");

            var bucket = new GridFSBucket(database, new GridFSBucketOptions
            {
                BucketName = DisplayUser.Text
            });

            string fileToDelete = listBox.GetItemText(listBox.SelectedItem);
            var collection = database.GetCollection<GridFSFileInfo>(DisplayUser.Text+".files");

            var list = collection.Find(_ => true).ToList();
            string nameToDelete = "";
            var idToDelete = "";
            foreach (var file in list)
            {
                if (fileToDelete.Contains(file.Filename))
                {
                    nameToDelete = file.Filename;
                    idToDelete = file.Id.ToString();
                }
            }

            if (fileToDelete == "")
            {
                MessageBox.Show("Please select a file to delete!");
            }
            else
            {
                var filter = Builders<GridFSFileInfo>.Filter.Eq(x => x.Filename, nameToDelete );
                using (var cursor = bucket.Find(filter))
                {
                    var fileInfo = cursor.ToList().FirstOrDefault();
                    bucket.Delete(fileInfo.Id);
                    UpdateListBox();
                }
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            var database = client.GetDatabase("Proba");

            var bucket = new GridFSBucket(database, new GridFSBucketOptions
            {
                BucketName = DisplayUser.Text
            });

            string fileToRename = listBox.GetItemText(listBox.SelectedItem);
            var collection = database.GetCollection<GridFSFileInfo>(DisplayUser.Text+".files");

            var list = collection.Find(_ => true).ToList();
            string nameToRename = "";
            foreach (var file in list)
            {
                if (fileToRename.Contains(file.Filename))
                {
                    nameToRename = file.Filename;

                }
            }
            if (fileToRename == "")
            {
                MessageBox.Show("Please select the file to rename!");
            }
            else if (textNewFName.Text == "")
            {
                MessageBox.Show("Please fill in the new file name!");
            }
            else
            {
                string newFileName = textNewFName.Text;
                var filter = Builders<GridFSFileInfo>.Filter.Eq(x => x.Filename, nameToRename);
                using (var cursor = bucket.Find(filter))
                {
                    var fileInfo = cursor.ToList().FirstOrDefault();
                    bucket.Rename(fileInfo.Id, newFileName);
                    UpdateListBox();
                    newFileName = "";
                    textNewFName.Text = newFileName;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListBox();
        }
        internal int CountOccurrences(string haystack, string needle)
        {
            int n = 0, pos = 0;
            while ((pos = haystack.IndexOf(needle, pos)) != -1)
            {
                n++;
                pos += needle.Length;
            }
            return n;
        }

        public void UpdateListBox()
        {
            listBox.Items.Clear();
            var connectionString = "mongodb://localhost/?safe=true";
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            var database = client.GetDatabase("Proba");

            var RefColl = database.GetCollection<Reference>("reference");

            var bucket = new GridFSBucket(database, new GridFSBucketOptions
            {
                BucketName = DisplayUser.Text
            }) ;

            var filter = Builders<Reference>.Filter.Eq(x => x.Username, DisplayUser.Text);

            var collection = database.GetCollection<GridFSFileInfo>(DisplayUser.Text+".files");

            var list = collection.Find(_ => true).ToList();

            foreach (var file in list)
            {
                listBox.Items.Add(file.Filename+ "      " + file.UploadDateTime + "      " +file.Length + " B");
                this.Controls.Add(listBox);

            }
            this.listBox.DrawMode = DrawMode.OwnerDrawVariable;
            this.listBox.MeasureItem += ListBoxMeasureItem;
            this.listBox.DrawItem += ListBoxDrawItem;
        }

        public void ListBoxMeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)((CountOccurrences(((ListBox)sender).Items[e.Index].ToString(), "\n") + 1) * ((ListBox)sender).Font.GetHeight() + 2);
        }

        public void ListBoxDrawItem(object sender, DrawItemEventArgs e)
        {
            if (((ListBox)sender).Items.Count == 0)
            {
                return;
            }

            string text = ((ListBox)sender).Items[e.Index].ToString();
            e.DrawBackground();
            using (Brush b = new SolidBrush(e.ForeColor)) e.Graphics.DrawString(text, e.Font, b, new RectangleF(e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height));
            e.DrawFocusRectangle();
        }

        private void SearchNameButton_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            var database = client.GetDatabase("Proba");

            var collection = database.GetCollection<GridFSFileInfo>(DisplayUser+".files");
            string name = txtBoxNameSearch.Text;
           

            var bucket = new GridFSBucket(database, new GridFSBucketOptions
            {
                BucketName = DisplayUser.Text
            });
            var filter = Builders<GridFSFileInfo>.Filter.Eq(x => x.Filename, name);
            
            using (var cursor = bucket.Find(filter))
            {
                var fileNames = cursor.ToList().FirstOrDefault();
                
                if(fileNames != null)
                {
                    listBox.Items.Clear();
                    listBox.Items.Add(fileNames.Filename + "      " + fileNames.UploadDateTime + "      " + fileNames.Length + " B");
                }
                else
                {
                    MessageBox.Show("There is no file with selected name. Please choose another one.");
                }
            }

            
        }

        private void DateSearchButton_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            var database = client.GetDatabase("Proba");

            var bucket = new GridFSBucket(database, new GridFSBucketOptions
            {
                BucketName = DisplayUser.Text
            });
            var collection = database.GetCollection<GridFSFileInfo>(DisplayUser.Text+".files");
            int year = this.dateTimePicker2.Value.Year;
            int month = this.dateTimePicker2.Value.Month;
            int day = this.dateTimePicker2.Value.Day;
            var filter = Builders<GridFSFileInfo>.Filter.And(
                Builders<GridFSFileInfo>.Filter.Gte(x => x.UploadDateTime, new DateTime(year, month, day, 0, 0, 0, DateTimeKind.Utc)),
                Builders<GridFSFileInfo>.Filter.Lt(x => x.UploadDateTime, new DateTime(year, month, day + 1, 0, 0, 0, DateTimeKind.Utc)));

            using (var cursor = bucket.Find(filter))
            {
                var fileNames = cursor.ToList();

                if (fileNames != null)
                {
                    listBox.Items.Clear();
                    foreach (var file in fileNames)
                    {
                        listBox.Items.Add(file.Filename + "      " + file.UploadDateTime + "      " + file.Length + " B");
                    }
                }
                else
                    MessageBox.Show("There is no file with selected date. Please choose another one");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        public void DisplayUserFunc(string text)
        {
            DisplayUser.Text = text;
        }
    }
}

