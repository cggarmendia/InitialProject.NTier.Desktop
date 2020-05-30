using IP_NTier.Business.DomainServices.Modules.Security;
using IP_NTier.Common.Core.Context;
using IP_NTier.Common.DataAccess.EF.UnitOfWork;
using IP_NTier.Common.Presentation.WinForm.Context;
using IP_NTier.DataAccess.EF.UnitOfWorks;
using IP_NTier.Domain.UnitOfWork;
using Ninject.Modules;

namespace IP_NTier.Common.IoC
{
    public class IoCConfigModule : NinjectModule
    {
        #region Public Methods

        public override void Load()
        {
            // Infraestructure
            Bind<IUnitOfWork>().To<IpNTierUnitOfWork>();
            Bind<IUnitOfWorkManager>().To<UnitOfWorkManager>().InSingletonScope();

            // Call Context
            Bind<ICallContext>().To<WinFormCallContext>().InSingletonScope();

            // DomainServices
            Bind<IRoleDomainServices>().To<RoleDomainServices>().InSingletonScope();
            Bind<IUserDomainServices>().To<UserDomainServices>().InSingletonScope();
            
        }

        #endregion Public Methods
    }
}
