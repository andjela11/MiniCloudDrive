
namespace ProbaZaMongoDB
{
    partial class Login
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
            this.passNotMatch = new System.Windows.Forms.Label();
            this.IncorrectUserNameLogin = new System.Windows.Forms.Label();
            this.WrongPassLogin = new System.Windows.Forms.Label();
            this.InvalidNameSignUp = new System.Windows.Forms.Label();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.textBoxConfirm = new System.Windows.Forms.TextBox();
            this.textBoxPassSign = new System.Windows.Forms.TextBox();
            this.textBoxUserSign = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Label();
            this.passSignUp = new System.Windows.Forms.Label();
            this.userSign = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passLogin = new System.Windows.Forms.Label();
            this.userLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passNotMatch
            // 
            this.passNotMatch.AutoSize = true;
            this.passNotMatch.ForeColor = System.Drawing.Color.Red;
            this.passNotMatch.Location = new System.Drawing.Point(496, 265);
            this.passNotMatch.Name = "passNotMatch";
            this.passNotMatch.Size = new System.Drawing.Size(165, 17);
            this.passNotMatch.TabIndex = 35;
            this.passNotMatch.Text = "Passwords do not match!";
            this.passNotMatch.Visible = false;
            // 
            // IncorrectUserNameLogin
            // 
            this.IncorrectUserNameLogin.AutoSize = true;
            this.IncorrectUserNameLogin.ForeColor = System.Drawing.Color.Red;
            this.IncorrectUserNameLogin.Location = new System.Drawing.Point(112, 179);
            this.IncorrectUserNameLogin.Name = "IncorrectUserNameLogin";
            this.IncorrectUserNameLogin.Size = new System.Drawing.Size(137, 34);
            this.IncorrectUserNameLogin.TabIndex = 34;
            this.IncorrectUserNameLogin.Text = "Incorrect username! \r\nTry again.";
            this.IncorrectUserNameLogin.Visible = false;
            // 
            // WrongPassLogin
            // 
            this.WrongPassLogin.AutoSize = true;
            this.WrongPassLogin.ForeColor = System.Drawing.Color.Red;
            this.WrongPassLogin.Location = new System.Drawing.Point(112, 288);
            this.WrongPassLogin.Name = "WrongPassLogin";
            this.WrongPassLogin.Size = new System.Drawing.Size(134, 34);
            this.WrongPassLogin.TabIndex = 33;
            this.WrongPassLogin.Text = "Incorrect password! \r\nTry again.";
            this.WrongPassLogin.Visible = false;
            // 
            // InvalidNameSignUp
            // 
            this.InvalidNameSignUp.AutoSize = true;
            this.InvalidNameSignUp.ForeColor = System.Drawing.Color.Red;
            this.InvalidNameSignUp.Location = new System.Drawing.Point(496, 155);
            this.InvalidNameSignUp.Name = "InvalidNameSignUp";
            this.InvalidNameSignUp.Size = new System.Drawing.Size(171, 34);
            this.InvalidNameSignUp.TabIndex = 32;
            this.InvalidNameSignUp.Text = "Username already taken. \r\nPlease choose another";
            this.InvalidNameSignUp.Visible = false;
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.Location = new System.Drawing.Point(521, 394);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(105, 33);
            this.SignUpBtn.TabIndex = 31;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.Location = new System.Drawing.Point(499, 328);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.Size = new System.Drawing.Size(143, 22);
            this.textBoxConfirm.TabIndex = 30;
            this.textBoxConfirm.UseSystemPasswordChar = true;
            // 
            // textBoxPassSign
            // 
            this.textBoxPassSign.Location = new System.Drawing.Point(499, 240);
            this.textBoxPassSign.Name = "textBoxPassSign";
            this.textBoxPassSign.Size = new System.Drawing.Size(143, 22);
            this.textBoxPassSign.TabIndex = 29;
            this.textBoxPassSign.UseSystemPasswordChar = true;
            // 
            // textBoxUserSign
            // 
            this.textBoxUserSign.Location = new System.Drawing.Point(499, 130);
            this.textBoxUserSign.Name = "textBoxUserSign";
            this.textBoxUserSign.Size = new System.Drawing.Size(143, 22);
            this.textBoxUserSign.TabIndex = 28;
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(495, 288);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(166, 24);
            this.confirm.TabIndex = 27;
            this.confirm.Text = "Confirm password:";
            // 
            // passSignUp
            // 
            this.passSignUp.AutoSize = true;
            this.passSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passSignUp.Location = new System.Drawing.Point(495, 198);
            this.passSignUp.Name = "passSignUp";
            this.passSignUp.Size = new System.Drawing.Size(97, 24);
            this.passSignUp.TabIndex = 26;
            this.passSignUp.Text = "Password:";
            // 
            // userSign
            // 
            this.userSign.AutoSize = true;
            this.userSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSign.Location = new System.Drawing.Point(495, 87);
            this.userSign.Name = "userSign";
            this.userSign.Size = new System.Drawing.Size(102, 24);
            this.userSign.TabIndex = 25;
            this.userSign.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "No account? Sign up";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Log in to your Mini Cloud Drive";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(124, 394);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 33);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(112, 154);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(134, 22);
            this.usernameTxt.TabIndex = 21;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(112, 263);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(134, 22);
            this.passwordTxt.TabIndex = 20;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // passLogin
            // 
            this.passLogin.AutoSize = true;
            this.passLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLogin.Location = new System.Drawing.Point(108, 221);
            this.passLogin.Name = "passLogin";
            this.passLogin.Size = new System.Drawing.Size(97, 24);
            this.passLogin.TabIndex = 19;
            this.passLogin.Text = "Password:";
            // 
            // userLog
            // 
            this.userLog.AutoSize = true;
            this.userLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLog.Location = new System.Drawing.Point(108, 111);
            this.userLog.Name = "userLog";
            this.userLog.Size = new System.Drawing.Size(102, 24);
            this.userLog.TabIndex = 18;
            this.userLog.Text = "Username:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passNotMatch);
            this.Controls.Add(this.IncorrectUserNameLogin);
            this.Controls.Add(this.WrongPassLogin);
            this.Controls.Add(this.InvalidNameSignUp);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.textBoxConfirm);
            this.Controls.Add(this.textBoxPassSign);
            this.Controls.Add(this.textBoxUserSign);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.passSignUp);
            this.Controls.Add(this.userSign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.passLogin);
            this.Controls.Add(this.userLog);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passNotMatch;
        private System.Windows.Forms.Label IncorrectUserNameLogin;
        private System.Windows.Forms.Label WrongPassLogin;
        private System.Windows.Forms.Label InvalidNameSignUp;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.TextBox textBoxConfirm;
        private System.Windows.Forms.TextBox textBoxPassSign;
        private System.Windows.Forms.TextBox textBoxUserSign;
        private System.Windows.Forms.Label confirm;
        private System.Windows.Forms.Label passSignUp;
        private System.Windows.Forms.Label userSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label passLogin;
        private System.Windows.Forms.Label userLog;
    }
}