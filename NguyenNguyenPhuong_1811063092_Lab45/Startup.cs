using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenNguyenPhuong_1811063092_Lab45.Startup))]
namespace NguyenNguyenPhuong_1811063092_Lab45
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
