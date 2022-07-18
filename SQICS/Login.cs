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
        private static Token token;
        private static UserInfo user;

       
        

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
            SetGlobalToken();
            //MessageBox.Show(token.access_token);

            user = await httpClientWebApi.GetUserInfo(token);
            //user = await httpClientWebApi.GetAuthInfo(token);
            SetGlobalUserInfo();
            

            //MessageBox.Show(user.preferred_username);
            //MessageBox.Show(user.supplier.ToString());
            SuccessLogin();
        }

        private void SetGlobalToken()
        {
            Global_Token.Access_token = token.access_token;
            Global_Token.Expires_in = token.expires_in;
            Global_Token.Id_token = token.id_token;
            Global_Token.Not_before_policy = token.not_before_policy;
            Global_Token.Refresh_expires_in = token.refresh_expires_in;
            Global_Token.Refresh_token = token.refresh_token;
            Global_Token.Scope = token.scope;
            Global_Token.Session_state = token.session_state;
            Global_Token.Token_type = token.token_type;
        }

        private void SetGlobalUserInfo()
        {
            Global_UserInfo.Email_verified = user.email_verified;
            Global_UserInfo.Family_name = user.family_name;
            //Global_UserInfo.Given_name = user.given_name;
            //Global_UserInfo.Name = user.name;
            Global_UserInfo.Preferred_username = user.preferred_username;
            Global_UserInfo.Sub = user.sub;
            Global_UserInfo.Supplier = user.supplier;

        }

        private void SuccessLogin()
        {
            this.Hide();
            Main.GetInstance.Show();

        }
}
}
