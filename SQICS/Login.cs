using Microsoft.Extensions.DependencyInjection;
using SQICS.Classess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQICS
{
    public partial class Login : Form
    {
        private static Login instance;
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private HttpClientWebApi httpClientWebApi;
        public Token token;
        public UserInfo user;

        public Login()
        {
            InitializeComponent();

            IServiceCollection services = new ServiceCollection();

            services.AddHttpClient();

            services.AddSingleton<HttpClientWebApi>();
            var provider = services.BuildServiceProvider();
            httpClientWebApi = provider.GetRequiredService<HttpClientWebApi>();
        }

        public static Login GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Login();
                }
                    
                return instance;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Logger.Info("Exit Application");
            Application.Exit();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            token = await httpClientWebApi.GetToken(textBoxUsername.Text, textBoxPassword.Text);

            MessageBox.Show(token.access_token);

            user = await httpClientWebApi.GetUserInfo(token);

            MessageBox.Show(user.preferred_username);
            MessageBox.Show(user.supplier.ToString());
        }
    }
}
