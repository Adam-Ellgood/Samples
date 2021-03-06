﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GuidVsId
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="TestData")]
	public partial class DataClassesNoGuidDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertNoGuidProduct(NoGuidProduct instance);
    partial void UpdateNoGuidProduct(NoGuidProduct instance);
    partial void DeleteNoGuidProduct(NoGuidProduct instance);
    partial void InsertNoGuidReleatedProduct(NoGuidReleatedProduct instance);
    partial void UpdateNoGuidReleatedProduct(NoGuidReleatedProduct instance);
    partial void DeleteNoGuidReleatedProduct(NoGuidReleatedProduct instance);
    #endregion
		
		public DataClassesNoGuidDataContext() : 
				base(global::GuidVsId.Properties.Settings.Default.TestDataConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesNoGuidDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesNoGuidDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesNoGuidDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesNoGuidDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<NoGuidProduct> NoGuidProducts
		{
			get
			{
				return this.GetTable<NoGuidProduct>();
			}
		}
		
		public System.Data.Linq.Table<NoGuidReleatedProduct> NoGuidReleatedProducts
		{
			get
			{
				return this.GetTable<NoGuidReleatedProduct>();
			}
		}
	}
	
	[Table(Name="dbo.noguid_Products")]
	public partial class NoGuidProduct : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private float _Price;
		
		private EntitySet<NoGuidReleatedProduct> _noguid_ReleatedProducts;
		
		private EntitySet<NoGuidReleatedProduct> _NoGuidReleatedProducts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPriceChanging(float value);
    partial void OnPriceChanged();
    #endregion
		
		public NoGuidProduct()
		{
			this._noguid_ReleatedProducts = new EntitySet<NoGuidReleatedProduct>(new Action<NoGuidReleatedProduct>(this.attach_noguid_ReleatedProducts), new Action<NoGuidReleatedProduct>(this.detach_noguid_ReleatedProducts));
			this._NoGuidReleatedProducts = new EntitySet<NoGuidReleatedProduct>(new Action<NoGuidReleatedProduct>(this.attach_NoGuidReleatedProducts), new Action<NoGuidReleatedProduct>(this.detach_NoGuidReleatedProducts));
			OnCreated();
		}
		
		[Column(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[Column(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_Price", DbType="Real NOT NULL")]
		public float Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[Association(Name="NoGuidProduct_NoGuidReleatedProduct", Storage="_noguid_ReleatedProducts", OtherKey="ProductIdFirst")]
		public EntitySet<NoGuidReleatedProduct> noguid_ReleatedProducts
		{
			get
			{
				return this._noguid_ReleatedProducts;
			}
			set
			{
				this._noguid_ReleatedProducts.Assign(value);
			}
		}
		
		[Association(Name="NoGuidProduct_NoGuidReleatedProduct1", Storage="_NoGuidReleatedProducts", OtherKey="ProductIdSecond")]
		public EntitySet<NoGuidReleatedProduct> NoGuidReleatedProducts
		{
			get
			{
				return this._NoGuidReleatedProducts;
			}
			set
			{
				this._NoGuidReleatedProducts.Assign(value);
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
		
		private void attach_noguid_ReleatedProducts(NoGuidReleatedProduct entity)
		{
			this.SendPropertyChanging();
			entity.noguid_Product = this;
		}
		
		private void detach_noguid_ReleatedProducts(NoGuidReleatedProduct entity)
		{
			this.SendPropertyChanging();
			entity.noguid_Product = null;
		}
		
		private void attach_NoGuidReleatedProducts(NoGuidReleatedProduct entity)
		{
			this.SendPropertyChanging();
			entity.NoGuidProduct = this;
		}
		
		private void detach_NoGuidReleatedProducts(NoGuidReleatedProduct entity)
		{
			this.SendPropertyChanging();
			entity.NoGuidProduct = null;
		}
	}
	
	[Table(Name="dbo.noguid_ReleatedProducts")]
	public partial class NoGuidReleatedProduct : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _ProductIdFirst;
		
		private int _ProductIdSecond;
		
		private EntityRef<NoGuidProduct> _noguid_Product;
		
		private EntityRef<NoGuidProduct> _NoGuidProduct;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnProductIdFirstChanging(int value);
    partial void OnProductIdFirstChanged();
    partial void OnProductIdSecondChanging(int value);
    partial void OnProductIdSecondChanged();
    #endregion
		
		public NoGuidReleatedProduct()
		{
			this._noguid_Product = default(EntityRef<NoGuidProduct>);
			this._NoGuidProduct = default(EntityRef<NoGuidProduct>);
			OnCreated();
		}
		
		[Column(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[Column(Storage="_ProductIdFirst", DbType="Int NOT NULL")]
		public int ProductIdFirst
		{
			get
			{
				return this._ProductIdFirst;
			}
			set
			{
				if ((this._ProductIdFirst != value))
				{
					if (this._noguid_Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdFirstChanging(value);
					this.SendPropertyChanging();
					this._ProductIdFirst = value;
					this.SendPropertyChanged("ProductIdFirst");
					this.OnProductIdFirstChanged();
				}
			}
		}
		
		[Column(Storage="_ProductIdSecond", DbType="Int NOT NULL")]
		public int ProductIdSecond
		{
			get
			{
				return this._ProductIdSecond;
			}
			set
			{
				if ((this._ProductIdSecond != value))
				{
					if (this._NoGuidProduct.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdSecondChanging(value);
					this.SendPropertyChanging();
					this._ProductIdSecond = value;
					this.SendPropertyChanged("ProductIdSecond");
					this.OnProductIdSecondChanged();
				}
			}
		}
		
		[Association(Name="NoGuidProduct_NoGuidReleatedProduct", Storage="_noguid_Product", ThisKey="ProductIdFirst", IsForeignKey=true)]
		public NoGuidProduct noguid_Product
		{
			get
			{
				return this._noguid_Product.Entity;
			}
			set
			{
				NoGuidProduct previousValue = this._noguid_Product.Entity;
				if (((previousValue != value) 
							|| (this._noguid_Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._noguid_Product.Entity = null;
						previousValue.noguid_ReleatedProducts.Remove(this);
					}
					this._noguid_Product.Entity = value;
					if ((value != null))
					{
						value.noguid_ReleatedProducts.Add(this);
						this._ProductIdFirst = value.Id;
					}
					else
					{
						this._ProductIdFirst = default(int);
					}
					this.SendPropertyChanged("noguid_Product");
				}
			}
		}
		
		[Association(Name="NoGuidProduct_NoGuidReleatedProduct1", Storage="_NoGuidProduct", ThisKey="ProductIdSecond", IsForeignKey=true)]
		public NoGuidProduct NoGuidProduct
		{
			get
			{
				return this._NoGuidProduct.Entity;
			}
			set
			{
				NoGuidProduct previousValue = this._NoGuidProduct.Entity;
				if (((previousValue != value) 
							|| (this._NoGuidProduct.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NoGuidProduct.Entity = null;
						previousValue.NoGuidReleatedProducts.Remove(this);
					}
					this._NoGuidProduct.Entity = value;
					if ((value != null))
					{
						value.NoGuidReleatedProducts.Add(this);
						this._ProductIdSecond = value.Id;
					}
					else
					{
						this._ProductIdSecond = default(int);
					}
					this.SendPropertyChanged("NoGuidProduct");
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
