using FluentMigrator;
using Nop.Core.Domain.Catalog;

namespace Nop.Data.Migrations
{
    [NopMigration("2020/05/26 11:24:16:2551770", "This is test")]
    public class Test: AutoReversingMigration
    {
        private readonly IMigrationManager _migrationManager;

        public Test(IMigrationManager migrationManager)
        {
            _migrationManager = migrationManager;
        }
        /// <summary>Collect the UP migration expressions</summary>
        public override void Up()
        {
            _migrationManager.BuildTable<CategoryTest>(Create);
        }
    }
}