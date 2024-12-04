using System;
using System.Data.Entity;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;
using CuaHangXeMay.Forms;
using CuaHangXeMay.Models;

namespace CuaHangXeMay
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            IUnityContainer container = new UnityContainer();
            RegisterServices(container);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormDangNhap>());
        }

        static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<DbContext, CuaHangXeEntities>(new TransientLifetimeManager());

            container.RegisterType<FormDangNhap>();
        }
    }
}
