using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QuestTracker
{
    public partial class QuestTracker : Form
    {
        public QuestTracker()
        {
            InitializeComponent();
        }

        private QuestList quests;
        private String currentFilename;
        private Boolean modF;
        
        private void QuestTracker_Load(object sender, EventArgs e)
        {
            InitData();
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void NewTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            if(modF)
            {
                String savePrompt = "You have unsaved changes.  Would you like to save?";
                String caption = "Discard Changes?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult res;
                res = MessageBox.Show(savePrompt, caption, buttons);
                switch(res)
                {
                    case DialogResult.Yes:
                        SaveData();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                    default:
                        return;

                }
                InitData();
            }

        }

        private Boolean ChangePrompt()
        {
            String savePrompt = "You have unsaved changes.  Would you like to save?";
            String caption = "Discard Changes?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult res;
            res = MessageBox.Show(savePrompt, caption, buttons);
            switch (res)
            {
                case DialogResult.Yes:
                    SaveData();
                    return true;
                case DialogResult.No:
                    return true;
                case DialogResult.Cancel:
                    return false;
                default:
                    return false;

            }
        }
        private void LoadData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(QuestList));
            StreamReader reader = new StreamReader(currentFilename);
            quests = (QuestList)serializer.Deserialize(reader);
            reader.Close();
        }

        private void SaveData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(QuestList));
            StreamWriter writer = new StreamWriter(currentFilename);
            serializer.Serialize(writer, quests);
            writer.Close();
            modF = false;
        }

        private void InitData()
        {
            quests = new QuestList();
            modF = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bail on cancel from unsaved data
            if (modF && !ChangePrompt())
            {
                return;
            }
            else
            {
                Application.Exit();
            }
        }

        private void QuestTracker_DoubleClick(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
            }
        }

    }
}
