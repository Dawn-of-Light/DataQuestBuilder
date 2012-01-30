using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataQuestBuilder;

namespace DataQuestBuilder.Content
{
    public class DataQuestStep
    //For step specific data, if adding additional step specific data, add it here (if the data is to change with each step type).
    {
        private eProperties.eStepType m_stepType;
        private string m_sourceText;
        private string m_stepText;
        private string m_stepItemTemplate;
        private string m_advanceText;
        private string m_targetName;
        private string m_targetText;
        private string m_collectItemTemplate;
        private string m_rewardMoney;
        private string m_rewardXP;
        private string m_rewardCLXP;
        private string m_rewardRP;
        private string m_rewardBP;
        //private string m_rewardCraftXP;

        /// <summary>
        /// what Step Type is this step?
        /// </summary>
        public eProperties.eStepType StepType
        {
            get { return m_stepType; }
            set { m_stepType = value; }
        }
        public string SourceText
        {
            get { return m_sourceText; }
            set { m_sourceText = value; }
        }
        public string StepText
        {
            get { return m_stepText; }
            set { m_stepText = value; }
        }
        public string StepItemTemplate
        {
            get { return m_stepItemTemplate; }
            set { m_stepItemTemplate = value; }
        }
        public string AdvanceText
        {
            get { return m_advanceText; }
            set { m_advanceText = value; }
        }
        public string TargetName
        {
            get { return m_targetName; }
            set { m_targetName = value; }
        }
        public string TargetText
        {
            get { return m_targetText; }
            set { m_targetText = value; }
        }
        public string CollectItemTemplate
        {
            get { return m_collectItemTemplate; }
            set { m_collectItemTemplate = value; }
        }
        public string RewardMoney
        {
            get { return m_rewardMoney; }
            set { m_rewardMoney = value; }
        }
        public string RewardXP
        {
            get { return m_rewardXP; }
            set { m_rewardXP = value; }
        }
        public string RewardCLXP
        {
            get { return m_rewardCLXP; }
            set { m_rewardCLXP = value; }
        }
        public string RewardRP
        {
            get { return m_rewardRP; }
            set { m_rewardRP = value; }
        }
        public string RewardBP
        {
            get { return m_rewardBP; }
            set { m_rewardBP = value; }
        }

        //TODO: Add crafting points to Dataquest
        //public string RewardCraftXP
        //{
        //	get { return m_rewardCraftXP; }
        //	set { m_rewardCraftXP = value; }
        //}

    }
    public class Rewards
    //Multiple reward data
    {
        private string r_optionalRewardItemTemplates;
        private string r_finalRewardItemTemplates;

        /// <summary>
        /// get rewards
        /// </summary>
        public string OptionalRewardItemTemplates
        {
            get { return r_optionalRewardItemTemplates; }
            set { r_optionalRewardItemTemplates = value; }
        }
        public string FinalRewardItemTemplates
        {
            get { return r_finalRewardItemTemplates; }
            set { r_finalRewardItemTemplates = value; }
        }
    }
}
