using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataQuestBuilder
{
    public class eStartType : ComboBox
    {
        public void Load()
        {
            Items.Clear();

            foreach (string type in Enum.GetNames(typeof(eProperties.eStartType)))
            {
                Items.Add(type);
            }
        }
    }
}
