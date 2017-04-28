using System;
using System.Linq;
using System.Windows.Forms;

namespace DataQuestBuilder
{
	public class eCharacterClass : ListBox
	{
		public void Load()
        {
            Items.Clear();

            foreach (string type in Enum.GetNames(typeof(eProperties.eCharacterClass)))
            {
                Items.Add(type);
            }
        }
	}
}
