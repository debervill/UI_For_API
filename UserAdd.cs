namespace UI_For_API
{
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string userName = InputName.Text;
            string userEmail = InputEmail.Text;
            string userDolgnost = InputDolgnost.Text;


            HttpClient client = new HttpClient();
            string apiUrl = "http://localhost:5046/api/Users";

            var newUser = new User { }


        }

        private void UserAdd_Load(object sender, EventArgs e)
        {

        }

    
    }
}
