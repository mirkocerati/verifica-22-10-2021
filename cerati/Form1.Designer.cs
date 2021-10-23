
namespace cerati
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.children = new System.Windows.Forms.ComboBox();
            this.adults = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkout = new System.Windows.Forms.DateTimePicker();
            this.checkin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.roomtype = new System.Windows.Forms.GroupBox();
            this.rtdeluxe = new System.Windows.Forms.RadioButton();
            this.rtsuperior = new System.Windows.Forms.RadioButton();
            this.rtstandard = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.temptxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tempup = new System.Windows.Forms.Button();
            this.tempdown = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.sheet = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.opttowel = new System.Windows.Forms.CheckBox();
            this.opttv = new System.Windows.Forms.CheckBox();
            this.booknow = new System.Windows.Forms.Button();
            this.confirmation = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.roomtype.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "City";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(55, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 2;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(55, 45);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.children);
            this.groupBox1.Controls.Add(this.adults);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(17, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guests";
            // 
            // children
            // 
            this.children.FormattingEnabled = true;
            this.children.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.children.Location = new System.Drawing.Point(85, 50);
            this.children.Name = "children";
            this.children.Size = new System.Drawing.Size(47, 21);
            this.children.TabIndex = 3;
            // 
            // adults
            // 
            this.adults.FormattingEnabled = true;
            this.adults.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.adults.Location = new System.Drawing.Point(85, 23);
            this.adults.Name = "adults";
            this.adults.Size = new System.Drawing.Size(47, 21);
            this.adults.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Children";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adults";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkout);
            this.groupBox2.Controls.Add(this.checkin);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(225, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 99);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Journey Date";
            // 
            // checkout
            // 
            this.checkout.Location = new System.Drawing.Point(70, 60);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(200, 20);
            this.checkout.TabIndex = 3;
            // 
            // checkin
            // 
            this.checkin.Location = new System.Drawing.Point(70, 28);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(200, 20);
            this.checkin.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "check-out";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "check-in";
            // 
            // roomtype
            // 
            this.roomtype.Controls.Add(this.rtdeluxe);
            this.roomtype.Controls.Add(this.rtsuperior);
            this.roomtype.Controls.Add(this.rtstandard);
            this.roomtype.Location = new System.Drawing.Point(225, 136);
            this.roomtype.Name = "roomtype";
            this.roomtype.Size = new System.Drawing.Size(130, 100);
            this.roomtype.TabIndex = 6;
            this.roomtype.TabStop = false;
            this.roomtype.Text = "Room Type";
            // 
            // rtdeluxe
            // 
            this.rtdeluxe.AutoSize = true;
            this.rtdeluxe.Location = new System.Drawing.Point(6, 62);
            this.rtdeluxe.Name = "rtdeluxe";
            this.rtdeluxe.Size = new System.Drawing.Size(58, 17);
            this.rtdeluxe.TabIndex = 2;
            this.rtdeluxe.TabStop = true;
            this.rtdeluxe.Text = "Deluxe";
            this.rtdeluxe.UseVisualStyleBackColor = true;
            // 
            // rtsuperior
            // 
            this.rtsuperior.AutoSize = true;
            this.rtsuperior.Location = new System.Drawing.Point(6, 42);
            this.rtsuperior.Name = "rtsuperior";
            this.rtsuperior.Size = new System.Drawing.Size(64, 17);
            this.rtsuperior.TabIndex = 1;
            this.rtsuperior.TabStop = true;
            this.rtsuperior.Text = "Superior";
            this.rtsuperior.UseVisualStyleBackColor = true;
            // 
            // rtstandard
            // 
            this.rtstandard.AutoSize = true;
            this.rtstandard.Location = new System.Drawing.Point(6, 23);
            this.rtstandard.Name = "rtstandard";
            this.rtstandard.Size = new System.Drawing.Size(68, 17);
            this.rtstandard.TabIndex = 0;
            this.rtstandard.TabStop = true;
            this.rtstandard.Text = "Standard";
            this.rtstandard.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = ".\\images\\termometro.png";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(361, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 93);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // temptxt
            // 
            this.temptxt.Location = new System.Drawing.Point(455, 173);
            this.temptxt.Name = "temptxt";
            this.temptxt.ReadOnly = true;
            this.temptxt.Size = new System.Drawing.Size(37, 20);
            this.temptxt.TabIndex = 8;
            this.temptxt.Text = "21";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(498, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "°";
            // 
            // tempup
            // 
            this.tempup.Location = new System.Drawing.Point(455, 144);
            this.tempup.Name = "tempup";
            this.tempup.Size = new System.Drawing.Size(37, 23);
            this.tempup.TabIndex = 10;
            this.tempup.Text = "+";
            this.tempup.UseVisualStyleBackColor = true;
            this.tempup.Click += new System.EventHandler(this.tempup_Click);
            // 
            // tempdown
            // 
            this.tempdown.Location = new System.Drawing.Point(455, 200);
            this.tempdown.Name = "tempdown";
            this.tempdown.Size = new System.Drawing.Size(37, 23);
            this.tempdown.TabIndex = 11;
            this.tempdown.Text = "-";
            this.tempdown.UseVisualStyleBackColor = true;
            this.tempdown.Click += new System.EventHandler(this.tempdown_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sheet set";
            // 
            // sheet
            // 
            this.sheet.FormattingEnabled = true;
            this.sheet.Items.AddRange(new object[] {
            "White",
            "Yellow",
            "Purple",
            "Blue"});
            this.sheet.Location = new System.Drawing.Point(13, 214);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(142, 21);
            this.sheet.TabIndex = 13;
            this.sheet.SelectedIndexChanged += new System.EventHandler(this.sheet_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(13, 242);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 116);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Optionals";
            // 
            // opttowel
            // 
            this.opttowel.AutoSize = true;
            this.opttowel.Location = new System.Drawing.Point(225, 274);
            this.opttowel.Name = "opttowel";
            this.opttowel.Size = new System.Drawing.Size(105, 17);
            this.opttowel.TabIndex = 16;
            this.opttowel.Text = "Clean towel daily";
            this.opttowel.UseVisualStyleBackColor = true;
            // 
            // opttv
            // 
            this.opttv.AutoSize = true;
            this.opttv.Location = new System.Drawing.Point(225, 298);
            this.opttv.Name = "opttv";
            this.opttv.Size = new System.Drawing.Size(108, 17);
            this.opttv.TabIndex = 17;
            this.opttv.Text = "75\" 8K OLED TV";
            this.opttv.UseVisualStyleBackColor = true;
            // 
            // booknow
            // 
            this.booknow.Location = new System.Drawing.Point(13, 378);
            this.booknow.Name = "booknow";
            this.booknow.Size = new System.Drawing.Size(505, 35);
            this.booknow.TabIndex = 18;
            this.booknow.Text = "BOOK NOW";
            this.booknow.UseVisualStyleBackColor = true;
            this.booknow.Click += new System.EventHandler(this.booknow_Click);
            // 
            // confirmation
            // 
            this.confirmation.Location = new System.Drawing.Point(12, 419);
            this.confirmation.Multiline = true;
            this.confirmation.Name = "confirmation";
            this.confirmation.ReadOnly = true;
            this.confirmation.Size = new System.Drawing.Size(506, 222);
            this.confirmation.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 653);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.booknow);
            this.Controls.Add(this.opttv);
            this.Controls.Add(this.opttowel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sheet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tempdown);
            this.Controls.Add(this.tempup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.temptxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roomtype);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.city);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Reservation.com";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.roomtype.ResumeLayout(false);
            this.roomtype.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox children;
        private System.Windows.Forms.ComboBox adults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox roomtype;
        private System.Windows.Forms.DateTimePicker checkout;
        private System.Windows.Forms.DateTimePicker checkin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rtdeluxe;
        private System.Windows.Forms.RadioButton rtsuperior;
        private System.Windows.Forms.RadioButton rtstandard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox temptxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tempup;
        private System.Windows.Forms.Button tempdown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox sheet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox opttowel;
        private System.Windows.Forms.CheckBox opttv;
        private System.Windows.Forms.Button booknow;
        private System.Windows.Forms.TextBox confirmation;
    }
}

