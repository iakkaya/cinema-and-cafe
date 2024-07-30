namespace fiyatlandirma_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            int misir, cay, su, bilet, toplam;
            misir = Convert.ToUInt16(textMisir.Text);
            cay = Convert.ToUInt16(text«ay.Text);
            su = Convert.ToUInt16(textSu.Text);
            bilet = Convert.ToUInt16(textBilet.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;

            labelToplam.Text = toplam.ToString() + "TL";
            kasatutar = kasatutar + toplam;
            labelKasa.Text = kasatutar.ToString() + "TL ";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBilet.Text = " ";
            textMisir.Text = " ";
            text«ay.Text = " ";
            textSu.Text = " ";
            textMisir.Focus();

        }
    }
}
