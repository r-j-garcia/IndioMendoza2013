﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region Metadatos de relaciones en EDM

[assembly: EdmRelationshipAttribute("IndioMendoza2013Model", "FK_Zona_Provincia", "Provincia", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(IndioMendoza2013.OrigenesDeDatos.Provincia), "Zona", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(IndioMendoza2013.OrigenesDeDatos.Zona), true)]
[assembly: EdmRelationshipAttribute("IndioMendoza2013Model", "BondiRicotero_Zona", "BondiRicotero", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(IndioMendoza2013.OrigenesDeDatos.BondiRicotero), "Zona", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(IndioMendoza2013.OrigenesDeDatos.Zona))]

#endregion

namespace IndioMendoza2013.OrigenesDeDatos
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class IndioMendoza2013Entities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto IndioMendoza2013Entities usando la cadena de conexión encontrada en la sección 'IndioMendoza2013Entities' del archivo de configuración de la aplicación.
        /// </summary>
        public IndioMendoza2013Entities() : base("name=IndioMendoza2013Entities", "IndioMendoza2013Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto IndioMendoza2013Entities.
        /// </summary>
        public IndioMendoza2013Entities(string connectionString) : base(connectionString, "IndioMendoza2013Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto IndioMendoza2013Entities.
        /// </summary>
        public IndioMendoza2013Entities(EntityConnection connection) : base(connection, "IndioMendoza2013Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<PosicionRicotera> PosicionRicotera
        {
            get
            {
                if ((_PosicionRicotera == null))
                {
                    _PosicionRicotera = base.CreateObjectSet<PosicionRicotera>("PosicionRicotera");
                }
                return _PosicionRicotera;
            }
        }
        private ObjectSet<PosicionRicotera> _PosicionRicotera;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Provincia> Provincia
        {
            get
            {
                if ((_Provincia == null))
                {
                    _Provincia = base.CreateObjectSet<Provincia>("Provincia");
                }
                return _Provincia;
            }
        }
        private ObjectSet<Provincia> _Provincia;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Contacto> Contacto
        {
            get
            {
                if ((_Contacto == null))
                {
                    _Contacto = base.CreateObjectSet<Contacto>("Contacto");
                }
                return _Contacto;
            }
        }
        private ObjectSet<Contacto> _Contacto;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<BondiRicotero> BondiRicotero
        {
            get
            {
                if ((_BondiRicotero == null))
                {
                    _BondiRicotero = base.CreateObjectSet<BondiRicotero>("BondiRicotero");
                }
                return _BondiRicotero;
            }
        }
        private ObjectSet<BondiRicotero> _BondiRicotero;
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<Zona> Zona
        {
            get
            {
                if ((_Zona == null))
                {
                    _Zona = base.CreateObjectSet<Zona>("Zona");
                }
                return _Zona;
            }
        }
        private ObjectSet<Zona> _Zona;

        #endregion
        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet PosicionRicotera. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToPosicionRicotera(PosicionRicotera posicionRicotera)
        {
            base.AddObject("PosicionRicotera", posicionRicotera);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Provincia. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToProvincia(Provincia provincia)
        {
            base.AddObject("Provincia", provincia);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Contacto. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToContacto(Contacto contacto)
        {
            base.AddObject("Contacto", contacto);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet BondiRicotero. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToBondiRicotero(BondiRicotero bondiRicotero)
        {
            base.AddObject("BondiRicotero", bondiRicotero);
        }
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Zona. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToZona(Zona zona)
        {
            base.AddObject("Zona", zona);
        }

        #endregion
    }
    

    #endregion
    
    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="IndioMendoza2013Model", Name="BondiRicotero")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class BondiRicotero : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto BondiRicotero.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad id.</param>
        /// <param name="nombre">Valor inicial de la propiedad nombre.</param>
        public static BondiRicotero CreateBondiRicotero(global::System.Int32 id, global::System.String nombre)
        {
            BondiRicotero bondiRicotero = new BondiRicotero();
            bondiRicotero.id = id;
            bondiRicotero.nombre = nombre;
            return bondiRicotero;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                OnnombreChanging(value);
                ReportPropertyChanging("nombre");
                _nombre = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("nombre");
                OnnombreChanged();
            }
        }
        private global::System.String _nombre;
        partial void OnnombreChanging(global::System.String value);
        partial void OnnombreChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                OndescripcionChanging(value);
                ReportPropertyChanging("descripcion");
                _descripcion = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("descripcion");
                OndescripcionChanged();
            }
        }
        private global::System.String _descripcion;
        partial void OndescripcionChanging(global::System.String value);
        partial void OndescripcionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String detalle
        {
            get
            {
                return _detalle;
            }
            set
            {
                OndetalleChanging(value);
                ReportPropertyChanging("detalle");
                _detalle = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("detalle");
                OndetalleChanged();
            }
        }
        private global::System.String _detalle;
        partial void OndetalleChanging(global::System.String value);
        partial void OndetalleChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("IndioMendoza2013Model", "BondiRicotero_Zona", "Zona")]
        public EntityCollection<Zona> Zona
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Zona>("IndioMendoza2013Model.BondiRicotero_Zona", "Zona");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Zona>("IndioMendoza2013Model.BondiRicotero_Zona", "Zona", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="IndioMendoza2013Model", Name="Contacto")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Contacto : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Contacto.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad id.</param>
        /// <param name="nombre">Valor inicial de la propiedad nombre.</param>
        /// <param name="contacto1">Valor inicial de la propiedad contacto1.</param>
        /// <param name="consulta">Valor inicial de la propiedad consulta.</param>
        /// <param name="leido">Valor inicial de la propiedad leido.</param>
        public static Contacto CreateContacto(global::System.Int32 id, global::System.String nombre, global::System.String contacto1, global::System.String consulta, global::System.Boolean leido)
        {
            Contacto contacto = new Contacto();
            contacto.id = id;
            contacto.nombre = nombre;
            contacto.contacto1 = contacto1;
            contacto.consulta = consulta;
            contacto.leido = leido;
            return contacto;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                OnnombreChanging(value);
                ReportPropertyChanging("nombre");
                _nombre = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("nombre");
                OnnombreChanged();
            }
        }
        private global::System.String _nombre;
        partial void OnnombreChanging(global::System.String value);
        partial void OnnombreChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String contacto1
        {
            get
            {
                return _contacto1;
            }
            set
            {
                Oncontacto1Changing(value);
                ReportPropertyChanging("contacto1");
                _contacto1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("contacto1");
                Oncontacto1Changed();
            }
        }
        private global::System.String _contacto1;
        partial void Oncontacto1Changing(global::System.String value);
        partial void Oncontacto1Changed();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String consulta
        {
            get
            {
                return _consulta;
            }
            set
            {
                OnconsultaChanging(value);
                ReportPropertyChanging("consulta");
                _consulta = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("consulta");
                OnconsultaChanged();
            }
        }
        private global::System.String _consulta;
        partial void OnconsultaChanging(global::System.String value);
        partial void OnconsultaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean leido
        {
            get
            {
                return _leido;
            }
            set
            {
                OnleidoChanging(value);
                ReportPropertyChanging("leido");
                _leido = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("leido");
                OnleidoChanged();
            }
        }
        private global::System.Boolean _leido;
        partial void OnleidoChanging(global::System.Boolean value);
        partial void OnleidoChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="IndioMendoza2013Model", Name="PosicionRicotera")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PosicionRicotera : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto PosicionRicotera.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad id.</param>
        /// <param name="nombre">Valor inicial de la propiedad nombre.</param>
        /// <param name="latitude">Valor inicial de la propiedad latitude.</param>
        /// <param name="longitude">Valor inicial de la propiedad longitude.</param>
        public static PosicionRicotera CreatePosicionRicotera(global::System.Int32 id, global::System.String nombre, global::System.Double latitude, global::System.Double longitude)
        {
            PosicionRicotera posicionRicotera = new PosicionRicotera();
            posicionRicotera.id = id;
            posicionRicotera.nombre = nombre;
            posicionRicotera.latitude = latitude;
            posicionRicotera.longitude = longitude;
            return posicionRicotera;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                OnnombreChanging(value);
                ReportPropertyChanging("nombre");
                _nombre = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("nombre");
                OnnombreChanged();
            }
        }
        private global::System.String _nombre;
        partial void OnnombreChanging(global::System.String value);
        partial void OnnombreChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double latitude
        {
            get
            {
                return _latitude;
            }
            set
            {
                OnlatitudeChanging(value);
                ReportPropertyChanging("latitude");
                _latitude = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("latitude");
                OnlatitudeChanged();
            }
        }
        private global::System.Double _latitude;
        partial void OnlatitudeChanging(global::System.Double value);
        partial void OnlatitudeChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double longitude
        {
            get
            {
                return _longitude;
            }
            set
            {
                OnlongitudeChanging(value);
                ReportPropertyChanging("longitude");
                _longitude = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("longitude");
                OnlongitudeChanged();
            }
        }
        private global::System.Double _longitude;
        partial void OnlongitudeChanging(global::System.Double value);
        partial void OnlongitudeChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String comentarios
        {
            get
            {
                return _comentarios;
            }
            set
            {
                OncomentariosChanging(value);
                ReportPropertyChanging("comentarios");
                _comentarios = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("comentarios");
                OncomentariosChanged();
            }
        }
        private global::System.String _comentarios;
        partial void OncomentariosChanging(global::System.String value);
        partial void OncomentariosChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ip
        {
            get
            {
                return _ip;
            }
            set
            {
                OnipChanging(value);
                ReportPropertyChanging("ip");
                _ip = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ip");
                OnipChanged();
            }
        }
        private global::System.String _ip;
        partial void OnipChanging(global::System.String value);
        partial void OnipChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="IndioMendoza2013Model", Name="Provincia")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Provincia : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Provincia.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad id.</param>
        /// <param name="descripcion">Valor inicial de la propiedad descripcion.</param>
        public static Provincia CreateProvincia(global::System.Int32 id, global::System.String descripcion)
        {
            Provincia provincia = new Provincia();
            provincia.id = id;
            provincia.descripcion = descripcion;
            return provincia;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                OndescripcionChanging(value);
                ReportPropertyChanging("descripcion");
                _descripcion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("descripcion");
                OndescripcionChanged();
            }
        }
        private global::System.String _descripcion;
        partial void OndescripcionChanging(global::System.String value);
        partial void OndescripcionChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("IndioMendoza2013Model", "FK_Zona_Provincia", "Zona")]
        public EntityCollection<Zona> Zona
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Zona>("IndioMendoza2013Model.FK_Zona_Provincia", "Zona");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Zona>("IndioMendoza2013Model.FK_Zona_Provincia", "Zona", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="IndioMendoza2013Model", Name="Zona")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Zona : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto Zona.
        /// </summary>
        /// <param name="id">Valor inicial de la propiedad id.</param>
        /// <param name="id_provincia">Valor inicial de la propiedad id_provincia.</param>
        /// <param name="descripcion">Valor inicial de la propiedad descripcion.</param>
        public static Zona CreateZona(global::System.Int32 id, global::System.Int32 id_provincia, global::System.String descripcion)
        {
            Zona zona = new Zona();
            zona.id = id;
            zona.id_provincia = id_provincia;
            zona.descripcion = descripcion;
            return zona;
        }

        #endregion
        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id_provincia
        {
            get
            {
                return _id_provincia;
            }
            set
            {
                Onid_provinciaChanging(value);
                ReportPropertyChanging("id_provincia");
                _id_provincia = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("id_provincia");
                Onid_provinciaChanged();
            }
        }
        private global::System.Int32 _id_provincia;
        partial void Onid_provinciaChanging(global::System.Int32 value);
        partial void Onid_provinciaChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                OndescripcionChanging(value);
                ReportPropertyChanging("descripcion");
                _descripcion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("descripcion");
                OndescripcionChanged();
            }
        }
        private global::System.String _descripcion;
        partial void OndescripcionChanging(global::System.String value);
        partial void OndescripcionChanged();

        #endregion
    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("IndioMendoza2013Model", "FK_Zona_Provincia", "Provincia")]
        public Provincia Provincia
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Provincia>("IndioMendoza2013Model.FK_Zona_Provincia", "Provincia").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Provincia>("IndioMendoza2013Model.FK_Zona_Provincia", "Provincia").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Provincia> ProvinciaReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Provincia>("IndioMendoza2013Model.FK_Zona_Provincia", "Provincia");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Provincia>("IndioMendoza2013Model.FK_Zona_Provincia", "Provincia", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("IndioMendoza2013Model", "BondiRicotero_Zona", "BondiRicotero")]
        public EntityCollection<BondiRicotero> BondiRicotero
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<BondiRicotero>("IndioMendoza2013Model.BondiRicotero_Zona", "BondiRicotero");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<BondiRicotero>("IndioMendoza2013Model.BondiRicotero_Zona", "BondiRicotero", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
