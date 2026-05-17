namespace XmlButon
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
            txtAd = new TextBox();
            txtYas = new TextBox();
            btnKaydet = new Button();
            btnYukle = new Button();
            lbl_Ad = new Label();
            lbl_Yas = new Label();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(142, 256);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 0;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(396, 256);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(125, 27);
            txtYas.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(142, 340);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnYukle
            // 
            btnYukle.Location = new Point(396, 340);
            btnYukle.Name = "btnYukle";
            btnYukle.Size = new Size(94, 29);
            btnYukle.TabIndex = 3;
            btnYukle.Text = "yükle";
            btnYukle.UseVisualStyleBackColor = true;
            btnYukle.Click += btnYukle_Click;
            // 
            // lbl_Ad
            // 
            lbl_Ad.AutoSize = true;
            lbl_Ad.Location = new Point(161, 222);
            lbl_Ad.Name = "lbl_Ad";
            lbl_Ad.Size = new Size(31, 20);
            lbl_Ad.TabIndex = 4;
            lbl_Ad.Text = "Ad:";
            // 
            // lbl_Yas
            // 
            lbl_Yas.AutoSize = true;
            lbl_Yas.Location = new Point(396, 222);
            lbl_Yas.Name = "lbl_Yas";
            lbl_Yas.Size = new Size(33, 20);
            lbl_Yas.TabIndex = 5;
            lbl_Yas.Text = "Yaş:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Yas);
            Controls.Add(lbl_Ad);
            Controls.Add(btnYukle);
            Controls.Add(btnKaydet);
            Controls.Add(txtYas);
            Controls.Add(txtAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtYas;
        private Button btnKaydet;
        private Button btnYukle;
        private Label lbl_Ad;
        private Label lbl_Yas;
    }
}
