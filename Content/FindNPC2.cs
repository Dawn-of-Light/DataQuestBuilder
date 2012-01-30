using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DOL.Database;
using DataQuestBuilder.Properties;

namespace DataQuestBuilder.Content
{
    public partial class FindNPC2 : Form
    {
        public FindNPC2()
        {
           InitializeComponent();
        }
        
        private void FindNPC_Load(object sender, EventArgs e)
        {
           var g = DatabaseManager.Database.SelectAllObjects<Mob>();
           foreach (Mob m in g)
           {
               dataGridView1.Rows.Add(m.Name, m.Guild, m.Model, m.Region);
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string target = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           string targetregion = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           target += ";";
           target += targetregion;
           Settings.Default.SelectNPC2 = target;
           //Settings.Default.SelectNPC2Region = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           //Hide();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
        
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                //http://herald.uthgard-server.net/daoc/list.php?img=monsters-%3Emob_model_0034
                string model = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                if (model == "1" || model == "666")
                {
                    webBrowser1.DocumentText = "Invisible Mob!";
                    return;
                }
                if (model.Length == 1)
                {
                    model = "000" + model;
                }
                if (model.Length == 2)
                {
                    model = "00" + model;
                }
                if (model.Length == 3)
                {
                    model = "0" + model;
                }
                if (model.Length == 4)
                {

                }
                webBrowser1.Navigate("http://herald.uthgard-server.net/daoc/list.php?img=monsters-%3Emob_model_" + model);
            }
            catch { }
        }
    }
}
