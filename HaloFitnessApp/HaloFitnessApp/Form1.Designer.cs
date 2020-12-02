namespace HaloFitnessApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordSubmitButton = new System.Windows.Forms.Button();
            this.PricingPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TermTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.ClientConfirmedTextBox = new System.Windows.Forms.TextBox();
            this.QuotePanel = new System.Windows.Forms.Panel();
            this.PriceNextTermTextBox = new System.Windows.Forms.TextBox();
            this.PriceFullTermTextBox = new System.Windows.Forms.TextBox();
            this.PricePerMonthTextBox = new System.Windows.Forms.TextBox();
            this.MembershipDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.JoiningDateTextBox = new System.Windows.Forms.TextBox();
            this.MembershipIDTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PricingGroupBox = new System.Windows.Forms.GroupBox();
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.NoSaleLabel = new System.Windows.Forms.Label();
            this.NumberOfMembershipsTextBox = new System.Windows.Forms.TextBox();
            this.TotalSaleTextBox = new System.Windows.Forms.TextBox();
            this.AverageMembershipTermTextBox = new System.Windows.Forms.TextBox();
            this.AverageSaleTextBox = new System.Windows.Forms.TextBox();
            this.AverageMembershipTermLabel = new System.Windows.Forms.Label();
            this.AverageSaleLabel = new System.Windows.Forms.Label();
            this.NumberOfMembershipsLabel = new System.Windows.Forms.Label();
            this.TotalSaleLabel = new System.Windows.Forms.Label();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.DateFormatLabel = new System.Windows.Forms.Label();
            this.SearchByIDTextBox = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.SearchByDateTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PricingPictureBox)).BeginInit();
            this.QuotePanel.SuspendLayout();
            this.MembershipDetailsGroupBox.SuspendLayout();
            this.PricingGroupBox.SuspendLayout();
            this.SummaryGroupBox.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordPanel.Controls.Add(this.label1);
            this.PasswordPanel.Controls.Add(this.PasswordTextBox);
            this.PasswordPanel.Controls.Add(this.PasswordSubmitButton);
            this.PasswordPanel.Location = new System.Drawing.Point(92, 71);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(541, 64);
            this.PasswordPanel.TabIndex = 0;
            this.PasswordPanel.Visible = false;
            this.PasswordPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PasswordPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Enter Your Password ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(244, 24);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(123, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // PasswordSubmitButton
            // 
            this.PasswordSubmitButton.Location = new System.Drawing.Point(411, 22);
            this.PasswordSubmitButton.Name = "PasswordSubmitButton";
            this.PasswordSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.PasswordSubmitButton.TabIndex = 0;
            this.PasswordSubmitButton.Text = "&Submit";
            this.PasswordSubmitButton.UseVisualStyleBackColor = true;
            this.PasswordSubmitButton.Click += new System.EventHandler(this.PasswordSubmitButton_Click);
            // 
            // PricingPictureBox
            // 
            this.PricingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PricingPictureBox.Image")));
            this.PricingPictureBox.Location = new System.Drawing.Point(12, 37);
            this.PricingPictureBox.Name = "PricingPictureBox";
            this.PricingPictureBox.Size = new System.Drawing.Size(212, 250);
            this.PricingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PricingPictureBox.TabIndex = 1;
            this.PricingPictureBox.TabStop = false;
            this.PricingPictureBox.Click += new System.EventHandler(this.PricingPictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monthly Base Price €59";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Client Requested Term";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TermTextBox
            // 
            this.TermTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermTextBox.Location = new System.Drawing.Point(270, 42);
            this.TermTextBox.MaxLength = 2;
            this.TermTextBox.Name = "TermTextBox";
            this.TermTextBox.Size = new System.Drawing.Size(100, 22);
            this.TermTextBox.TabIndex = 5;
            this.TermTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TermTextBox.TextChanged += new System.EventHandler(this.TermTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price Per Month";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(390, 41);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 3;
            this.DisplayButton.Text = "&Display";
            this.toolTip1.SetToolTip(this.DisplayButton, "Press to display pricing details");
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(14, 55);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 13);
            this.label.TabIndex = 8;
            this.label.Text = "Price Full Term";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(14, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price @ Start Next Full Term";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(42, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Your Sales Prompt Here";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Client Confirmed Term";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ProceedButton
            // 
            this.ProceedButton.Location = new System.Drawing.Point(390, 263);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(75, 23);
            this.ProceedButton.TabIndex = 15;
            this.ProceedButton.Text = "Proceed";
            this.toolTip1.SetToolTip(this.ProceedButton, "Press to proceed with processing membership");
            this.ProceedButton.UseMnemonic = false;
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // ClientConfirmedTextBox
            // 
            this.ClientConfirmedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientConfirmedTextBox.Location = new System.Drawing.Point(270, 265);
            this.ClientConfirmedTextBox.MaxLength = 2;
            this.ClientConfirmedTextBox.Name = "ClientConfirmedTextBox";
            this.ClientConfirmedTextBox.Size = new System.Drawing.Size(100, 22);
            this.ClientConfirmedTextBox.TabIndex = 16;
            this.ClientConfirmedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientConfirmedTextBox.TextChanged += new System.EventHandler(this.ClientConfirmedTextBox_TextChanged_1);
            // 
            // QuotePanel
            // 
            this.QuotePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuotePanel.Controls.Add(this.PriceNextTermTextBox);
            this.QuotePanel.Controls.Add(this.PriceFullTermTextBox);
            this.QuotePanel.Controls.Add(this.PricePerMonthTextBox);
            this.QuotePanel.Controls.Add(this.label7);
            this.QuotePanel.Controls.Add(this.label6);
            this.QuotePanel.Controls.Add(this.label);
            this.QuotePanel.Controls.Add(this.label4);
            this.QuotePanel.Location = new System.Drawing.Point(247, 76);
            this.QuotePanel.Name = "QuotePanel";
            this.QuotePanel.Size = new System.Drawing.Size(232, 154);
            this.QuotePanel.TabIndex = 17;
            this.QuotePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.QuotePanel_Paint);
            // 
            // PriceNextTermTextBox
            // 
            this.PriceNextTermTextBox.Location = new System.Drawing.Point(129, 91);
            this.PriceNextTermTextBox.Name = "PriceNextTermTextBox";
            this.PriceNextTermTextBox.ReadOnly = true;
            this.PriceNextTermTextBox.Size = new System.Drawing.Size(89, 20);
            this.PriceNextTermTextBox.TabIndex = 15;
            this.PriceNextTermTextBox.TextChanged += new System.EventHandler(this.PriceNextTermTextBox_TextChanged);
            // 
            // PriceFullTermTextBox
            // 
            this.PriceFullTermTextBox.Location = new System.Drawing.Point(129, 53);
            this.PriceFullTermTextBox.Name = "PriceFullTermTextBox";
            this.PriceFullTermTextBox.ReadOnly = true;
            this.PriceFullTermTextBox.Size = new System.Drawing.Size(89, 20);
            this.PriceFullTermTextBox.TabIndex = 14;
            this.PriceFullTermTextBox.TextChanged += new System.EventHandler(this.PriceFullTermTextBox_TextChanged);
            // 
            // PricePerMonthTextBox
            // 
            this.PricePerMonthTextBox.Location = new System.Drawing.Point(129, 13);
            this.PricePerMonthTextBox.Name = "PricePerMonthTextBox";
            this.PricePerMonthTextBox.ReadOnly = true;
            this.PricePerMonthTextBox.Size = new System.Drawing.Size(89, 20);
            this.PricePerMonthTextBox.TabIndex = 13;
            this.PricePerMonthTextBox.TextChanged += new System.EventHandler(this.PricePerMonthTextBox_TextChanged);
            // 
            // MembershipDetailsGroupBox
            // 
            this.MembershipDetailsGroupBox.Controls.Add(this.JoiningDateTextBox);
            this.MembershipDetailsGroupBox.Controls.Add(this.MembershipIDTextBox);
            this.MembershipDetailsGroupBox.Controls.Add(this.ConfirmButton);
            this.MembershipDetailsGroupBox.Controls.Add(this.label12);
            this.MembershipDetailsGroupBox.Controls.Add(this.EmailTextBox);
            this.MembershipDetailsGroupBox.Controls.Add(this.label11);
            this.MembershipDetailsGroupBox.Controls.Add(this.TelephoneTextBox);
            this.MembershipDetailsGroupBox.Controls.Add(this.label9);
            this.MembershipDetailsGroupBox.Controls.Add(this.FullNameTextBox);
            this.MembershipDetailsGroupBox.Controls.Add(this.label5);
            this.MembershipDetailsGroupBox.Controls.Add(this.label10);
            this.MembershipDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembershipDetailsGroupBox.Location = new System.Drawing.Point(540, 12);
            this.MembershipDetailsGroupBox.Name = "MembershipDetailsGroupBox";
            this.MembershipDetailsGroupBox.Size = new System.Drawing.Size(369, 245);
            this.MembershipDetailsGroupBox.TabIndex = 4;
            this.MembershipDetailsGroupBox.TabStop = false;
            this.MembershipDetailsGroupBox.Text = "Member Details";
            this.MembershipDetailsGroupBox.Enter += new System.EventHandler(this.MembershipDetailsGroupBox_Enter);
            // 
            // JoiningDateTextBox
            // 
            this.JoiningDateTextBox.Location = new System.Drawing.Point(201, 68);
            this.JoiningDateTextBox.Name = "JoiningDateTextBox";
            this.JoiningDateTextBox.ReadOnly = true;
            this.JoiningDateTextBox.Size = new System.Drawing.Size(120, 20);
            this.JoiningDateTextBox.TabIndex = 23;
            this.JoiningDateTextBox.TextChanged += new System.EventHandler(this.JoiningDateTextBox_TextChanged);
            // 
            // MembershipIDTextBox
            // 
            this.MembershipIDTextBox.Location = new System.Drawing.Point(201, 21);
            this.MembershipIDTextBox.Name = "MembershipIDTextBox";
            this.MembershipIDTextBox.ReadOnly = true;
            this.MembershipIDTextBox.Size = new System.Drawing.Size(120, 20);
            this.MembershipIDTextBox.TabIndex = 22;
            this.MembershipIDTextBox.TextChanged += new System.EventHandler(this.MembershipIDTextBox_TextChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(156, 216);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 18;
            this.ConfirmButton.Text = "C&onfirm";
            this.toolTip1.SetToolTip(this.ConfirmButton, "Press to enter client details");
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(47, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Joining Date";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(201, 181);
            this.EmailTextBox.MaxLength = 60;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(121, 20);
            this.EmailTextBox.TabIndex = 18;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(47, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Email Address";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Location = new System.Drawing.Point(201, 144);
            this.TelephoneTextBox.MaxLength = 10;
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(120, 20);
            this.TelephoneTextBox.TabIndex = 16;
            this.TelephoneTextBox.TextChanged += new System.EventHandler(this.TelephoneTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(47, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Telephone Number";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(201, 103);
            this.FullNameTextBox.MaxLength = 50;
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.FullNameTextBox.TabIndex = 3;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(47, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Full Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(47, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Membership ID";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // PricingGroupBox
            // 
            this.PricingGroupBox.Controls.Add(this.DisplayButton);
            this.PricingGroupBox.Controls.Add(this.ProceedButton);
            this.PricingGroupBox.Controls.Add(this.label2);
            this.PricingGroupBox.Controls.Add(this.label3);
            this.PricingGroupBox.Controls.Add(this.ClientConfirmedTextBox);
            this.PricingGroupBox.Controls.Add(this.QuotePanel);
            this.PricingGroupBox.Controls.Add(this.TermTextBox);
            this.PricingGroupBox.Controls.Add(this.label8);
            this.PricingGroupBox.Controls.Add(this.PricingPictureBox);
            this.PricingGroupBox.Location = new System.Drawing.Point(26, 12);
            this.PricingGroupBox.Name = "PricingGroupBox";
            this.PricingGroupBox.Size = new System.Drawing.Size(498, 314);
            this.PricingGroupBox.TabIndex = 18;
            this.PricingGroupBox.TabStop = false;
            this.PricingGroupBox.Enter += new System.EventHandler(this.PricingGroupBox_Enter);
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.Controls.Add(this.NoSaleLabel);
            this.SummaryGroupBox.Controls.Add(this.NumberOfMembershipsTextBox);
            this.SummaryGroupBox.Controls.Add(this.TotalSaleTextBox);
            this.SummaryGroupBox.Controls.Add(this.AverageMembershipTermTextBox);
            this.SummaryGroupBox.Controls.Add(this.AverageSaleTextBox);
            this.SummaryGroupBox.Controls.Add(this.AverageMembershipTermLabel);
            this.SummaryGroupBox.Controls.Add(this.AverageSaleLabel);
            this.SummaryGroupBox.Controls.Add(this.NumberOfMembershipsLabel);
            this.SummaryGroupBox.Controls.Add(this.TotalSaleLabel);
            this.SummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SummaryGroupBox.Location = new System.Drawing.Point(26, 340);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Size = new System.Drawing.Size(498, 220);
            this.SummaryGroupBox.TabIndex = 19;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Summary";
            this.SummaryGroupBox.Enter += new System.EventHandler(this.SummaryGroupBox_Enter);
            // 
            // NoSaleLabel
            // 
            this.NoSaleLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoSaleLabel.Location = new System.Drawing.Point(172, 78);
            this.NoSaleLabel.Name = "NoSaleLabel";
            this.NoSaleLabel.Size = new System.Drawing.Size(150, 20);
            this.NoSaleLabel.TabIndex = 11;
            this.NoSaleLabel.Text = "No details to show.";
            this.NoSaleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NoSaleLabel.Visible = false;
            // 
            // NumberOfMembershipsTextBox
            // 
            this.NumberOfMembershipsTextBox.Location = new System.Drawing.Point(311, 30);
            this.NumberOfMembershipsTextBox.Name = "NumberOfMembershipsTextBox";
            this.NumberOfMembershipsTextBox.ReadOnly = true;
            this.NumberOfMembershipsTextBox.Size = new System.Drawing.Size(100, 22);
            this.NumberOfMembershipsTextBox.TabIndex = 10;
            // 
            // TotalSaleTextBox
            // 
            this.TotalSaleTextBox.Location = new System.Drawing.Point(311, 61);
            this.TotalSaleTextBox.Name = "TotalSaleTextBox";
            this.TotalSaleTextBox.ReadOnly = true;
            this.TotalSaleTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalSaleTextBox.TabIndex = 9;
            // 
            // AverageMembershipTermTextBox
            // 
            this.AverageMembershipTermTextBox.Location = new System.Drawing.Point(311, 127);
            this.AverageMembershipTermTextBox.Name = "AverageMembershipTermTextBox";
            this.AverageMembershipTermTextBox.ReadOnly = true;
            this.AverageMembershipTermTextBox.Size = new System.Drawing.Size(100, 22);
            this.AverageMembershipTermTextBox.TabIndex = 8;
            // 
            // AverageSaleTextBox
            // 
            this.AverageSaleTextBox.Location = new System.Drawing.Point(311, 92);
            this.AverageSaleTextBox.Name = "AverageSaleTextBox";
            this.AverageSaleTextBox.ReadOnly = true;
            this.AverageSaleTextBox.Size = new System.Drawing.Size(100, 22);
            this.AverageSaleTextBox.TabIndex = 6;
            // 
            // AverageMembershipTermLabel
            // 
            this.AverageMembershipTermLabel.AutoSize = true;
            this.AverageMembershipTermLabel.Location = new System.Drawing.Point(84, 132);
            this.AverageMembershipTermLabel.Name = "AverageMembershipTermLabel";
            this.AverageMembershipTermLabel.Size = new System.Drawing.Size(198, 16);
            this.AverageMembershipTermLabel.TabIndex = 3;
            this.AverageMembershipTermLabel.Text = "Average membership term: ";
            this.AverageMembershipTermLabel.Click += new System.EventHandler(this.AverageMembershipTermLabel_Click);
            // 
            // AverageSaleLabel
            // 
            this.AverageSaleLabel.AutoSize = true;
            this.AverageSaleLabel.Location = new System.Drawing.Point(84, 98);
            this.AverageSaleLabel.Name = "AverageSaleLabel";
            this.AverageSaleLabel.Size = new System.Drawing.Size(105, 16);
            this.AverageSaleLabel.TabIndex = 2;
            this.AverageSaleLabel.Text = "Average sale:";
            this.AverageSaleLabel.Click += new System.EventHandler(this.AverageSaleLabel_Click);
            // 
            // NumberOfMembershipsLabel
            // 
            this.NumberOfMembershipsLabel.AutoSize = true;
            this.NumberOfMembershipsLabel.Location = new System.Drawing.Point(84, 30);
            this.NumberOfMembershipsLabel.Name = "NumberOfMembershipsLabel";
            this.NumberOfMembershipsLabel.Size = new System.Drawing.Size(172, 16);
            this.NumberOfMembershipsLabel.TabIndex = 1;
            this.NumberOfMembershipsLabel.Text = "Number of membersips:";
            this.NumberOfMembershipsLabel.Click += new System.EventHandler(this.NumberOfMembershipsLabel_Click);
            // 
            // TotalSaleLabel
            // 
            this.TotalSaleLabel.AutoSize = true;
            this.TotalSaleLabel.Location = new System.Drawing.Point(84, 64);
            this.TotalSaleLabel.Name = "TotalSaleLabel";
            this.TotalSaleLabel.Size = new System.Drawing.Size(82, 16);
            this.TotalSaleLabel.TabIndex = 0;
            this.TotalSaleLabel.Text = "Total sale:";
            this.TotalSaleLabel.Click += new System.EventHandler(this.TotalSaleLabel_Click);
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.DateFormatLabel);
            this.SearchGroupBox.Controls.Add(this.SearchByIDTextBox);
            this.SearchGroupBox.Controls.Add(this.Find);
            this.SearchGroupBox.Controls.Add(this.SearchByDateTextBox);
            this.SearchGroupBox.Controls.Add(this.label16);
            this.SearchGroupBox.Controls.Add(this.label15);
            this.SearchGroupBox.Controls.Add(this.label14);
            this.SearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.Location = new System.Drawing.Point(540, 340);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(369, 220);
            this.SearchGroupBox.TabIndex = 20;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            this.SearchGroupBox.Enter += new System.EventHandler(this.SearchGroupBox_Enter);
            // 
            // DateFormatLabel
            // 
            this.DateFormatLabel.AutoSize = true;
            this.DateFormatLabel.Location = new System.Drawing.Point(46, 135);
            this.DateFormatLabel.Name = "DateFormatLabel";
            this.DateFormatLabel.Size = new System.Drawing.Size(102, 16);
            this.DateFormatLabel.TabIndex = 30;
            this.DateFormatLabel.Text = "(dd-mm-yyyy)";
            // 
            // SearchByIDTextBox
            // 
            this.SearchByIDTextBox.Location = new System.Drawing.Point(201, 48);
            this.SearchByIDTextBox.MaxLength = 6;
            this.SearchByIDTextBox.Name = "SearchByIDTextBox";
            this.SearchByIDTextBox.Size = new System.Drawing.Size(130, 22);
            this.SearchByIDTextBox.TabIndex = 29;
            this.SearchByIDTextBox.TextChanged += new System.EventHandler(this.SearchByIDTextBox_TextChanged);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(138, 161);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 23);
            this.Find.TabIndex = 28;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // SearchByDateTextBox
            // 
            this.SearchByDateTextBox.Location = new System.Drawing.Point(201, 116);
            this.SearchByDateTextBox.MaxLength = 10;
            this.SearchByDateTextBox.Name = "SearchByDateTextBox";
            this.SearchByDateTextBox.Size = new System.Drawing.Size(130, 22);
            this.SearchByDateTextBox.TabIndex = 27;
            this.SearchByDateTextBox.TextChanged += new System.EventHandler(this.SearchByDateTextBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 16);
            this.label16.TabIndex = 26;
            this.label16.Text = "Enter Joining date:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(153, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "OR";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(24, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Enter Membership Id:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonPanel.Controls.Add(this.ClearButton);
            this.ButtonPanel.Controls.Add(this.SearchButton);
            this.ButtonPanel.Controls.Add(this.ExitButton);
            this.ButtonPanel.Controls.Add(this.SummaryButton);
            this.ButtonPanel.Location = new System.Drawing.Point(540, 275);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(369, 51);
            this.ButtonPanel.TabIndex = 21;
            this.ButtonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonPanel_Paint);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(104, 16);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(86, 23);
            this.ClearButton.TabIndex = 22;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(191, 16);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(86, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "S&earch";
            this.toolTip1.SetToolTip(this.SearchButton, "Press to bring up functionality to search records");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(278, 16);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(86, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.ExitButton, "Press to exit application");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(17, 16);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(86, 23);
            this.SummaryButton.TabIndex = 1;
            this.SummaryButton.Text = "&Summary";
            this.toolTip1.SetToolTip(this.SummaryButton, "Press to show summary of company sales ");
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 581);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.SummaryGroupBox);
            this.Controls.Add(this.PricingGroupBox);
            this.Controls.Add(this.MembershipDetailsGroupBox);
            this.Controls.Add(this.PasswordPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Welcome to Halo Fitness";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PricingPictureBox)).EndInit();
            this.QuotePanel.ResumeLayout(false);
            this.QuotePanel.PerformLayout();
            this.MembershipDetailsGroupBox.ResumeLayout(false);
            this.MembershipDetailsGroupBox.PerformLayout();
            this.PricingGroupBox.ResumeLayout(false);
            this.PricingGroupBox.PerformLayout();
            this.SummaryGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button PasswordSubmitButton;
        private System.Windows.Forms.PictureBox PricingPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.TextBox ClientConfirmedTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TermTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel QuotePanel;
        private System.Windows.Forms.GroupBox MembershipDetailsGroupBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TelephoneTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox PricingGroupBox;
        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PricePerMonthTextBox;
        private System.Windows.Forms.TextBox PriceFullTermTextBox;
        private System.Windows.Forms.TextBox MembershipIDTextBox;
        private System.Windows.Forms.TextBox JoiningDateTextBox;
        private System.Windows.Forms.TextBox PriceNextTermTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox SearchByDateTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.TextBox SearchByIDTextBox;
        private System.Windows.Forms.Label AverageMembershipTermLabel;
        private System.Windows.Forms.Label AverageSaleLabel;
        private System.Windows.Forms.Label NumberOfMembershipsLabel;
        private System.Windows.Forms.Label TotalSaleLabel;
        private System.Windows.Forms.TextBox NumberOfMembershipsTextBox;
        private System.Windows.Forms.TextBox TotalSaleTextBox;
        private System.Windows.Forms.TextBox AverageMembershipTermTextBox;
        private System.Windows.Forms.TextBox AverageSaleTextBox;
        private System.Windows.Forms.Label NoSaleLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label DateFormatLabel;
        private System.Windows.Forms.Button ClearButton;
    }
}

