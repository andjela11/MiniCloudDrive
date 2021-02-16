namespace ProbaZaMongoDB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Upload = new System.Windows.Forms.Button();
            this.Download = new System.Windows.Forms.Button();
            this.btnBrows = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPathTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.textNewFName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxNameSearch = new System.Windows.Forms.TextBox();
            this.SearchNameButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DateSearchButton = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Label();
            this.DisplayUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(94, 71);
            this.Upload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(93, 23);
            this.Upload.TabIndex = 0;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(94, 117);
            this.Download.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(93, 23);
            this.Download.TabIndex = 1;
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // btnBrows
            // 
            this.btnBrows.Location = new System.Drawing.Point(193, 71);
            this.btnBrows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(75, 23);
            this.btnBrows.TabIndex = 2;
            this.btnBrows.Text = "Browse";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(282, 71);
            this.textPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPath.Name = "textPath";
            this.textPath.ReadOnly = true;
            this.textPath.Size = new System.Drawing.Size(288, 22);
            this.textPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(593, 71);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(163, 22);
            this.textName.TabIndex = 5;
            // 
            // textPathTo
            // 
            this.textPathTo.Location = new System.Drawing.Point(282, 116);
            this.textPathTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPathTo.Name = "textPathTo";
            this.textPathTo.ReadOnly = true;
            this.textPathTo.Size = new System.Drawing.Size(288, 22);
            this.textPathTo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Path:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 117);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "To:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(247, 175);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(93, 30);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(247, 221);
            this.btnRename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(93, 23);
            this.btnRename.TabIndex = 13;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // textNewFName
            // 
            this.textNewFName.Location = new System.Drawing.Point(168, 283);
            this.textNewFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNewFName.Name = "textNewFName";
            this.textNewFName.Size = new System.Drawing.Size(172, 22);
            this.textNewFName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "New File Name:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(357, 175);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(398, 292);
            this.listBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Search by name:";
            // 
            // txtBoxNameSearch
            // 
            this.txtBoxNameSearch.Location = new System.Drawing.Point(16, 338);
            this.txtBoxNameSearch.Name = "txtBoxNameSearch";
            this.txtBoxNameSearch.Size = new System.Drawing.Size(135, 22);
            this.txtBoxNameSearch.TabIndex = 22;
            // 
            // SearchNameButton
            // 
            this.SearchNameButton.Location = new System.Drawing.Point(157, 337);
            this.SearchNameButton.Name = "SearchNameButton";
            this.SearchNameButton.Size = new System.Drawing.Size(75, 23);
            this.SearchNameButton.TabIndex = 24;
            this.SearchNameButton.Text = "Search\r\n";
            this.SearchNameButton.UseVisualStyleBackColor = true;
            this.SearchNameButton.Click += new System.EventHandler(this.SearchNameButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Search by date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(16, 403);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // DateSearchButton
            // 
            this.DateSearchButton.Location = new System.Drawing.Point(265, 402);
            this.DateSearchButton.Name = "DateSearchButton";
            this.DateSearchButton.Size = new System.Drawing.Size(75, 23);
            this.DateSearchButton.TabIndex = 27;
            this.DateSearchButton.Text = "Search\r\n";
            this.DateSearchButton.UseVisualStyleBackColor = true;
            this.DateSearchButton.Click += new System.EventHandler(this.DateSearchButton_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(23, 443);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(81, 24);
            this.btnShowAll.TabIndex = 28;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(608, 9);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(46, 17);
            this.User.TabIndex = 29;
            this.User.Text = "User: ";
            // 
            // DisplayUser
            // 
            this.DisplayUser.AutoSize = true;
            this.DisplayUser.Location = new System.Drawing.Point(660, 9);
            this.DisplayUser.Name = "DisplayUser";
            this.DisplayUser.Size = new System.Drawing.Size(0, 17);
            this.DisplayUser.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.DisplayUser);
            this.Controls.Add(this.User);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.DateSearchButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SearchNameButton);
            this.Controls.Add(this.txtBoxNameSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNewFName);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPathTo);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.btnBrows);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Upload);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPathTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TextBox textNewFName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxNameSearch;
        private System.Windows.Forms.Button SearchNameButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button DateSearchButton;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label DisplayUser;
    }
}

