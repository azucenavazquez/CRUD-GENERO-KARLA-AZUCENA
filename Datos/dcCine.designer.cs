﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BD_CursoCSharpNet")]
	public partial class dcCineDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertCine(Cine instance);
    partial void UpdateCine(Cine instance);
    partial void DeleteCine(Cine instance);
    partial void InsertCiudad(Ciudad instance);
    partial void UpdateCiudad(Ciudad instance);
    partial void DeleteCiudad(Ciudad instance);
    partial void InsertUsuario(Usuario instance);
    partial void UpdateUsuario(Usuario instance);
    partial void DeleteUsuario(Usuario instance);
    #endregion
		
		public dcCineDataContext() : 
				base(global::Datos.Properties.Settings.Default.BD_CursoCSharpNetConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dcCineDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcCineDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcCineDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcCineDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Cine> Cine
		{
			get
			{
				return this.GetTable<Cine>();
			}
		}
		
		public System.Data.Linq.Table<Ciudad> Ciudad
		{
			get
			{
				return this.GetTable<Ciudad>();
			}
		}
		
		public System.Data.Linq.Table<Usuario> Usuario
		{
			get
			{
				return this.GetTable<Usuario>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cine")]
	public partial class Cine : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Cine1;
		
		private int _ID_Ciudad;
		
		private string _Direccion;
		
		private string _Telefono;
		
		private EntityRef<Ciudad> _Ciudad;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCine1Changing(string value);
    partial void OnCine1Changed();
    partial void OnID_CiudadChanging(int value);
    partial void OnID_CiudadChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    #endregion
		
		public Cine()
		{
			this._Ciudad = default(EntityRef<Ciudad>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Cine", Storage="_Cine1", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Cine1
		{
			get
			{
				return this._Cine1;
			}
			set
			{
				if ((this._Cine1 != value))
				{
					this.OnCine1Changing(value);
					this.SendPropertyChanging();
					this._Cine1 = value;
					this.SendPropertyChanged("Cine1");
					this.OnCine1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Ciudad", DbType="Int NOT NULL")]
		public int ID_Ciudad
		{
			get
			{
				return this._ID_Ciudad;
			}
			set
			{
				if ((this._ID_Ciudad != value))
				{
					if (this._Ciudad.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_CiudadChanging(value);
					this.SendPropertyChanging();
					this._ID_Ciudad = value;
					this.SendPropertyChanged("ID_Ciudad");
					this.OnID_CiudadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="VarChar(50)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ciudad_Cine", Storage="_Ciudad", ThisKey="ID_Ciudad", OtherKey="ID", IsForeignKey=true)]
		public Ciudad Ciudad
		{
			get
			{
				return this._Ciudad.Entity;
			}
			set
			{
				Ciudad previousValue = this._Ciudad.Entity;
				if (((previousValue != value) 
							|| (this._Ciudad.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ciudad.Entity = null;
						previousValue.Cine.Remove(this);
					}
					this._Ciudad.Entity = value;
					if ((value != null))
					{
						value.Cine.Add(this);
						this._ID_Ciudad = value.ID;
					}
					else
					{
						this._ID_Ciudad = default(int);
					}
					this.SendPropertyChanged("Ciudad");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ciudad")]
	public partial class Ciudad : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Ciudad1;
		
		private EntitySet<Cine> _Cine;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCiudad1Changing(string value);
    partial void OnCiudad1Changed();
    #endregion
		
		public Ciudad()
		{
			this._Cine = new EntitySet<Cine>(new Action<Cine>(this.attach_Cine), new Action<Cine>(this.detach_Cine));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Ciudad", Storage="_Ciudad1", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Ciudad1
		{
			get
			{
				return this._Ciudad1;
			}
			set
			{
				if ((this._Ciudad1 != value))
				{
					this.OnCiudad1Changing(value);
					this.SendPropertyChanging();
					this._Ciudad1 = value;
					this.SendPropertyChanged("Ciudad1");
					this.OnCiudad1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ciudad_Cine", Storage="_Cine", ThisKey="ID", OtherKey="ID_Ciudad")]
		public EntitySet<Cine> Cine
		{
			get
			{
				return this._Cine;
			}
			set
			{
				this._Cine.Assign(value);
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
		
		private void attach_Cine(Cine entity)
		{
			this.SendPropertyChanging();
			entity.Ciudad = this;
		}
		
		private void detach_Cine(Cine entity)
		{
			this.SendPropertyChanging();
			entity.Ciudad = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuario")]
	public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Usuario1;
		
		private string _Password;
		
		private string _CorreoElectronico;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUsuario1Changing(string value);
    partial void OnUsuario1Changed();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnCorreoElectronicoChanging(string value);
    partial void OnCorreoElectronicoChanged();
    #endregion
		
		public Usuario()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Usuario", Storage="_Usuario1", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Usuario1
		{
			get
			{
				return this._Usuario1;
			}
			set
			{
				if ((this._Usuario1 != value))
				{
					this.OnUsuario1Changing(value);
					this.SendPropertyChanging();
					this._Usuario1 = value;
					this.SendPropertyChanged("Usuario1");
					this.OnUsuario1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CorreoElectronico", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string CorreoElectronico
		{
			get
			{
				return this._CorreoElectronico;
			}
			set
			{
				if ((this._CorreoElectronico != value))
				{
					this.OnCorreoElectronicoChanging(value);
					this.SendPropertyChanging();
					this._CorreoElectronico = value;
					this.SendPropertyChanged("CorreoElectronico");
					this.OnCorreoElectronicoChanged();
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