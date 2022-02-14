using CsvHelper;
using CsvHelper.Configuration;
using System.DirectoryServices;
using System.Globalization;

namespace Manser
{
    public partial class MainForm : Form
    {
        public DirectoryEntry? LDAP = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // This line is used to connect the applciation to AD
            LDAP = new DirectoryEntry(ADNameBox.Text, LoginBox.Text, PasswordBox.Text);
        }

        private void buttonCSV_Click(object sender, EventArgs e)
        {
            try
            {
                MainOFD.InitialDirectory = Directory.GetCurrentDirectory();
                MainOFD.ShowDialog();

                var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
                {
                    HasHeaderRecord = false,
                    Comment = '#',
                    AllowComments = true,
                    Delimiter = ";",
                };

                using var streamReader = File.OpenText(MainOFD.FileName);
                using var csvReader = new CsvReader(streamReader, csvConfig);

                if (LDAP == null)
                {
                    MessageBox.Show("You're not connected !");
                }
                else
                {
                    while (csvReader.Read())
                    {
                        DirectoryEntry LDAP = new DirectoryEntry(ADNameBox.Text, LoginBox.Text, PasswordBox.Text);
                        DirectoryEntry directoryEntry = LDAP.Children.Add("cn=" + csvReader.GetField(0), "user");
                        directoryEntry.Properties["SAMAccountName"].Add(csvReader.GetField(1));
                        directoryEntry.Properties["sn"].Add(csvReader.GetField(2));
                        directoryEntry.Properties["givenName"].Add(csvReader.GetField(3));
                        directoryEntry.Properties["scriptPath"].Add(csvReader.GetField(4));
                        directoryEntry.Properties["homeDirectory"].Add(csvReader.GetField(5));
                        directoryEntry.Properties["homeDrive"].Add(csvReader.GetField(6));
                        directoryEntry.Properties["profilePath"].Add(csvReader.GetField(7));
                        directoryEntry.CommitChanges();
                        directoryEntry.Invoke("SetPassword", new object[] { csvReader.GetField(8) });
                        directoryEntry.Properties["userAccountControl"].Value = 0x0200;
                        directoryEntry.Properties["userAccountControl"].Value = 0x10000;
                        directoryEntry.Properties["userAccountControl"].Value = 0x0040;
                        directoryEntry.Properties["pwdLastSet"].Value = 0;
                        directoryEntry.CommitChanges();
                        if (checkBoxDirectory.Checked == true)
                        {
                            System.IO.Directory.CreateDirectory(csvReader.GetField(5));
                        }
                    }
                }
                MessageBox.Show("All users as been created !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // These lines check if user is connected
                if (LDAP == null)
                {
                    MessageBox.Show("You're not connected !");
                }
                else
                {
                    // This line create "cn" as user full name and "user" as type
                    DirectoryEntry directoryEntry = LDAP.Children.Add("cn=" + cnBox.Text, "user");
                    // This line is the name use to connect the user
                    directoryEntry.Properties["SAMAccountName"].Add(SAMBox.Text);
                    // This line add the user last name
                    directoryEntry.Properties["sn"].Add(snBox.Text);
                    // This line add the user first name
                    directoryEntry.Properties["givenName"].Add(givenBox.Text);
                    // This line add the script path
                    directoryEntry.Properties["scriptPath"].Add(spBox.Text);
                    // This line add the home directory
                    directoryEntry.Properties["homeDirectory"].Add(hdirBox.Text);
                    // This line add the home drive
                    directoryEntry.Properties["homeDrive"].Add(hdriveBox.Text);
                    // This line add the profile path
                    directoryEntry.Properties["profilePath"].Add(ppBox.Text);
                    // This line create the user
                    directoryEntry.CommitChanges();
                    // This line set user password
                    directoryEntry.Invoke("SetPassword", new object[] { pswBox.Text });
                    // This line create a standard account
                    directoryEntry.Properties["userAccountControl"].Value = 0x0200;
                    // This line make passord never expire
                    directoryEntry.Properties["userAccountControl"].Value = 0x10000;
                    // This line make the user cannot change password
                    directoryEntry.Properties["userAccountControl"].Value = 0x0040;
                    // This line make the user didn't change password at first start
                    directoryEntry.Properties["pwdLastSet"].Value = 0;
                    // This line update the user
                    directoryEntry.CommitChanges();
                    // These lines create user's directory by using the CMD
                    if (checkBoxDirectory.Checked == true)
                    {
                        System.IO.Directory.CreateDirectory(ppBox.Text);
                    }
                    MessageBox.Show("User as been created !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}