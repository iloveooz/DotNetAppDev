﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerService
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CarRentalCaseDB")]
	public partial class DataClassesCustomerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    #endregion
		
		public DataClassesCustomerDataContext() : 
				base(global::CustomerService.Properties.Settings.Default.CarRentalCaseDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesCustomerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesCustomerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesCustomerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesCustomerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerID;
		
		private string _CustomerName;
		
		private string _CustomerFirstName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnCustomerNameChanging(string value);
    partial void OnCustomerNameChanged();
    partial void OnCustomerFirstNameChanging(string value);
    partial void OnCustomerFirstNameChanged();
    #endregion
		
		public Customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerName", DbType="NVarChar(50)")]
		public string CustomerName
		{
			get
			{
				return this._CustomerName;
			}
			set
			{
				if ((this._CustomerName != value))
				{
					this.OnCustomerNameChanging(value);
					this.SendPropertyChanging();
					this._CustomerName = value;
					this.SendPropertyChanged("CustomerName");
					this.OnCustomerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerFirstName", DbType="NVarChar(50)")]
		public string CustomerFirstName
		{
			get
			{
				return this._CustomerFirstName;
			}
			set
			{
				if ((this._CustomerFirstName != value))
				{
					this.OnCustomerFirstNameChanging(value);
					this.SendPropertyChanging();
					this._CustomerFirstName = value;
					this.SendPropertyChanged("CustomerFirstName");
					this.OnCustomerFirstNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
