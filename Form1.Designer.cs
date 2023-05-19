namespace faktöriyelHesaplamaApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_bilgi = new Label();
            txt_box_sayi = new TextBox();
            btn_fakt = new Button();
            btn_asal = new Button();
            btn_sayilar = new Button();
            lbl_faktor = new Label();
            lbl_asal = new Label();
            lbl_sayilar = new Label();
            btn_cikis = new Button();
            SuspendLayout();
            // 
            // lbl_bilgi
            // 
            lbl_bilgi.AutoSize = true;
            lbl_bilgi.Location = new Point(116, 47);
            lbl_bilgi.Name = "lbl_bilgi";
            lbl_bilgi.Size = new Size(328, 28);
            lbl_bilgi.TabIndex = 0;
            lbl_bilgi.Text = "Hesaplamak İsteğiniz Sayıyı Giriniz\r\n";
            // 
            // txt_box_sayi
            // 
            txt_box_sayi.Location = new Point(116, 107);
            txt_box_sayi.Name = "txt_box_sayi";
            txt_box_sayi.Size = new Size(328, 34);
            txt_box_sayi.TabIndex = 1;
            // 
            // btn_fakt
            // 
            btn_fakt.Location = new Point(56, 262);
            btn_fakt.Name = "btn_fakt";
            btn_fakt.Size = new Size(177, 57);
            btn_fakt.TabIndex = 2;
            btn_fakt.Text = "Faktoriyel";
            btn_fakt.UseVisualStyleBackColor = true;
            btn_fakt.Click += btn_fakt_Click;
            // 
            // btn_asal
            // 
            btn_asal.Location = new Point(56, 383);
            btn_asal.Name = "btn_asal";
            btn_asal.Size = new Size(177, 57);
            btn_asal.TabIndex = 2;
            btn_asal.Text = "Asal mı ?";
            btn_asal.UseVisualStyleBackColor = true;
            btn_asal.Click += btn_asal_Click;
            // 
            // btn_sayilar
            // 
            btn_sayilar.Location = new Point(56, 503);
            btn_sayilar.Name = "btn_sayilar";
            btn_sayilar.Size = new Size(177, 69);
            btn_sayilar.TabIndex = 2;
            btn_sayilar.Text = "Kendisine kadar\r\nolan sayılar";
            btn_sayilar.UseVisualStyleBackColor = true;
            btn_sayilar.Click += btn_sayilar_Click;
            // 
            // lbl_faktor
            // 
            lbl_faktor.AutoSize = true;
            lbl_faktor.BackColor = Color.Transparent;
            lbl_faktor.ForeColor = Color.Black;
            lbl_faktor.Location = new Point(298, 276);
            lbl_faktor.Name = "lbl_faktor";
            lbl_faktor.Size = new Size(0, 28);
            lbl_faktor.TabIndex = 3;
            // 
            // lbl_asal
            // 
            lbl_asal.AutoSize = true;
            lbl_asal.Location = new Point(298, 397);
            lbl_asal.Name = "lbl_asal";
            lbl_asal.Size = new Size(0, 28);
            lbl_asal.TabIndex = 3;
            // 
            // lbl_sayilar
            // 
            lbl_sayilar.AutoSize = true;
            lbl_sayilar.Location = new Point(298, 514);
            lbl_sayilar.Name = "lbl_sayilar";
            lbl_sayilar.Size = new Size(0, 28);
            lbl_sayilar.TabIndex = 3;
            // 
            // btn_cikis
            // 
            btn_cikis.BackColor = Color.Brown;
            btn_cikis.FlatStyle = FlatStyle.Popup;
            btn_cikis.ForeColor = SystemColors.ButtonFace;
            btn_cikis.Location = new Point(56, 642);
            btn_cikis.Name = "btn_cikis";
            btn_cikis.Size = new Size(177, 40);
            btn_cikis.TabIndex = 4;
            btn_cikis.Text = "Çıkış Yap";
            btn_cikis.UseVisualStyleBackColor = false;
            btn_cikis.Click += btn_cikis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(561, 705);
            Controls.Add(btn_cikis);
            Controls.Add(lbl_sayilar);
            Controls.Add(lbl_asal);
            Controls.Add(lbl_faktor);
            Controls.Add(btn_sayilar);
            Controls.Add(btn_asal);
            Controls.Add(btn_fakt);
            Controls.Add(txt_box_sayi);
            Controls.Add(lbl_bilgi);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Hesaplama Aracı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_bilgi;
        private TextBox txt_box_sayi;
        private Button btn_fakt;
        private Button btn_asal;
        private Button btn_sayilar;
        private Label lbl_faktor;
        private Label lbl_asal;
        private Label lbl_sayilar;
        private Button btn_cikis;
    }
}