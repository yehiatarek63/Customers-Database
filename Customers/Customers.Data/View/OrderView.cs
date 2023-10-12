﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.10.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace View.DtoClasses
{ 
	/// <summary> DTO class which is derived from the entity 'Order'.</summary>
	[Serializable]
	[DataContract]
	public partial class OrderView
	{
		/// <summary>Gets or sets the Customer field. </summary>
		[DataMember]
		public OrderViewTypes.Customer Customer { get; set; }
		/// <summary>Gets or sets the OrderDate field. Derived from Entity Model Field 'Order.OrderDate'</summary>
		[DataMember]
		public System.DateTime OrderDate { get; set; }
		/// <summary>Gets or sets the OrderName field. Derived from Entity Model Field 'Order.OrderName'</summary>
		[DataMember]
		public System.String OrderName { get; set; }
		/// <summary>Gets or sets the Status field. Derived from Entity Model Field 'Order.Status'</summary>
		[DataMember]
		public System.String Status { get; set; }
		/// <summary>Gets or sets the Total field. Derived from Entity Model Field 'Order.Total'</summary>
		[DataMember]
		public System.Decimal Total { get; set; }
	}

	namespace OrderViewTypes
	{
		/// <summary> DTO class which is derived from the entity 'Customer (Customer)'.</summary>
		[Serializable]
		[DataContract]
		public partial class Customer
		{
			/// <summary>Gets or sets the FirstName field. Derived from Entity Model Field 'Customer.FirstName'</summary>
			[DataMember]
			public System.String FirstName { get; set; }
			/// <summary>Gets or sets the LastName field. Derived from Entity Model Field 'Customer.LastName'</summary>
			[DataMember]
			public System.String LastName { get; set; }
		}
	}

}



