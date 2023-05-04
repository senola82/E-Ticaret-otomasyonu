namespace E_Ticaret_Otomasyonu
{
    public partial class frmAnaform : Form
    {
        public frmAnaform()
        {
            InitializeComponent();
        }

        private void btnGunluk_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Günlük")
            {
                pnlCubuk.Location = new Point(260, 285);

            }
            else if (((Button)sender).Text == "Haftalýk")
            {
                pnlCubuk.Location = new Point(368, 285);
            }
            else if (((Button)sender).Text == "Aylýk")
            {
                pnlCubuk.Location = new Point(480, 285);
            }
            else
            {

            }
           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = (DateTime.Today.Hour.ToString());
        }
    }
}