using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class dancerInformation : Form

    {
        static int currentPerformanceNum;
        static int momYear;
        static int currentYear;
        static int currentId;
        static int counter = 0;
        static DancerStudio ds;
        static int numOfDancers;
        public dancerInformation()
        {
            InitializeComponent();
            
            checkEnable(false);
            VisibleControl(false);
           
        }



        private void txtNumOfDancers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    numOfDancers = int.Parse(txtNumOfDancers.Text);
                    if (numOfDancers <= 0)
                    {
                        throw new Exception("Invalid number-number is too small\n Please try again");
                    }
                    ds = new DancerStudio(numOfDancers);
                    txtNumOfDancers.Hide();
                    lblNumOfDancers.Hide();
                    txtNumOfDancers.Enabled = false;
                    lblNumOfDancers.Enabled = true;
                    checkEnable(true);
                    VisibleControl(true);
                    txtShow.Text = "Dancers' Details Overview\r\n";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter an integer number");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Invalid number-number is too big");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void txtNumOfDancers_Leave(object sender, EventArgs e)
        {
            checkNumOfDancers();
        }

        private void btnNumOfDancers_Click(object sender, EventArgs e)
        {
            checkNumOfDancers();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (counter < numOfDancers)
            {
                try
                {
                    try
                    {
                        if ((txtDancerName.Text == "") || (txtIdNum.Text == "") || (txtHospital.Text == "") || (txtCountry.Text == "") || (txtYear.Text == "") || (txtMomCountry.Text == "") || (txtMomHos.Text == "") || (txtMomYear.Text == "") || (cboxType.Text == "") || (txtPerNum.Text == ""))
                            throw new Exception("Some details are missing! \r\nPlease fill in all fields");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    string currentName = txtDancerName.Text;
                    try
                    {

                        currentId = int.Parse(txtIdNum.Text);
                        if (txtIdNum.Text.Length != 9)
                            throw new Exception("Invalid ID Number, please enter a positive 9 - digit integer number ");
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Invalid ID Number, please enter a positive 9 - digit integer number ");
                        return;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid ID Number, please enter a positive 9 - digit integer number ");
                        return;
                    }
                    
                        string currentDanceType = cboxType.SelectedItem.ToString();
                    
                   
                    try
                    {
                        currentYear = int.Parse(txtYear.Text);
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Please enter year between 1900 and 2100");
                        return;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid Year!\r\nPlease try again");
                        return;
                    }
                    try
                    {
                        currentPerformanceNum = int.Parse(txtPerNum.Text);
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Invalid number of performances.\r\nPlease try again");
                        return;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid number of performances.\r\nPlease enter only integer numbers");
                        return;
                    }
                    string currentCountry = txtCountry.Text;
                    string currentHospital = txtHospital.Text;
                    string momHospital = txtMomHos.Text;
                    string momCountry = txtMomCountry.Text;
                    try
                    {
                        momYear = int.Parse(txtMomYear.Text);
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Please enter year between 1900 and 2100");
                        return;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid Year!\r\nPlease try again");
                        return;
                    }


                    if (momYear >= currentYear)
                    {
                        throw new Exception("Sorry\r\nA mother can not be younger than her son!\r\nPlease Enter a valid mother's birth year");
                    }
                    BirthData bdmama = new BirthData(momYear, momHospital, momCountry);
                    BirthData dancerBd = new BirthData(currentYear, currentHospital, currentCountry);
                    Dancer dancer = new Dancer(currentDanceType, currentPerformanceNum, bdmama, currentName, currentId, dancerBd);
                    ds.intUpdate(counter);
                    if ((counter != 0) && (ds.Equals(dancer) != false))
                        throw new Exception("The dancer already exists in the system\r\n");
                    ds.DancerArr[counter] = dancer;
                    counter++;
                    CleanField();

                }
                catch (OverflowException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Please choose a type of dance");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {

                

                MessageBox.Show("Sorry!\r\nThere is no more available space!");
            }

        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if(counter == 0)
                throw new Exception("There are no dancers to show!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtShow.Text = "Dancers' Details Overview\r\n";

            for (int i = 0; i < counter; i++)
            {
                txtShow.Text += "\r\n************************************\r\nDancer number " + (i+1) + " details: \r\n" +
                    ds.DancerArr[i].DancerDetails() + "\r\n************************************";
            }
        }

        public void CleanField()
        {
            txtNumOfDancers.Text = "";
            txtDancerName.Text = "";
            txtIdNum.Text = "";
            txtHospital.Text = "";
            txtCountry.Text = "";
            txtYear.Text = "";
            txtMomCountry.Text = "";
            txtMomHos.Text = "";
            txtMomYear.Text = "";
            cboxType.Text = "";
            txtPerNum.Text = "";
        }

        public void checkEnable(bool b)
        {

            txtDancerName.Enabled = b;
            txtIdNum.Enabled = b;
            txtHospital.Enabled = b;
            txtCountry.Enabled = b;
            txtYear.Enabled = b;
            txtMomCountry.Enabled = b;
            txtMomHos.Enabled = b;
            txtMomYear.Enabled = b;
            cboxType.Enabled = b;
            txtPerNum.Enabled = b;
            btnShow.Enabled = b;
            btnOk.Enabled = b;
            txtShow.Enabled = b;
        }

        public void checkNumOfDancers()
        {
            try
            {
                numOfDancers = int.Parse(txtNumOfDancers.Text);
                if (numOfDancers <= 0)
                {
                    throw new Exception("Invalid number-number is too small\n Please try again");
                }
                ds = new DancerStudio(numOfDancers);
                txtNumOfDancers.Hide();
                lblNumOfDancers.Hide();
                btnNumOfDancers.Hide();
                checkEnable(true);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter an integer number");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Invalid number-number is too big");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void VisibleControl(bool b)
        {
            txtDancerName.Visible= b;
            txtIdNum.Visible = b;
            txtHospital.Visible = b;
            txtCountry.Visible = b;
            txtYear.Visible = b;
            txtMomCountry.Visible = b;
            txtMomHos.Visible = b;
            txtMomYear.Visible = b;
            cboxType.Visible = b;
            txtPerNum.Visible = b;
            btnShow.Visible = b;
            btnOk.Visible = b;
            lblDancerName.Visible = b;
            lblIdNum.Visible = b;
            lblCountry.Visible = b;
            lblDetails.Visible = b;
            lblYear.Visible = b;
            lblHospitalName.Visible = b;
            lblMomCountry.Visible = b;
            lblMomHos.Visible = b;
            lblMomYear.Visible = b;
            lblPerNum.Visible = b;
            lblType.Visible = b;
            
        }

        private void dancerInformation_Load(object sender, EventArgs e)
        {

        }
    }
}





