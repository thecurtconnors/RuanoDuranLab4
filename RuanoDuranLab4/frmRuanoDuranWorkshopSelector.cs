using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuanoDuranLab4
{
    public partial class frmRuanoDuranWorkshopSelector : Form
    {
        public frmRuanoDuranWorkshopSelector()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!");
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declaring variables
            string workshop, city;
            decimal workshopCost, lodgingCost, totalCost;
            int days;

            //declare constants for workshop prices & lodging base pricing                
            const decimal HandlingStress = 1000, TimeManagement = 800, SupervisionSkills = 1500,
            Negotiation = 1300, HowToInterview = 500, AustinLodging = 150, ChicagoLodging = 225,
            DallasLodging = 175, OrlandoLodging = 300, PhoenixLodging = 175, RaleighLodging = 150;



            if (lstWorkshop.SelectedIndex != -1)

            {
                workshop = lstWorkshop.SelectedItem.ToString();

                //setup price for each workshop
                switch (workshop)

                {
                    case "Handling Stress":
                        txtRegistrationCost.Text = HandlingStress.ToString("c");
                        workshopCost = 1000m;
                        days = 3;
                        break;
                    case "Time Management":
                        txtRegistrationCost.Text = TimeManagement.ToString("c");
                        workshopCost = 800m;
                        days = 3;
                        break;
                    case "Supervision Skills":
                        txtRegistrationCost.Text = SupervisionSkills.ToString("c");
                        workshopCost = 1500m;
                        days = 3;
                        break;
                    case "Negotiation":
                        txtRegistrationCost.Text = Negotiation.ToString("c");
                        workshopCost = 1300;
                        days = 5;
                        break;
                    case "How to Interview":
                        txtRegistrationCost.Text = HowToInterview.ToString("c");
                        workshopCost = 500m;
                        days = 1;
                        break;
                }
            }

            else

            {
                //No Workshop Selected :(
                MessageBox.Show("Select a Workshop!");
            }

            if (lstLocation.SelectedIndex != -1)
            {

                city = lstLocation.SelectedItem.ToString();

                //setup price for each city
                switch (city)
                {
                    case "Austin":
                        txtLodgingCost.Text = AustinLodging.ToString("c");
                        lodgingCost = 150;
                        break;
                    case "Chicago":
                        txtLodgingCost.Text = ChicagoLodging.ToString("c");
                        lodgingCost = 225;
                        break;
                    case "Dallas":
                        txtLodgingCost.Text = DallasLodging.ToString("c");
                        lodgingCost = 175;
                        break;
                    case "Orlando":
                        txtLodgingCost.Text = OrlandoLodging.ToString("c");
                        lodgingCost = 300;
                        break;
                    case "Phoenix":
                        txtLodgingCost.Text = PhoenixLodging.ToString("c");
                        lodgingCost = 175;
                        break;
                    case "Raleigh":
                        txtLodgingCost.Text = RaleighLodging.ToString("c");
                        lodgingCost = 150;
                        break;
                }
            }
            else
            {
                //No City Selected :(
                MessageBox.Show("Select a City!");
            }


      
            {



            //calculate totals

                if (decimal.TryParse(txtRegistrationCost.Text, out workshopCost))

                {
                    if (decimal.TryParse(txtLodgingCost.Text, out lodgingCost))
                    {


                        totalCost = lodgingCost + workshopCost;

                        txtTotalCost.Text = totalCost.ToString("c");


                    }
                    else

                    {

                    }

                }

            else
                {

                }


            }



        }

    }
}







