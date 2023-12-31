﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.10.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using Customers.Data.EntityClasses;
using Customers.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec.AdapterSpecific;
using SD.LLBLGen.Pro.QuerySpec;

namespace Customers.Data.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory : QueryFactoryBase2
	{
		/// <summary>Creates and returns a new EntityQuery for the Customer entity</summary>
		public EntityQuery<CustomerEntity> Customer { get { return Create<CustomerEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Order entity</summary>
		public EntityQuery<OrderEntity> Order { get { return Create<OrderEntity>(); } }

		/// <inheritdoc/>
		protected override IElementCreatorCore CreateElementCreator() { return new ElementCreator(); }
 
	}
}