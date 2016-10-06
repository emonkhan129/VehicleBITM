using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle
{
    public partial class VehicleApplication : Form
    {
        Vehicle myVehicle = new Vehicle();
        public VehicleApplication()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string vehicleName = vehicleNameTextBox.Text;
            string registrationNo = regNoTextBox.Text;

            myVehicle.VehicleName = vehicleName;
            myVehicle.RegistrationNo = registrationNo;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            myVehicle.Speed = Convert.ToDouble(speedTextBox.Text);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
           minSpeedTextBox.Text = myVehicle.GetMinimumSpeed().ToString();
            maxSpeedTextBox.Text = myVehicle.GetMaximumSpeed().ToString();
            avgSpeedTextBox.Text = myVehicle.GetAverageSpeed().ToString();
        }
    }
}
