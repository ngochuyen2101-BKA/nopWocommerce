using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Plugin.CustomPoint.ManageCustom.Models
{
    public record ManageCustomModel : BaseNopEntityModel
    {
        [NopResourceDisplayName("Plugin.CustomPoint.ManageCustom.Fields.CustomerName")]
        public string CustomerName { get; set; }
        [NopResourceDisplayName("Plugin.CustomPoint.ManageCustom.Fields.Email")]
        public string Email { get; set; } 
    }
}