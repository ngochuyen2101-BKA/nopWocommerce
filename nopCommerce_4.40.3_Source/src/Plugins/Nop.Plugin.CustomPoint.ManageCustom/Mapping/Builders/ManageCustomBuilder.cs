using FluentMigrator.Builders.Create.Table;
using FluentMigrator.SqlServer;
using FluentMigrator.Runner.Extensions;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Customers;
using Nop.Data.Mapping.Builders;
using Nop.Plugin.CustomPoint.ManageCustom.Domain;
using Nop.Data.Extensions;
using System.Data;

namespace Nop.Plugin.CustomPoint.ManageCustom.Mapping.Builders
{
    public class ManageCustomBuilder : NopEntityBuilder<ManagePointCustom>
    {
        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            //map the primary key (not necessary if it is Id field)
            table.WithColumn(nameof(ManagePointCustom.Id)).AsInt32().Identity().PrimaryKey()
            //avoiding truncation/failure
            //so we set the same max length used in the product name
            .WithColumn(nameof(ManagePointCustom.CustomerName)).AsString(200)
            //not necessary if we don't specify any rules
            .WithColumn(nameof(ManagePointCustom.Email)).AsString(255);
        }
    }
}