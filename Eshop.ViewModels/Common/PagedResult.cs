using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.ViewModels.Common
{
    public class PagedResult<T>: PagedResultBase
    {
        public int TotalRecord { get; set; }
        public List<T> Items { get; set; }

    }
}
