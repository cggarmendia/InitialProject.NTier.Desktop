using System;
using System.Windows.Forms;
using IP_NTier.Common.Core.IoC;
using IP_NTier.Common.IoC;
using Ninject;
using Ninject.Modules;
using IP_NTier.Common.DataAccess.EF.UnitOfWork;
using IP_NTier.Presentation.WinForm.Helpers;

namespace IP_NTier.Presentation.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(new Login());
            AppExitHelper.Exit();
        }

        private static void Bootstrap()
        {
            InitIoC();
            InitUoW();
        }

        private static void InitUoW()
        {
            var uowManager = DependencyManager.Instance().Resolve<IUnitOfWorkManager>();
            uowManager.GetUoW();
        }

        private static void InitIoC()
        {
            var configModules = new INinjectModule[] {new IoCConfigModule()};
            DependencyManager.Instance().Configure(configModules);
        }
    }
}
