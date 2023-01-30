using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.ViewModels.System.Auth
{
    public class RefreshToken
    {
        public string Token { get; set; } = string.Empty;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Expires { get; set; }
    }
}
