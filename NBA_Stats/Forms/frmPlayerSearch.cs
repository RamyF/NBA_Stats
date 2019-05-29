using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSC236_RFarah_Final.Classes.Centers;
using CSC236_RFarah_Final.Classes.Fowards;

namespace CSC236_RFarah_Final.Forms
{
    public partial class frmPlayerSearch : Form
    {
        private ActiveGuard[] currentGuards;
        private ActiveFoward[] currentFowards;
        private ActiveCenter[] currentCenters;

        public frmPlayerSearch()
        {
            InitializeComponent();
        }

        public frmPlayerSearch(ActiveGuard[] currentGuards, ActiveFoward[] currentFowards, ActiveCenter[] currentCenters)
        {
            this.currentGuards = currentGuards;
            this.currentFowards = currentFowards;
            this.currentCenters = currentCenters;
            InitializeComponent();
        }

        //public frmPlayerSearch(ActiveGuard[] currentGuards, ActiveFoward[] currentFowards, ActiveCenter[] currentCenters)
        //{
        //    InitializeComponent();
        //}

        private void frmPlayerSearch_Load(object sender, EventArgs e)
        {
            lstvPlayers.Items.Clear();
            Array.Sort(currentGuards, delegate (ActiveGuard guard1, ActiveGuard guard2) { return guard1.Name[0].CompareTo(guard2.Name[0]); });
            Array.Sort(currentFowards, delegate (ActiveFoward foward1, ActiveFoward foward2) { return foward1.Name[0].CompareTo(foward2.Name[0]); });
            Array.Sort(currentCenters, delegate (ActiveCenter center1, ActiveCenter center2) { return center1.Name[0].CompareTo(center2.Name[0]); });
            foreach (ActiveGuard guard in currentGuards)
            {
                var row = new string[] { guard.Name, "Guard", Convert.ToString(guard.Age), Convert.ToString(guard.DraftYear), Convert.ToString(guard.YearsExp), guard.Team };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = guard;
                lstvPlayers.Items.Add(listViewItem);
            }

            foreach (ActiveFoward foward in currentFowards)
            {
                var row = new string[] { foward.Name, "Foward", Convert.ToString(foward.Age), Convert.ToString(foward.DraftYear), Convert.ToString(foward.YearsExp), foward.Team };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = foward;
                lstvPlayers.Items.Add(listViewItem);
            }

            foreach (ActiveCenter center in currentCenters)
            {
                var row = new string[] { center.Name, "Center", Convert.ToString(center.Age), Convert.ToString(center.DraftYear), Convert.ToString(center.YearsExp), center.Team };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = center;
                lstvPlayers.Items.Add(listViewItem);
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewPlayer_Click(object sender, EventArgs e)
        {

            if (lstvPlayers.SelectedItems[0].Tag.GetType() == typeof(ActiveGuard))
            {
                
                frmPlayerInfo playerForm = new frmPlayerInfo((ActiveGuard)lstvPlayers.SelectedItems[0].Tag);
                playerForm.Show();
            }

            else if (lstvPlayers.SelectedItems[0].Tag.GetType() == typeof(ActiveFoward))
            {
                frmPlayerInfo playerForm = new frmPlayerInfo((ActiveFoward)lstvPlayers.SelectedItems[0].Tag);
                playerForm.Show();
            }

            else
            {
                frmPlayerInfo playerForm = new frmPlayerInfo((ActiveCenter)lstvPlayers.SelectedItems[0].Tag);
                playerForm.Show();
            }
        }
    }
}
