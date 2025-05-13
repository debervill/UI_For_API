using System.Text.Json;
using UI_For_API.Model;

namespace UI_For_API
{
    public partial class Form1 : Form
    {

        private readonly HttpClient _httpClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
            "НИЧООООООСИ"
            );
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserAdd form2 = new UserAdd();
            form2.Show(); // Показывает новое окно
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }


}

