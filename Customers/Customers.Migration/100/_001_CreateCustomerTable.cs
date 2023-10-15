using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Migration._100;
[Migration(1)]
public class _001_CreateCustomerTable : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table(Tables.Customer)
            .WithColumn("id").AsInt32().PrimaryKey().Identity()
            .WithColumn("first_name").AsString(50).NotNullable()
            .WithColumn("last_name").AsString(50).NotNullable()
            .WithColumn("address").AsString(50).NotNullable()
            .WithColumn("email").AsString().NotNullable()
            .WithColumn("zip_code").AsString(5).NotNullable();
    }
}
