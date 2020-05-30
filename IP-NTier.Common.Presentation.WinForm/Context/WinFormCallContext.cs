using System;
using IP_NTier.Common.Core.Context;

namespace IP_NTier.Common.Presentation.WinForm.Context
{
    /// <summary>
    /// Con un singlenton (WinFormItems), hace que se compartan recursos como la unidad de trabajo, entre otros.
    /// </summary>
    public class WinFormCallContext : ICallContext
    {
        #region Constructor

        public WinFormCallContext()
        {
        }

        #endregion Constructor

        #region Methods

        public bool Contains(string Key)
        {
            return WinFormItems.Instance.Items.ContainsKey(Key);
        }

        public void Remove(string Key)
        {
            WinFormItems.Instance.Items.Remove(Key);
        }

        public T Retrieve<T>(string Key)
        {
            lock (WinFormItems.Instance.Items)
            {
                if (!WinFormItems.Instance.Items.ContainsKey(Key))
                    throw new InvalidOperationException("Key not found");
                return (T)WinFormItems.Instance.Items[Key];
            }
        }

        public T Retrieve<T>(string Key, T Default)
        {
            lock (WinFormItems.Instance.Items)
            {
                if (WinFormItems.Instance.Items.ContainsKey(Key))
                    return (T)WinFormItems.Instance.Items[Key];
                return Default;
            }
        }

        public void Save(string Key, object Obj)
        {
            WinFormItems.Instance.Items[Key] = Obj;
        }

        #endregion Methods
    }
}
