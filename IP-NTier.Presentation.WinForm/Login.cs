using System;
using System.Windows.Forms;
using IP_NTier.Business.DomainServices.Modules.Security;
using IP_NTier.Common.Core.IoC;
using IP_NTier.Common.Core.Security;
using IP_NTier.Common.DataAccess.EF.UnitOfWork;

namespace IP_NTier.Presentation.WinForm
{
    public partial class Login : Form
    {
        private readonly IUserDomainServices _userServices;

        public Login()
        {
            this._userServices = DependencyManager.Instance().Resolve<IUserDomainServices>();
            TestIoC();
            InitializeComponent();
        }

        private void TestIoC()
        {
            var temp = _userServices.GetAll();
        }
    }
}
