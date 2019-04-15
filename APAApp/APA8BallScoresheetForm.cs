using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAApp
{
    public partial class APA8BallScoresheetForm : Form
    {
        public APA8BallScoresheetForm()
        {
            InitializeComponent();
        }

        private void StartScoringButton_Click(object sender, EventArgs e)
        {
            teamInfoTab.Hide();
            scoresheetTab.Show();
        }

        private void APA8BallScoresheetForm_Load(object sender, EventArgs e)
        {
            //set attributes of tabPage so that tabs do not show
            Size itemSize = new Size(0, 1);
            infoScoresheetTC.ItemSize = itemSize;
            infoScoresheetTC.Multiline = true;
            infoScoresheetTC.SizeMode = TabSizeMode.Fixed;
        }

        private void CancelScoringButton_Click(object sender, EventArgs e)
        {
            scoresheetTab.Hide();
            teamInfoTab.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
