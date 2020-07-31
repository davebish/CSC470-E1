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
        }
    }
}
