﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="cryppayqa")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTab_Applications_Detail(Tab_Applications_Detail instance);
    partial void UpdateTab_Applications_Detail(Tab_Applications_Detail instance);
    partial void DeleteTab_Applications_Detail(Tab_Applications_Detail instance);
    partial void InsertTab_Application(Tab_Application instance);
    partial void UpdateTab_Application(Tab_Application instance);
    partial void DeleteTab_Application(Tab_Application instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["cryppayqaConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Tab_Applications_Detail> Tab_Applications_Details
		{
			get
			{
				return this.GetTable<Tab_Applications_Detail>();
			}
		}
		
		public System.Data.Linq.Table<Tab_Application> Tab_Applications
		{
			get
			{
				return this.GetTable<Tab_Application>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tab_Applications_Details")]
	public partial class Tab_Applications_Detail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _IdAplication;
		
		private string _Server;
		
		private string _PathAssemblies;
		
		private bool _Estado;
		
		private string _Mensaje;
		
		private EntityRef<Tab_Application> _Tab_Application;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnIdAplicationChanging(int value);
    partial void OnIdAplicationChanged();
    partial void OnServerChanging(string value);
    partial void OnServerChanged();
    partial void OnPathAssembliesChanging(string value);
    partial void OnPathAssembliesChanged();
    partial void OnEstadoChanging(bool value);
    partial void OnEstadoChanged();
    partial void OnMensajeChanging(string value);
    partial void OnMensajeChanged();
    #endregion
		
		public Tab_Applications_Detail()
		{
			this._Tab_Application = default(EntityRef<Tab_Application>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdAplication", DbType="Int NOT NULL")]
		public int IdAplication
		{
			get
			{
				return this._IdAplication;
			}
			set
			{
				if ((this._IdAplication != value))
				{
					if (this._Tab_Application.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdAplicationChanging(value);
					this.SendPropertyChanging();
					this._IdAplication = value;
					this.SendPropertyChanged("IdAplication");
					this.OnIdAplicationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Server", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Server
		{
			get
			{
				return this._Server;
			}
			set
			{
				if ((this._Server != value))
				{
					this.OnServerChanging(value);
					this.SendPropertyChanging();
					this._Server = value;
					this.SendPropertyChanged("Server");
					this.OnServerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PathAssemblies", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string PathAssemblies
		{
			get
			{
				return this._PathAssemblies;
			}
			set
			{
				if ((this._PathAssemblies != value))
				{
					this.OnPathAssembliesChanging(value);
					this.SendPropertyChanging();
					this._PathAssemblies = value;
					this.SendPropertyChanged("PathAssemblies");
					this.OnPathAssembliesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estado", DbType="Bit NOT NULL")]
		public bool Estado
		{
			get
			{
				return this._Estado;
			}
			set
			{
				if ((this._Estado != value))
				{
					this.OnEstadoChanging(value);
					this.SendPropertyChanging();
					this._Estado = value;
					this.SendPropertyChanged("Estado");
					this.OnEstadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mensaje", DbType="VarChar(MAX)")]
		public string Mensaje
		{
			get
			{
				return this._Mensaje;
			}
			set
			{
				if ((this._Mensaje != value))
				{
					this.OnMensajeChanging(value);
					this.SendPropertyChanging();
					this._Mensaje = value;
					this.SendPropertyChanged("Mensaje");
					this.OnMensajeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tab_Application_Tab_Applications_Detail", Storage="_Tab_Application", ThisKey="IdAplication", OtherKey="Id", IsForeignKey=true)]
		public Tab_Application Tab_Application
		{
			get
			{
				return this._Tab_Application.Entity;
			}
			set
			{
				Tab_Application previousValue = this._Tab_Application.Entity;
				if (((previousValue != value) 
							|| (this._Tab_Application.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tab_Application.Entity = null;
						previousValue.Tab_Applications_Details.Remove(this);
					}
					this._Tab_Application.Entity = value;
					if ((value != null))
					{
						value.Tab_Applications_Details.Add(this);
						this._IdAplication = value.Id;
					}
					else
					{
						this._IdAplication = default(int);
					}
					this.SendPropertyChanged("Tab_Application");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tab_Applications")]
	public partial class Tab_Application : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nombre;
		
		private string _Descripcion;
		
		private bool _Estado;
		
		private System.DateTime _FechaActualizacion;
		
		private EntitySet<Tab_Applications_Detail> _Tab_Applications_Details;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    partial void OnEstadoChanging(bool value);
    partial void OnEstadoChanged();
    partial void OnFechaActualizacionChanging(System.DateTime value);
    partial void OnFechaActualizacionChanged();
    #endregion
		
		public Tab_Application()
		{
			this._Tab_Applications_Details = new EntitySet<Tab_Applications_Detail>(new Action<Tab_Applications_Detail>(this.attach_Tab_Applications_Details), new Action<Tab_Applications_Detail>(this.detach_Tab_Applications_Details));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this.OnDescripcionChanging(value);
					this.SendPropertyChanging();
					this._Descripcion = value;
					this.SendPropertyChanged("Descripcion");
					this.OnDescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estado", DbType="Bit NOT NULL")]
		public bool Estado
		{
			get
			{
				return this._Estado;
			}
			set
			{
				if ((this._Estado != value))
				{
					this.OnEstadoChanging(value);
					this.SendPropertyChanging();
					this._Estado = value;
					this.SendPropertyChanged("Estado");
					this.OnEstadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaActualizacion", DbType="DateTime NOT NULL")]
		public System.DateTime FechaActualizacion
		{
			get
			{
				return this._FechaActualizacion;
			}
			set
			{
				if ((this._FechaActualizacion != value))
				{
					this.OnFechaActualizacionChanging(value);
					this.SendPropertyChanging();
					this._FechaActualizacion = value;
					this.SendPropertyChanged("FechaActualizacion");
					this.OnFechaActualizacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tab_Application_Tab_Applications_Detail", Storage="_Tab_Applications_Details", ThisKey="Id", OtherKey="IdAplication")]
		public EntitySet<Tab_Applications_Detail> Tab_Applications_Details
		{
			get
			{
				return this._Tab_Applications_Details;
			}
			set
			{
				this._Tab_Applications_Details.Assign(value);
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
		
		private void attach_Tab_Applications_Details(Tab_Applications_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Tab_Application = this;
		}
		
		private void detach_Tab_Applications_Details(Tab_Applications_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Tab_Application = null;
		}
	}
}
#pragma warning restore 1591
