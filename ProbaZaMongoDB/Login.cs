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
           /* else if (acc[i].Username == usernameTxt.Text && acc[i].Password != passwordTxt.Text)
            {
                WrongPassLogin.Visible = true;
                passwordTxt.Text = "";
            }
            else if (acc[i].Username != usernameTxt.Text && acc[i].Password == passwordTxt.Text)
            {
                IncorrectUserNameLogin.Visible = true;
                usernameTxt.Text = "";
            }*/

        }
        public bool CheckUsernameAndPassword(string txtBoxUsername, string txtBoxPassword)
        {
            /*ova fja treba da proveri username i password koji su uneti i da li postoje u kolekciji u kojoj se cuvaju informacije o nalogu
            problem je sto ne treba da se nadju bilo koji username i password,samo da postoje, nego da su to podaci jednog objekta
            Ovaj query bi bio dobro resenje ali ne moze da se prosledi string

            btw ova fje je prvobitno proveravala samo username da li postoji pa sam htela da probam da li bi bilo bolje ako se sve proveri odjednom
            */

            var connectionString = "mongodb://localhost/?safe=true";
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            var database = client.GetDatabase("Proba");

            var collection = database.GetCollection<Account>("account");
                var query = Query.And(
                            Query.EQ("Username", txtBoxUsername),
                            Query.EQ("Password", txtBoxPassword)
                            );
            
            
          //  MongoCursor m = collection.FindAs(query);

            var filter = Builders<Account>.Filter;
             //   var result = collection.Find(filter).ToString();

                /* var existsUser = collection.AsQueryable().Any(x => x.Username == txtBoxUsername , x => x.Password == txtBoxPassword);
                 var existsPass = collection.AsQueryable().Where(x => x.Username == txtBoxUsername )


                 if (existsUser && existsPass)
                 {
                     return true;
                 }*/
                return false;
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

               // if (CheckUsername(textBoxUserSign.Text) || textBoxUserSign.Text == "")
                //{
                    InvalidNameSignUp.Visible = true;
                //}
                /*else
                {
                    Account a = new Account(textBoxUserSign.Text, textBoxPassSign.Text);
                    acc.Add(a);
                    var collection = database.GetCollection<Account>("account");
                    collection.InsertOne(a);
                    var bucket = new GridFSBucket(database, new GridFSBucketOptions
                    {
                        BucketName = textBoxUserSign.Text
                    });
                    Form1 f = new Form1();
                    f.ShowDialog();
                    this.Close();
                }*/
            }


        }
    }
}
