using System.Windows.Forms;
using IP_NTier.Common.Core.IoC;
using IP_NTier.Common.DataAccess.EF.UnitOfWork;

namespace IP_NTier.Presentation.WinForm.Helpers
{
    public static class AppExitHelper
    {
        public static void Exit()
        {
            IUnitOfWorkManager uowManager = DependencyManager.Instance().Resolve<IUnitOfWorkManager>();

            var uow = uowManager.GetUoW();
            uow.Commit();
            uow.Dispose();

            Application.Exit();
        }
    }
}
