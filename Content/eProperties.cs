using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataQuestBuilder
{
    /// <summary>
    /// This class holds all enums in the project related to data quests.
    /// </summary>
    public class eProperties
    {
        /// <summary>
        /// The trigger to accept the quest. Some finish the quest aswell.
        /// </summary>
        public enum eStartType : byte
        {
            Standard = 0,			// Talk to npc, accept quest, go through steps
            Collection = 1,			// Player turns drops into npc for xp, quest not added to player quest log, has no steps
            AutoStart = 2,			// Standard quest is auto started simply by interacting with start object
            KillComplete = 3,		// Killing the Start living grants and finished the quest, similar to One Time Drops
            InteractComplete = 4,	// Interacting with start object grants and finishes the quest
            RewardQuest = 200,		// A reward quest, where reward dialog is given to player on quest offer and complete.  
            Unknown = 255
        }
        /// <summary>
        /// The type of each quest step
        /// All quests with steps must end in a Finish step
        /// </summary>
        public enum eStepType : byte
        {
            Kill = 0,				// Kill the target to advance the quest
            killFinish = 1,			// Killing the target finishes the quest and gives the reward
            Deliver = 2,			// Deliver an item to the target to advance the quest
            deliverFinish = 3,		// Deliver an item to the target to finish the quest
            Interact = 4,			// Interact with the target to advance the step
            interactFinish = 5,		// Interact with the target to finish the quest.  This is required to end a RewardQuest
            Whisper = 6,			// Whisper to the target to advance the quest
            whisperFinish = 7,		// Whisper to the target to finish the quest
            Search = 8,				// Search in a specified location
            searchFinish = 9,		// Search in a specified location to finish the quest
            Collect = 10,			// Player must give the target an item to advance the step
			collectFinish = 11		// Player must give the target an item to finish the quest
            //Unknown = 255
        }
    }
}
