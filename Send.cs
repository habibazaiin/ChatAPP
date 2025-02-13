using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ChatAPP
{
    public partial class Send : Form
    {
        public Send()
        {
            InitializeComponent();
        }

        private void Send_Load(object sender, EventArgs e)
        {
            DB.FillListBox("select UserID, FullName from Users order by FullName", lstUsers);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string sl = "INSERT INTO Messages (SenderID ,RecipientID ,Subject ,Body) VALUES ";

            foreach (var item in lstUsers.SelectedItems)
            {
                DataRowView row = item as DataRowView;
                var valueMember = row[lstUsers.ValueMember].ToString();
                sl += $"({DB.UserId}, {valueMember}, '{txtSubject.Text}', '{txtBody.Text}'),";
            }

            sl = sl.Remove(sl.Length - 1);

            DB.Execute(sl);

            DB.clean(this);
        }
    }
}
