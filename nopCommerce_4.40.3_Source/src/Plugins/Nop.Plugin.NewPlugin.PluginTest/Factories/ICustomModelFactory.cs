using System.Threading.Tasks;
using Nop.Core.Domain.CustomerPlugin;
using Nop.Plugin.NewPlugin.PluginTest.Models;

namespace Nop.Plugin.NewPlugin.PluginTest.Factories
{
    public partial interface ICustomerTestFactory
    {
        Task<CustomSearchModel> PrepareCustomTestListModelAsync(CustomSearchModel searchModel);

    }
}