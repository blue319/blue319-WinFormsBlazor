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
            // 增加 BootstrapBlazor 服务
            services.AddBootstrapBlazor();
            services.AddWindowsFormsBlazorWebView();
            // 增加 Table 数据服务操作类
            services.AddTableDemoDataService();

            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<Main>("#app");

        }
    }
}
