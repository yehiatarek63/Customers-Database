﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.10.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Customers.Data.HelperClasses;
using Customers.Data.FactoryClasses;
using Customers.Data.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Customers.Data.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Order'.<br/><br/></summary>
	[Serializable]
	public partial class OrderEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private CustomerEntity _customer;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static OrderEntityStaticMetaData _staticMetaData = new OrderEntityStaticMetaData();
		private static OrderRelations _relationsFactory = new OrderRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Customer</summary>
			public static readonly string Customer = "Customer";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class OrderEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public OrderEntityStaticMetaData()
			{
				SetEntityCoreInfo("OrderEntity", InheritanceHierarchyType.None, false, (int)Customers.Data.EntityType.OrderEntity, typeof(OrderEntity), typeof(OrderEntityFactory), false);
				AddNavigatorMetaData<OrderEntity, CustomerEntity>("Customer", "Orders", (a, b) => a._customer = b, a => a._customer, (a, b) => a.Customer = b, Customers.Data.RelationClasses.StaticOrderRelations.CustomerEntityUsingCustomerIdStatic, ()=>new OrderRelations().CustomerEntityUsingCustomerId, null, new int[] { (int)OrderFieldIndex.CustomerId }, null, true, (int)Customers.Data.EntityType.CustomerEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static OrderEntity()
		{
		}

		/// <summary> CTor</summary>
		public OrderEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public OrderEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this OrderEntity</param>
		public OrderEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Order which data should be fetched into this Order object</param>
		public OrderEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Order which data should be fetched into this Order object</param>
		/// <param name="validator">The custom validator object for this OrderEntity</param>
		public OrderEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected OrderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Customer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomer() { return CreateRelationInfoForNavigator("Customer"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this OrderEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static OrderRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomer { get { return _staticMetaData.GetPrefetchPathElement("Customer", CommonEntityBase.CreateEntityCollection<CustomerEntity>()); } }

		/// <summary>The CustomerId property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order"."customer_id".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CustomerId
		{
			get { return (System.Int32)GetValue((int)OrderFieldIndex.CustomerId, true); }
			set	{ SetValue((int)OrderFieldIndex.CustomerId, value); }
		}

		/// <summary>The Id property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order"."id".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)OrderFieldIndex.Id, true); }
			set	{ SetValue((int)OrderFieldIndex.Id, value); }
		}

		/// <summary>The OrderDate property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order"."order_date".<br/>Table field type characteristics (type, precision, scale, length): Timestamp, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime OrderDate
		{
			get { return (System.DateTime)GetValue((int)OrderFieldIndex.OrderDate, true); }
			set	{ SetValue((int)OrderFieldIndex.OrderDate, value); }
		}

		/// <summary>The OrderName property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order"."order_name".<br/>Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String OrderName
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.OrderName, true); }
			set	{ SetValue((int)OrderFieldIndex.OrderName, value); }
		}

		/// <summary>The Status property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order"."status".<br/>Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Status
		{
			get { return (System.String)GetValue((int)OrderFieldIndex.Status, true); }
			set	{ SetValue((int)OrderFieldIndex.Status, value); }
		}

		/// <summary>The Total property of the Entity Order<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Order"."total".<br/>Table field type characteristics (type, precision, scale, length): Numeric, 19, 5, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Total
		{
			get { return (System.Decimal)GetValue((int)OrderFieldIndex.Total, true); }
			set	{ SetValue((int)OrderFieldIndex.Total, value); }
		}

		/// <summary>Gets / sets related entity of type 'CustomerEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CustomerEntity Customer
		{
			get { return _customer; }
			set { SetSingleRelatedEntityNavigator(value, "Customer"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace Customers.Data
{
	public enum OrderFieldIndex
	{
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>Id. </summary>
		Id,
		///<summary>OrderDate. </summary>
		OrderDate,
		///<summary>OrderName. </summary>
		OrderName,
		///<summary>Status. </summary>
		Status,
		///<summary>Total. </summary>
		Total,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace Customers.Data.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Order. </summary>
	public partial class OrderRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between OrderEntity and CustomerEntity over the m:1 relation they have, using the relation between the fields: Order.CustomerId - Customer.Id</summary>
		public virtual IEntityRelation CustomerEntityUsingCustomerId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Customer", false, new[] { CustomerFields.Id, OrderFields.CustomerId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticOrderRelations
	{
		internal static readonly IEntityRelation CustomerEntityUsingCustomerIdStatic = new OrderRelations().CustomerEntityUsingCustomerId;

		/// <summary>CTor</summary>
		static StaticOrderRelations() { }
	}
}
