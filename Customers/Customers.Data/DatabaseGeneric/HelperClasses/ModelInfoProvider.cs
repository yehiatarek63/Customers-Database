﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.10.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using Customers.Data.FactoryClasses;
using Customers.Data.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Customers.Data.HelperClasses
{
	/// <summary>Singleton implementation of the ModelInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	public static class ModelInfoProviderSingleton
	{
		private static readonly IModelInfoProvider _providerInstance = new ModelInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static ModelInfoProviderSingleton()	{ }

		/// <summary>Gets the singleton instance of the ModelInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IModelInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the ModelInfoProvider.</summary>
	internal class ModelInfoProviderCore : ModelInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="ModelInfoProviderCore"/> class.</summary>
		internal ModelInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass();
			InitCustomerEntityInfo();
			InitOrderEntityInfo();
			this.BuildInternalStructures();
		}

		/// <summary>Inits CustomerEntity's info objects</summary>
		private void InitCustomerEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomerFieldIndex), "CustomerEntity");
			this.AddElementFieldInfo("CustomerEntity", "Address", typeof(System.String), false, false, false, false,  (int)CustomerFieldIndex.Address, 50, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "Email", typeof(System.String), false, false, false, false,  (int)CustomerFieldIndex.Email, 1073741824, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)CustomerFieldIndex.FirstName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "Id", typeof(System.Int32), true, false, false, false,  (int)CustomerFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("CustomerEntity", "LastName", typeof(System.String), false, false, false, false,  (int)CustomerFieldIndex.LastName, 50, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "ZipCode", typeof(System.String), false, false, false, false,  (int)CustomerFieldIndex.ZipCode, 50, 0, 0);
		}

		/// <summary>Inits OrderEntity's info objects</summary>
		private void InitOrderEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(OrderFieldIndex), "OrderEntity");
			this.AddElementFieldInfo("OrderEntity", "CustomerId", typeof(System.Int32), false, true, false, false,  (int)OrderFieldIndex.CustomerId, 0, 0, 10);
			this.AddElementFieldInfo("OrderEntity", "Id", typeof(System.Int32), true, false, false, false,  (int)OrderFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("OrderEntity", "OrderDate", typeof(System.DateTime), false, false, false, false,  (int)OrderFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "OrderName", typeof(System.String), false, false, false, false,  (int)OrderFieldIndex.OrderName, 50, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "Status", typeof(System.String), false, false, false, false,  (int)OrderFieldIndex.Status, 50, 0, 0);
			this.AddElementFieldInfo("OrderEntity", "Total", typeof(System.Decimal), false, false, false, false,  (int)OrderFieldIndex.Total, 0, 5, 19);
		}
	}
}