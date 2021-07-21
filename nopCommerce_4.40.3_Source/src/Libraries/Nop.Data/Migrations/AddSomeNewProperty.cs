using FluentMigrator;
using Nop.Core.Domain.Catalog;

namespace Nop.Data.Migrations
{
    [NopMigration("2020/05/25 11:24:16:2551770", "Category. Add some new property")]
    public class AddSomeNewProperty: AutoReversingMigration
    {
        /// <summary>Collect the UP migration expressions</summary>
        public override void Up()
        {
            Create.Column(nameof(Category.SomeNewProperty))
            .OnTable(nameof(Category))
            .AsString(255)
            .Nullable();
        }
    }
}