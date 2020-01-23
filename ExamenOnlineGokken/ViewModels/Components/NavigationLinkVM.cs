using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenOnlineGokken.ViewModels.Components
{
    public class NavigationLinkVM
    {
        public string Text { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public long RouteId { get; set; }
    }
}
