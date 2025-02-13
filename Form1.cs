namespace ChatAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();

            string FullName = DB.GetValue($"SELECT FullName FROM Users WHERE UserID = {DB.UserId}");

            lbluserName.Text = FullName;
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Send send = new Send();
            send.Show();
        }

        private void messagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Messages message = new Messages();
            message.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
