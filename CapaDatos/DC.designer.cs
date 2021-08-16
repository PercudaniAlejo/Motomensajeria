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

namespace CapaDatos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MotoMensajeria")]
	public partial class DCDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InserteEnvio(eEnvio instance);
    partial void UpdateeEnvio(eEnvio instance);
    partial void DeleteeEnvio(eEnvio instance);
    partial void InserteMotoquero(eMotoquero instance);
    partial void UpdateeMotoquero(eMotoquero instance);
    partial void DeleteeMotoquero(eMotoquero instance);
    #endregion
		
		public DCDataContext() : 
				base(global::CapaDatos.Properties.Settings.Default.MotoMensajeriaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<eEnvio> eEnvio
		{
			get
			{
				return this.GetTable<eEnvio>();
			}
		}
		
		public System.Data.Linq.Table<eMotoquero> eMotoquero
		{
			get
			{
				return this.GetTable<eMotoquero>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Envio")]
	public partial class eEnvio : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idEnvio;
		
		private System.DateTime _fecha;
		
		private string _nombreCliente;
		
		private string _apellidoCliente;
		
		private int _numCelCliente;
		
		private string _domicEntrega;
		
		private string _localidadEntrega;
		
		private int _unidades;
		
		private bool _fragil;
		
		private double _precioViaje;
		
		private double _precioFinal;
		
		private int _FKMotoquero;
		
		private EntityRef<eMotoquero> _eMotoquero;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidEnvioChanging(int value);
    partial void OnidEnvioChanged();
    partial void OnfechaChanging(System.DateTime value);
    partial void OnfechaChanged();
    partial void OnnombreClienteChanging(string value);
    partial void OnnombreClienteChanged();
    partial void OnapellidoClienteChanging(string value);
    partial void OnapellidoClienteChanged();
    partial void OnnumCelClienteChanging(int value);
    partial void OnnumCelClienteChanged();
    partial void OndomicEntregaChanging(string value);
    partial void OndomicEntregaChanged();
    partial void OnlocalidadEntregaChanging(string value);
    partial void OnlocalidadEntregaChanged();
    partial void OnunidadesChanging(int value);
    partial void OnunidadesChanged();
    partial void OnfragilChanging(bool value);
    partial void OnfragilChanged();
    partial void OnprecioViajeChanging(double value);
    partial void OnprecioViajeChanged();
    partial void OnprecioFinalChanging(double value);
    partial void OnprecioFinalChanged();
    partial void OnFKMotoqueroChanging(int value);
    partial void OnFKMotoqueroChanged();
    #endregion
		
		public eEnvio()
		{
			this._eMotoquero = default(EntityRef<eMotoquero>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEnvio", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idEnvio
		{
			get
			{
				return this._idEnvio;
			}
			set
			{
				if ((this._idEnvio != value))
				{
					this.OnidEnvioChanging(value);
					this.SendPropertyChanging();
					this._idEnvio = value;
					this.SendPropertyChanged("idEnvio");
					this.OnidEnvioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha", DbType="DateTime NOT NULL")]
		public System.DateTime fecha
		{
			get
			{
				return this._fecha;
			}
			set
			{
				if ((this._fecha != value))
				{
					this.OnfechaChanging(value);
					this.SendPropertyChanging();
					this._fecha = value;
					this.SendPropertyChanged("fecha");
					this.OnfechaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreCliente", DbType="VarChar(100)")]
		public string nombreCliente
		{
			get
			{
				return this._nombreCliente;
			}
			set
			{
				if ((this._nombreCliente != value))
				{
					this.OnnombreClienteChanging(value);
					this.SendPropertyChanging();
					this._nombreCliente = value;
					this.SendPropertyChanged("nombreCliente");
					this.OnnombreClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoCliente", DbType="VarChar(100)")]
		public string apellidoCliente
		{
			get
			{
				return this._apellidoCliente;
			}
			set
			{
				if ((this._apellidoCliente != value))
				{
					this.OnapellidoClienteChanging(value);
					this.SendPropertyChanging();
					this._apellidoCliente = value;
					this.SendPropertyChanged("apellidoCliente");
					this.OnapellidoClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numCelCliente", DbType="Int NOT NULL")]
		public int numCelCliente
		{
			get
			{
				return this._numCelCliente;
			}
			set
			{
				if ((this._numCelCliente != value))
				{
					this.OnnumCelClienteChanging(value);
					this.SendPropertyChanging();
					this._numCelCliente = value;
					this.SendPropertyChanged("numCelCliente");
					this.OnnumCelClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_domicEntrega", DbType="VarChar(100)")]
		public string domicEntrega
		{
			get
			{
				return this._domicEntrega;
			}
			set
			{
				if ((this._domicEntrega != value))
				{
					this.OndomicEntregaChanging(value);
					this.SendPropertyChanging();
					this._domicEntrega = value;
					this.SendPropertyChanged("domicEntrega");
					this.OndomicEntregaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_localidadEntrega", DbType="VarChar(50)")]
		public string localidadEntrega
		{
			get
			{
				return this._localidadEntrega;
			}
			set
			{
				if ((this._localidadEntrega != value))
				{
					this.OnlocalidadEntregaChanging(value);
					this.SendPropertyChanging();
					this._localidadEntrega = value;
					this.SendPropertyChanged("localidadEntrega");
					this.OnlocalidadEntregaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_unidades", DbType="Int NOT NULL")]
		public int unidades
		{
			get
			{
				return this._unidades;
			}
			set
			{
				if ((this._unidades != value))
				{
					this.OnunidadesChanging(value);
					this.SendPropertyChanging();
					this._unidades = value;
					this.SendPropertyChanged("unidades");
					this.OnunidadesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fragil", DbType="Bit NOT NULL")]
		public bool fragil
		{
			get
			{
				return this._fragil;
			}
			set
			{
				if ((this._fragil != value))
				{
					this.OnfragilChanging(value);
					this.SendPropertyChanging();
					this._fragil = value;
					this.SendPropertyChanged("fragil");
					this.OnfragilChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precioViaje", DbType="Float NOT NULL")]
		public double precioViaje
		{
			get
			{
				return this._precioViaje;
			}
			set
			{
				if ((this._precioViaje != value))
				{
					this.OnprecioViajeChanging(value);
					this.SendPropertyChanging();
					this._precioViaje = value;
					this.SendPropertyChanged("precioViaje");
					this.OnprecioViajeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precioFinal", DbType="Float NOT NULL")]
		public double precioFinal
		{
			get
			{
				return this._precioFinal;
			}
			set
			{
				if ((this._precioFinal != value))
				{
					this.OnprecioFinalChanging(value);
					this.SendPropertyChanging();
					this._precioFinal = value;
					this.SendPropertyChanged("precioFinal");
					this.OnprecioFinalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FKMotoquero", DbType="Int NOT NULL")]
		public int FKMotoquero
		{
			get
			{
				return this._FKMotoquero;
			}
			set
			{
				if ((this._FKMotoquero != value))
				{
					if (this._eMotoquero.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFKMotoqueroChanging(value);
					this.SendPropertyChanging();
					this._FKMotoquero = value;
					this.SendPropertyChanged("FKMotoquero");
					this.OnFKMotoqueroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motoquero_Envio", Storage="_eMotoquero", ThisKey="FKMotoquero", OtherKey="id", IsForeignKey=true)]
		public eMotoquero eMotoquero
		{
			get
			{
				return this._eMotoquero.Entity;
			}
			set
			{
				eMotoquero previousValue = this._eMotoquero.Entity;
				if (((previousValue != value) 
							|| (this._eMotoquero.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._eMotoquero.Entity = null;
						previousValue.eEnvio.Remove(this);
					}
					this._eMotoquero.Entity = value;
					if ((value != null))
					{
						value.eEnvio.Add(this);
						this._FKMotoquero = value.id;
					}
					else
					{
						this._FKMotoquero = default(int);
					}
					this.SendPropertyChanged("eMotoquero");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Motoquero")]
	public partial class eMotoquero : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nombre;
		
		private string _apellido;
		
		private int _numCelular;
		
		private string _modeloMoto;
		
		private EntitySet<eEnvio> _eEnvio;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnapellidoChanging(string value);
    partial void OnapellidoChanged();
    partial void OnnumCelularChanging(int value);
    partial void OnnumCelularChanged();
    partial void OnmodeloMotoChanging(string value);
    partial void OnmodeloMotoChanged();
    #endregion
		
		public eMotoquero()
		{
			this._eEnvio = new EntitySet<eEnvio>(new Action<eEnvio>(this.attach_eEnvio), new Action<eEnvio>(this.detach_eEnvio));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(100)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellido", DbType="VarChar(100)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numCelular", DbType="Int NOT NULL")]
		public int numCelular
		{
			get
			{
				return this._numCelular;
			}
			set
			{
				if ((this._numCelular != value))
				{
					this.OnnumCelularChanging(value);
					this.SendPropertyChanging();
					this._numCelular = value;
					this.SendPropertyChanged("numCelular");
					this.OnnumCelularChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modeloMoto", DbType="VarChar(100)")]
		public string modeloMoto
		{
			get
			{
				return this._modeloMoto;
			}
			set
			{
				if ((this._modeloMoto != value))
				{
					this.OnmodeloMotoChanging(value);
					this.SendPropertyChanging();
					this._modeloMoto = value;
					this.SendPropertyChanged("modeloMoto");
					this.OnmodeloMotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Motoquero_Envio", Storage="_eEnvio", ThisKey="id", OtherKey="FKMotoquero")]
		public EntitySet<eEnvio> eEnvio
		{
			get
			{
				return this._eEnvio;
			}
			set
			{
				this._eEnvio.Assign(value);
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
		
		private void attach_eEnvio(eEnvio entity)
		{
			this.SendPropertyChanging();
			entity.eMotoquero = this;
		}
		
		private void detach_eEnvio(eEnvio entity)
		{
			this.SendPropertyChanging();
			entity.eMotoquero = null;
		}
	}
}
#pragma warning restore 1591
