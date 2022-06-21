namespace Manser
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LDAPGB = new System.Windows.Forms.GroupBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.ADNameBox = new System.Windows.Forms.TextBox();
            this.ADDUSERGB = new System.Windows.Forms.GroupBox();
            this.checkBoxDirectory = new System.Windows.Forms.CheckBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.pswBox = new System.Windows.Forms.TextBox();
            this.ppBox = new System.Windows.Forms.TextBox();
            this.initBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.TextBox();
            this.hdirBox = new System.Windows.Forms.TextBox();
            this.givenBox = new System.Windows.Forms.TextBox();
            this.snBox = new System.Windows.Forms.TextBox();
            this.SAMBox = new System.Windows.Forms.TextBox();
            this.cnBox = new System.Windows.Forms.TextBox();
            this.buttonCSV = new System.Windows.Forms.Button();
            this.MainOFD = new System.Windows.Forms.OpenFileDialog();
            this.labelVersion = new System.Windows.Forms.Label();
            this.LDAPGB.SuspendLayout();
            this.ADDUSERGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // LDAPGB
            // 
            this.LDAPGB.Controls.Add(this.buttonLogin);
            this.LDAPGB.Controls.Add(this.PasswordBox);
            this.LDAPGB.Controls.Add(this.LoginBox);
            this.LDAPGB.Controls.Add(this.ADNameBox);
            this.LDAPGB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LDAPGB.Location = new System.Drawing.Point(14, 15);
            this.LDAPGB.Name = "LDAPGB";
            this.LDAPGB.Size = new System.Drawing.Size(351, 135);
            this.LDAPGB.TabIndex = 0;
            this.LDAPGB.TabStop = false;
            this.LDAPGB.Text = "LDAP";
            // 
            // buttonLogin
            // 
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLogin.Location = new System.Drawing.Point(6, 106);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(339, 23);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(6, 80);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(339, 21);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.Text = "Password";
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(6, 51);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(339, 21);
            this.LoginBox.TabIndex = 2;
            this.LoginBox.Text = "Login";
            // 
            // ADNameBox
            // 
            this.ADNameBox.Location = new System.Drawing.Point(6, 22);
            this.ADNameBox.Name = "ADNameBox";
            this.ADNameBox.Size = new System.Drawing.Size(339, 21);
            this.ADNameBox.TabIndex = 1;
            this.ADNameBox.Text = "LDAP://CN=Users,DC=ARSG734,DC=LOCAL";
            // 
            // ADDUSERGB
            // 
            this.ADDUSERGB.Controls.Add(this.checkBoxDirectory);
            this.ADDUSERGB.Controls.Add(this.buttonCreate);
            this.ADDUSERGB.Controls.Add(this.pswBox);
            this.ADDUSERGB.Controls.Add(this.ppBox);
            this.ADDUSERGB.Controls.Add(this.initBox);
            this.ADDUSERGB.Controls.Add(this.groupBox);
            this.ADDUSERGB.Controls.Add(this.hdirBox);
            this.ADDUSERGB.Controls.Add(this.givenBox);
            this.ADDUSERGB.Controls.Add(this.snBox);
            this.ADDUSERGB.Controls.Add(this.SAMBox);
            this.ADDUSERGB.Controls.Add(this.cnBox);
            this.ADDUSERGB.Location = new System.Drawing.Point(371, 15);
            this.ADDUSERGB.Name = "ADDUSERGB";
            this.ADDUSERGB.Size = new System.Drawing.Size(351, 330);
            this.ADDUSERGB.TabIndex = 1;
            this.ADDUSERGB.TabStop = false;
            this.ADDUSERGB.Text = "Add user";
            // 
            // checkBoxDirectory
            // 
            this.checkBoxDirectory.AutoSize = true;
            this.checkBoxDirectory.Location = new System.Drawing.Point(6, 281);
            this.checkBoxDirectory.Name = "checkBoxDirectory";
            this.checkBoxDirectory.Size = new System.Drawing.Size(160, 19);
            this.checkBoxDirectory.TabIndex = 4;
            this.checkBoxDirectory.Text = "Create user\'s repertories";
            this.checkBoxDirectory.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(6, 307);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(339, 23);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Create user";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // pswBox
            // 
            this.pswBox.Location = new System.Drawing.Point(6, 252);
            this.pswBox.Name = "pswBox";
            this.pswBox.Size = new System.Drawing.Size(339, 21);
            this.pswBox.TabIndex = 11;
            this.pswBox.Text = "Password";
            this.pswBox.UseSystemPasswordChar = true;
            // 
            // ppBox
            // 
            this.ppBox.Location = new System.Drawing.Point(6, 223);
            this.ppBox.Name = "ppBox";
            this.ppBox.Size = new System.Drawing.Size(339, 21);
            this.ppBox.TabIndex = 10;
            this.ppBox.Text = "Profile Path";
            // 
            // initBox
            // 
            this.initBox.BackColor = System.Drawing.SystemColors.Window;
            this.initBox.Enabled = false;
            this.initBox.Location = new System.Drawing.Point(6, 194);
            this.initBox.Name = "initBox";
            this.initBox.Size = new System.Drawing.Size(339, 21);
            this.initBox.TabIndex = 9;
            this.initBox.Text = "Initials";
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(6, 167);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(339, 21);
            this.groupBox.TabIndex = 8;
            this.groupBox.Text = "Group";
            // 
            // hdirBox
            // 
            this.hdirBox.Location = new System.Drawing.Point(6, 140);
            this.hdirBox.Name = "hdirBox";
            this.hdirBox.Size = new System.Drawing.Size(339, 21);
            this.hdirBox.TabIndex = 7;
            this.hdirBox.Text = "Home Dir";
            // 
            // givenBox
            // 
            this.givenBox.Location = new System.Drawing.Point(6, 109);
            this.givenBox.Name = "givenBox";
            this.givenBox.Size = new System.Drawing.Size(339, 21);
            this.givenBox.TabIndex = 5;
            this.givenBox.Text = "First Name";
            // 
            // snBox
            // 
            this.snBox.Location = new System.Drawing.Point(6, 80);
            this.snBox.Name = "snBox";
            this.snBox.Size = new System.Drawing.Size(339, 21);
            this.snBox.TabIndex = 4;
            this.snBox.Text = "Last Name";
            // 
            // SAMBox
            // 
            this.SAMBox.Location = new System.Drawing.Point(6, 51);
            this.SAMBox.Name = "SAMBox";
            this.SAMBox.Size = new System.Drawing.Size(339, 21);
            this.SAMBox.TabIndex = 3;
            this.SAMBox.Text = "SAMAccount";
            // 
            // cnBox
            // 
            this.cnBox.Location = new System.Drawing.Point(6, 22);
            this.cnBox.Name = "cnBox";
            this.cnBox.Size = new System.Drawing.Size(339, 21);
            this.cnBox.TabIndex = 2;
            this.cnBox.Text = "Full Name";
            // 
            // buttonCSV
            // 
            this.buttonCSV.Location = new System.Drawing.Point(14, 153);
            this.buttonCSV.Name = "buttonCSV";
            this.buttonCSV.Size = new System.Drawing.Size(351, 23);
            this.buttonCSV.TabIndex = 2;
            this.buttonCSV.Text = "CSV";
            this.buttonCSV.UseVisualStyleBackColor = true;
            this.buttonCSV.Click += new System.EventHandler(this.buttonCSV_Click);
            // 
            // MainOFD
            // 
            this.MainOFD.FileName = "CSV";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(12, 330);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(93, 15);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "VERSION BÊTA";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 351);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonCSV);
            this.Controls.Add(this.ADDUSERGB);
            this.Controls.Add(this.LDAPGB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainForm";
            this.Text = "Manser";
            this.LDAPGB.ResumeLayout(false);
            this.LDAPGB.PerformLayout();
            this.ADDUSERGB.ResumeLayout(false);
            this.ADDUSERGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox LDAPGB;
        private TextBox PasswordBox;
        private TextBox LoginBox;
        private TextBox ADNameBox;
        private Button buttonLogin;
        private GroupBox ADDUSERGB;
        private TextBox cnBox;
        private TextBox SAMBox;
        private TextBox pswBox;
        private TextBox ppBox;
        private TextBox initBox;
        private TextBox groupBox;
        private TextBox hdirBox;
        private TextBox givenBox;
        private TextBox snBox;
        private Button buttonCreate;
        private Button buttonCSV;
        private OpenFileDialog MainOFD;
        private Label labelVersion;
        private CheckBox checkBoxDirectory;
    }
}