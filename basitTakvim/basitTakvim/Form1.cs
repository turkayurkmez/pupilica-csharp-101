namespace basitTakvim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for (int gun = 1; gun <= 31; gun++)
            //{
            //    comboBoxGun.Items.Add(gun);
            //}

            //for (int ay  = 1; ay <= 12; ay++)
            //{
            //    comboBoxAy.Items.Add(ay);
            //}

            //for (int yil = DateTime.Now.Year; yil > DateTime.Now.Year -100; yil--)
            //{
            //    comboBoxYil.Items.Add(yil);
            //}

            int gunVeAy = 1;
            for (int yil = DateTime.Now.Year; yil > DateTime.Now.Year - 100; yil--)
            {

                if (gunVeAy<=31)
                {
                    comboBoxGun.Items.Add(gunVeAy);
                }

                if (gunVeAy<=12)
                {
                    comboBoxAy.Items.Add(gunVeAy);
                }

                gunVeAy++;
                comboBoxYil.Items.Add(yil);
            }
        }

    }
}
