using System.Collections.Generic;

namespace MiniAbp.Domain.Uow
{
    public class ConnectionStringResolveArgs : Dictionary<string, object>
    {
        //public MultiTenancySides? MultiTenancySide { get; set; }

        public ConnectionStringResolveArgs()//MultiTenancySides? multiTenancySide = null)
        {
            //MultiTenancySide = multiTenancySide;
        }
    }
}