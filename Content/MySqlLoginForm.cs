using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataQuestBuilder.Controls
{
    public partial class MySqlLoginForm : UserControl
    {
        public MySqlLoginForm()
        {
            InitializeComponent();
        }

        private void testConnection_Click(object sender, EventArgs e)
        {
            DatabaseManager.SetDatabaseConnection(hostname.Text, uint.Parse(port.Text), database.Text, username.Text, password.Text);

            try
            {
                DatabaseManager.Database.RegisterDataObject(typeof(DOL.Database.Mob));
                if (DatabaseManager.Database.GetObjectCount<DOL.Database.Mob>() >= 1)
                    MessageBox.Show("Connection Successful!");
            }
            catch { }

            Properties.Settings.Default.Save();
        }

        private void MySqlLoginForm_Load(object sender, EventArgs e)
        {
            username.Text = Properties.Settings.Default.Username;
            password.Text = Properties.Settings.Default.Password;
            hostname.Text = Properties.Settings.Default.Hostname;
            port.Text = Properties.Settings.Default.Port.ToString();
            database.Text = Properties.Settings.Default.Database;
    
        }

        private void saveConnection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Saved MySQL information.") == DialogResult.OK)
            {
                try
                {
                    Properties.Settings.Default.Username = username.Text;
                    Properties.Settings.Default.Password = password.Text;
                    Properties.Settings.Default.Hostname = hostname.Text;
                    Properties.Settings.Default.Port = uint.Parse(port.Text);
                    Properties.Settings.Default.Database = database.Text;
                    FindForm().Close();
                }
                catch (Exception g)
                {
                    MessageBox.Show(g.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         
            
            
        }
    }
}
