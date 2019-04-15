using System;
using System.Data.Entity;
using APA;
using System.Linq;
using System.Windows.Forms;

namespace APAApp
{
    public partial class APAAdminForm : Form
    {
        //object declaration to be able to perform read, update, and delete operations on the 
        //database
        private APADataEntities data = new APADataEntities();
        private BindingSource dataBindingSource = new BindingSource();

        public APAAdminForm()
        {
            InitializeComponent();
        }

        //display players table if the user selects players option from the load tables option, under
        //file on the menu, enable update and delete buttons so that the user can update data or
        //delete data
        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableDescriptionTB.Text = sender.ToString() + " Table";
            adminStatusLabel.Text = null;

            //using entity framework, load the players table and then initialize dataBindingSource's datasource
            //with the data from the players table in the local database. using dataBindingSource, intialize
            //dataGridView's data source so that the players data displays
            data.Players.Load();
            dataBindingSource.DataSource = data.Players.Local.ToBindingList();
            dataGridView.DataSource = dataBindingSource;        
            
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
            fileToolStripMenuItem.DropDown.Close();
        }

        //display division reps table if the user selects division reps option from the load tables option, under
        //file on the menu, enable update and delete buttons so that the user can update data or
        //delete data
        private void divisionRepsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableDescriptionTB.Text = sender.ToString() + " Table";
            adminStatusLabel.Text = null;

            //using entity framework, load the divisionReps table and then initialize dataBindingSource's datasource
            //with the data from the divisionReps table in the local database. using dataBindingSource, intialize
            //dataGridView's data source so that the divisionReps data displays
            data.DivisionReps.Load();
            dataBindingSource.DataSource = data.DivisionReps.Local.ToBindingList();
            dataGridView.DataSource = dataBindingSource;

            updateButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        //display teams table if the user selects teams option from the load tables option, under
        //file on the menu, enable update and delete buttons so that the user can update data or
        //delete data
        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableDescriptionTB.Text = sender.ToString() + " Table";
            adminStatusLabel.Text = null;

            //using entity framework, load the teams table and then initialize dataBindingSource's datasource
            //with the data from the teams table in the local database. using dataBindingSource, intialize
            //dataGridView's data source so that the teams data displays
            data.Teams.Load();
            dataBindingSource.DataSource = data.Teams.Local.ToBindingList();
            dataGridView.DataSource = dataBindingSource;           

            updateButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        //display players that have a status of Captain and enable update and delete buttons
        //so that the user can update or delete data
        private void captainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableDescriptionTB.Text = sender.ToString() + " Table";
            adminStatusLabel.Text = null;

            //using entity framework, load the players table and then initialize dataBindingSource's datasource 
            //with the data from the players table in the local database. use linq to filter out data so that
            //dataBindingSource will initialize dataGridView's data source with people that have Captain status
            data.Players.Load();
            dataBindingSource.DataSource = data.Players.Local.ToBindingList()
                .Where(p => p.Status == "Captain");
            dataGridView.DataSource = dataBindingSource;

            updateButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        //display players that have a status of Player and enable update and delete buttons
        //so that the user can update or delete data
        private void playersOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableDescriptionTB.Text = sender.ToString() + " Table";
            adminStatusLabel.Text = null;

            //using entity framework, load the players table and then initialize dataBindSource's datasource
            //with the data from the players table in the local database. use linq to filter out data so that
            //dataBindingSource will initialize dataGridView's data source with people that have Player status
            data.Players.Load();
            dataBindingSource.DataSource = data.Players.Local.ToBindingList()
                .Where(p => p.Status == "Player");
            dataGridView.DataSource = dataBindingSource;

            updateButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //event handler to save changes to the database when the user clicks the update button
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                data.SaveChanges();
                adminStatusLabel.Text = "Data Updated Successfully";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //event handler for when the user clicks the delete button after having a row, or rows, selected
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row or rows?", "Are you sure?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        dataGridView.Rows.RemoveAt(row.Index);
                    }

                    data.SaveChanges();
                    adminStatusLabel.Text = "Selected row deleted successfully";
                }
                else
                    dataGridView.ClearSelection();
            }
            catch (Exception)
            {
                MessageBox.Show("You must have at least one row selected to be able to delete.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
