namespace CS322_DZ02_Marija_Milovanovic_4400
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_unesi_Click(object sender, EventArgs e)
        {
            if (tb_ime.Text.Equals("") || tb_prezime.Text.Equals("") || tb_adresa.Text.Equals(""))
            {
                lbl_poruka.BackColor = Color.Red;
                lbl_poruka.Text = "Sva polja moraju biti popunjena!!!!";
                lbl_poruka.Visible = true;

            }
            else if (tb_ime.Text.Contains(' '))
            {
                lbl_poruka.BackColor = Color.Red;
                lbl_poruka.Text = "Ime se mora sastojati od jedne reci!!!";
                lbl_poruka.Visible = true;

            }
            else if (!tb_adresa.Text.Contains(' '))
            {
                lbl_poruka.BackColor = Color.Red;
                lbl_poruka.Visible = true;
                lbl_poruka.Text = "Adresa se mora sastojati od vise reci!";
            }
            else
            {
                lbl_poruka.BackColor = Color.Green;
                lbl_poruka.Text = "Uspesno ste uneli podatke!";
                MessageBox.Show(tb_ime.Text + ", " + tb_prezime.Text + ", " + tb_adresa.Text);
                lbl_poruka.Visible = false;
            }
        }
    }
}