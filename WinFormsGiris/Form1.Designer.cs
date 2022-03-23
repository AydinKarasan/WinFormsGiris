namespace WinFormsGiris
{
    partial class Arabalar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Araba = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudKapiSayisi = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBeygirGucu = new System.Windows.Forms.TextBox();
            this.ddlArabaTuru = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSifirYuz = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpUretimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbIkinciEl = new System.Windows.Forms.CheckBox();
            this.bOlustur = new System.Windows.Forms.Button();
            this.bGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKapiSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // Araba
            // 
            this.Araba.BackColor = System.Drawing.Color.Silver;
            this.Araba.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Araba.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Araba.Location = new System.Drawing.Point(12, 9);
            this.Araba.Name = "Araba";
            this.Araba.Size = new System.Drawing.Size(1076, 154);
            this.Araba.TabIndex = 0;
            this.Araba.Text = "Araba";
            this.Araba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(129, 186);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(420, 27);
            this.tbMarka.TabIndex = 2;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(129, 239);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(420, 27);
            this.tbModel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kapı Sayısı";
            // 
            // nudKapiSayisi
            // 
            this.nudKapiSayisi.Location = new System.Drawing.Point(129, 289);
            this.nudKapiSayisi.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudKapiSayisi.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudKapiSayisi.Name = "nudKapiSayisi";
            this.nudKapiSayisi.Size = new System.Drawing.Size(190, 27);
            this.nudKapiSayisi.TabIndex = 5;
            this.nudKapiSayisi.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Beygir Gücü";
            // 
            // tbBeygirGucu
            // 
            this.tbBeygirGucu.Location = new System.Drawing.Point(129, 344);
            this.tbBeygirGucu.Name = "tbBeygirGucu";
            this.tbBeygirGucu.Size = new System.Drawing.Size(190, 27);
            this.tbBeygirGucu.TabIndex = 6;
            // 
            // ddlArabaTuru
            // 
            this.ddlArabaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlArabaTuru.FormattingEnabled = true;
            this.ddlArabaTuru.Items.AddRange(new object[] {
            "Sedan",
            "Spor",
            "Hatchback",
            "Satation Wagon"});
            this.ddlArabaTuru.Location = new System.Drawing.Point(129, 397);
            this.ddlArabaTuru.Name = "ddlArabaTuru";
            this.ddlArabaTuru.Size = new System.Drawing.Size(190, 28);
            this.ddlArabaTuru.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Türü";
            // 
            // tbSifirYuz
            // 
            this.tbSifirYuz.Location = new System.Drawing.Point(129, 451);
            this.tbSifirYuz.Name = "tbSifirYuz";
            this.tbSifirYuz.Size = new System.Drawing.Size(190, 27);
            this.tbSifirYuz.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "0-100 km";
            // 
            // dtpUretimTarihi
            // 
            this.dtpUretimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUretimTarihi.Location = new System.Drawing.Point(129, 505);
            this.dtpUretimTarihi.Name = "dtpUretimTarihi";
            this.dtpUretimTarihi.Size = new System.Drawing.Size(190, 27);
            this.dtpUretimTarihi.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Üretim Tarihi";
            // 
            // cbIkinciEl
            // 
            this.cbIkinciEl.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbIkinciEl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbIkinciEl.Location = new System.Drawing.Point(25, 555);
            this.cbIkinciEl.Name = "cbIkinciEl";
            this.cbIkinciEl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbIkinciEl.Size = new System.Drawing.Size(121, 30);
            this.cbIkinciEl.TabIndex = 10;
            this.cbIkinciEl.Text = "2. El";
            this.cbIkinciEl.UseVisualStyleBackColor = true;
            // 
            // bOlustur
            // 
            this.bOlustur.Location = new System.Drawing.Point(127, 621);
            this.bOlustur.Name = "bOlustur";
            this.bOlustur.Size = new System.Drawing.Size(94, 29);
            this.bOlustur.TabIndex = 11;
            this.bOlustur.Text = "Oluştur";
            this.bOlustur.UseVisualStyleBackColor = true;
            this.bOlustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // bGetir
            // 
            this.bGetir.Location = new System.Drawing.Point(227, 621);
            this.bGetir.Name = "bGetir";
            this.bGetir.Size = new System.Drawing.Size(94, 29);
            this.bGetir.TabIndex = 11;
            this.bGetir.Text = "Getir";
            this.bGetir.UseVisualStyleBackColor = true;
            this.bGetir.Click += new System.EventHandler(this.bGetir_Click);
            // 
            // Arabalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 744);
            this.Controls.Add(this.bGetir);
            this.Controls.Add(this.bOlustur);
            this.Controls.Add(this.cbIkinciEl);
            this.Controls.Add(this.dtpUretimTarihi);
            this.Controls.Add(this.tbSifirYuz);
            this.Controls.Add(this.ddlArabaTuru);
            this.Controls.Add(this.tbBeygirGucu);
            this.Controls.Add(this.nudKapiSayisi);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Araba);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Arabalar";
            this.Text = "Arabalar";
            
            ((System.ComponentModel.ISupportInitialize)(this.nudKapiSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Araba;
        private Label label1;
        private TextBox tbMarka;
        private TextBox tbModel;
        private Label label2;
        private Label label3;
        private NumericUpDown nudKapiSayisi;
        private Label label4;
        private TextBox tbBeygirGucu;
        private ComboBox ddlArabaTuru;
        private Label label5;
        private TextBox tbSifirYuz;
        private Label label6;
        private DateTimePicker dtpUretimTarihi;
        private Label label7;
        private CheckBox cbIkinciEl;
        private Button bOlustur;
        private Button bGetir;
    }
}