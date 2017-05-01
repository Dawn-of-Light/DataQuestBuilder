using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DOL.Database;
using System.Windows.Forms;
using DataQuestBuilder.Content;
using DataQuestBuilder.Properties;

namespace DataQuestBuilder
{
    public partial class MainForm : Form
    {
    	public Dictionary<int, string> opt_dictionary;
        public Dictionary<int, string> fin_dictionary;
        public Dictionary<int, string> advtext_dictionary;
        public Dictionary<int, string> colitem_dictionary;
        public Dictionary<int, string> money_dictionary;
        public Dictionary<int, string> xp_dictionary;
        public Dictionary<int, string> clxp_dictionary;
        public Dictionary<int, string> rp_dictionary;
        public Dictionary<int, string> bp_dictionary;
        public Dictionary<int, string> srctext_dictionary;
        public Dictionary<int, string> stepitem_dictionary;
        public Dictionary<int, string> steptext_dictionary;
        public Dictionary<int, string> trgtname_dictionary;
        public Dictionary<int, string> trgttext_dictionary;
        public Dictionary<int, string> steptype_dictionary;        

        public MainForm()
        {
            InitializeComponent();            
            opt_dictionary = new Dictionary<int, string>();
            fin_dictionary = new Dictionary<int, string>();
            advtext_dictionary = new Dictionary<int, string>();
            colitem_dictionary = new Dictionary<int, string>();
            money_dictionary = new Dictionary<int, string>();
            xp_dictionary = new Dictionary<int, string>();
            clxp_dictionary = new Dictionary<int, string>();
            rp_dictionary = new Dictionary<int, string>();
            bp_dictionary = new Dictionary<int, string>();
            srctext_dictionary = new Dictionary<int, string>();
            stepitem_dictionary = new Dictionary<int, string>();
            steptext_dictionary = new Dictionary<int, string>();
            trgtname_dictionary = new Dictionary<int, string>();
            trgttext_dictionary = new Dictionary<int, string>();
            steptype_dictionary = new Dictionary<int, string>();            
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlLoginForm form = new MySqlLoginForm();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string username = Properties.Settings.Default.Username;
            string password = Properties.Settings.Default.Password;
            string hostname = Properties.Settings.Default.Hostname;
            string database = Properties.Settings.Default.Database;
            uint port = Properties.Settings.Default.Port;

            DatabaseManager.SetDatabaseConnection(hostname, port, database, username, password);

            eStepType.SelectedIndexChanged += new EventHandler(ShowStepTypeTooltip);
            eStartType.SelectedIndexChanged += new EventHandler(ShowStartTypeTooltip);
            eStartType.Load();
            eStepType.Load();
            allowedClasses.Load();
        }

        void ShowStartTypeTooltip(object sender, EventArgs e)
        {

            primaryTooltip.ToolTipTitle = eStartType.Text;

            int duration = (int.Parse(Properties.Settings.Default.TooltipDuration) * 1000);

            switch (eStartType.Text)
            {
                case "Standard":
                    {
                        primaryTooltip.Show("Talk to the npc, accept quest, and go through the steps.", eStartType, duration);
                    }
                    break;
                case "Collection":
                    {
                        primaryTooltip.Show("Player turns in drops to an npc for xp, quest not added to player quest log. Has no steps.", eStartType, duration);
                    }
                    break;
                case "AutoStart":
                    {
                        primaryTooltip.Show("Standard quest is auto started simply by interacting with start object.", eStartType, duration);
                    }
                    break;
                case "KillComplete":
                    {
                        primaryTooltip.Show("Killing the start living grants and finishes the quest. Similar to One Time Drops.", eStartType, duration);
                    }
                    break;
                case "InteractComplete":
                    {
                        primaryTooltip.Show("Interacting with the start object grants and finishes the quest.", eStartType, duration);
                    }
                    break;
                case "RewardQuest":
                    {
                        primaryTooltip.Show("A reward quest, where reward dialog is givin to the player on quest offer and complete.", eStartType, duration);
                    }
                    break;
                default: primaryTooltip.Show("Unknown start type. This is not recommended.", eStartType, duration); break;
            }
        }

        public void ShowStepTypeTooltip(object sender, EventArgs e)
        {
            primaryTooltip.ToolTipTitle = eStepType.Text;

            int duration = (int.Parse(Properties.Settings.Default.TooltipDuration) * 2000);

            switch (eStepType.Text)
            {
                case "Kill":
                    {
                        primaryTooltip.Show("Kill the target to advance the quest.", eStepType, duration);
                    }
                    break;
                case "KillFinish":
                    {
                        primaryTooltip.Show("Killing the target finishes the quest and gives the reward.", eStepType, duration);
                    }
                    break;
                case "Deliver":
                    {
                        primaryTooltip.Show("Deliver an item to the target to advance the quest.", eStepType, duration);
                    }
                    break;
                case "DeliverFinish":
                    {
                        primaryTooltip.Show("Deliver an item to the target to finish the quest.", eStepType, duration);
                    }
                    break;
                case "Interact":
                    {
                        primaryTooltip.Show("Interact with the target to advance the step.", eStepType, duration);
                    }
                    break;
                case "InteractFinish":
                    {
                        primaryTooltip.Show("Interact with the target to finish the quest. This is required to end a RewardQuest.", eStepType, duration);
                    }
                    break;
                case "Whisper":
                    {
                        primaryTooltip.Show("Whisper to the target to advance the quest.", eStepType, duration);
                    }
                    break;
                case "WhisperFinish":
                    {
                        primaryTooltip.Show("Whisper to the target to finish the quest.", eStepType, duration);
                    }
                    break;
                case "Search":
                    {
                        primaryTooltip.Show("*Search NOT implemented!* Search in a specified location to advance the quest.", eStepType, duration);
                    }
                    break;
                case "SearchFinish":
                    {
                        primaryTooltip.Show("*Search NOT implemented!* Search in a specified location to finish the quest.", eStepType, duration);
                    }
                    break;
                case "Collect":
                    {
                        primaryTooltip.Show("Player must give the target an item to advance the step.", eStepType, duration);
                    }
                    break;
                case "CollectFinish":
                    {
                        primaryTooltip.Show("Player must give the target an item to finish the quest.", eStepType, duration);
                    }
                    break;
                    default: primaryTooltip.Show("This option is either invalid or unknown. it is not recomended.", eStepType, duration); break;
            }
        }

        private void newDataQuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to create a new form?","Halt", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                questID.Text = "";
                questName.Text = "";
                eStartType.Text = "";
                startNPCName.Text = "";
                questNPCRegionID.Text = "";
                acceptText.Text = "";
                description.Text = "";
                sourceText.Text = "";
                eStepType.Text = "";
                stepText.Text = "";
                stepItem.Text = "";
                advanceText.Text = "";
                targetName.Text = "";
                targetText.Text = "";
                collectItem.Text = "";
                maxCount.Text = "";
                questMinLevel.Text = "1";
                questMaxLevel.Text = "50";
                rewardMoney.Text = "0";
                rewardXp.Text = "0";
                rewardCLXp.Text = "0";
                rewardRp.Text = "0";
                rewardBp.Text = "0";
                finishText.Text = "";
                questDependency.Text = "";
                allowedClasses.Text =
                questClassType.Text = "";
                getOpt.Text = "";
                getFin.Text = "";
            }
        }

        #region Step/Reward forward/back buttons

        //Step data forward
        private void stepForward_Click(object sender, EventArgs e)
        {

            int stepNum = int.Parse(stepNumber.Text);

            if (eStepType.Text == "" || targetName.Text == "")
            {
                MessageBox.Show("You cannot proceed until you have selected a step type and target!");
                return;
            }

            #region Step forward data entry

            //advanceText.Text
            if (!advtext_dictionary.ContainsKey(stepNum))
            {
                advtext_dictionary.Add(stepNum, advanceText.Text);
            }
            else
            {
                advtext_dictionary.Remove(stepNum);
                advtext_dictionary.Add(stepNum, advanceText.Text);
            }
            advanceText.Text = "";

            //collectItem.Text
            if (!colitem_dictionary.ContainsKey(stepNum))
            {
                colitem_dictionary.Add(stepNum, collectItem.Text);
            }
            else
            {
                colitem_dictionary.Remove(stepNum);
                colitem_dictionary.Add(stepNum, collectItem.Text);
            }
            collectItem.Text = "";

            //rewardMoney.Text
            if (!money_dictionary.ContainsKey(stepNum))
            {
                money_dictionary.Add(stepNum, rewardMoney.Text);
            }
            else
            {
                money_dictionary.Remove(stepNum);
                money_dictionary.Add(stepNum, rewardMoney.Text);
            }
            rewardMoney.Text = "";
            
            //rewardXp.Text
            if (!xp_dictionary.ContainsKey(stepNum))
            {
                xp_dictionary.Add(stepNum, rewardXp.Text);
            }
            else
            {
                xp_dictionary.Remove(stepNum);
                xp_dictionary.Add(stepNum, rewardXp.Text);
            }
            rewardXp.Text = "";

            //rewardCLXp.Text
            if (!clxp_dictionary.ContainsKey(stepNum))
            {
                clxp_dictionary.Add(stepNum, rewardCLXp.Text);
            }
            else
            {
                clxp_dictionary.Remove(stepNum);
                clxp_dictionary.Add(stepNum, rewardCLXp.Text);
            }
            rewardCLXp.Text = "";

            //rewardRp.Text
            if (!rp_dictionary.ContainsKey(stepNum))
            {
                rp_dictionary.Add(stepNum, rewardRp.Text);
            }
            else
            {
                rp_dictionary.Remove(stepNum);
                rp_dictionary.Add(stepNum, rewardRp.Text);
            }
            rewardRp.Text = "";

            //rewardBp.Text
            if (!bp_dictionary.ContainsKey(stepNum))
            {
                bp_dictionary.Add(stepNum, rewardBp.Text);
            }
            else
            {
                bp_dictionary.Remove(stepNum);
                bp_dictionary.Add(stepNum, rewardBp.Text);
            }
            rewardBp.Text = "";

            //sourceText.Text
            if (!srctext_dictionary.ContainsKey(stepNum))
            {
                srctext_dictionary.Add(stepNum, sourceText.Text);
            }
            else
            {
                srctext_dictionary.Remove(stepNum);
                srctext_dictionary.Add(stepNum, sourceText.Text);
            }
            sourceText.Text = "";

            //stepItem.Text
            if (!stepitem_dictionary.ContainsKey(stepNum))
            {
                stepitem_dictionary.Add(stepNum, stepItem.Text);
            }
            else
            {
                stepitem_dictionary.Remove(stepNum);
                stepitem_dictionary.Add(stepNum, stepItem.Text);
            }
            stepItem.Text = "";

            //stepText.Text
            if (!steptext_dictionary.ContainsKey(stepNum))
            {
                steptext_dictionary.Add(stepNum, stepText.Text);
            }
            else
            {
                steptext_dictionary.Remove(stepNum);
                steptext_dictionary.Add(stepNum, stepText.Text);
            }
            stepText.Text = "";

            //targetName.Text
            if (!trgtname_dictionary.ContainsKey(stepNum))
            {
                trgtname_dictionary.Add(stepNum, targetName.Text);
            }
            else
            {
                trgtname_dictionary.Remove(stepNum);
                trgtname_dictionary.Add(stepNum, targetName.Text);
            }
            targetName.Text = "";

            //targetText.Text
            if (!trgttext_dictionary.ContainsKey(stepNum))
            {
                trgttext_dictionary.Add(stepNum, targetText.Text);
            }
            else
            {
                trgttext_dictionary.Remove(stepNum);
                trgttext_dictionary.Add(stepNum, targetText.Text);
            }
            targetText.Text = "";

            //eStepType.Text
            if (!steptype_dictionary.ContainsKey(stepNum))
            {
                steptype_dictionary.Add(stepNum, eStepType.Text);
            }
            else
            {
                steptype_dictionary.Remove(stepNum);
                steptype_dictionary.Add(stepNum, eStepType.Text);
            }
            eStepType.Text = "";

            #endregion

            stepNumber.Text = (stepNum + 1).ToString(); //increment label

            #region Step forward check next step

            int stepNext = int.Parse(stepNumber.Text);
            string stepvalue;

            if (advtext_dictionary.ContainsKey(stepNext))
            {
                advtext_dictionary.TryGetValue(stepNext, out stepvalue);
                advanceText.Text = stepvalue;
            }
            else advanceText.Text = "";

            if (colitem_dictionary.ContainsKey(stepNext))
            {
                colitem_dictionary.TryGetValue(stepNext, out stepvalue);
                collectItem.Text = stepvalue;
            }
            else collectItem.Text = "";

            if (money_dictionary.ContainsKey(stepNext))
            {
                money_dictionary.TryGetValue(stepNext, out stepvalue);
                rewardMoney.Text = stepvalue;
            }
            else rewardMoney.Text = "0";

            if (xp_dictionary.ContainsKey(stepNext))
            {
                xp_dictionary.TryGetValue(stepNext, out stepvalue);
                rewardXp.Text = stepvalue;
            }
            else rewardXp.Text = "0";

            if (clxp_dictionary.ContainsKey(stepNext))
            {
                clxp_dictionary.TryGetValue(stepNext, out stepvalue);
                rewardCLXp.Text = stepvalue;   
            }
            else rewardCLXp.Text = "0";

            if (rp_dictionary.ContainsKey(stepNext))
            {
                rp_dictionary.TryGetValue(stepNext, out stepvalue);
                rewardRp.Text = stepvalue;
            }
            else rewardRp.Text = "0";

            if (bp_dictionary.ContainsKey(stepNext))
            {
                bp_dictionary.TryGetValue(stepNext, out stepvalue);
                rewardBp.Text = stepvalue;
            }
            else rewardBp.Text = "0";

            if (srctext_dictionary.ContainsKey(stepNext))
            {
                srctext_dictionary.TryGetValue(stepNext, out stepvalue);
                sourceText.Text = stepvalue;
            }
            else sourceText.Text = "";

            if (stepitem_dictionary.ContainsKey(stepNext))
            {
                stepitem_dictionary.TryGetValue(stepNext, out stepvalue);
                stepItem.Text = stepvalue;
            }
            else stepItem.Text = "";

            if (steptext_dictionary.ContainsKey(stepNext))
            {
                steptext_dictionary.TryGetValue(stepNext, out stepvalue);
                stepText.Text = stepvalue;
            }
            else stepText.Text = "";

            if (trgtname_dictionary.ContainsKey(stepNext))
            {
                trgtname_dictionary.TryGetValue(stepNext, out stepvalue);
                targetName.Text = stepvalue;
            }
            else targetName.Text = "";
            
            if (trgttext_dictionary.ContainsKey(stepNext))
            {
                trgttext_dictionary.TryGetValue(stepNext, out stepvalue);
                targetText.Text = stepvalue;
            }
            else targetText.Text = "";

            if (steptype_dictionary.ContainsKey(stepNext))
            {
                steptype_dictionary.TryGetValue(stepNext, out stepvalue);
                eStepType.Text = stepvalue;
            }
            else eStepType.Text = "";

            #endregion
        }
        
        //Step data back
        private void stepBack_Click(object sender, EventArgs e)
        {
            int stepNum = int.Parse(stepNumber.Text);

            if (stepNum == 1) //return if already at step 1, there ain't no step 0
            {
                return;
            }

            //remove step altogether if mandatory fields are not entered
            if (targetName.Text == "" || eStepType.Text == "")
            {
                advtext_dictionary.Remove(stepNum);
                colitem_dictionary.Remove(stepNum);
                money_dictionary.Remove(stepNum);
                xp_dictionary.Remove(stepNum);
                clxp_dictionary.Remove(stepNum);
                rp_dictionary.Remove(stepNum);
                bp_dictionary.Remove(stepNum);
                srctext_dictionary.Remove(stepNum);
                stepitem_dictionary.Remove(stepNum);
                steptext_dictionary.Remove(stepNum);
                trgtname_dictionary.Remove(stepNum);
                trgttext_dictionary.Remove(stepNum);
                steptype_dictionary.Remove(stepNum);
            }
            else
            //Needed to commit data to m_dictionary when the back button is clicked
            {
            advtext_dictionary.Remove(stepNum);
            advtext_dictionary.Add(stepNum, advanceText.Text);
            colitem_dictionary.Remove(stepNum);
            colitem_dictionary.Add(stepNum, collectItem.Text);
            money_dictionary.Remove(stepNum);
            money_dictionary.Add(stepNum, rewardMoney.Text);
            xp_dictionary.Remove(stepNum);
            xp_dictionary.Add(stepNum, rewardXp.Text);
            clxp_dictionary.Remove(stepNum);
            clxp_dictionary.Add(stepNum, rewardCLXp.Text);
            rp_dictionary.Remove(stepNum);
            rp_dictionary.Add(stepNum, rewardRp.Text);
            bp_dictionary.Remove(stepNum);
            bp_dictionary.Add(stepNum, rewardBp.Text);
            srctext_dictionary.Remove(stepNum);
            srctext_dictionary.Add(stepNum, sourceText.Text);
            stepitem_dictionary.Remove(stepNum);
            stepitem_dictionary.Add(stepNum, stepItem.Text);
            steptext_dictionary.Remove(stepNum);
            steptext_dictionary.Add(stepNum, stepText.Text);
            trgtname_dictionary.Remove(stepNum);
            trgtname_dictionary.Add(stepNum, targetName.Text);
            trgttext_dictionary.Remove(stepNum);
            trgttext_dictionary.Add(stepNum, targetText.Text);
            steptype_dictionary.Remove(stepNum);
            steptype_dictionary.Add(stepNum, eStepType.Text);
            }
            

            stepNumber.Text = (stepNum - 1).ToString();
            string stepvalue;
            stepNum--;

            //Previous step data check
            if (advtext_dictionary.ContainsKey(stepNum))
            {
                advtext_dictionary.TryGetValue(stepNum, out stepvalue);
                advanceText.Text = stepvalue;
            }
            else advanceText.Text = "";

            if (colitem_dictionary.ContainsKey(stepNum))
            {
                colitem_dictionary.TryGetValue(stepNum, out stepvalue);
                collectItem.Text = stepvalue;
            }
            else collectItem.Text = "";

            if (money_dictionary.ContainsKey(stepNum))
            {
                money_dictionary.TryGetValue(stepNum, out stepvalue);
                rewardMoney.Text = stepvalue;
            }
            else rewardMoney.Text = "0";

            if (xp_dictionary.ContainsKey(stepNum))
            {
                xp_dictionary.TryGetValue(stepNum, out stepvalue);
                rewardXp.Text = stepvalue;
            }
            else rewardXp.Text = "0";

            if (clxp_dictionary.ContainsKey(stepNum))
            {
                clxp_dictionary.TryGetValue(stepNum, out stepvalue);
                rewardCLXp.Text = stepvalue;
            }
            else rewardCLXp.Text = "0";

            if (rp_dictionary.ContainsKey(stepNum))
            {
                rp_dictionary.TryGetValue(stepNum, out stepvalue);
                rewardRp.Text = stepvalue;
            }
            else rewardRp.Text = "0";

            if (bp_dictionary.ContainsKey(stepNum))
            {
                bp_dictionary.TryGetValue(stepNum, out stepvalue);
                rewardBp.Text = stepvalue;
            }
            else rewardBp.Text = "0";

            if (srctext_dictionary.ContainsKey(stepNum))
            {
                srctext_dictionary.TryGetValue(stepNum, out stepvalue);
                sourceText.Text = stepvalue;
            }
            else sourceText.Text = "";

            if (stepitem_dictionary.ContainsKey(stepNum))
            {
                stepitem_dictionary.TryGetValue(stepNum, out stepvalue);
                stepItem.Text = stepvalue;
                
            }
            else stepItem.Text = "";

            if (steptext_dictionary.ContainsKey(stepNum))
            {
                steptext_dictionary.TryGetValue(stepNum, out stepvalue);
                stepText.Text = stepvalue;
            }
            else stepText.Text = "";

            if (trgtname_dictionary.ContainsKey(stepNum))
            {
                trgtname_dictionary.TryGetValue(stepNum, out stepvalue);
                targetName.Text = stepvalue;
            }
            else targetName.Text = "";
           
            if (trgttext_dictionary.ContainsKey(stepNum))
            {
                trgttext_dictionary.TryGetValue(stepNum, out stepvalue);
                targetText.Text = stepvalue;
            }
            else targetText.Text = "";

            if (steptype_dictionary.ContainsKey(stepNum)) //wtf...enum can get bent
            {
                steptype_dictionary.TryGetValue(stepNum, out stepvalue);
                eStepType.Text = stepvalue;
            }
            else eStepType.Text = "";
        }

        //Final Reward forward dictionary
        private void finrewardForward_Click(object sender, EventArgs e)
        {
            if (getFin.Text == "")
            {
                MessageBox.Show("You can't add nothing as a reward!", "PEBKAC");
                return;
            }

            int finNum = int.Parse(finNumber.Text);

            if (!fin_dictionary.ContainsKey(finNum)) //If the reward data is not in the dictionary...check for step 1, then add
            {
                fin_dictionary.Add(finNum, getFin.Text);
            }
            else //If the reward data is in the dictionary...check if the values match and add if they don't
            {
                string finvalue;
                fin_dictionary.TryGetValue(finNum, out finvalue);

                if (finvalue != getFin.Text)
                {
                    fin_dictionary.Remove(finNum);
                    fin_dictionary.Add(finNum, getFin.Text);
                }
            }

            finNumber.Text = (finNum + 1).ToString();
            
            //Check if next step contains data
            int finNext = int.Parse(finNumber.Text);
            if (fin_dictionary.ContainsKey(finNext))
            {
                string finvalue;
                fin_dictionary.TryGetValue(finNext, out finvalue);
                getFin.Text = finvalue;
            }
            else getFin.Text = "";
            
        }

        //Final Reward back Dictionary
        private void finrewardBack_Click(object sender, EventArgs e)
        {
            int finNum = int.Parse(finNumber.Text);

            if (finNum == 1) //return if already at step 1, there ain't no step 0
            {
                return;
            }

            if (getFin.Text != "") //Add data on back click
            {
                string finvalue;
                fin_dictionary.TryGetValue(finNum, out finvalue);
                if (finvalue != getFin.Text) //check if data is different from dictionary data
                {
                    fin_dictionary.Remove(finNum);
                    fin_dictionary.Add(finNum, getFin.Text);
                }
            }
            else //There are no breaks in reward data, so a blank box cannot exist between populated blocks
            {
                if (fin_dictionary.ContainsKey(finNum + 1))
                {
                    MessageBox.Show("You must remove the items listed after the current item to remove this one!", "Error");
                    return;
                }
                else
                {
                    fin_dictionary.Remove(finNum);
                }
            }

            
            //Pull previous step data
            string finback;
            int fincheck = int.Parse(finNumber.Text);
            fincheck--;
            fin_dictionary.TryGetValue(fincheck, out finback);
            getFin.Text = finback;
 
            finNumber.Text = (finNum - 1).ToString(); //finally, decrement fin label
        }

        //Optional Reward forward dictionary
        private void optrewardForward_Click(object sender, EventArgs e)
        {
            if (getOpt.Text == "")
            {
                MessageBox.Show("You can't add nothing as a reward!", "PEBKAC");
                return;
            }

            int optNum = int.Parse(optNumber.Text);

            if (optNum == 8)
            {
                opt_dictionary.Remove(optNum);
                opt_dictionary.Add(optNum, getOpt.Text);
                MessageBox.Show("Last optional item added", "8 Optional Rewards Max");
                return;
            }

            if (!opt_dictionary.ContainsKey(optNum)) //If the reward data is not in the dictionary...check for step 1, then add
            {
                opt_dictionary.Add(optNum, getOpt.Text);
            }
            else //If the reward data is in the dictionary...check if the values match and add if they don't
            {
                string optvalue;
                opt_dictionary.TryGetValue(optNum, out optvalue);

                if (optvalue != getOpt.Text)
                {
                    opt_dictionary.Remove(optNum);
                    opt_dictionary.Add(optNum, getOpt.Text);
                }
            }

            optNumber.Text = (optNum + 1).ToString();

            //Check if next step contains data
            int optNext = int.Parse(optNumber.Text);
            if (opt_dictionary.ContainsKey(optNext))
            {
                string optvalue;
                opt_dictionary.TryGetValue(optNext, out optvalue);
                getOpt.Text = optvalue;
            }
            else getOpt.Text = "";

        }

        //Optional Reward back dictionary
        private void optrewardBack_Click(object sender, EventArgs e)
        {
            int optNum = int.Parse(optNumber.Text);

            if (optNum == 1) //return if already at step 1, there ain't no step 0
            {
                return;
            }

            if (getOpt.Text != "") //Add data on back click
            {
                string optvalue;
                opt_dictionary.TryGetValue(optNum, out optvalue);
                if (optvalue != getOpt.Text)
                {
                    opt_dictionary.Remove(optNum);
                    opt_dictionary.Add(optNum, getOpt.Text);
                }
            }
            else
            {
                if (opt_dictionary.ContainsKey(optNum + 1))
                {
                    MessageBox.Show("You must remove the items listed after the current item to remove this one!", "Error");
                    return;
                }
                else
                {
                    opt_dictionary.Remove(optNum);
                }
            }

            //Pull previous step data
            string optback;
            int optcheck = int.Parse(optNumber.Text);
            optcheck--;
            opt_dictionary.TryGetValue(optcheck, out optback);
            getOpt.Text = optback;
            
            optNumber.Text = (optNum - 1).ToString(); //finally, decrement opt label
        }
            
        #endregion

        #region Save to DB
        private void saveToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int stepNum = int.Parse(stepNumber.Text);
            int optNum = int.Parse(optNumber.Text);
            int finNum = int.Parse(finNumber.Text);            
            if (!steptype_dictionary.ContainsKey(stepNum)) //Adds step data to the dictionary on last step if the forward/back button has not been pressed yet
            {
                advtext_dictionary.Remove(stepNum);
                advtext_dictionary.Add(stepNum, advanceText.Text);
                colitem_dictionary.Remove(stepNum);
                colitem_dictionary.Add(stepNum, collectItem.Text);
                money_dictionary.Remove(stepNum);
                money_dictionary.Add(stepNum, rewardMoney.Text);
                xp_dictionary.Remove(stepNum);
                xp_dictionary.Add(stepNum, rewardXp.Text);
                clxp_dictionary.Remove(stepNum);
                clxp_dictionary.Add(stepNum, rewardCLXp.Text);
                rp_dictionary.Remove(stepNum);
                rp_dictionary.Add(stepNum, rewardRp.Text);
                bp_dictionary.Remove(stepNum);
                bp_dictionary.Add(stepNum, rewardBp.Text);
                srctext_dictionary.Remove(stepNum);
                srctext_dictionary.Add(stepNum, sourceText.Text);
                stepitem_dictionary.Remove(stepNum);
                stepitem_dictionary.Add(stepNum, stepItem.Text);
                steptext_dictionary.Remove(stepNum);
                steptext_dictionary.Add(stepNum, stepText.Text);
                trgtname_dictionary.Remove(stepNum);
                trgtname_dictionary.Add(stepNum, targetName.Text);
                trgttext_dictionary.Remove(stepNum);
                trgttext_dictionary.Add(stepNum, targetText.Text);
                steptype_dictionary.Remove(stepNum);
                steptype_dictionary.Add(stepNum, eStepType.Text);
            }
            if (!opt_dictionary.ContainsKey(optNum))
            {
                opt_dictionary.Remove(stepNum);
                opt_dictionary.Add(stepNum, getOpt.Text);
            }
            if (!fin_dictionary.ContainsKey(finNum))
            {
                fin_dictionary.Remove(stepNum);
                fin_dictionary.Add(stepNum, getFin.Text);
            }

            try
            {
                #region String conversions                
                string opt = String.Join("|", Array.ConvertAll(opt_dictionary.Values.ToArray(), i => i.ToString()));
                string fin = String.Join("|", Array.ConvertAll(fin_dictionary.Values.ToArray(), i => i.ToString()));
                string adv = String.Join("|", Array.ConvertAll(advtext_dictionary.Values.ToArray(), i => i.ToString()));
                string col = String.Join("|", Array.ConvertAll(colitem_dictionary.Values.ToArray(), i => i.ToString()));
                string mon = String.Join("|", Array.ConvertAll(money_dictionary.Values.ToArray(), i => i.ToString()));
                string exp = String.Join("|", Array.ConvertAll(xp_dictionary.Values.ToArray(), i => i.ToString()));
                string cxp = String.Join("|", Array.ConvertAll(clxp_dictionary.Values.ToArray(), i => i.ToString()));
                string rxp = String.Join("|", Array.ConvertAll(rp_dictionary.Values.ToArray(), i => i.ToString()));
                string bxp = String.Join("|", Array.ConvertAll(bp_dictionary.Values.ToArray(), i => i.ToString()));
                string srctx = String.Join("|", Array.ConvertAll(srctext_dictionary.Values.ToArray(), i => i.ToString()));
                string stpit = String.Join("|", Array.ConvertAll(stepitem_dictionary.Values.ToArray(), i => i.ToString()));
                string stptx = String.Join("|", Array.ConvertAll(steptext_dictionary.Values.ToArray(), i => i.ToString()));
                string trgnm = String.Join("|", Array.ConvertAll(trgtname_dictionary.Values.ToArray(), i => i.ToString()));
                string trgtx = String.Join("|", Array.ConvertAll(trgttext_dictionary.Values.ToArray(), i => i.ToString()));
                string stptp = String.Join("|", Array.ConvertAll(steptype_dictionary.Values.ToArray(), i => i.ToString()));
                string acl = String.Join("|", allowedClasses.SelectedItems.Cast<object>().Select(i => i.ToString()));
                //eStepType string replace values:
                
                StringBuilder stype = new StringBuilder(stptp);
                stype.Replace("Kill", "0");
                stype.Replace("killFinish", "1");
                stype.Replace("Deliver", "2");
                stype.Replace("deliverFinish", "3");
                stype.Replace("Interact", "4");
                stype.Replace("interactFinish", "5");
                stype.Replace("Whisper", "6");
                stype.Replace("whisperFinish", "7");
                stype.Replace("Search", "8");
                stype.Replace("searchFinish", "9");
                stype.Replace("Collect", "10");
                stype.Replace("collectFinish", "11");
                string steptp = stype.ToString();
				
                StringBuilder allcl = new StringBuilder(acl);
				allcl.Replace("Armsman", "2");
				allcl.Replace("Cabalist", "13");
				allcl.Replace("Cleric", "6");
				allcl.Replace("Friar", "10");
				allcl.Replace("Heretic", "33");
				allcl.Replace("Infitrator", "9");
				allcl.Replace("Mercenary", "11");
				allcl.Replace("Minstrel", "4");
				allcl.Replace("Necromancer", "12");
				allcl.Replace("Paladin", "1");
				allcl.Replace("Reaver", "19");
				allcl.Replace("Scout", "3");
				allcl.Replace("Sorcerer", "8");
				allcl.Replace("Theurgist", "5");
				allcl.Replace("Wizard", "7");
				allcl.Replace("MaulerAlb", "60");
				allcl.Replace("Berserker", "31");
				allcl.Replace("Bonedancer", "30");
				allcl.Replace("Healer", "36");
				allcl.Replace("Hunter", "35");
				allcl.Replace("Runemaster", "29");
				allcl.Replace("Savage", "32");
				allcl.Replace("Shadowblade", "23");
				allcl.Replace("Shaman", "28");
				allcl.Replace("Skald", "24");
				allcl.Replace("Spiritmaster", "27");
				allcl.Replace("Thane", "21");
				allcl.Replace("Valkyrie", "34");
				allcl.Replace("Warlock", "59");
				allcl.Replace("Warrior", "22");
				allcl.Replace("MaulerMid", "61");
				allcl.Replace("Animist", "55");
				allcl.Replace("Bainshee", "39");
				allcl.Replace("Bard", "48");
				allcl.Replace("Blademaster", "43");
				allcl.Replace("Champ", "45");
				allcl.Replace("Druid", "47");
				allcl.Replace("Eldritch", "40");
				allcl.Replace("Enchanter", "41");
				allcl.Replace("Hero", "44");
				allcl.Replace("Mentalist", "42");
				allcl.Replace("Nightshade", "49");
				allcl.Replace("Ranger", "50");
				allcl.Replace("Valewalker", "56");
				allcl.Replace("Vampiir", "58");
				allcl.Replace("Warden", "46");
				allcl.Replace("MaulerMid", "62");
				string aclts = allcl.ToString();
                
                #endregion

                DatabaseManager.SetDatabaseConnection(Settings.Default.Hostname, Settings.Default.Port, Settings.Default.Database, Settings.Default.Username, Settings.Default.Password);
                DBDataQuest q = new DBDataQuest();
                q.ID = int.Parse(questID.Text);
                q.Name = questName.Text;
                q.StartType = (byte)(eStartType.SelectedIndex);
                q.StartName = startNPCName.Text;
                q.StartRegionID = ushort.Parse(questNPCRegionID.Text);
                q.AcceptText = acceptText.Text;
                q.Description = description.Text;
                q.SourceText = srctx; //serialized
                q.StepType = steptp; //serialized
                q.StepText = stptx; //serialized
                q.StepItemTemplates = stpit; //serialized
                q.AdvanceText = adv; //serialized
                q.TargetName = trgnm; //serialized
                q.TargetText = trgtx; //serialized
                q.CollectItemTemplate = col; //serialized
                q.MaxCount = byte.Parse(maxCount.Text);
                q.MinLevel = byte.Parse(questMinLevel.Text);
                q.MaxLevel = byte.Parse(questMaxLevel.Text);
                q.RewardMoney = mon; //serialized
                q.RewardXP = exp; //serialized
                q.RewardCLXP = cxp; //serialized
                q.RewardRP = rxp; //serialized
                q.RewardBP = bxp; //serialized
                q.OptionalRewardItemTemplates = opt;
                q.FinalRewardItemTemplates = fin;
                q.FinishText = finishText.Text;
                q.QuestDependency = questDependency.Text; //might need to serialize....if quest has multiple dependencies
                q.AllowedClasses = aclts; //serialized
                q.ClassType = questClassType.Text;
                DatabaseManager.Database.AddObject(q);

                MessageBox.Show("Quest added to the database!");
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Input validation
        private void questID_TextChanged(object sender, EventArgs e)
        {
            int qID = 1;
            try
            {
                qID = int.Parse(questID.Text);
            }
            catch
            {
                MessageBox.Show("Enter numbers between 1 and 32767 only!");
                questID.Text = "1";
            }
            if (qID > 32767)
            {
                MessageBox.Show("Select a Quest ID between 1 and 32767");
                questID.Text = "1";
                return;
            }
        }
        private void description_TextChanged(object sender, EventArgs e)
        {
            label4.Text = (description.TextLength).ToString();
            if (description.TextLength > 255)
            {
                MessageBox.Show("Quest description cannot exceed 255 characters.");
            }
        }
        private void questMaxLevel_TextChanged(object sender, EventArgs e)
        {
            int qMaxlvl = 50;
            try
            {
                qMaxlvl = int.Parse(questMaxLevel.Text);
            }
            catch
            {
                MessageBox.Show("Enter numbers only!");
                questMaxLevel.Text = "50";
            }
        }
        private void questMinLevel_TextChanged(object sender, EventArgs e)
        {
            
            int qMinlvl = 1;
            try
            {
                qMinlvl = int.Parse(questMinLevel.Text);
            }
            catch
            {
                MessageBox.Show("Enter numbers only!");
                questMinLevel.Text = "1";
            }
        }
        private void maxCount_TextChanged(object sender, EventArgs e)
        {
            int qMaxcou = 1;
            try
            {
                qMaxcou = int.Parse(maxCount.Text);
            }
            catch
            {
                MessageBox.Show("Enter numbers only!");
                maxCount.Text = "1";
            }
        }
        private void questNPCRegionID_TextChanged(object sender, EventArgs e)
        {
            int regId;
            try
            {
                regId = int.Parse(questNPCRegionID.Text);
            }
            catch
            {
                MessageBox.Show("Enter numbers only!");
                questNPCRegionID.Text = "0";
            }
        }
        #endregion

        #region Search & Set Buttons, Groupboxes

        private void targetSearch_Click(object sender, EventArgs e)
        {
            FindNPC2 npc2 = new FindNPC2();
            npc2.Show();
        }
        private void targetSelected_Click(object sender, EventArgs e)
        {
            targetName.Text = Settings.Default.SelectNPC2;
        }
        private void itemSearch_Click(object sender, EventArgs e)
        {
            FindItem item = new FindItem();
            item.Show();
        }
        private void optSelect_Click(object sender, EventArgs e)
        {
           getOpt.Text = Settings.Default.SelectOption;
        }
        private void finSelect_Click(object sender, EventArgs e)
        {
           getFin.Text = Settings.Default.SelectFinish;
        }
        private void startNPCSearch_Click(object sender, EventArgs e)
        {
            {
                FindStart npc = new FindStart();
                npc.Show();
            }
        }
        private void setStart_Click(object sender, EventArgs e)
        {
            startNPCName.Text = Settings.Default.SelectStartNPC;
            questNPCRegionID.Text = Settings.Default.SelectStartNPCRegion;
        }
        private void questSearch_Click(object sender, EventArgs e)
        {
            FindQuest quest = new FindQuest();
            quest.Show();
        }
        private void setQuest_Click(object sender, EventArgs e)
        {
            questDependency.Text = Settings.Default.SelectQuest;
        }
        private void itemSelect_Click(object sender, EventArgs e)
        {
            stepItem.Text = Settings.Default.SelectStepItem;
        }
        private void collectSelect_Click(object sender, EventArgs e)
        {
            collectItem.Text = Settings.Default.SelectCollectItem;
        }
        private void button1_Click(object sender, EventArgs e) //Clear data button
        {
            int stepNum = int.Parse(stepNumber.Text);
            advtext_dictionary.Remove(stepNum);
            advanceText.Text = "";
            colitem_dictionary.Remove(stepNum);
            collectItem.Text = "";
            money_dictionary.Remove(stepNum);
            rewardMoney.Text = "0";
            xp_dictionary.Remove(stepNum);
            rewardXp.Text = "0";
            clxp_dictionary.Remove(stepNum);
            rewardCLXp.Text = "0";
            rp_dictionary.Remove(stepNum);
            rewardRp.Text = "0";
            bp_dictionary.Remove(stepNum);
            rewardBp.Text = "0";
            srctext_dictionary.Remove(stepNum);
            sourceText.Text = "";
            stepitem_dictionary.Remove(stepNum);
            stepItem.Text = "";
            steptext_dictionary.Remove(stepNum);
            stepText.Text = "";
            trgtname_dictionary.Remove(stepNum);
            targetName.Text = "";
            trgttext_dictionary.Remove(stepNum);
            targetText.Text = "";
            steptype_dictionary.Remove(stepNum);
            eStepType.Text = "";
        }
        #endregion
    }
}