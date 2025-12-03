namespace IFDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBaslat_Click(object sender, EventArgs e)
        {
            timerSlot.Start();
        }

        private void timerSlot_Tick(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi1 = rastgele.Next(0, 10);
            int sayi2 = rastgele.Next(0, 10);
            int sayi3 = rastgele.Next(0, 10);

            labelSlot1.Text = sayi1.ToString();
            labelSlot2.Text = sayi2.ToString();
            labelSlot3.Text = sayi3.ToString();

        }

        private void buttonDurdur_Click(object sender, EventArgs e)
        {
            timerSlot.Stop();

            if (labelSlot1.Text == labelSlot2.Text && labelSlot1.Text == labelSlot3.Text)
            {
                MessageBox.Show("kazandýnýz!");
                    
            }
            else if (labelSlot1.Text == labelSlot2.Text || labelSlot1.Text == labelSlot3.Text || labelSlot2.Text == labelSlot3.Text)
            {
                MessageBox.Show("Bir hak daha verildi");
            }
            else
            {
                MessageBox.Show("kaybettiniz");
            }
        }
    }
}
