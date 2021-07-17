using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;
using Microsoft.AspNetCore.Mvc;

namespace Nop.Plugin.NewPlugin.PluginTest.Models
{
    public record CustomSearchModel : BaseSearchModel
    {
        #region Ctor

        public CustomSearchModel()
        {
        }

        #endregion

        #region Properties
        
        public string SearchCustomName { get; set; }

        #endregion
    }
}