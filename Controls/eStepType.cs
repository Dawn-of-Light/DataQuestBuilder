using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataQuestBuilder
{
    public class eStepType : ComboBox
    {
        public void Load()
        {
            Items.Clear();

            foreach (string type in Enum.GetNames(typeof(eProperties.eStepType)))
            {
                Items.Add(type);
            }
        }
    }
}
