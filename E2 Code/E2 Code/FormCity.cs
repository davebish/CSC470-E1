using System;
using System.Windows.Forms;

namespace E2_Code
{
    public partial class FormCity : Form
    {
        public string _SelectedCity;
        private string _SelectedState;
        public FormCity(string selectedState) 
        {
            InitializeComponent();
            _SelectedState = selectedState;
        }

        private void FormCity_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            labelSelectedState.Text = _SelectedState;
            PopulateCities();
        }
        private void PopulateCities()
        {
            listBoxCities.Items.Clear();
            if (_SelectedState == "Alaska")
            {
                listBoxCities.Items.Add("Anchorage");
                listBoxCities.Items.Add("Glenallen");
                listBoxCities.Items.Add("Homer");
                listBoxCities.Items.Add("Juneau");
                listBoxCities.Items.Add("Valdez");

            }
            else if (_SelectedState == "California")
            {
                listBoxCities.Items.Add("Corona");
                listBoxCities.Items.Add("Jarupa Valley");
                listBoxCities.Items.Add("Norco");
                listBoxCities.Items.Add("Rancho Cucamonga");
                listBoxCities.Items.Add("Riverside");
            }
            else if (_SelectedState == "Colorado")
            {
                listBoxCities.Items.Add("Aurora");
                listBoxCities.Items.Add("Durango");
                listBoxCities.Items.Add("Littleton");
                listBoxCities.Items.Add("Morrison");
                listBoxCities.Items.Add("Wheat Ridge");
            }
            else if (_SelectedState == "North Carolina")
            {
                listBoxCities.Items.Add("Burlington");
                listBoxCities.Items.Add("Climax");
                listBoxCities.Items.Add("Greensboro");
                listBoxCities.Items.Add("High Point");
                listBoxCities.Items.Add("Raliegh");
            }
            else if (_SelectedState == "Oregon")
            {
                listBoxCities.Items.Add("Aloha");
                listBoxCities.Items.Add("Beaverton");
                listBoxCities.Items.Add("Clackamas");
                listBoxCities.Items.Add("Portland");
                listBoxCities.Items.Add("Tualatin");
            }
            else if (_SelectedState == "South Dakota")
            {
                listBoxCities.Items.Add("Agar");
                listBoxCities.Items.Add("Blunt");
                listBoxCities.Items.Add("Ft Piere");
                listBoxCities.Items.Add("Onida");
                listBoxCities.Items.Add("Pierre");
            }
            else if (_SelectedState == "Washington")
            {
                listBoxCities.Items.Add("Anacortes");
                listBoxCities.Items.Add("Bellingham");
                listBoxCities.Items.Add("Ferndale");
                listBoxCities.Items.Add("Lynden");
                listBoxCities.Items.Add("Wickersham");
            }
            else
            {
                MessageBox.Show("Unknown state - " + _SelectedState, "Error");
                this.DialogResult = DialogResult.Abort;
                _SelectedCity = "";
                this.Close();
            }
            listBoxCities.SelectedIndex = 0;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (listBoxCities.SelectedIndex >= 0)
            { 
            string selectedCity = listBoxCities.SelectedItem.ToString().Trim();
                _SelectedCity = selectedCity;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please selected a city or click Cancel", "Attention");
            }
        }
    }
}
