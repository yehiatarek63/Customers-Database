﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.10.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Customers.Data.HelperClasses
{
	/// <summary>Field Creation Class for entity CustomerEntity</summary>
	public partial class CustomerFields
	{
		/// <summary>Creates a new CustomerEntity.Address field instance</summary>
		public static EntityField2 Address { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.Address); }}
		/// <summary>Creates a new CustomerEntity.Email field instance</summary>
		public static EntityField2 Email { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.Email); }}
		/// <summary>Creates a new CustomerEntity.FirstName field instance</summary>
		public static EntityField2 FirstName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.FirstName); }}
		/// <summary>Creates a new CustomerEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.Id); }}
		/// <summary>Creates a new CustomerEntity.LastName field instance</summary>
		public static EntityField2 LastName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.LastName); }}
		/// <summary>Creates a new CustomerEntity.ZipCode field instance</summary>
		public static EntityField2 ZipCode { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(CustomerFieldIndex.ZipCode); }}
	}

	/// <summary>Field Creation Class for entity OrderEntity</summary>
	public partial class OrderFields
	{
		/// <summary>Creates a new OrderEntity.CustomerId field instance</summary>
		public static EntityField2 CustomerId { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.CustomerId); }}
		/// <summary>Creates a new OrderEntity.Id field instance</summary>
		public static EntityField2 Id { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.Id); }}
		/// <summary>Creates a new OrderEntity.OrderDate field instance</summary>
		public static EntityField2 OrderDate { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.OrderDate); }}
		/// <summary>Creates a new OrderEntity.OrderName field instance</summary>
		public static EntityField2 OrderName { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.OrderName); }}
		/// <summary>Creates a new OrderEntity.Status field instance</summary>
		public static EntityField2 Status { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.Status); }}
		/// <summary>Creates a new OrderEntity.Total field instance</summary>
		public static EntityField2 Total { get { return ModelInfoProviderSingleton.GetInstance().CreateField2(OrderFieldIndex.Total); }}
	}
	

}