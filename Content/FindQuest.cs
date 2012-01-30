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
    public partial class FindQuest : Form
    {
        public FindQuest()
        {
           InitializeComponent();
        }
        
        private void FindQuest_Load(object sender, EventArgs e)
        {
           var g = DatabaseManager.Database.SelectAllObjects<DBDataQuest>();
           foreach (DBDataQuest m in g)
           {
               dataGridView1.Rows.Add(m.Name);
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.SelectQuest = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Hide();
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
            
        }
    }
}
