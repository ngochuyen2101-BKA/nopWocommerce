using FluentMigrator.Builders.Create.Table;
using Nop.Core.Domain.CustomerPlugin;
using Nop.Core.Domain.Localization;
using Nop.Data.Extensions;

namespace Nop.Data.Mapping.Builders.CustomerPlugin
{
    /// <summary>
    /// Represents a blog post entity builder
    /// </summary>
    public partial class CustomTestBuild : NopEntityBuilder<CustomerTest>
    {
        #region Methods

        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
                .WithColumn(nameof(CustomerTest.CustomerName)).AsString(200).NotNullable()
                .WithColumn(nameof(CustomerTest.Email)).AsString(255).Nullable();
        }

        #endregion
    }
}