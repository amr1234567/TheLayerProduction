

using Microsoft.AspNetCore.Identity;

namespace TheLayerProduction.Core.Identity.Base
{
    public class Consumer : IdentityUser
    {
        public byte[]? Photo { get; set; }
    }
}