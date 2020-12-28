using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawlerWindowsForms
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        public void SetEncounter(Encounter encounter)
        {
            encounterPrompt.Text = encounter.prompt;
            encounterLabel.Text = encounter.title;
            foreach( ActionButton action in encounter.actions)
            {
                CustomButton button = new CustomButton();
                ActionEvent e = new ActionEvent(encounter, action);
                button.SetAction(e);
                actionLayout.Controls.Add(button);

                //Button button = new Button();
                //button.Text = action.title;
                //ActionEvent e = new ActionEvent(encounter, action);
                //button.Click += e.DoAction;
                //actionLayout.Controls.Add(button);
            }
        }

        public class ActionEvent
        {
            public Encounter encounter;
            public ActionButton action;

            public ActionEvent(Encounter encounter, ActionButton action)
            {
                this.encounter = encounter;
                this.action = action;
            }

            public void DoAction(object sender, EventArgs e)
            {
                action.DoClick(encounter);
            }
        }

        private void actionLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
