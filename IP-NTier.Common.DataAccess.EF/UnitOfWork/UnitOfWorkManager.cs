using IP_NTier.Common.Core.Context;
using IP_NTier.Common.Core.IoC;
using IP_NTier.Common.Core.Key;
using IP_NTier.Domain.UnitOfWork;

namespace IP_NTier.Common.DataAccess.EF.UnitOfWork
{
    /// <summary>
    /// Encapsula el llamado a la unidad de trabajo.
    /// </summary>
    public class UnitOfWorkManager : IUnitOfWorkManager
    {
        #region Members

        private ICallContext callContext;
        private object lockUoW = new object();

        #endregion Members

        #region Constructor

        public UnitOfWorkManager(ICallContext context)
        {
            callContext = DependencyManager.Instance().Resolve<ICallContext>();
        }

        #endregion Constructor

        #region Methods

        public virtual IUnitOfWork GetUoW()
        {
            if (!callContext.Contains(IpNTierKeyConst.UoW))
            {
                lock (lockUoW)
                {
                    if (!callContext.Contains(IpNTierKeyConst.UoW))
                    {
                        callContext.Save(IpNTierKeyConst.UoW, DependencyManager.Instance().Resolve<IUnitOfWork>());
                    }
                }
            }

            return callContext.Retrieve<IUnitOfWork>(IpNTierKeyConst.UoW);
        }

        #endregion Methods
    }
}
