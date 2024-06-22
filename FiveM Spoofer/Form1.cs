using KeyAuth;
// chres0
namespace FiveM_Spoofer
{
    public partial class Form1 : Form
    {
        public static api KeyAuthApp = new api(
            name: "FiveM1",
            ownerid: "PwBTV43ofz",
            secret: "226b407f71d9c16679b3c42401bcb21a2f651375df726c7f247b6b325fd21272",
            version: "1.0"
        );


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            //KeyAuthApp.init();
            //KeyAuthApp.license(KeyBox.Text);
            //if (KeyAuthApp.response.success)
            //{
                Spoofer main = new Spoofer();
                main.Show();
                this.Hide();
            //}
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
