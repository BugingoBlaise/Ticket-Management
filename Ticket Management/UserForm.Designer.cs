namespace Ticket_Management
{
    partial class UserForm
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
            this.exitLabel = new System.Windows.Forms.LinkLabel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customenameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nationalityComboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.regularTicket = new System.Windows.Forms.RadioButton();
            this.vipTicket = new System.Windows.Forms.RadioButton();
            this.vvipTicket = new System.Windows.Forms.RadioButton();
            this.numberOfTicket = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.displayPriceLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.promoCode = new System.Windows.Forms.TextBox();
            this.requestTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bookButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.ticketTypeLabel = new System.Windows.Forms.Label();
            this.printEvent = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitLabel
            // 
            this.exitLabel.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.exitLabel.AutoSize = true;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exitLabel.Location = new System.Drawing.Point(544, 34);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(39, 20);
            this.exitLabel.TabIndex = 52;
            this.exitLabel.TabStop = true;
            this.exitLabel.Text = "Exit";
            this.exitLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLabel_LinkClicked);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(226, 131);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(286, 28);
            this.emailTextBox.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 457);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Promotion Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 393);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Payment method:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ticket type:";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberBox.Location = new System.Drawing.Point(226, 163);
            this.phoneNumberBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneNumberBox.Multiline = true;
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(286, 28);
            this.phoneNumberBox.TabIndex = 37;
            this.phoneNumberBox.TextChanged += new System.EventHandler(this.phoneNumberBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Phone number:";
            // 
            // customenameBox
            // 
            this.customenameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customenameBox.Location = new System.Drawing.Point(226, 95);
            this.customenameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customenameBox.Multiline = true;
            this.customenameBox.Name = "customenameBox";
            this.customenameBox.Size = new System.Drawing.Size(286, 28);
            this.customenameBox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Full Names:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "CHECK IN";
            // 
            // nationalityComboBox2
            // 
            this.nationalityComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalityComboBox2.FormattingEnabled = true;
            this.nationalityComboBox2.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Austria",
            "Azerbaijan",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Channel Islands",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Costa Rica",
            "Côte d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "DR Congo",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Faeroe Islands",
            "Finland",
            "France",
            "French Guiana",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Isle of Man",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macao",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Mauritania",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nepal",
            "Netherlands",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "North Macedonia",
            "Norway",
            "Oman",
            "Pakistan",
            "Panama",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Réunion",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Helena",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "San Marino",
            "Sao Tome & Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "State of Palestine",
            "Sudan",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "The Bahamas",
            "Timor-Leste",
            "Togo",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Venezuela",
            "Vietnam",
            "Western Sahara",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.nationalityComboBox2.Location = new System.Drawing.Point(226, 204);
            this.nationalityComboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nationalityComboBox2.Name = "nationalityComboBox2";
            this.nationalityComboBox2.Size = new System.Drawing.Size(288, 24);
            this.nationalityComboBox2.TabIndex = 55;
            this.nationalityComboBox2.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Nationality:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 290);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Unit price:";
            // 
            // regularTicket
            // 
            this.regularTicket.AutoSize = true;
            this.regularTicket.Location = new System.Drawing.Point(13, 15);
            this.regularTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.regularTicket.Name = "regularTicket";
            this.regularTicket.Size = new System.Drawing.Size(62, 17);
            this.regularTicket.TabIndex = 58;
            this.regularTicket.TabStop = true;
            this.regularTicket.Text = "Regular";
            this.regularTicket.UseVisualStyleBackColor = true;
            this.regularTicket.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // vipTicket
            // 
            this.vipTicket.AutoSize = true;
            this.vipTicket.Location = new System.Drawing.Point(122, 15);
            this.vipTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vipTicket.Name = "vipTicket";
            this.vipTicket.Size = new System.Drawing.Size(42, 17);
            this.vipTicket.TabIndex = 59;
            this.vipTicket.TabStop = true;
            this.vipTicket.Text = "VIP";
            this.vipTicket.UseVisualStyleBackColor = true;
            this.vipTicket.CheckedChanged += new System.EventHandler(this.vipTicket_CheckedChanged);
            // 
            // vvipTicket
            // 
            this.vvipTicket.AutoSize = true;
            this.vvipTicket.Location = new System.Drawing.Point(218, 15);
            this.vvipTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vvipTicket.Name = "vvipTicket";
            this.vvipTicket.Size = new System.Drawing.Size(52, 17);
            this.vvipTicket.TabIndex = 60;
            this.vvipTicket.TabStop = true;
            this.vvipTicket.Text = " VVIP";
            this.vvipTicket.UseVisualStyleBackColor = true;
            this.vvipTicket.CheckedChanged += new System.EventHandler(this.vvipTicket_CheckedChanged);
            // 
            // numberOfTicket
            // 
            this.numberOfTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfTicket.Location = new System.Drawing.Point(226, 320);
            this.numberOfTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberOfTicket.Multiline = true;
            this.numberOfTicket.Name = "numberOfTicket";
            this.numberOfTicket.Size = new System.Drawing.Size(286, 28);
            this.numberOfTicket.TabIndex = 62;
            this.numberOfTicket.TextChanged += new System.EventHandler(this.numberOfTicket_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 327);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 61;
            this.label10.Text = "Number of Ticket:";
            // 
            // displayPriceLabel
            // 
            this.displayPriceLabel.AutoSize = true;
            this.displayPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPriceLabel.Location = new System.Drawing.Point(228, 290);
            this.displayPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.displayPriceLabel.Name = "displayPriceLabel";
            this.displayPriceLabel.Size = new System.Drawing.Size(0, 20);
            this.displayPriceLabel.TabIndex = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.regularTicket);
            this.groupBox1.Controls.Add(this.vipTicket);
            this.groupBox1.Controls.Add(this.vvipTicket);
            this.groupBox1.Location = new System.Drawing.Point(226, 232);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(286, 36);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Items.AddRange(new object[] {
            "PayPal",
            "MasterCard",
            "MTN momo"});
            this.paymentComboBox.Location = new System.Drawing.Point(226, 392);
            this.paymentComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(288, 24);
            this.paymentComboBox.TabIndex = 65;
            // 
            // promoCode
            // 
            this.promoCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promoCode.Location = new System.Drawing.Point(226, 457);
            this.promoCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.promoCode.Name = "promoCode";
            this.promoCode.Size = new System.Drawing.Size(88, 22);
            this.promoCode.TabIndex = 66;
            this.promoCode.TextChanged += new System.EventHandler(this.promoCode_TextChanged);
            // 
            // requestTextBox
            // 
            this.requestTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestTextBox.Location = new System.Drawing.Point(226, 419);
            this.requestTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.requestTextBox.Multiline = true;
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.Size = new System.Drawing.Size(297, 29);
            this.requestTextBox.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(56, 429);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 20);
            this.label11.TabIndex = 67;
            this.label11.Text = "Special request:";
            // 
            // bookButton
            // 
            this.bookButton.BackColor = System.Drawing.SystemColors.Menu;
            this.bookButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookButton.Location = new System.Drawing.Point(538, 204);
            this.bookButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(164, 60);
            this.bookButton.TabIndex = 69;
            this.bookButton.Text = "Book Now";
            this.bookButton.UseVisualStyleBackColor = false;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(56, 362);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 20);
            this.label12.TabIndex = 70;
            this.label12.Text = "Amount to be paid:";
            // 
            // totalAmount
            // 
            this.totalAmount.AutoSize = true;
            this.totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.Location = new System.Drawing.Point(223, 362);
            this.totalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(14, 20);
            this.totalAmount.TabIndex = 71;
            this.totalAmount.Text = " ";
            // 
            // ticketTypeLabel
            // 
            this.ticketTypeLabel.AutoSize = true;
            this.ticketTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketTypeLabel.Location = new System.Drawing.Point(409, 290);
            this.ticketTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ticketTypeLabel.Name = "ticketTypeLabel";
            this.ticketTypeLabel.Size = new System.Drawing.Size(0, 20);
            this.ticketTypeLabel.TabIndex = 72;
            // 
            // printEvent
            // 
            this.printEvent.AutoSize = true;
            this.printEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printEvent.Location = new System.Drawing.Point(223, 64);
            this.printEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.printEvent.Name = "printEvent";
            this.printEvent.Size = new System.Drawing.Size(0, 20);
            this.printEvent.TabIndex = 73;
            this.printEvent.Click += new System.EventHandler(this.printEvent_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(53, 64);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 20);
            this.label13.TabIndex = 74;
            this.label13.Text = "Event Name:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Tan;
            this.linkLabel1.Location = new System.Drawing.Point(57, 22);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 20);
            this.linkLabel1.TabIndex = 75;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 502);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.printEvent);
            this.Controls.Add(this.ticketTypeLabel);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.requestTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.promoCode);
            this.Controls.Add(this.paymentComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.displayPriceLabel);
            this.Controls.Add(this.numberOfTicket);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nationalityComboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneNumberBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customenameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel exitLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customenameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nationalityComboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton regularTicket;
        private System.Windows.Forms.RadioButton vipTicket;
        private System.Windows.Forms.RadioButton vvipTicket;
        private System.Windows.Forms.TextBox numberOfTicket;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label displayPriceLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox paymentComboBox;
        private System.Windows.Forms.TextBox promoCode;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.Label ticketTypeLabel;
        private System.Windows.Forms.Label printEvent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}