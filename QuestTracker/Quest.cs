using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestTracker
{
    class Quest
    {
        public
        Quest(String questname)
        {
            name = questname;
            status = QuestStatus.New;
        }

        public Quest(Quest quest)
        {
            this.name = quest.Name;
            this.status = quest.Status;
        }

        public void complete()
        {
            switch(status)
            {
                case QuestStatus.New:
                    Status = QuestStatus.Completed;
                    break;
                case QuestStatus.Completed:
                    throw new QuestException("Quest is already completed.");
                case QuestStatus.Abandoned:
                    throw new QuestException("Quest was abandonded.");
                case QuestStatus.Failed:
                    throw new QuestException("Quest was already failed.");
                default:
                    throw new QuestException("Could not complete quest.");

            }
        }

        private QuestStatus status;
        public QuestStatus Status
        {
            get => status; set => status = value;
        }

        private String name;
        public String Name
        {
            get => name; set => name = value;
        }
    }
}
