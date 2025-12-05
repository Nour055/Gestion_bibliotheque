using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibliothèque
{
    public partial class WelcomeAdmincs : UserControl
    {
        private Notification notificationControl;
        public WelcomeAdmincs()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pointerTriangle1.Visible = true;

            panel1.Controls.Clear();

            if (notificationControl == null)
                notificationControl = new Notification();

            notificationControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(notificationControl);

            // IMPORTANT: Manually call the load logic
            notificationControl.LoadRequests();
            notificationControl.LoadOverdues();
        }
    }
}
