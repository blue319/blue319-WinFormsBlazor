using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using WinFormsBlazor.Data;

namespace WinFormsBlazor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var services = new ServiceCollection();
            // ���� BootstrapBlazor ����
            services.AddBootstrapBlazor();
            services.AddWindowsFormsBlazorWebView();
            // ���� Table ���ݷ��������
            services.AddTableDemoDataService();

            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<Main>("#app");

        }
    }
}
