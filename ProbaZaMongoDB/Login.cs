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
    public partial class Login : Form
    {
        List<Account> acc = new List<Account>();
        Form1 form1 = new Form1();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckUsernameAndPassword(usernameTxt.Text, passwordTxt.Text))
            {
                var connectionString = "mongodb://localhost/?safe=true";
                MongoClient client = new MongoClient(connectionString);
                MongoServer server = client.GetServer();
                var database = client.GetDatabase("Proba");

                var bucket = new GridFSBucket(database, new GridFSBucketOptions
                {
                    BucketName = usernameTxt.Text
                });

                form1.DisplayUserFunc(usernameTxt.Text);
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                IncorrectUserNameLogin.Visible = true;
                WrongPassLogin.Visible = true;
                usernameTxt.Text = "";
                passwordTxt.Text = "";
            }
        }
        public bool CheckUsernameAndPassword(string txtBoxUsername, string txtBoxPassword)
        {
            bool res;
            var connectionString = "mongodb://localhost/?safe=true";
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            var database = client.GetDatabase("Proba");

            var collection = database.GetCollection<Account>("account");



            var filter = Builders<Account>.Filter.Eq(x => x.Username, txtBoxUsername);
            var result = collection.Find(filter).ToList().First();  
            
                if (result.Password == txtBoxPassword)
                {
                    return res = true;
                }
                return res = false;
            

        }
        public bool CheckUsername(string txtBoxUsername)
        {
            bool res;
            var connectionString = "mongodb://localhost/?safe=true";
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            var database = client.GetDatabase("Proba");

            var collection = database.GetCollection<Account>("account");

            var exist = collection.AsQueryable().Any(x => x.Username == txtBoxUsername);
            return exist;

            

        }
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            var database = client.GetDatabase("Proba");

            if (textBoxPassSign.Text != textBoxConfirm.Text || textBoxPassSign.Text == "" || textBoxConfirm.Text == "")
            {
                passNotMatch.Visible = true;
            }
            else
            {

                if (CheckUsername(textBoxUserSign.Text) || textBoxUserSign.Text == "")
                {
                    InvalidNameSignUp.Visible = true;
                }
                else
                {
                    
                    var bucket = new GridFSBucket(database, new GridFSBucketOptions
                    {
                        BucketName = textBoxUserSign.Text,
                        ChunkSizeBytes = 1048576,
                        WriteConcern = WriteConcern.WMajority,
                        ReadPreference = ReadPreference.Secondary
                    });

                    
                    var AccountCollection = database.GetCollection<Account>("account");
                    

                    Account a = new Account { Username = textBoxUserSign.Text, Password = textBoxPassSign.Text};
                    acc.Add(a);
                    AccountCollection.InsertOne(a);
                   

                    form1.DisplayUserFunc(textBoxUserSign.Text);
                    form1.ShowDialog();
                    this.Close();
                }
            }


        }
    }
}
