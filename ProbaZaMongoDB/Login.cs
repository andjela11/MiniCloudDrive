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

                MessageBox.Show("Hello " + usernameTxt.Text);

                Form1 form1 = new Form1();
                form1.Show();
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

            /*var filter = Builders<Account>.Filter.Eq(x => x.Username, txtBoxUsername);
            using (var cursor = collection.Find(filter))
            {
                var result = cursor.ToList().First();
                if (result != null)
                {
                    return res = true;
                }
                return res = false;
            }*/

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
                    Account a = new Account(textBoxUserSign.Text, textBoxPassSign.Text);
                    acc.Add(a);
                    var collection = database.GetCollection<Account>("account");
                    collection.InsertOne(new Account(textBoxUserSign.Text, textBoxPassSign.Text));
                    var bucket = new GridFSBucket(database, new GridFSBucketOptions
                    {
                        BucketName = textBoxUserSign.Text
                    });
                    Form1 f = new Form1();
                    f.ShowDialog();
                    this.Close();
                }
            }


        }
    }
}
