using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAPP
{
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void Messages_Load(object sender, EventArgs e)
        {
            string sl = $"SELECT Users.FullName, Messages.Subject, Messages.Body, Messages.DateSent FROM Users INNER JOIN Messages ON Users.UserID = Messages.SenderID WHERE Messages.RecipientID = {DB.UserId};";
            DB.FillGrid(sl, Grid);
            Grid.Columns[0].HeaderText = "Sender";
            Grid.Columns[1].HeaderText = "Subject";
            Grid.Columns[2].HeaderText = "Message";
            Grid.Columns[3].HeaderText = "Date";
        }
    }
}
