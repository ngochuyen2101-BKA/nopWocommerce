using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Plugin.NewPlugin.PluginTest.Models
{
    /// <summary>
    /// Represents a blog post model
    /// </summary>
    public partial record CustomTestModel : BaseNopEntityModel
    {
        #region Ctor

        public CustomTestModel()
        {

        }

        #endregion

        #region Properties

        public string CustomerName { get; set; }
        public string Email { get; set; }

        #endregion
    }
}