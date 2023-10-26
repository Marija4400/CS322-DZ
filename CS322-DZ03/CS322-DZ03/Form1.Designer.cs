namespace CS322_DZ03
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
            label1 = new Label();
            tb_ime = new TextBox();
            btn_unesi = new Button();
            openFileDialog1 = new OpenFileDialog();
            btn_ucitaj = new Button();
            pictureBox1 = new PictureBox();
            btn_izbroj = new Button();
            lbl_brojim = new Label();
            tb_izbroj = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            gitToolStripMenuItem = new ToolStripMenuItem();
            cloneRepositoryToolStripMenuItem = new ToolStripMenuItem();
            localRepositortyToolStripMenuItem = new ToolStripMenuItem();
            openLocanRepositoryToolStripMenuItem = new ToolStripMenuItem();
            Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 103);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Unesite ime: ";
            // 
            // tb_ime
            // 
            tb_ime.Location = new Point(62, 140);
            tb_ime.Name = "tb_ime";
            tb_ime.Size = new Size(100, 23);
            tb_ime.TabIndex = 1;
            // 
            // btn_unesi
            // 
            btn_unesi.Location = new Point(62, 186);
            btn_unesi.Name = "btn_unesi";
            btn_unesi.Size = new Size(75, 23);
            btn_unesi.TabIndex = 2;
            btn_unesi.Text = "OK";
            btn_unesi.UseVisualStyleBackColor = true;
            btn_unesi.Click += btn_unesi_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_ucitaj
            // 
            btn_ucitaj.Location = new Point(272, 257);
            btn_ucitaj.Name = "btn_ucitaj";
            btn_ucitaj.Size = new Size(75, 23);
            btn_ucitaj.TabIndex = 3;
            btn_ucitaj.Text = "Ucitaj";
            btn_ucitaj.UseVisualStyleBackColor = true;
            btn_ucitaj.Click += btn_ucitaj_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(239, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 125);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_izbroj
            // 
            btn_izbroj.Location = new Point(524, 186);
            btn_izbroj.Name = "btn_izbroj";
            btn_izbroj.Size = new Size(134, 23);
            btn_izbroj.TabIndex = 5;
            btn_izbroj.Text = "Brojim karaktere";
            btn_izbroj.UseVisualStyleBackColor = true;
            btn_izbroj.Click += btn_izbroj_Click;
            // 
            // lbl_brojim
            // 
            lbl_brojim.AutoSize = true;
            lbl_brojim.Location = new Point(449, 113);
            lbl_brojim.Name = "lbl_brojim";
            lbl_brojim.Size = new Size(300, 15);
            lbl_brojim.TabIndex = 6;
            lbl_brojim.Text = "Klikom na dugme dobicete broj karaktera unetog teksta";
            // 
            // tb_izbroj
            // 
            tb_izbroj.Location = new Point(477, 140);
            tb_izbroj.Name = "tb_izbroj";
            tb_izbroj.Size = new Size(220, 23);
            tb_izbroj.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, gitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(103, 22);
            closeToolStripMenuItem.Text = "Close";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(103, 22);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(103, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(103, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // gitToolStripMenuItem
            // 
            gitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cloneRepositoryToolStripMenuItem, localRepositortyToolStripMenuItem });
            gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            gitToolStripMenuItem.Size = new Size(34, 20);
            gitToolStripMenuItem.Text = "Git";
            // 
            // cloneRepositoryToolStripMenuItem
            // 
            cloneRepositoryToolStripMenuItem.Name = "cloneRepositoryToolStripMenuItem";
            cloneRepositoryToolStripMenuItem.Size = new Size(162, 22);
            cloneRepositoryToolStripMenuItem.Text = "Clone repository";
            // 
            // localRepositortyToolStripMenuItem
            // 
            localRepositortyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openLocanRepositoryToolStripMenuItem });
            localRepositortyToolStripMenuItem.Name = "localRepositortyToolStripMenuItem";
            localRepositortyToolStripMenuItem.Size = new Size(162, 22);
            localRepositortyToolStripMenuItem.Text = "Local repositorty";
            // 
            // openLocanRepositoryToolStripMenuItem
            // 
            openLocanRepositoryToolStripMenuItem.Name = "openLocanRepositoryToolStripMenuItem";
            openLocanRepositoryToolStripMenuItem.Size = new Size(191, 22);
            openLocanRepositoryToolStripMenuItem.Text = "Open locan repository";
            // 
            // Exit
            // 
            Exit.Location = new Point(674, 375);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 9;
            Exit.Text = "EXIT";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(tb_izbroj);
            Controls.Add(lbl_brojim);
            Controls.Add(btn_izbroj);
            Controls.Add(pictureBox1);
            Controls.Add(btn_ucitaj);
            Controls.Add(btn_unesi);
            Controls.Add(tb_ime);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_ime;
        private Button btn_unesi;
        private OpenFileDialog openFileDialog1;
        private Button btn_ucitaj;
        private PictureBox pictureBox1;
        private Button btn_izbroj;
        private Label lbl_brojim;
        private TextBox tb_izbroj;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem gitToolStripMenuItem;
        private ToolStripMenuItem cloneRepositoryToolStripMenuItem;
        private ToolStripMenuItem localRepositortyToolStripMenuItem;
        private ToolStripMenuItem openLocanRepositoryToolStripMenuItem;
        private Button Exit;
    }
}