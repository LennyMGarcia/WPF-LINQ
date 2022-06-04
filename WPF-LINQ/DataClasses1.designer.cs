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

namespace WPF_LINQ
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GestionPedidos")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertempresa(empresa instance);
    partial void Updateempresa(empresa instance);
    partial void Deleteempresa(empresa instance);
    partial void Insertempleado(empleado instance);
    partial void Updateempleado(empleado instance);
    partial void Deleteempleado(empleado instance);
    partial void Insertcargo(cargo instance);
    partial void Updatecargo(cargo instance);
    partial void Deletecargo(cargo instance);
    partial void Insertcargoempleado(cargoempleado instance);
    partial void Updatecargoempleado(cargoempleado instance);
    partial void Deletecargoempleado(cargoempleado instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WPF_LINQ.Properties.Settings.Default.CrudLinqSql, mappingSource)
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
		
		public System.Data.Linq.Table<empresa> empresa
		{
			get
			{
				return this.GetTable<empresa>();
			}
		}
		
		public System.Data.Linq.Table<empleado> empleado
		{
			get
			{
				return this.GetTable<empleado>();
			}
		}
		
		public System.Data.Linq.Table<cargo> cargo
		{
			get
			{
				return this.GetTable<cargo>();
			}
		}
		
		public System.Data.Linq.Table<cargoempleado> cargoempleado
		{
			get
			{
				return this.GetTable<cargoempleado>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.empresa")]
	public partial class empresa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _nombre;
		
		private EntitySet<empleado> _empleado;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    #endregion
		
		public empresa()
		{
			this._empleado = new EntitySet<empleado>(new Action<empleado>(this.attach_empleado), new Action<empleado>(this.detach_empleado));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="empresa_empleado", Storage="_empleado", ThisKey="Id", OtherKey="empresaID")]
		public EntitySet<empleado> empleado
		{
			get
			{
				return this._empleado;
			}
			set
			{
				this._empleado.Assign(value);
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
		
		private void attach_empleado(empleado entity)
		{
			this.SendPropertyChanging();
			entity.empresa = this;
		}
		
		private void detach_empleado(empleado entity)
		{
			this.SendPropertyChanging();
			entity.empresa = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.empleado")]
	public partial class empleado : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _nombre;
		
		private string _apellido;
		
		private int _empresaID;
		
		private EntitySet<cargoempleado> _cargoempleado;
		
		private EntityRef<empresa> _empresa;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnapellidoChanging(string value);
    partial void OnapellidoChanged();
    partial void OnempresaIDChanging(int value);
    partial void OnempresaIDChanged();
    #endregion
		
		public empleado()
		{
			this._cargoempleado = new EntitySet<cargoempleado>(new Action<cargoempleado>(this.attach_cargoempleado), new Action<cargoempleado>(this.detach_cargoempleado));
			this._empresa = default(EntityRef<empresa>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellido", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string apellido
		{
			get
			{
				return this._apellido;
			}
			set
			{
				if ((this._apellido != value))
				{
					this.OnapellidoChanging(value);
					this.SendPropertyChanging();
					this._apellido = value;
					this.SendPropertyChanged("apellido");
					this.OnapellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empresaID", DbType="Int NOT NULL")]
		public int empresaID
		{
			get
			{
				return this._empresaID;
			}
			set
			{
				if ((this._empresaID != value))
				{
					if (this._empresa.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnempresaIDChanging(value);
					this.SendPropertyChanging();
					this._empresaID = value;
					this.SendPropertyChanged("empresaID");
					this.OnempresaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="empleado_cargoempleado", Storage="_cargoempleado", ThisKey="Id", OtherKey="empleadoID")]
		public EntitySet<cargoempleado> cargoempleado
		{
			get
			{
				return this._cargoempleado;
			}
			set
			{
				this._cargoempleado.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="empresa_empleado", Storage="_empresa", ThisKey="empresaID", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public empresa empresa
		{
			get
			{
				return this._empresa.Entity;
			}
			set
			{
				empresa previousValue = this._empresa.Entity;
				if (((previousValue != value) 
							|| (this._empresa.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._empresa.Entity = null;
						previousValue.empleado.Remove(this);
					}
					this._empresa.Entity = value;
					if ((value != null))
					{
						value.empleado.Add(this);
						this._empresaID = value.Id;
					}
					else
					{
						this._empresaID = default(int);
					}
					this.SendPropertyChanged("empresa");
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
		
		private void attach_cargoempleado(cargoempleado entity)
		{
			this.SendPropertyChanging();
			entity.empleado = this;
		}
		
		private void detach_cargoempleado(cargoempleado entity)
		{
			this.SendPropertyChanging();
			entity.empleado = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cargo")]
	public partial class cargo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _nombreCargi;
		
		private EntitySet<cargoempleado> _cargoempleado;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnombreCargiChanging(string value);
    partial void OnnombreCargiChanged();
    #endregion
		
		public cargo()
		{
			this._cargoempleado = new EntitySet<cargoempleado>(new Action<cargoempleado>(this.attach_cargoempleado), new Action<cargoempleado>(this.detach_cargoempleado));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreCargi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nombreCargi
		{
			get
			{
				return this._nombreCargi;
			}
			set
			{
				if ((this._nombreCargi != value))
				{
					this.OnnombreCargiChanging(value);
					this.SendPropertyChanging();
					this._nombreCargi = value;
					this.SendPropertyChanged("nombreCargi");
					this.OnnombreCargiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cargo_cargoempleado", Storage="_cargoempleado", ThisKey="Id", OtherKey="cargoID")]
		public EntitySet<cargoempleado> cargoempleado
		{
			get
			{
				return this._cargoempleado;
			}
			set
			{
				this._cargoempleado.Assign(value);
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
		
		private void attach_cargoempleado(cargoempleado entity)
		{
			this.SendPropertyChanging();
			entity.cargo = this;
		}
		
		private void detach_cargoempleado(cargoempleado entity)
		{
			this.SendPropertyChanging();
			entity.cargo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cargoempleado")]
	public partial class cargoempleado : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _empleadoID;
		
		private int _cargoID;
		
		private EntityRef<cargo> _cargo;
		
		private EntityRef<empleado> _empleado;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnempleadoIDChanging(int value);
    partial void OnempleadoIDChanged();
    partial void OncargoIDChanging(int value);
    partial void OncargoIDChanged();
    #endregion
		
		public cargoempleado()
		{
			this._cargo = default(EntityRef<cargo>);
			this._empleado = default(EntityRef<empleado>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empleadoID", DbType="Int NOT NULL")]
		public int empleadoID
		{
			get
			{
				return this._empleadoID;
			}
			set
			{
				if ((this._empleadoID != value))
				{
					if (this._empleado.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnempleadoIDChanging(value);
					this.SendPropertyChanging();
					this._empleadoID = value;
					this.SendPropertyChanged("empleadoID");
					this.OnempleadoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cargoID", DbType="Int NOT NULL")]
		public int cargoID
		{
			get
			{
				return this._cargoID;
			}
			set
			{
				if ((this._cargoID != value))
				{
					if (this._cargo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncargoIDChanging(value);
					this.SendPropertyChanging();
					this._cargoID = value;
					this.SendPropertyChanged("cargoID");
					this.OncargoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cargo_cargoempleado", Storage="_cargo", ThisKey="cargoID", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public cargo cargo
		{
			get
			{
				return this._cargo.Entity;
			}
			set
			{
				cargo previousValue = this._cargo.Entity;
				if (((previousValue != value) 
							|| (this._cargo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._cargo.Entity = null;
						previousValue.cargoempleado.Remove(this);
					}
					this._cargo.Entity = value;
					if ((value != null))
					{
						value.cargoempleado.Add(this);
						this._cargoID = value.Id;
					}
					else
					{
						this._cargoID = default(int);
					}
					this.SendPropertyChanged("cargo");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="empleado_cargoempleado", Storage="_empleado", ThisKey="empleadoID", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public empleado empleado
		{
			get
			{
				return this._empleado.Entity;
			}
			set
			{
				empleado previousValue = this._empleado.Entity;
				if (((previousValue != value) 
							|| (this._empleado.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._empleado.Entity = null;
						previousValue.cargoempleado.Remove(this);
					}
					this._empleado.Entity = value;
					if ((value != null))
					{
						value.cargoempleado.Add(this);
						this._empleadoID = value.Id;
					}
					else
					{
						this._empleadoID = default(int);
					}
					this.SendPropertyChanged("empleado");
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