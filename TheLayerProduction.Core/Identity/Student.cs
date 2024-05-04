using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLayerProduction.Core.Application;
using TheLayerProduction.Core.Identity.Base;

namespace TheLayerProduction.Core.Identity
{
    public class Student : Consumer
    {
        public List<Package> Packages { get; set; } = [];
    }
}