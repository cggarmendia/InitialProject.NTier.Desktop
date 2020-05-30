using System.Collections.Generic;

namespace IP_NTier.Common.Presentation.WinForm.Context
{
    public class WinFormItems
    {
        private static WinFormItems _instance = null;
        private static readonly object _padlock = new object();
        private static Dictionary<string, object> _resources { get; set; }

        private WinFormItems()
        {
            _resources = new Dictionary<string, object>();
        }

        public static WinFormItems Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new WinFormItems();
                        }
                    }
                }
                return _instance;
            }
        }

        public Dictionary<string, object> Items => _resources;
    }
}
