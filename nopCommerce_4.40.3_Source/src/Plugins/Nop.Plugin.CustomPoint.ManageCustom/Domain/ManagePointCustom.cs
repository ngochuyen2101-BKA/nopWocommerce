using Nop.Core;

namespace Nop.Plugin.CustomPoint.ManageCustom.Domain
{
    /// <summary>
    /// Represents a pickup point of store
    /// </summary>
    public partial class ManagePointCustom : BaseEntity
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
    }
}