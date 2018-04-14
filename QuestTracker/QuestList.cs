using System;
using System.Collections.Generic;

namespace QuestTracker
{
    class QuestList
    {
        public QuestList()
        {
            quests = new List<Quest>();
        }

        private List<Quest> quests;
        public List<Quest> Quests => quests;
        
    }
}
