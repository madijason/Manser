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
            LDAPGB = new GroupBox();
            buttonLogin = new Button();
            PasswordBox = new TextBox();
            LoginBox = new TextBox();
            ADNameBox = new TextBox();
            ADDUSERGB = new GroupBox();
            checkBoxDirectory = new CheckBox();
            buttonCreate = new Button();
            pswBox = new TextBox();
            ppBox = new TextBox();
            initBox = new TextBox();
            groupBox = new TextBox();
            hdirBox = new TextBox();
            givenBox = new TextBox();
            snBox = new TextBox();
            SAMBox = new TextBox();
            cnBox = new TextBox();
            buttonCSV = new Button();
            MainOFD = new OpenFileDialog();
            labelVersion = new Label();
            LDAPGB.SuspendLayout();
            ADDUSERGB.SuspendLayout();
            SuspendLayout();
            // 
            // LDAPGB
            // 
            LDAPGB.Controls.Add(buttonLogin);
            LDAPGB.Controls.Add(PasswordBox);
            LDAPGB.Controls.Add(LoginBox);
            LDAPGB.Controls.Add(ADNameBox);
            LDAPGB.ForeColor = SystemColors.ActiveCaptionText;
            LDAPGB.Location = new Point(14, 15);
            LDAPGB.Name = "LDAPGB";
            LDAPGB.Size = new Size(351, 135);
            LDAPGB.TabIndex = 0;
            LDAPGB.TabStop = false;
            LDAPGB.Text = "LDAP";
            // 
            // buttonLogin
            // 
            buttonLogin.ForeColor = SystemColors.ActiveCaptionText;
            buttonLogin.Location = new Point(6, 106);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(339, 23);
            buttonLogin.TabIndex = 1;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(6, 80);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(339, 21);
            PasswordBox.TabIndex = 3;
            PasswordBox.Text = "Password";
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // LoginBox
            // 
            LoginBox.Location = new Point(6, 51);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(339, 21);
            LoginBox.TabIndex = 2;
            LoginBox.Text = "Login";
            // 
            // ADNameBox
            // 
            ADNameBox.Location = new Point(6, 22);
            ADNameBox.Name = "ADNameBox";
            ADNameBox.Size = new Size(339, 21);
            ADNameBox.TabIndex = 1;
            ADNameBox.Text = "Path";
            // 
            // ADDUSERGB
            // 
            ADDUSERGB.Controls.Add(checkBoxDirectory);
            ADDUSERGB.Controls.Add(buttonCreate);
            ADDUSERGB.Controls.Add(pswBox);
            ADDUSERGB.Controls.Add(ppBox);
            ADDUSERGB.Controls.Add(initBox);
            ADDUSERGB.Controls.Add(groupBox);
            ADDUSERGB.Controls.Add(hdirBox);
            ADDUSERGB.Controls.Add(givenBox);
            ADDUSERGB.Controls.Add(snBox);
            ADDUSERGB.Controls.Add(SAMBox);
            ADDUSERGB.Controls.Add(cnBox);
            ADDUSERGB.Location = new Point(371, 15);
            ADDUSERGB.Name = "ADDUSERGB";
            ADDUSERGB.Size = new Size(351, 330);
            ADDUSERGB.TabIndex = 1;
            ADDUSERGB.TabStop = false;
            ADDUSERGB.Text = "Add user";
            // 
            // checkBoxDirectory
            // 
            checkBoxDirectory.AutoSize = true;
            checkBoxDirectory.Location = new Point(6, 281);
            checkBoxDirectory.Name = "checkBoxDirectory";
            checkBoxDirectory.Size = new Size(160, 19);
            checkBoxDirectory.TabIndex = 4;
            checkBoxDirectory.Text = "Create user's repertories";
            checkBoxDirectory.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(6, 307);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(339, 23);
            buttonCreate.TabIndex = 2;
            buttonCreate.Text = "Create user";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // pswBox
            // 
            pswBox.Location = new Point(6, 252);
            pswBox.Name = "pswBox";
            pswBox.Size = new Size(339, 21);
            pswBox.TabIndex = 11;
            pswBox.Text = "Password";
            pswBox.UseSystemPasswordChar = true;
            // 
            // ppBox
            // 
            ppBox.Location = new Point(6, 223);
            ppBox.Name = "ppBox";
            ppBox.Size = new Size(339, 21);
            ppBox.TabIndex = 10;
            ppBox.Text = "Profile Path";
            // 
            // initBox
            // 
            initBox.BackColor = SystemColors.Window;
            initBox.Enabled = false;
            initBox.Location = new Point(6, 194);
            initBox.Name = "initBox";
            initBox.Size = new Size(339, 21);
            initBox.TabIndex = 9;
            initBox.Text = "Initials";
            // 
            // groupBox
            // 
            groupBox.Location = new Point(6, 167);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(339, 21);
            groupBox.TabIndex = 8;
            groupBox.Text = "Group";
            // 
            // hdirBox
            // 
            hdirBox.Location = new Point(6, 140);
            hdirBox.Name = "hdirBox";
            hdirBox.Size = new Size(339, 21);
            hdirBox.TabIndex = 7;
            hdirBox.Text = "Home Dir";
            // 
            // givenBox
            // 
            givenBox.Location = new Point(6, 109);
            givenBox.Name = "givenBox";
            givenBox.Size = new Size(339, 21);
            givenBox.TabIndex = 5;
            givenBox.Text = "First Name";
            // 
            // snBox
            // 
            snBox.Location = new Point(6, 80);
            snBox.Name = "snBox";
            snBox.Size = new Size(339, 21);
            snBox.TabIndex = 4;
            snBox.Text = "Last Name";
            // 
            // SAMBox
            // 
            SAMBox.Location = new Point(6, 51);
            SAMBox.Name = "SAMBox";
            SAMBox.Size = new Size(339, 21);
            SAMBox.TabIndex = 3;
            SAMBox.Text = "SAMAccount";
            // 
            // cnBox
            // 
            cnBox.Location = new Point(6, 22);
            cnBox.Name = "cnBox";
            cnBox.Size = new Size(339, 21);
            cnBox.TabIndex = 2;
            cnBox.Text = "Full Name";
            // 
            // buttonCSV
            // 
            buttonCSV.Location = new Point(14, 153);
            buttonCSV.Name = "buttonCSV";
            buttonCSV.Size = new Size(351, 23);
            buttonCSV.TabIndex = 2;
            buttonCSV.Text = "CSV";
            buttonCSV.UseVisualStyleBackColor = true;
            buttonCSV.Click += buttonCSV_Click;
            // 
            // MainOFD
            // 
            MainOFD.FileName = "CSV";
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Location = new Point(12, 330);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(80, 15);
            labelVersion.TabIndex = 3;
            labelVersion.Text = "VERSION 2.1";
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(736, 351);
            Controls.Add(labelVersion);
            Controls.Add(buttonCSV);
            Controls.Add(ADDUSERGB);
            Controls.Add(LDAPGB);
            Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainForm";
            Text = "Manser";
            LDAPGB.ResumeLayout(false);
            LDAPGB.PerformLayout();
            ADDUSERGB.ResumeLayout(false);
            ADDUSERGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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