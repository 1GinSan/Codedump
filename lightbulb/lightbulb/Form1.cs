namespace lightbulb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TurnLightOn()
        {
            LightON.Visible = true;

            LightOff.Visible = false;

            label1.Text = "ON";
        }

        private void TurnLightOff()
        {
            LightON.Visible = false;

            LightOff.Visible = true;

            label1.Text = "OFF";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            TurnLightOn();
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            TurnLightOff();
        }
    }
}