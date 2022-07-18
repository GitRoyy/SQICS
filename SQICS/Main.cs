using SQICS.Classess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQICS
{
    public partial class Main : Form
    {
        private static Main instance;
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public Main()
        {
            InitializeComponent();
        }

        public static Main GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Main();
                }

                return instance;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "Welcome, " + Global_UserInfo.Preferred_username;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Main.GetInstance.Close();
            Login.GetInstance.Show();
        }

        private void labelName_SizeChanged(object sender, EventArgs e)
        {
            lblUsername.Left = (GetInstance.Width - (lblUsername.Width + 25));
        }

        private void btnNewPlan_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewPlan Nplan = new NewPlan();
            //Nplan.TopLevel = false;
            //this.Controls.Add(Nplan);
            Nplan.Show();
        
        }
    }
}
