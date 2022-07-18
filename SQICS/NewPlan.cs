using Microsoft.Extensions.DependencyInjection;
using System;
using SQICS.Classess;
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
    public partial class NewPlan : Form
    {
        private HttpClientWebApi httpClientWebApi;
        private static List<NPlanInfo> nPLanInfo;
        public NewPlan()
        {
            InitializeComponent();

            IServiceCollection services = new ServiceCollection();

            services.AddHttpClient();

            services.AddSingleton<HttpClientWebApi>();
            var provider = services.BuildServiceProvider();
            httpClientWebApi = provider.GetRequiredService<HttpClientWebApi>();
        }

        private async void NewPlan_Load(object sender, EventArgs e)
        {

            cbxSubAssyName.Items.Insert(0, "Sub Assy Name");

            nPLanInfo = await httpClientWebApi.GetSubAssyName();

            cbxSubAssyName.DataSource = nPLanInfo;
            cbxSubAssyName.DisplayMember = "AssyCode";
            cbxSubAssyName.ValueMember = "id";
            cbxSubAssyName.SelectedIndex = 0;
        }


    }
}
