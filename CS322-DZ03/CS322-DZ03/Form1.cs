using System.Windows.Forms;

namespace CS322_DZ03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_unesi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + tb_ime.Text);
        }

        private void btn_ucitaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            DialogResult rez = of.ShowDialog();
            if (rez == DialogResult.OK)
            {
                Bitmap image = (Bitmap)Bitmap.FromFile(of.FileName);
                pictureBox1.Image = image;

            }
        }

        private void btn_izbroj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uneli ste: " + tb_izbroj.Text.Length.ToString() + " kataktera.");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}