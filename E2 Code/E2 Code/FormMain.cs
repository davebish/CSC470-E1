using System;
using System.Windows.Forms;

namespace E2_Code
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            PopulateStates();
        }
        private void PopulateStates()
        {
            listBoxStates.Items.Clear();
            listBoxStates.Items.Add("Alaska");
            listBoxStates.Items.Add("California");
            listBoxStates.Items.Add("Colorado");
            listBoxStates.Items.Add("North Carolina");
            listBoxStates.Items.Add("Oregon");
            listBoxStates.Items.Add("South Dakota");
            listBoxStates.Items.Add("Washington");
            listBoxStates.SelectedIndex = 0;
        }

        private void buttonSeeTheCities_Click(object sender, EventArgs e)
        {
            // Make sure a state is selected
            string selectedState = listBoxStates.SelectedItem.ToString().Trim();
            if (selectedState != "")
            {
                // Open the form as a dialog
                FormCity formCity = new FormCity(selectedState);
                DialogResult result = formCity.ShowDialog();

                // Check the dialog result
                if (result == DialogResult.OK)
                {
                    // get the public member variable value
                    MessageBox.Show("The selected city is " + formCity._SelectedCity);
                }
                else
                {
                    MessageBox.Show("No city selected - dialog cancelled");
                }
            }
            else
            {
                MessageBox.Show("Please selected a state", "Attention");
            }
        }
    }
}
