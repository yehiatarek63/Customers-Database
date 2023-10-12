using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Migration._100;
[Migration(2)]
public class _002_CreateOrderTable : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table(Tables.Order)
            .WithColumn("id").AsInt32().PrimaryKey().Identity().NotNullable()
            .WithColumn("customer_id").AsInt32().NotNullable().ForeignKey("Customer", "id")
            .WithColumn("order_name").AsString(50).NotNullable()
            .WithColumn("order_date").AsDateTime().NotNullable()
            .WithColumn("total").AsDecimal().NotNullable()
            .WithColumn("status").AsString(50).NotNullable();
    }
}
