namespace CS322_DZ02_Marija_Milovanovic_4400
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
            tb_ime = new TextBox();
            tb_prezime = new TextBox();
            tb_adresa = new TextBox();
            lbl_ime = new Label();
            lbl_prezime = new Label();
            lbl_adresa = new Label();
            btn_unesi = new Button();
            lbl_poruka = new Label();
            SuspendLayout();
            // 
            // tb_ime
            // 
            tb_ime.Location = new Point(353, 99);
            tb_ime.Name = "tb_ime";
            tb_ime.Size = new Size(100, 23);
            tb_ime.TabIndex = 0;
            // 
            // tb_prezime
            // 
            tb_prezime.Location = new Point(353, 146);
            tb_prezime.Name = "tb_prezime";
            tb_prezime.Size = new Size(100, 23);
            tb_prezime.TabIndex = 1;
            // 
            // tb_adresa
            // 
            tb_adresa.Location = new Point(353, 193);
            tb_adresa.Name = "tb_adresa";
            tb_adresa.Size = new Size(100, 23);
            tb_adresa.TabIndex = 2;
            // 
            // lbl_ime
            // 
            lbl_ime.AutoSize = true;
            lbl_ime.Location = new Point(253, 99);
            lbl_ime.Name = "lbl_ime";
            lbl_ime.Size = new Size(27, 15);
            lbl_ime.TabIndex = 3;
            lbl_ime.Text = "Ime";
            // 
            // lbl_prezime
            // 
            lbl_prezime.AutoSize = true;
            lbl_prezime.Location = new Point(231, 151);
            lbl_prezime.Name = "lbl_prezime";
            lbl_prezime.Size = new Size(49, 15);
            lbl_prezime.TabIndex = 4;
            lbl_prezime.Text = "Prezime";
            // 
            // lbl_adresa
            // 
            lbl_adresa.AutoSize = true;
            lbl_adresa.Location = new Point(237, 203);
            lbl_adresa.Name = "lbl_adresa";
            lbl_adresa.Size = new Size(43, 15);
            lbl_adresa.TabIndex = 5;
            lbl_adresa.Text = "Adresa";
            // 
            // btn_unesi
            // 
            btn_unesi.Location = new Point(378, 259);
            btn_unesi.Name = "btn_unesi";
            btn_unesi.Size = new Size(75, 23);
            btn_unesi.TabIndex = 6;
            btn_unesi.Text = "Unesi";
            btn_unesi.UseVisualStyleBackColor = true;
            btn_unesi.Click += btn_unesi_Click;
            // 
            // lbl_poruka
            // 
            lbl_poruka.AutoSize = true;
            lbl_poruka.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_poruka.Location = new Point(353, 50);
            lbl_poruka.Name = "lbl_poruka";
            lbl_poruka.Size = new Size(0, 21);
            lbl_poruka.TabIndex = 7;
            lbl_poruka.TextAlign = ContentAlignment.MiddleCenter;
            lbl_poruka.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_poruka);
            Controls.Add(btn_unesi);
            Controls.Add(lbl_adresa);
            Controls.Add(lbl_prezime);
            Controls.Add(lbl_ime);
            Controls.Add(tb_adresa);
            Controls.Add(tb_prezime);
            Controls.Add(tb_ime);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_ime;
        private TextBox tb_prezime;
        private TextBox tb_adresa;
        private Label lbl_ime;
        private Label lbl_prezime;
        private Label lbl_adresa;
        private Button btn_unesi;
        private Label lbl_poruka;
    }
}