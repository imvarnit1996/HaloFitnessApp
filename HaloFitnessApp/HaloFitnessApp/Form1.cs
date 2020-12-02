using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HaloFitnessApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        const int INCREMENT = 2, FORMWIDTH = 954, FORMSTARTHEIGHT = 380, FORMEXPANDHEIGHT = 620;

        int cust_term;
        static int PRICE_PER_MONTH = 59;
        static double total_price = 0;
        static double discounted_price = 0;
        static int PASSWORD_ATTEMPTS = 3;
        static string file_name = "Members_details.txt";
        //change file path according to your file location
        string file_path = @"C:\Users\VarnitsMachine\source\repos\HaloFitnessApp\Members\" + file_name;

        private void MainForm_Load(object sender, EventArgs e)
        {
            MembershipDetailsGroupBox.Visible = false;
            PricingGroupBox.Visible = false;
            SummaryGroupBox.Visible = false;
            SearchGroupBox.Visible = false;
            ButtonPanel.Visible = false;
            PasswordPanel.Visible = true;
            this.Size = new Size(FORMWIDTH, FORMSTARTHEIGHT);
        }

        private void PasswordSubmitButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "ILuvVisualC#")
            {
                PasswordPanel.Visible = false;
                PricingGroupBox.Visible = true;
                ButtonPanel.Visible = true;
            }
            else
            {
                if (PASSWORD_ATTEMPTS == 1)
                {
                    this.Close();
                }
                else
                {
                    PASSWORD_ATTEMPTS--;
                    MessageBox.Show("Wrong password, " + PASSWORD_ATTEMPTS + " attempts left");
                }

            }

        }

        // calculate prices according to terms selected for membership
        private void calculatorFunction(int cust_term)
        {
            int next_term = 0;
            double next_price;
            double next_term_discounted_price = 0;


            if (cust_term == 1 || cust_term == 2)
            {

                discounted_price = PRICE_PER_MONTH;
                next_term = 3;
                next_term_discounted_price = PRICE_PER_MONTH - (PRICE_PER_MONTH * 0.1);
            }
            else if (cust_term >= 3 && cust_term <= 6)
            {
                discounted_price = PRICE_PER_MONTH - (PRICE_PER_MONTH * 0.1);
                next_term = 7;
                next_term_discounted_price = PRICE_PER_MONTH - (PRICE_PER_MONTH * 0.2);
            }

            else if (cust_term >= 7 && cust_term <= 12)
            {
                discounted_price = PRICE_PER_MONTH - (PRICE_PER_MONTH * 0.2);
                next_term = 13;
                next_term_discounted_price = PRICE_PER_MONTH - (PRICE_PER_MONTH * 0.25);
            }

            else if (cust_term >= 13 && cust_term <= 18)
            {
                discounted_price = PRICE_PER_MONTH - (PRICE_PER_MONTH * 0.25);
                next_term = 19;
                next_term_discounted_price = PRICE_PER_MONTH - (PRICE_PER_MONTH * 0.34);
            }

            else if (cust_term >= 19 && cust_term <= 24)
            {
                discounted_price = PRICE_PER_MONTH - (PRICE_PER_MONTH * 0.34);
                next_term = 25;
                next_term_discounted_price = PRICE_PER_MONTH - (PRICE_PER_MONTH * 0.4);

            }

            else if (cust_term >= 25 && cust_term <= 60)
            {
                discounted_price = PRICE_PER_MONTH - (PRICE_PER_MONTH * 0.4);
                next_term = 61;
                next_term_discounted_price = PRICE_PER_MONTH - (PRICE_PER_MONTH * 0.67);
            }
            else
            {
                discounted_price = PRICE_PER_MONTH - (PRICE_PER_MONTH * 0.67);
            }

            total_price = discounted_price * cust_term;
            PricePerMonthTextBox.Text = discounted_price.ToString() + " €";
            PriceFullTermTextBox.Text = total_price.ToString() + " €";
            next_price = next_term_discounted_price * next_term;
            PriceNextTermTextBox.Text = next_price.ToString() + " €";

        }

        // displays prices for term chosen by customer
        private void DisplayButton_Click(object sender, EventArgs e)
        {

            int num;

            if (TermTextBox.Text != "" && TermTextBox.Text != "0")
            {

                if (int.TryParse(TermTextBox.Text, out num))
                {
                    cust_term = int.Parse(TermTextBox.Text);
                    // Console.WriteLine(cust_term);
                    calculatorFunction(cust_term);
                }

                else
                {
                    MessageBox.Show("Only natural numbers are acceptable");
                }

            }
            else
            {
                MessageBox.Show("Please Enter a valid term to show prices, 0 is not valid term in this context");
            }


        }

        // proceeds with term chosen by customer
        private void ProceedButton_Click(object sender, EventArgs e)
        {


            if (ClientConfirmedTextBox.Text != "" && ClientConfirmedTextBox.Text != "0")
            {

                int num;
                if (int.TryParse(ClientConfirmedTextBox.Text, out num))
                {
                    cust_term = int.Parse(ClientConfirmedTextBox.Text);
                    calculatorFunction(cust_term);
                }
                else
                {
                    MessageBox.Show("Only whole numbers are acceptable");
                    return;
                }
                MembershipDetailsGroupBox.Visible = true;
                FullNameTextBox.Text = "";
                TelephoneTextBox.Text = "";
                EmailTextBox.Text = "";

                Random generator = new Random();
                int membership_id = generator.Next(100000, 1000000);
                // Console.WriteLine(membership_id);
                MembershipIDTextBox.Text = membership_id.ToString();
                DateTime dateTime = DateTime.UtcNow.Date;
                // Console.WriteLine(dateTime.ToString("dd-MM-yyyy"));
                JoiningDateTextBox.Text = dateTime.ToString("dd-MM-yyyy");


            }
            else
            {
                MessageBox.Show("Please enter a term to proceed 0 is not valid term in this context");
            }
        }

        // save the coustomer details to file Members_details.txt
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            double check;
            if (FullNameTextBox.Text == "" || TelephoneTextBox.Text == "" || EmailTextBox.Text == "")
            {
                MessageBox.Show("Fill all the details");
                return;
            }
            else if (!double.TryParse(TelephoneTextBox.Text, out check))
            {
                MessageBox.Show("Telephone number should only contain numbers");
                return;
            }
            else if (!Regex.IsMatch(EmailTextBox.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                MessageBox.Show("Please Enter a valid email.");
                return;
            }

            try
            {
                using (StreamReader sr = new StreamReader(file_path))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == MembershipIDTextBox.Text)
                        {
                            MessageBox.Show("Member already registered");
                            return;
                        }
                    }
                }
                string member_details = MembershipIDTextBox.Text + Environment.NewLine + JoiningDateTextBox.Text + Environment.NewLine +
                                        FullNameTextBox.Text + Environment.NewLine + TelephoneTextBox.Text + Environment.NewLine +
                                        EmailTextBox.Text + Environment.NewLine + ClientConfirmedTextBox.Text + Environment.NewLine +
                                        PriceFullTermTextBox.Text + Environment.NewLine + "#" + Environment.NewLine;

                File.AppendAllText(file_path, member_details);
                MessageBox.Show("Saved to " + file_name);
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be read:");
            }

        }



        private void ClearButton_Click(object sender, EventArgs e)
        {

            FullNameTextBox.Text = "";
            TelephoneTextBox.Text = "";
            EmailTextBox.Text = "";
            MembershipIDTextBox.Text = "";
            JoiningDateTextBox.Text = "";
            PriceFullTermTextBox.Text = "";
            PriceNextTermTextBox.Text = "";
            PricePerMonthTextBox.Text = "";
            ClientConfirmedTextBox.Text = "";
            TermTextBox.Text = "";
            SearchByDateTextBox.Text = "";
            SearchByIDTextBox.Text = "";
            AverageMembershipTermTextBox.Text = "";
            TotalSaleTextBox.Text = "";
            AverageSaleTextBox.Text = "";
            NumberOfMembershipsTextBox.Text = "";

            if ((SummaryGroupBox.Visible) || (SearchGroupBox.Visible))
            {
                for (int i = 620; i > 380; i -= INCREMENT)
                {
                    this.Size = new Size(FORMWIDTH, i);
                    this.Update();
                    System.Threading.Thread.Sleep(1);
                }
            }
            SummaryGroupBox.Visible = false;
            SearchGroupBox.Visible = false;
        }



        // search for details in file Members_details.text accordingly 
        private void Find_Click(object sender, EventArgs e)
        {

            if (SearchByDateTextBox.Text == "" && SearchByIDTextBox.Text == "")
            {
                MessageBox.Show("Please Enter either Membership Id or Date to search");
            }
            else if (SearchByDateTextBox.Text != "" && SearchByIDTextBox.Text != "")
            {
                MessageBox.Show("Please Enter only one parameter for search either Membership Id or Date to search not both");
            }
            else if (SearchByIDTextBox.Text == "")
            {
                string line;
                string membership_details = "";
                string membership_id = "";
                try
                {
                    using (StreamReader sr = new StreamReader(file_path))
                    {

                        while ((line = sr.ReadLine()) != null)
                        {

                            if (membership_id == "")
                            {
                                membership_id = line;
                                line = sr.ReadLine();
                            }

                            if (line == SearchByDateTextBox.Text)
                            {
                                membership_details += Environment.NewLine + Environment.NewLine + membership_id;
                                membership_details += Environment.NewLine + line;

                                while ((line = sr.ReadLine()) != "#")
                                {
                                    membership_details += Environment.NewLine + line;
                                }
                                // Console.WriteLine(line);
                                membership_id = "";
                            }
                            else
                            {
                                while ((line = sr.ReadLine()) != "#")
                                {
                                    continue;
                                }
                                membership_id = "";
                            }

                        }
                        if (membership_details == "")
                        {
                            MessageBox.Show("No Sales on this DATE");
                        }
                        else
                        {
                            MessageBox.Show(membership_details + Environment.NewLine);
                            // Console.WriteLine(membership_id + " " + membership_details);

                        }

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("The file could not be read:");
                }

            }
            else if (SearchByDateTextBox.Text == "")
            {
                string line;
                string membership_details = "";
                try
                {
                    using (StreamReader sr = new StreamReader(file_path))
                    {


                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line == SearchByIDTextBox.Text)
                            {
                                membership_details = line;
                                while ((line = sr.ReadLine()) != "#")
                                {
                                    membership_details = membership_details + Environment.NewLine + line;
                                }
                                Console.WriteLine(membership_details);
                                break;
                            }

                        }

                        if (membership_details == "")
                        {
                            MessageBox.Show("No Result with this membership Id");
                        }
                        else
                        {
                            MessageBox.Show(membership_details);
                        }

                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("The file could not be read:");

                }

            }
        }

        // gives summary of data i.e. average sales ,number of members, total sale, average term
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            SearchGroupBox.Visible = false;
            SummaryGroupBox.Visible = true;

            for (int i = FORMSTARTHEIGHT; i < FORMEXPANDHEIGHT; i += INCREMENT)
            {
                this.Size = new Size(FORMWIDTH, i);
                this.Update();
                System.Threading.Thread.Sleep(1);
            }

            try
            {
                using (StreamReader sr = new StreamReader(file_path))
                {
                    string line;
                    int number_of_members = 0;
                    int line_number = 1;
                    double total_sale = 0;
                    int sum_of_terms = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == "#")
                        {
                            number_of_members++;
                            line = sr.ReadLine();
                            line_number = 1;
                        }

                        if (line_number == 6)
                        {
                            sum_of_terms += int.Parse(line);
                        }

                        if (line_number == 7)
                        {
                            var price = Regex.Match(line, @"\d+").Value;
                            total_sale += Convert.ToDouble(price);
                        }
                        // Console.WriteLine(line_number + " " + line);
                        line_number++;


                    }
                    //Console.WriteLine("Total sale " + total_sale);
                    //Console.WriteLine("Average sale " + (total_sale / number_of_members));
                    //Console.WriteLine("Average " + (sum_of_terms / number_of_members));
                    //Console.WriteLine("number_of_members " + number_of_members);

                    if (number_of_members == 0)
                    {
                        NoSaleLabel.Visible = true;
                        NumberOfMembershipsLabel.Visible = false;
                        TotalSaleLabel.Visible = false;
                        AverageMembershipTermLabel.Visible = false;
                        AverageSaleLabel.Visible = false;

                        NumberOfMembershipsTextBox.Visible = false;
                        TotalSaleTextBox.Visible = false;
                        AverageSaleTextBox.Visible = false;
                        AverageMembershipTermTextBox.Visible = false;
                    }
                    else
                    {
                        NumberOfMembershipsTextBox.Text = number_of_members.ToString();
                        TotalSaleTextBox.Text = total_sale.ToString();
                        AverageSaleTextBox.Text = (total_sale / number_of_members).ToString();
                        AverageMembershipTermTextBox.Text = (sum_of_terms / number_of_members).ToString();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be read:");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SummaryGroupBox.Visible = false;
            SearchGroupBox.Visible = true;

            for (int i = FORMSTARTHEIGHT; i < FORMEXPANDHEIGHT; i += INCREMENT)
            {
                this.Size = new Size(FORMWIDTH, i);
                this.Update();
                System.Threading.Thread.Sleep(1);
            }

        }


        private void SearchByDateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchByIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PricingPictureBox_Click(object sender, EventArgs e)
        {

        }


        private void TermTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceFullTermLabel_Click(object sender, EventArgs e)
        {

        }

        private void PricePerMonthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceFullTermTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceNextTermTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MembershipIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void JoiningDateTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void TelephoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void PasswordPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void SummaryGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ClientConfirmedTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void QuotePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MembershipDetailsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PricingGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void SearchGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void NumberOfMembershipsLabel_Click(object sender, EventArgs e)
        {

        }

        private void TotalSaleLabel_Click(object sender, EventArgs e)
        {

        }

        private void AverageMembershipTermLabel_Click(object sender, EventArgs e)
        {

        }

        private void AverageSaleLabel_Click(object sender, EventArgs e)
        {

        }

        private void AverageMembershipFeesLabel_Click(object sender, EventArgs e)
        {

        }


        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
