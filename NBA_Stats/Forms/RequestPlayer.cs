using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSC236_RFarah_Final.Forms
{
    public partial class RequestPlayer : Form
    {
        public RequestPlayer()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            // validation
            if (txtFirst.Text == "")
            {
                MessageBox.Show("First name is required.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLast.Text == "")
            {
                MessageBox.Show("Last name is required.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTeam.Text == "")
            {
                MessageBox.Show("A team is required.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbPosition.SelectedIndex == -1)
            {
                MessageBox.Show("A position must be selected.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // read from requested players file to check if player has been already requested
            StreamReader sr = new StreamReader("../../Resources/PlayersRequested.txt");
            string firstName, lastName ;
            bool newPlayer = false;
            string name = sr.ReadLine();

            while (name != null)
            {
                string[] info = name.Split(',');
                firstName = info[0];
                lastName = info[1];
                firstName.Trim();
                lastName.Trim(); // last name comp wont return true

                if (firstName.Equals(txtFirst.ToString()) && lastName.Equals(txtLast.ToString()))
                {
                    MessageBox.Show("That player has already been requested.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    newPlayer = true;
                }
                name = sr.ReadLine();
            }
            sr.Close();
            if (newPlayer == true)
            {
                try
                {
                    StreamWriter sw = new StreamWriter("../../Resources/PlayersRequested.txt");
                    sw.WriteLine(txtFirst.Text + ", " + txtLast.Text + ", " + cbPosition.Text + ", " + txtTeam.Text);
                    sw.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Cant write to specified file. {0}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
