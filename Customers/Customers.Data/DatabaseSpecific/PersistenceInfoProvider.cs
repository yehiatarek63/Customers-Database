﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.10.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Customers.Data.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	internal static class PersistenceInfoProviderSingleton
	{
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton() {	}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance() { return _providerInstance; }
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass();
			InitCustomerEntityMappings();
			InitOrderEntityMappings();
		}

		/// <summary>Inits CustomerEntity's mappings</summary>
		private void InitCustomerEntityMappings()
		{
			this.AddElementMapping("CustomerEntity", @"Customers", @"public", "Customer", 6, 0);
			this.AddElementFieldMapping("CustomerEntity", "Address", "address", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("CustomerEntity", "Email", "email", false, "Text", 1073741824, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("CustomerEntity", "FirstName", "first_name", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("CustomerEntity", "Id", "id", false, "Integer", 0, 10, 0, true, "public.Customer_id_seq", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("CustomerEntity", "LastName", "last_name", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("CustomerEntity", "ZipCode", "zip_code", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 5);
		}

		/// <summary>Inits OrderEntity's mappings</summary>
		private void InitOrderEntityMappings()
		{
			this.AddElementMapping("OrderEntity", @"Customers", @"public", "Order", 6, 0);
			this.AddElementFieldMapping("OrderEntity", "CustomerId", "customer_id", false, "Integer", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("OrderEntity", "Id", "id", false, "Integer", 0, 10, 0, true, "public.Order_id_seq", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("OrderEntity", "OrderDate", "order_date", false, "Timestamp", 0, 0, 0, false, "", null, typeof(System.DateTime), 2);
			this.AddElementFieldMapping("OrderEntity", "OrderName", "order_name", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("OrderEntity", "Status", "status", false, "Varchar", 50, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("OrderEntity", "Total", "total", false, "Numeric", 0, 19, 5, false, "", null, typeof(System.Decimal), 5);
		}

	}
}
