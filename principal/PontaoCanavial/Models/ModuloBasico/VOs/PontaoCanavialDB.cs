#region Auto-generated classes for PontaoCanavialDB database on 2010-02-03 19:51:24Z

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from PontaoCanavialDB on 2010-02-03 19:51:24Z
// Please visit http://linq.to/db for more information

#endregion

using System;
using System.Data;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Reflection;
#if MONO_STRICT
using System.Data.Linq;
#else   // MONO_STRICT
using DbLinq.Data.Linq;
using DbLinq.Vendor;
#endif  // MONO_STRICT
using System.ComponentModel;
using System.Data.Linq;



    public partial class PontaoCanavialDB : DbLinq.Data.Linq.DataContext
    {
        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion

        public PontaoCanavialDB(string connectionString)
            : base(connectionString)
        {
            OnCreated();
        }

        public PontaoCanavialDB(IDbConnection connection)
#if MONO_STRICT
		: base(connection)
#else   // MONO_STRICT
            : base(connection, new DbLinq.MySql.MySqlVendor())
#endif  // MONO_STRICT
        {
            OnCreated();
        }

        public PontaoCanavialDB(string connection, MappingSource mappingSource)
            : base(connection, mappingSource)
        {
            OnCreated();
        }

        public PontaoCanavialDB(IDbConnection connection, MappingSource mappingSource)
            : base(connection, mappingSource)
        {
            OnCreated();
        }

#if !MONO_STRICT
        public PontaoCanavialDB(IDbConnection connection, IVendor vendor)
            : base(connection, vendor)
        {
            OnCreated();
        }
#endif  // !MONO_STRICT

#if !MONO_STRICT
        public PontaoCanavialDB(IDbConnection connection, MappingSource mappingSource, IVendor vendor)
            : base(connection, mappingSource, vendor)
        {
            OnCreated();
        }
#endif  // !MONO_STRICT

        public DbLinq.Data.Linq.Table<Banner> Banner { get { return GetTable<Banner>(); } }
        public DbLinq.Data.Linq.Table<Categoria> Categoria { get { return GetTable<Categoria>(); } }
        public DbLinq.Data.Linq.Table<Evento> Evento { get { return GetTable<Evento>(); } }
        public DbLinq.Data.Linq.Table<Galeria> Galeria { get { return GetTable<Galeria>(); } }
        public DbLinq.Data.Linq.Table<Imagem> Imagem { get { return GetTable<Imagem>(); } }
        public DbLinq.Data.Linq.Table<Newsletter> Newsletter { get { return GetTable<Newsletter>(); } }
        public DbLinq.Data.Linq.Table<Noticia> Noticia { get { return GetTable<Noticia>(); } }
        public DbLinq.Data.Linq.Table<Personalization> Personalization { get { return GetTable<Personalization>(); } }
        public DbLinq.Data.Linq.Table<Ponto> Ponto { get { return GetTable<Ponto>(); } }
        public DbLinq.Data.Linq.Table<Produto> Produto { get { return GetTable<Produto>(); } }
        public DbLinq.Data.Linq.Table<Profiles> Profiles { get { return GetTable<Profiles>(); } }
        public DbLinq.Data.Linq.Table<Projeto> Projeto { get { return GetTable<Projeto>(); } }
        public DbLinq.Data.Linq.Table<Roles> Roles { get { return GetTable<Roles>(); } }
        public DbLinq.Data.Linq.Table<SiteMap> SiteMap { get { return GetTable<SiteMap>(); } }
        public DbLinq.Data.Linq.Table<Users> Users { get { return GetTable<Users>(); } }
        public DbLinq.Data.Linq.Table<UsersInRoles> UsersInRoles { get { return GetTable<UsersInRoles>(); } }
        public DbLinq.Data.Linq.Table<Usuario> Usuario { get { return GetTable<Usuario>(); } }
        public DbLinq.Data.Linq.Table<UsuarioPonto> UsuarioPonto { get { return GetTable<UsuarioPonto>(); } }
        public DbLinq.Data.Linq.Table<Video> Video { get { return GetTable<Video>(); } }

    }

    [Table(Name = "PontaoCanavialDB.banner")]
    public partial class Banner : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnCorpoChanged();
        partial void OnCorpoChanging(string value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnLocalizacaoChanged();
        partial void OnLocalizacaoChanging(int? value);
        partial void OnNomeChanged();
        partial void OnNomeChanging(string value);
        partial void OnPontoIDChanged();
        partial void OnPontoIDChanging(int value);
        partial void OnStatusBannerChanged();
        partial void OnStatusBannerChanging(int? value);
        partial void OnUsuarioIDChanged();
        partial void OnUsuarioIDChanging(int value);

        #endregion

        #region string Corpo

        private string _corpo;
        [DebuggerNonUserCode]
        [Column(Storage = "_corpo", Name = "Corpo", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Corpo
        {
            get
            {
                return _corpo;
            }
            set
            {
                if (value != _corpo)
                {
                    OnCorpoChanging(value);
                    SendPropertyChanging();
                    _corpo = value;
                    SendPropertyChanged("Corpo");
                    OnCorpoChanged();
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region int? Localizacao

        private int? _localizacao;
        [DebuggerNonUserCode]
        [Column(Storage = "_localizacao", Name = "Localizacao", DbType = "int", AutoSync = AutoSync.Never)]
        public int? Localizacao
        {
            get
            {
                return _localizacao;
            }
            set
            {
                if (value != _localizacao)
                {
                    OnLocalizacaoChanging(value);
                    SendPropertyChanging();
                    _localizacao = value;
                    SendPropertyChanged("Localizacao");
                    OnLocalizacaoChanged();
                }
            }
        }

        #endregion

        #region string Nome

        private string _nome;
        [DebuggerNonUserCode]
        [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != _nome)
                {
                    OnNomeChanging(value);
                    SendPropertyChanging();
                    _nome = value;
                    SendPropertyChanged("Nome");
                    OnNomeChanged();
                }
            }
        }

        #endregion

        #region int PontoID

        private int _pontoID;
        [DebuggerNonUserCode]
        [Column(Storage = "_pontoID", Name = "PontoID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int PontoID
        {
            get
            {
                return _pontoID;
            }
            set
            {
                if (value != _pontoID)
                {
                    if (_poNto.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnPontoIDChanging(value);
                    SendPropertyChanging();
                    _pontoID = value;
                    SendPropertyChanged("PontoID");
                    OnPontoIDChanged();
                }
            }
        }

        #endregion

        #region int? StatusBanner

        private int? _statusBanner;
        [DebuggerNonUserCode]
        [Column(Storage = "_statusBanner", Name = "StatusBanner", DbType = "int", AutoSync = AutoSync.Never)]
        public int? StatusBanner
        {
            get
            {
                return _statusBanner;
            }
            set
            {
                if (value != _statusBanner)
                {
                    OnStatusBannerChanging(value);
                    SendPropertyChanging();
                    _statusBanner = value;
                    SendPropertyChanged("StatusBanner");
                    OnStatusBannerChanged();
                }
            }
        }

        #endregion

        #region int UsuarioID

        private int _usuarioID;
        [DebuggerNonUserCode]
        [Column(Storage = "_usuarioID", Name = "UsuarioID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int UsuarioID
        {
            get
            {
                return _usuarioID;
            }
            set
            {
                if (value != _usuarioID)
                {
                    if (_usUarIo.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnUsuarioIDChanging(value);
                    SendPropertyChanging();
                    _usuarioID = value;
                    SendPropertyChanged("UsuarioID");
                    OnUsuarioIDChanged();
                }
            }
        }

        #endregion

        #region Parents

        private DbLinq.Data.Linq.EntityRef<Ponto> _poNto;
        [Association(Storage = "_poNto", OtherKey = "ID", ThisKey = "PontoID", Name = "fk_Banner_Ponto1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Ponto Ponto
        {
            get
            {
                return _poNto.Entity;
            }
            set
            {
                if (value != _poNto.Entity)
                {
                    if (_poNto.Entity != null)
                    {
                        var previousPonto = _poNto.Entity;
                        _poNto.Entity = null;
                        previousPonto.Banner.Remove(this);
                    }
                    _poNto.Entity = value;
                    if (value != null)
                    {
                        value.Banner.Add(this);
                        _pontoID = value.ID;
                    }
                    else
                    {
                        _pontoID = default(int);
                    }
                }
            }
        }

        private DbLinq.Data.Linq.EntityRef<Usuario> _usUarIo;
        [Association(Storage = "_usUarIo", OtherKey = "ID", ThisKey = "UsuarioID", Name = "fk_Banner_Usuario1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Usuario Usuario
        {
            get
            {
                return _usUarIo.Entity;
            }
            set
            {
                if (value != _usUarIo.Entity)
                {
                    if (_usUarIo.Entity != null)
                    {
                        var previousUsuario = _usUarIo.Entity;
                        _usUarIo.Entity = null;
                        previousUsuario.Banner.Remove(this);
                    }
                    _usUarIo.Entity = value;
                    if (value != null)
                    {
                        value.Banner.Add(this);
                        _usuarioID = value.ID;
                    }
                    else
                    {
                        _usuarioID = default(int);
                    }
                }
            }
        }


        #endregion

        #region ctor

        public Banner()
        {
            _poNto = new DbLinq.Data.Linq.EntityRef<Ponto>();
            _usUarIo = new DbLinq.Data.Linq.EntityRef<Usuario>();
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.categoria")]
    public partial class Categoria : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnDescricaoChanged();
        partial void OnDescricaoChanging(string value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);

        #endregion

        #region string Descricao

        private string _descricao;
        [DebuggerNonUserCode]
        [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
        public string Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                if (value != _descricao)
                {
                    OnDescricaoChanging(value);
                    SendPropertyChanging();
                    _descricao = value;
                    SendPropertyChanged("Descricao");
                    OnDescricaoChanged();
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region Children

        private DbLinq.Data.Linq.EntitySet<Produto> _prodUtO;
        [Association(Storage = "_prodUtO", OtherKey = "CategoriaID", ThisKey = "ID", Name = "fk_Produto_Categoria1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Produto> Produto
        {
            get
            {
                return _prodUtO;
            }
            set
            {
                _prodUtO = value;
            }
        }


        #endregion

        #region Attachement handlers

        private void Produto_Attach(Produto entity)
        {
            entity.Categoria = this;
        }

        private void Produto_Detach(Produto entity)
        {
            entity.Categoria = null;
        }


        #endregion

        #region ctor

        public Categoria()
        {
            _prodUtO = new DbLinq.Data.Linq.EntitySet<Produto>(Produto_Attach, Produto_Detach);
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.evento")]
    public partial class Evento : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnDataEventoChanged();
        partial void OnDataEventoChanging(DateTime? value);
        partial void OnDescricaoChanged();
        partial void OnDescricaoChanging(string value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnImagemGrandeChanged();
        partial void OnImagemGrandeChanging(Byte[] value);
        partial void OnImagemMediaChanged();
        partial void OnImagemMediaChanging(Byte[] value);
        partial void OnImagemPequenaChanged();
        partial void OnImagemPequenaChanging(Byte[] value);
        partial void OnNomeChanged();
        partial void OnNomeChanging(string value);
        partial void OnPontoIDChanged();
        partial void OnPontoIDChanging(int value);
        partial void OnUsuarioPontoIDChanged();
        partial void OnUsuarioPontoIDChanging(int value);

        #endregion

        #region DateTime? DataEvento

        private DateTime? _dataEvento;
        [DebuggerNonUserCode]
        [Column(Storage = "_dataEvento", Name = "DataEvento", DbType = "datetime", AutoSync = AutoSync.Never)]
        public DateTime? DataEvento
        {
            get
            {
                return _dataEvento;
            }
            set
            {
                if (value != _dataEvento)
                {
                    OnDataEventoChanging(value);
                    SendPropertyChanging();
                    _dataEvento = value;
                    SendPropertyChanged("DataEvento");
                    OnDataEventoChanged();
                }
            }
        }

        #endregion

        #region string Descricao

        private string _descricao;
        [DebuggerNonUserCode]
        [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                if (value != _descricao)
                {
                    OnDescricaoChanging(value);
                    SendPropertyChanging();
                    _descricao = value;
                    SendPropertyChanged("Descricao");
                    OnDescricaoChanged();
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemGrande

        private Byte[] _imagemGrande;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemGrande", Name = "ImagemGrande", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemGrande
        {
            get
            {
                return _imagemGrande;
            }
            set
            {
                if (value != _imagemGrande)
                {
                    OnImagemGrandeChanging(value);
                    SendPropertyChanging();
                    _imagemGrande = value;
                    SendPropertyChanged("ImagemGrande");
                    OnImagemGrandeChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemMedia

        private Byte[] _imagemMedia;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemMedia", Name = "ImagemMedia", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemMedia
        {
            get
            {
                return _imagemMedia;
            }
            set
            {
                if (value != _imagemMedia)
                {
                    OnImagemMediaChanging(value);
                    SendPropertyChanging();
                    _imagemMedia = value;
                    SendPropertyChanged("ImagemMedia");
                    OnImagemMediaChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemPequena

        private Byte[] _imagemPequena;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemPequena", Name = "ImagemPequena", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemPequena
        {
            get
            {
                return _imagemPequena;
            }
            set
            {
                if (value != _imagemPequena)
                {
                    OnImagemPequenaChanging(value);
                    SendPropertyChanging();
                    _imagemPequena = value;
                    SendPropertyChanged("ImagemPequena");
                    OnImagemPequenaChanged();
                }
            }
        }

        #endregion

        #region string Nome

        private string _nome;
        [DebuggerNonUserCode]
        [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != _nome)
                {
                    OnNomeChanging(value);
                    SendPropertyChanging();
                    _nome = value;
                    SendPropertyChanged("Nome");
                    OnNomeChanged();
                }
            }
        }

        #endregion

        #region int PontoID

        private int _pontoID;
        [DebuggerNonUserCode]
        [Column(Storage = "_pontoID", Name = "PontoID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int PontoID
        {
            get
            {
                return _pontoID;
            }
            set
            {
                if (value != _pontoID)
                {
                    if (_poNto.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnPontoIDChanging(value);
                    SendPropertyChanging();
                    _pontoID = value;
                    SendPropertyChanged("PontoID");
                    OnPontoIDChanged();
                }
            }
        }

        #endregion

        #region int UsuarioPontoID

        private int _usuarioPontoID;
        [DebuggerNonUserCode]
        [Column(Storage = "_usuarioPontoID", Name = "UsuarioPontoID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int UsuarioPontoID
        {
            get
            {
                return _usuarioPontoID;
            }
            set
            {
                if (value != _usuarioPontoID)
                {
                    if (_usUarIoPoNto.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnUsuarioPontoIDChanging(value);
                    SendPropertyChanging();
                    _usuarioPontoID = value;
                    SendPropertyChanged("UsuarioPontoID");
                    OnUsuarioPontoIDChanged();
                }
            }
        }

        #endregion

        #region Parents

        private DbLinq.Data.Linq.EntityRef<Ponto> _poNto;
        [Association(Storage = "_poNto", OtherKey = "ID", ThisKey = "PontoID", Name = "fk_Evento_Ponto1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Ponto Ponto
        {
            get
            {
                return _poNto.Entity;
            }
            set
            {
                if (value != _poNto.Entity)
                {
                    if (_poNto.Entity != null)
                    {
                        var previousPonto = _poNto.Entity;
                        _poNto.Entity = null;
                        previousPonto.Evento.Remove(this);
                    }
                    _poNto.Entity = value;
                    if (value != null)
                    {
                        value.Evento.Add(this);
                        _pontoID = value.ID;
                    }
                    else
                    {
                        _pontoID = default(int);
                    }
                }
            }
        }

        private DbLinq.Data.Linq.EntityRef<UsuarioPonto> _usUarIoPoNto;
        [Association(Storage = "_usUarIoPoNto", OtherKey = "ID", ThisKey = "UsuarioPontoID", Name = "fk_Evento_UsuarioPonto1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public UsuarioPonto UsuarioPonto
        {
            get
            {
                return _usUarIoPoNto.Entity;
            }
            set
            {
                if (value != _usUarIoPoNto.Entity)
                {
                    if (_usUarIoPoNto.Entity != null)
                    {
                        var previousUsuarioPonto = _usUarIoPoNto.Entity;
                        _usUarIoPoNto.Entity = null;
                        previousUsuarioPonto.Evento.Remove(this);
                    }
                    _usUarIoPoNto.Entity = value;
                    if (value != null)
                    {
                        value.Evento.Add(this);
                        _usuarioPontoID = value.ID;
                    }
                    else
                    {
                        _usuarioPontoID = default(int);
                    }
                }
            }
        }


        #endregion

        #region ctor

        public Evento()
        {
            _poNto = new DbLinq.Data.Linq.EntityRef<Ponto>();
            _usUarIoPoNto = new DbLinq.Data.Linq.EntityRef<UsuarioPonto>();
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.galeria")]
    public partial class Galeria : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnDescricaoChanged();
        partial void OnDescricaoChanging(string value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnImagemGrandeChanged();
        partial void OnImagemGrandeChanging(Byte[] value);
        partial void OnImagemMediaChanged();
        partial void OnImagemMediaChanging(Byte[] value);
        partial void OnImagemPequenaChanged();
        partial void OnImagemPequenaChanging(Byte[] value);
        partial void OnNomeChanged();
        partial void OnNomeChanging(string value);
        partial void OnPontoIDChanged();
        partial void OnPontoIDChanging(int value);
        partial void OnUsuarioIDChanged();
        partial void OnUsuarioIDChanging(int value);

        #endregion

        #region string Descricao

        private string _descricao;
        [DebuggerNonUserCode]
        [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                if (value != _descricao)
                {
                    OnDescricaoChanging(value);
                    SendPropertyChanging();
                    _descricao = value;
                    SendPropertyChanged("Descricao");
                    OnDescricaoChanged();
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemGrande

        private Byte[] _imagemGrande;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemGrande", Name = "ImagemGrande", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemGrande
        {
            get
            {
                return _imagemGrande;
            }
            set
            {
                if (value != _imagemGrande)
                {
                    OnImagemGrandeChanging(value);
                    SendPropertyChanging();
                    _imagemGrande = value;
                    SendPropertyChanged("ImagemGrande");
                    OnImagemGrandeChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemMedia

        private Byte[] _imagemMedia;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemMedia", Name = "ImagemMedia", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemMedia
        {
            get
            {
                return _imagemMedia;
            }
            set
            {
                if (value != _imagemMedia)
                {
                    OnImagemMediaChanging(value);
                    SendPropertyChanging();
                    _imagemMedia = value;
                    SendPropertyChanged("ImagemMedia");
                    OnImagemMediaChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemPequena

        private Byte[] _imagemPequena;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemPequena", Name = "ImagemPequena", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemPequena
        {
            get
            {
                return _imagemPequena;
            }
            set
            {
                if (value != _imagemPequena)
                {
                    OnImagemPequenaChanging(value);
                    SendPropertyChanging();
                    _imagemPequena = value;
                    SendPropertyChanged("ImagemPequena");
                    OnImagemPequenaChanged();
                }
            }
        }

        #endregion

        #region string Nome

        private string _nome;
        [DebuggerNonUserCode]
        [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != _nome)
                {
                    OnNomeChanging(value);
                    SendPropertyChanging();
                    _nome = value;
                    SendPropertyChanged("Nome");
                    OnNomeChanged();
                }
            }
        }

        #endregion

        #region int PontoID

        private int _pontoID;
        [DebuggerNonUserCode]
        [Column(Storage = "_pontoID", Name = "PontoID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int PontoID
        {
            get
            {
                return _pontoID;
            }
            set
            {
                if (value != _pontoID)
                {
                    if (_poNto.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnPontoIDChanging(value);
                    SendPropertyChanging();
                    _pontoID = value;
                    SendPropertyChanged("PontoID");
                    OnPontoIDChanged();
                }
            }
        }

        #endregion

        #region int UsuarioID

        private int _usuarioID;
        [DebuggerNonUserCode]
        [Column(Storage = "_usuarioID", Name = "UsuarioID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int UsuarioID
        {
            get
            {
                return _usuarioID;
            }
            set
            {
                if (value != _usuarioID)
                {
                    if (_usUarIo.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnUsuarioIDChanging(value);
                    SendPropertyChanging();
                    _usuarioID = value;
                    SendPropertyChanged("UsuarioID");
                    OnUsuarioIDChanged();
                }
            }
        }

        #endregion

        #region Children

        private DbLinq.Data.Linq.EntitySet<Imagem> _imageM;
        [Association(Storage = "_imageM", OtherKey = "GaleriaID", ThisKey = "ID", Name = "fk_Imagem_Galeria1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Imagem> Imagem
        {
            get
            {
                return _imageM;
            }
            set
            {
                _imageM = value;
            }
        }


        #endregion

        #region Parents

        private DbLinq.Data.Linq.EntityRef<Ponto> _poNto;
        [Association(Storage = "_poNto", OtherKey = "ID", ThisKey = "PontoID", Name = "fk_Galeria_Ponto1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Ponto Ponto
        {
            get
            {
                return _poNto.Entity;
            }
            set
            {
                if (value != _poNto.Entity)
                {
                    if (_poNto.Entity != null)
                    {
                        var previousPonto = _poNto.Entity;
                        _poNto.Entity = null;
                        previousPonto.Galeria.Remove(this);
                    }
                    _poNto.Entity = value;
                    if (value != null)
                    {
                        value.Galeria.Add(this);
                        _pontoID = value.ID;
                    }
                    else
                    {
                        _pontoID = default(int);
                    }
                }
            }
        }

        private DbLinq.Data.Linq.EntityRef<Usuario> _usUarIo;
        [Association(Storage = "_usUarIo", OtherKey = "ID", ThisKey = "UsuarioID", Name = "fk_Galeria_Usuario1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Usuario Usuario
        {
            get
            {
                return _usUarIo.Entity;
            }
            set
            {
                if (value != _usUarIo.Entity)
                {
                    if (_usUarIo.Entity != null)
                    {
                        var previousUsuario = _usUarIo.Entity;
                        _usUarIo.Entity = null;
                        previousUsuario.Galeria.Remove(this);
                    }
                    _usUarIo.Entity = value;
                    if (value != null)
                    {
                        value.Galeria.Add(this);
                        _usuarioID = value.ID;
                    }
                    else
                    {
                        _usuarioID = default(int);
                    }
                }
            }
        }


        #endregion

        #region Attachement handlers

        private void Imagem_Attach(Imagem entity)
        {
            entity.Galeria = this;
        }

        private void Imagem_Detach(Imagem entity)
        {
            entity.Galeria = null;
        }


        #endregion

        #region ctor

        public Galeria()
        {
            _imageM = new DbLinq.Data.Linq.EntitySet<Imagem>(Imagem_Attach, Imagem_Detach);
            _poNto = new DbLinq.Data.Linq.EntityRef<Ponto>();
            _usUarIo = new DbLinq.Data.Linq.EntityRef<Usuario>();
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.imagem")]
    public partial class Imagem : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnDescricaoChanged();
        partial void OnDescricaoChanging(string value);
        partial void OnGaleriaIDChanged();
        partial void OnGaleriaIDChanging(int value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnImagemGrandeChanged();
        partial void OnImagemGrandeChanging(Byte[] value);
        partial void OnImagemMediaChanged();
        partial void OnImagemMediaChanging(Byte[] value);
        partial void OnImagemPequenaChanged();
        partial void OnImagemPequenaChanging(Byte[] value);
        partial void OnNomeChanged();
        partial void OnNomeChanging(string value);
        partial void OnUsuarioIDChanged();
        partial void OnUsuarioIDChanging(int value);

        #endregion

        #region string Descricao

        private string _descricao;
        [DebuggerNonUserCode]
        [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
        public string Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                if (value != _descricao)
                {
                    OnDescricaoChanging(value);
                    SendPropertyChanging();
                    _descricao = value;
                    SendPropertyChanged("Descricao");
                    OnDescricaoChanged();
                }
            }
        }

        #endregion

        #region int GaleriaID

        private int _galeriaID;
        [DebuggerNonUserCode]
        [Column(Storage = "_galeriaID", Name = "GaleriaID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int GaleriaID
        {
            get
            {
                return _galeriaID;
            }
            set
            {
                if (value != _galeriaID)
                {
                    if (_galeRiA.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnGaleriaIDChanging(value);
                    SendPropertyChanging();
                    _galeriaID = value;
                    SendPropertyChanged("GaleriaID");
                    OnGaleriaIDChanged();
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemGrande

        private Byte[] _imagemGrande;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemGrande", Name = "ImagemGrande", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemGrande
        {
            get
            {
                return _imagemGrande;
            }
            set
            {
                if (value != _imagemGrande)
                {
                    OnImagemGrandeChanging(value);
                    SendPropertyChanging();
                    _imagemGrande = value;
                    SendPropertyChanged("ImagemGrande");
                    OnImagemGrandeChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemMedia

        private Byte[] _imagemMedia;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemMedia", Name = "ImagemMedia", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemMedia
        {
            get
            {
                return _imagemMedia;
            }
            set
            {
                if (value != _imagemMedia)
                {
                    OnImagemMediaChanging(value);
                    SendPropertyChanging();
                    _imagemMedia = value;
                    SendPropertyChanged("ImagemMedia");
                    OnImagemMediaChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemPequena

        private Byte[] _imagemPequena;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemPequena", Name = "ImagemPequena", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemPequena
        {
            get
            {
                return _imagemPequena;
            }
            set
            {
                if (value != _imagemPequena)
                {
                    OnImagemPequenaChanging(value);
                    SendPropertyChanging();
                    _imagemPequena = value;
                    SendPropertyChanged("ImagemPequena");
                    OnImagemPequenaChanged();
                }
            }
        }

        #endregion

        #region string Nome

        private string _nome;
        [DebuggerNonUserCode]
        [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != _nome)
                {
                    OnNomeChanging(value);
                    SendPropertyChanging();
                    _nome = value;
                    SendPropertyChanged("Nome");
                    OnNomeChanged();
                }
            }
        }

        #endregion

        #region int UsuarioID

        private int _usuarioID;
        [DebuggerNonUserCode]
        [Column(Storage = "_usuarioID", Name = "UsuarioID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int UsuarioID
        {
            get
            {
                return _usuarioID;
            }
            set
            {
                if (value != _usuarioID)
                {
                    if (_usUarIo.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnUsuarioIDChanging(value);
                    SendPropertyChanging();
                    _usuarioID = value;
                    SendPropertyChanged("UsuarioID");
                    OnUsuarioIDChanged();
                }
            }
        }

        #endregion

        #region Parents

        private DbLinq.Data.Linq.EntityRef<Galeria> _galeRiA;
        [Association(Storage = "_galeRiA", OtherKey = "ID", ThisKey = "GaleriaID", Name = "fk_Imagem_Galeria1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Galeria Galeria
        {
            get
            {
                return _galeRiA.Entity;
            }
            set
            {
                if (value != _galeRiA.Entity)
                {
                    if (_galeRiA.Entity != null)
                    {
                        var previousGaleria = _galeRiA.Entity;
                        _galeRiA.Entity = null;
                        previousGaleria.Imagem.Remove(this);
                    }
                    _galeRiA.Entity = value;
                    if (value != null)
                    {
                        value.Imagem.Add(this);
                        _galeriaID = value.ID;
                    }
                    else
                    {
                        _galeriaID = default(int);
                    }
                }
            }
        }

        private DbLinq.Data.Linq.EntityRef<Usuario> _usUarIo;
        [Association(Storage = "_usUarIo", OtherKey = "ID", ThisKey = "UsuarioID", Name = "fk_Imagem_Usuario1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Usuario Usuario
        {
            get
            {
                return _usUarIo.Entity;
            }
            set
            {
                if (value != _usUarIo.Entity)
                {
                    if (_usUarIo.Entity != null)
                    {
                        var previousUsuario = _usUarIo.Entity;
                        _usUarIo.Entity = null;
                        previousUsuario.Imagem.Remove(this);
                    }
                    _usUarIo.Entity = value;
                    if (value != null)
                    {
                        value.Imagem.Add(this);
                        _usuarioID = value.ID;
                    }
                    else
                    {
                        _usuarioID = default(int);
                    }
                }
            }
        }


        #endregion

        #region ctor

        public Imagem()
        {
            _galeRiA = new DbLinq.Data.Linq.EntityRef<Galeria>();
            _usUarIo = new DbLinq.Data.Linq.EntityRef<Usuario>();
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.newsletter")]
    public partial class Newsletter : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnEmailChanged();
        partial void OnEmailChanging(string value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnPontoIDChanged();
        partial void OnPontoIDChanging(int value);

        #endregion

        #region string Email

        private string _email;
        [DebuggerNonUserCode]
        [Column(Storage = "_email", Name = "Email", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value != _email)
                {
                    OnEmailChanging(value);
                    SendPropertyChanging();
                    _email = value;
                    SendPropertyChanged("Email");
                    OnEmailChanged();
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region int PontoID

        private int _pontoID;
        [DebuggerNonUserCode]
        [Column(Storage = "_pontoID", Name = "PontoID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int PontoID
        {
            get
            {
                return _pontoID;
            }
            set
            {
                if (value != _pontoID)
                {
                    if (_poNto.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnPontoIDChanging(value);
                    SendPropertyChanging();
                    _pontoID = value;
                    SendPropertyChanged("PontoID");
                    OnPontoIDChanged();
                }
            }
        }

        #endregion

        #region Parents

        private DbLinq.Data.Linq.EntityRef<Ponto> _poNto;
        [Association(Storage = "_poNto", OtherKey = "ID", ThisKey = "PontoID", Name = "fk_NewsLetter_Ponto1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Ponto Ponto
        {
            get
            {
                return _poNto.Entity;
            }
            set
            {
                if (value != _poNto.Entity)
                {
                    if (_poNto.Entity != null)
                    {
                        var previousPonto = _poNto.Entity;
                        _poNto.Entity = null;
                        previousPonto.Newsletter.Remove(this);
                    }
                    _poNto.Entity = value;
                    if (value != null)
                    {
                        value.Newsletter.Add(this);
                        _pontoID = value.ID;
                    }
                    else
                    {
                        _pontoID = default(int);
                    }
                }
            }
        }


        #endregion

        #region ctor

        public Newsletter()
        {
            _poNto = new DbLinq.Data.Linq.EntityRef<Ponto>();
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.noticia")]
    public partial class Noticia : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnCorpoChanged();
        partial void OnCorpoChanging(string value);
        partial void OnDataCriacaoChanged();
        partial void OnDataCriacaoChanging(DateTime? value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnImagemGrandeChanged();
        partial void OnImagemGrandeChanging(Byte[] value);
        partial void OnImagemMediaChanged();
        partial void OnImagemMediaChanging(Byte[] value);
        partial void OnImagemPequenaChanged();
        partial void OnImagemPequenaChanging(Byte[] value);
        partial void OnPontoIDChanged();
        partial void OnPontoIDChanging(int value);
        partial void OnPreviewChanged();
        partial void OnPreviewChanging(string value);
        partial void OnTituloChanged();
        partial void OnTituloChanging(string value);
        partial void OnUsuarioIDChanged();
        partial void OnUsuarioIDChanging(int value);

        #endregion

        #region string Corpo

        private string _corpo;
        [DebuggerNonUserCode]
        [Column(Storage = "_corpo", Name = "Corpo", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Corpo
        {
            get
            {
                return _corpo;
            }
            set
            {
                if (value != _corpo)
                {
                    OnCorpoChanging(value);
                    SendPropertyChanging();
                    _corpo = value;
                    SendPropertyChanged("Corpo");
                    OnCorpoChanged();
                }
            }
        }

        #endregion

        #region DateTime? DataCriacao

        private DateTime? _dataCriacao;
        [DebuggerNonUserCode]
        [Column(Storage = "_dataCriacao", Name = "DataCriacao", DbType = "datetime", AutoSync = AutoSync.Never)]
        public DateTime? DataCriacao
        {
            get
            {
                return _dataCriacao;
            }
            set
            {
                if (value != _dataCriacao)
                {
                    OnDataCriacaoChanging(value);
                    SendPropertyChanging();
                    _dataCriacao = value;
                    SendPropertyChanged("DataCriacao");
                    OnDataCriacaoChanged();
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemGrande

        private Byte[] _imagemGrande;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemGrande", Name = "ImagemGrande", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemGrande
        {
            get
            {
                return _imagemGrande;
            }
            set
            {
                if (value != _imagemGrande)
                {
                    OnImagemGrandeChanging(value);
                    SendPropertyChanging();
                    _imagemGrande = value;
                    SendPropertyChanged("ImagemGrande");
                    OnImagemGrandeChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemMedia

        private Byte[] _imagemMedia;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemMedia", Name = "ImagemMedia", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemMedia
        {
            get
            {
                return _imagemMedia;
            }
            set
            {
                if (value != _imagemMedia)
                {
                    OnImagemMediaChanging(value);
                    SendPropertyChanging();
                    _imagemMedia = value;
                    SendPropertyChanged("ImagemMedia");
                    OnImagemMediaChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemPequena

        private Byte[] _imagemPequena;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemPequena", Name = "ImagemPequena", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemPequena
        {
            get
            {
                return _imagemPequena;
            }
            set
            {
                if (value != _imagemPequena)
                {
                    OnImagemPequenaChanging(value);
                    SendPropertyChanging();
                    _imagemPequena = value;
                    SendPropertyChanged("ImagemPequena");
                    OnImagemPequenaChanged();
                }
            }
        }

        #endregion

        #region int PontoID

        private int _pontoID;
        [DebuggerNonUserCode]
        [Column(Storage = "_pontoID", Name = "PontoID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int PontoID
        {
            get
            {
                return _pontoID;
            }
            set
            {
                if (value != _pontoID)
                {
                    if (_poNto.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnPontoIDChanging(value);
                    SendPropertyChanging();
                    _pontoID = value;
                    SendPropertyChanged("PontoID");
                    OnPontoIDChanged();
                }
            }
        }

        #endregion

        #region string Preview

        private string _preview;
        [DebuggerNonUserCode]
        [Column(Storage = "_preview", Name = "Preview", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Preview
        {
            get
            {
                return _preview;
            }
            set
            {
                if (value != _preview)
                {
                    OnPreviewChanging(value);
                    SendPropertyChanging();
                    _preview = value;
                    SendPropertyChanged("Preview");
                    OnPreviewChanged();
                }
            }
        }

        #endregion

        #region string Titulo

        private string _titulo;
        [DebuggerNonUserCode]
        [Column(Storage = "_titulo", Name = "Titulo", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Titulo
        {
            get
            {
                return _titulo;
            }
            set
            {
                if (value != _titulo)
                {
                    OnTituloChanging(value);
                    SendPropertyChanging();
                    _titulo = value;
                    SendPropertyChanged("Titulo");
                    OnTituloChanged();
                }
            }
        }

        #endregion

        #region int UsuarioID

        private int _usuarioID;
        [DebuggerNonUserCode]
        [Column(Storage = "_usuarioID", Name = "UsuarioID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int UsuarioID
        {
            get
            {
                return _usuarioID;
            }
            set
            {
                if (value != _usuarioID)
                {
                    if (_usUarIo.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnUsuarioIDChanging(value);
                    SendPropertyChanging();
                    _usuarioID = value;
                    SendPropertyChanged("UsuarioID");
                    OnUsuarioIDChanged();
                }
            }
        }

        #endregion

        #region Parents

        private DbLinq.Data.Linq.EntityRef<Ponto> _poNto;
        [Association(Storage = "_poNto", OtherKey = "ID", ThisKey = "PontoID", Name = "fk_Noticia_Ponto1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Ponto Ponto
        {
            get
            {
                return _poNto.Entity;
            }
            set
            {
                if (value != _poNto.Entity)
                {
                    if (_poNto.Entity != null)
                    {
                        var previousPonto = _poNto.Entity;
                        _poNto.Entity = null;
                        previousPonto.Noticia.Remove(this);
                    }
                    _poNto.Entity = value;
                    if (value != null)
                    {
                        value.Noticia.Add(this);
                        _pontoID = value.ID;
                    }
                    else
                    {
                        _pontoID = default(int);
                    }
                }
            }
        }

        private DbLinq.Data.Linq.EntityRef<Usuario> _usUarIo;
        [Association(Storage = "_usUarIo", OtherKey = "ID", ThisKey = "UsuarioID", Name = "fk_Noticia_Usuario1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Usuario Usuario
        {
            get
            {
                return _usUarIo.Entity;
            }
            set
            {
                if (value != _usUarIo.Entity)
                {
                    if (_usUarIo.Entity != null)
                    {
                        var previousUsuario = _usUarIo.Entity;
                        _usUarIo.Entity = null;
                        previousUsuario.Noticia.Remove(this);
                    }
                    _usUarIo.Entity = value;
                    if (value != null)
                    {
                        value.Noticia.Add(this);
                        _usuarioID = value.ID;
                    }
                    else
                    {
                        _usuarioID = default(int);
                    }
                }
            }
        }


        #endregion

        #region ctor

        public Noticia()
        {
            _poNto = new DbLinq.Data.Linq.EntityRef<Ponto>();
            _usUarIo = new DbLinq.Data.Linq.EntityRef<Usuario>();
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.personalization")]
    public partial class Personalization : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnApplicationNameChanged();
        partial void OnApplicationNameChanging(string value);
        partial void OnPathChanged();
        partial void OnPathChanging(string value);
        partial void OnPerSonALizAtIonBlobChanged();
        partial void OnPerSonALizAtIonBlobChanging(Byte[] value);
        partial void OnUserNameChanged();
        partial void OnUserNameChanging(string value);

        #endregion

        #region string ApplicationName

        private string _applicationName;
        [DebuggerNonUserCode]
        [Column(Storage = "_applicationName", Name = "applicationname", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
        public string ApplicationName
        {
            get
            {
                return _applicationName;
            }
            set
            {
                if (value != _applicationName)
                {
                    OnApplicationNameChanging(value);
                    SendPropertyChanging();
                    _applicationName = value;
                    SendPropertyChanged("ApplicationName");
                    OnApplicationNameChanged();
                }
            }
        }

        #endregion

        #region string Path

        private string _path;
        [DebuggerNonUserCode]
        [Column(Storage = "_path", Name = "path", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                if (value != _path)
                {
                    OnPathChanging(value);
                    SendPropertyChanging();
                    _path = value;
                    SendPropertyChanged("Path");
                    OnPathChanged();
                }
            }
        }

        #endregion

        #region Byte[] PerSonALizAtIonBlob

        private Byte[] _perSonAlIzAtIonBlob;
        [DebuggerNonUserCode]
        [Column(Storage = "_perSonAlIzAtIonBlob", Name = "personalizationblob", DbType = "blob", AutoSync = AutoSync.Never)]
        public Byte[] PerSonALizAtIonBlob
        {
            get
            {
                return _perSonAlIzAtIonBlob;
            }
            set
            {
                if (value != _perSonAlIzAtIonBlob)
                {
                    OnPerSonALizAtIonBlobChanging(value);
                    SendPropertyChanging();
                    _perSonAlIzAtIonBlob = value;
                    SendPropertyChanged("PerSonALizAtIonBlob");
                    OnPerSonALizAtIonBlobChanged();
                }
            }
        }

        #endregion

        #region string UserName

        private string _userName;
        [DebuggerNonUserCode]
        [Column(Storage = "_userName", Name = "username", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (value != _userName)
                {
                    OnUserNameChanging(value);
                    SendPropertyChanging();
                    _userName = value;
                    SendPropertyChanged("UserName");
                    OnUserNameChanged();
                }
            }
        }

        #endregion

        #region ctor

        public Personalization()
        {
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.ponto")]
    public partial class Ponto : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnValidate(ChangeAction action);
        partial void OnApresentacaoChanged();
        partial void OnApresentacaoChanging(string value);
        partial void OnCabecalhoChanged();
        partial void OnCabecalhoChanging(Byte[] value);
        partial void OnContatoChanged();
        partial void OnContatoChanging(string value);
        partial void OnEPontaoChanged();
        partial void OnEPontaoChanging(sbyte? value);
        partial void OnEquipeChanged();
        partial void OnEquipeChanging(string value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnImagemGrandeChanged();
        partial void OnImagemGrandeChanging(Byte[] value);
        partial void OnImagemMediaChanged();
        partial void OnImagemMediaChanging(Byte[] value);
        partial void OnImagemPequenaChanged();
        partial void OnImagemPequenaChanging(Byte[] value);
        partial void OnJustificativaChanged();
        partial void OnJustificativaChanging(string value);
        partial void OnLogoChanged();
        partial void OnLogoChanging(Byte[] value);
        partial void OnNomeChanged();
        partial void OnNomeChanging(string value);
        partial void OnNomeIdentificadorChanged();
        partial void OnNomeIdentificadorChanging(string value);
        partial void OnObjetivoChanged();
        partial void OnObjetivoChanging(string value);

        #endregion

        #region string Apresentacao

        private string _apresentacao;
        [DebuggerNonUserCode]
        [Column(Storage = "_apresentacao", Name = "Apresentacao", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Apresentacao
        {
            get
            {
                return _apresentacao;
            }
            set
            {
                if (value != _apresentacao)
                {
                    OnApresentacaoChanging(value);
                    SendPropertyChanging();
                    _apresentacao = value;
                    SendPropertyChanged("Apresentacao");
                    OnApresentacaoChanged();
                }
            }
        }

        #endregion

        #region Byte[] Cabecalho

        private Byte[] _cabecalho;
        [DebuggerNonUserCode]
        [Column(Storage = "_cabecalho", Name = "Cabecalho", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] Cabecalho
        {
            get
            {
                return _cabecalho;
            }
            set
            {
                if (value != _cabecalho)
                {
                    OnCabecalhoChanging(value);
                    SendPropertyChanging();
                    _cabecalho = value;
                    SendPropertyChanged("Cabecalho");
                    OnCabecalhoChanged();
                }
            }
        }

        #endregion

        #region string Contato

        private string _contato;
        [DebuggerNonUserCode]
        [Column(Storage = "_contato", Name = "Contato", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Contato
        {
            get
            {
                return _contato;
            }
            set
            {
                if (value != _contato)
                {
                    OnContatoChanging(value);
                    SendPropertyChanging();
                    _contato = value;
                    SendPropertyChanged("Contato");
                    OnContatoChanged();
                }
            }
        }

        #endregion

        #region sbyte? EPontao

        private sbyte? _epOntao;
        [DebuggerNonUserCode]
        [Column(Storage = "_epOntao", Name = "EPontao", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
        public sbyte? EPontao
        {
            get
            {
                return _epOntao;
            }
            set
            {
                if (value != _epOntao)
                {
                    OnEPontaoChanging(value);
                    SendPropertyChanging();
                    _epOntao = value;
                    SendPropertyChanged("EPontao");
                    OnEPontaoChanged();
                }
            }
        }

        #endregion

        #region string Equipe

        private string _equipe;
        [DebuggerNonUserCode]
        [Column(Storage = "_equipe", Name = "Equipe", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Equipe
        {
            get
            {
                return _equipe;
            }
            set
            {
                if (value != _equipe)
                {
                    OnEquipeChanging(value);
                    SendPropertyChanging();
                    _equipe = value;
                    SendPropertyChanged("Equipe");
                    OnEquipeChanged();
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemGrande

        private Byte[] _imagemGrande;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemGrande", Name = "ImagemGrande", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemGrande
        {
            get
            {
                return _imagemGrande;
            }
            set
            {
                if (value != _imagemGrande)
                {
                    OnImagemGrandeChanging(value);
                    SendPropertyChanging();
                    _imagemGrande = value;
                    SendPropertyChanged("ImagemGrande");
                    OnImagemGrandeChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemMedia

        private Byte[] _imagemMedia;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemMedia", Name = "ImagemMedia", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemMedia
        {
            get
            {
                return _imagemMedia;
            }
            set
            {
                if (value != _imagemMedia)
                {
                    OnImagemMediaChanging(value);
                    SendPropertyChanging();
                    _imagemMedia = value;
                    SendPropertyChanged("ImagemMedia");
                    OnImagemMediaChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemPequena

        private Byte[] _imagemPequena;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemPequena", Name = "ImagemPequena", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemPequena
        {
            get
            {
                return _imagemPequena;
            }
            set
            {
                if (value != _imagemPequena)
                {
                    OnImagemPequenaChanging(value);
                    SendPropertyChanging();
                    _imagemPequena = value;
                    SendPropertyChanged("ImagemPequena");
                    OnImagemPequenaChanged();
                }
            }
        }

        #endregion

        #region string Justificativa

        private string _justificativa;
        [DebuggerNonUserCode]
        [Column(Storage = "_justificativa", Name = "Justificativa", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Justificativa
        {
            get
            {
                return _justificativa;
            }
            set
            {
                if (value != _justificativa)
                {
                    OnJustificativaChanging(value);
                    SendPropertyChanging();
                    _justificativa = value;
                    SendPropertyChanged("Justificativa");
                    OnJustificativaChanged();
                }
            }
        }

        #endregion

        #region Byte[] Logo

        private Byte[] _logo;
        [DebuggerNonUserCode]
        [Column(Storage = "_logo", Name = "Logo", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] Logo
        {
            get
            {
                return _logo;
            }
            set
            {
                if (value != _logo)
                {
                    OnLogoChanging(value);
                    SendPropertyChanging();
                    _logo = value;
                    SendPropertyChanged("Logo");
                    OnLogoChanged();
                }
            }
        }

        #endregion

        #region string Nome

        private string _nome;
        [DebuggerNonUserCode]
        [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != _nome)
                {
                    OnNomeChanging(value);
                    SendPropertyChanging();
                    _nome = value;
                    SendPropertyChanged("Nome");
                    OnNomeChanged();
                }
            }
        }

        #endregion

        #region string NomeIdentificador

        private string _nomeIdentificador;
        [DebuggerNonUserCode]
        [Column(Storage = "_nomeIdentificador", Name = "NomeIdentificador", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
        public string NomeIdentificador
        {
            get
            {
                return _nomeIdentificador;
            }
            set
            {
                if (value != _nomeIdentificador)
                {
                    OnNomeIdentificadorChanging(value);
                    SendPropertyChanging();
                    _nomeIdentificador = value;
                    SendPropertyChanged("NomeIdentificador");
                    OnNomeIdentificadorChanged();
                }
            }
        }

        #endregion

        #region string Objetivo

        private string _objetivo;
        [DebuggerNonUserCode]
        [Column(Storage = "_objetivo", Name = "Objetivo", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Objetivo
        {
            get
            {
                return _objetivo;
            }
            set
            {
                if (value != _objetivo)
                {
                    OnObjetivoChanging(value);
                    SendPropertyChanging();
                    _objetivo = value;
                    SendPropertyChanged("Objetivo");
                    OnObjetivoChanged();
                }
            }
        }

        #endregion

        #region Children

        private DbLinq.Data.Linq.EntitySet<Banner> _banner;
        [Association(Storage = "_banner", OtherKey = "PontoID", ThisKey = "ID", Name = "fk_Banner_Ponto1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Banner> Banner
        {
            get
            {
                return _banner;
            }
            set
            {
                _banner = value;
            }
        }

        private DbLinq.Data.Linq.EntitySet<Evento> _eventO;
        [Association(Storage = "_eventO", OtherKey = "PontoID", ThisKey = "ID", Name = "fk_Evento_Ponto1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Evento> Evento
        {
            get
            {
                return _eventO;
            }
            set
            {
                _eventO = value;
            }
        }

        private DbLinq.Data.Linq.EntitySet<Galeria> _galeRiA;
        [Association(Storage = "_galeRiA", OtherKey = "PontoID", ThisKey = "ID", Name = "fk_Galeria_Ponto1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Galeria> Galeria
        {
            get
            {
                return _galeRiA;
            }
            set
            {
                _galeRiA = value;
            }
        }

        private DbLinq.Data.Linq.EntitySet<Newsletter> _newsletter;
        [Association(Storage = "_newsletter", OtherKey = "PontoID", ThisKey = "ID", Name = "fk_NewsLetter_Ponto1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Newsletter> Newsletter
        {
            get
            {
                return _newsletter;
            }
            set
            {
                _newsletter = value;
            }
        }

        private DbLinq.Data.Linq.EntitySet<Noticia> _notIcIa;
        [Association(Storage = "_notIcIa", OtherKey = "PontoID", ThisKey = "ID", Name = "fk_Noticia_Ponto1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Noticia> Noticia
        {
            get
            {
                return _notIcIa;
            }
            set
            {
                _notIcIa = value;
            }
        }

        private DbLinq.Data.Linq.EntitySet<Produto> _prodUtO;
        [Association(Storage = "_prodUtO", OtherKey = "PontoID", ThisKey = "ID", Name = "fk_Produto_Ponto1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Produto> Produto
        {
            get
            {
                return _prodUtO;
            }
            set
            {
                _prodUtO = value;
            }
        }

        private DbLinq.Data.Linq.EntitySet<Projeto> _proJetO;
        [Association(Storage = "_proJetO", OtherKey = "PontoID", ThisKey = "ID", Name = "fk_Projeto_Ponto")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Projeto> Projeto
        {
            get
            {
                return _proJetO;
            }
            set
            {
                _proJetO = value;
            }
        }

        private DbLinq.Data.Linq.EntitySet<UsuarioPonto> _usUarIoPoNto;
        [Association(Storage = "_usUarIoPoNto", OtherKey = "PontoID", ThisKey = "ID", Name = "fk_UsuarioPonto_Ponto1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<UsuarioPonto> UsuarioPonto
        {
            get
            {
                return _usUarIoPoNto;
            }
            set
            {
                _usUarIoPoNto = value;
            }
        }

        private DbLinq.Data.Linq.EntitySet<Video> _video;
        [Association(Storage = "_video", OtherKey = "PontoID", ThisKey = "ID", Name = "fk_Video_Ponto1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Video> Video
        {
            get
            {
                return _video;
            }
            set
            {
                _video = value;
            }
        }


        #endregion

        #region Attachement handlers

        private void Banner_Attach(Banner entity)
        {
            entity.Ponto = this;
        }

        private void Banner_Detach(Banner entity)
        {
            entity.Ponto = null;
        }

        private void Evento_Attach(Evento entity)
        {
            entity.Ponto = this;
        }

        private void Evento_Detach(Evento entity)
        {
            entity.Ponto = null;
        }

        private void Galeria_Attach(Galeria entity)
        {
            entity.Ponto = this;
        }

        private void Galeria_Detach(Galeria entity)
        {
            entity.Ponto = null;
        }

        private void Newsletter_Attach(Newsletter entity)
        {
            entity.Ponto = this;
        }

        private void Newsletter_Detach(Newsletter entity)
        {
            entity.Ponto = null;
        }

        private void Noticia_Attach(Noticia entity)
        {
            entity.Ponto = this;
        }

        private void Noticia_Detach(Noticia entity)
        {
            entity.Ponto = null;
        }

        private void Produto_Attach(Produto entity)
        {
            entity.Ponto = this;
        }

        private void Produto_Detach(Produto entity)
        {
            entity.Ponto = null;
        }

        private void Projeto_Attach(Projeto entity)
        {
            entity.Ponto = this;
        }

        private void Projeto_Detach(Projeto entity)
        {
            entity.Ponto = null;
        }

        private void UsuarioPonto_Attach(UsuarioPonto entity)
        {
            entity.Ponto = this;
        }

        private void UsuarioPonto_Detach(UsuarioPonto entity)
        {
            entity.Ponto = null;
        }

        private void Video_Attach(Video entity)
        {
            entity.Ponto = this;
        }

        private void Video_Detach(Video entity)
        {
            entity.Ponto = null;
        }


        #endregion

        #region ctor

        public Ponto()
        {
            _banner = new DbLinq.Data.Linq.EntitySet<Banner>(Banner_Attach, Banner_Detach);
            _eventO = new DbLinq.Data.Linq.EntitySet<Evento>(Evento_Attach, Evento_Detach);
            _galeRiA = new DbLinq.Data.Linq.EntitySet<Galeria>(Galeria_Attach, Galeria_Detach);
            _newsletter = new DbLinq.Data.Linq.EntitySet<Newsletter>(Newsletter_Attach, Newsletter_Detach);
            _notIcIa = new DbLinq.Data.Linq.EntitySet<Noticia>(Noticia_Attach, Noticia_Detach);
            _prodUtO = new DbLinq.Data.Linq.EntitySet<Produto>(Produto_Attach, Produto_Detach);
            _proJetO = new DbLinq.Data.Linq.EntitySet<Projeto>(Projeto_Attach, Projeto_Detach);
            _usUarIoPoNto = new DbLinq.Data.Linq.EntitySet<UsuarioPonto>(UsuarioPonto_Attach, UsuarioPonto_Detach);
            _video = new DbLinq.Data.Linq.EntitySet<Video>(Video_Attach, Video_Detach);
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.produto")]
    public partial class Produto : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnCategoriaIDChanged();
        partial void OnCategoriaIDChanging(int value);
        partial void OnDescricaoChanged();
        partial void OnDescricaoChanging(string value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnImagemGrandeChanged();
        partial void OnImagemGrandeChanging(Byte[] value);
        partial void OnImagemMediaChanged();
        partial void OnImagemMediaChanging(Byte[] value);
        partial void OnImagemPequenaChanged();
        partial void OnImagemPequenaChanging(Byte[] value);
        partial void OnNomeChanged();
        partial void OnNomeChanging(string value);
        partial void OnPontoIDChanged();
        partial void OnPontoIDChanging(int value);
        partial void OnUsuarioIDChanged();
        partial void OnUsuarioIDChanging(int value);

        #endregion

        #region int CategoriaID

        private int _categoriaID;
        [DebuggerNonUserCode]
        [Column(Storage = "_categoriaID", Name = "CategoriaID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int CategoriaID
        {
            get
            {
                return _categoriaID;
            }
            set
            {
                if (value != _categoriaID)
                {
                    if (_catEgoRiA.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnCategoriaIDChanging(value);
                    SendPropertyChanging();
                    _categoriaID = value;
                    SendPropertyChanged("CategoriaID");
                    OnCategoriaIDChanged();
                }
            }
        }

        #endregion

        #region string Descricao

        private string _descricao;
        [DebuggerNonUserCode]
        [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                if (value != _descricao)
                {
                    OnDescricaoChanging(value);
                    SendPropertyChanging();
                    _descricao = value;
                    SendPropertyChanged("Descricao");
                    OnDescricaoChanged();
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemGrande

        private Byte[] _imagemGrande;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemGrande", Name = "ImagemGrande", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemGrande
        {
            get
            {
                return _imagemGrande;
            }
            set
            {
                if (value != _imagemGrande)
                {
                    OnImagemGrandeChanging(value);
                    SendPropertyChanging();
                    _imagemGrande = value;
                    SendPropertyChanged("ImagemGrande");
                    OnImagemGrandeChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemMedia

        private Byte[] _imagemMedia;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemMedia", Name = "ImagemMedia", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemMedia
        {
            get
            {
                return _imagemMedia;
            }
            set
            {
                if (value != _imagemMedia)
                {
                    OnImagemMediaChanging(value);
                    SendPropertyChanging();
                    _imagemMedia = value;
                    SendPropertyChanged("ImagemMedia");
                    OnImagemMediaChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemPequena

        private Byte[] _imagemPequena;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemPequena", Name = "ImagemPequena", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemPequena
        {
            get
            {
                return _imagemPequena;
            }
            set
            {
                if (value != _imagemPequena)
                {
                    OnImagemPequenaChanging(value);
                    SendPropertyChanging();
                    _imagemPequena = value;
                    SendPropertyChanged("ImagemPequena");
                    OnImagemPequenaChanged();
                }
            }
        }

        #endregion

        #region string Nome

        private string _nome;
        [DebuggerNonUserCode]
        [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != _nome)
                {
                    OnNomeChanging(value);
                    SendPropertyChanging();
                    _nome = value;
                    SendPropertyChanged("Nome");
                    OnNomeChanged();
                }
            }
        }

        #endregion

        #region int PontoID

        private int _pontoID;
        [DebuggerNonUserCode]
        [Column(Storage = "_pontoID", Name = "PontoID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int PontoID
        {
            get
            {
                return _pontoID;
            }
            set
            {
                if (value != _pontoID)
                {
                    if (_poNto.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnPontoIDChanging(value);
                    SendPropertyChanging();
                    _pontoID = value;
                    SendPropertyChanged("PontoID");
                    OnPontoIDChanged();
                }
            }
        }

        #endregion

        #region int UsuarioID

        private int _usuarioID;
        [DebuggerNonUserCode]
        [Column(Storage = "_usuarioID", Name = "UsuarioID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int UsuarioID
        {
            get
            {
                return _usuarioID;
            }
            set
            {
                if (value != _usuarioID)
                {
                    if (_usUarIo.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnUsuarioIDChanging(value);
                    SendPropertyChanging();
                    _usuarioID = value;
                    SendPropertyChanged("UsuarioID");
                    OnUsuarioIDChanged();
                }
            }
        }

        #endregion

        #region Parents

        private DbLinq.Data.Linq.EntityRef<Categoria> _catEgoRiA;
        [Association(Storage = "_catEgoRiA", OtherKey = "ID", ThisKey = "CategoriaID", Name = "fk_Produto_Categoria1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Categoria Categoria
        {
            get
            {
                return _catEgoRiA.Entity;
            }
            set
            {
                if (value != _catEgoRiA.Entity)
                {
                    if (_catEgoRiA.Entity != null)
                    {
                        var previousCategoria = _catEgoRiA.Entity;
                        _catEgoRiA.Entity = null;
                        previousCategoria.Produto.Remove(this);
                    }
                    _catEgoRiA.Entity = value;
                    if (value != null)
                    {
                        value.Produto.Add(this);
                        _categoriaID = value.ID;
                    }
                    else
                    {
                        _categoriaID = default(int);
                    }
                }
            }
        }

        private DbLinq.Data.Linq.EntityRef<Ponto> _poNto;
        [Association(Storage = "_poNto", OtherKey = "ID", ThisKey = "PontoID", Name = "fk_Produto_Ponto1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Ponto Ponto
        {
            get
            {
                return _poNto.Entity;
            }
            set
            {
                if (value != _poNto.Entity)
                {
                    if (_poNto.Entity != null)
                    {
                        var previousPonto = _poNto.Entity;
                        _poNto.Entity = null;
                        previousPonto.Produto.Remove(this);
                    }
                    _poNto.Entity = value;
                    if (value != null)
                    {
                        value.Produto.Add(this);
                        _pontoID = value.ID;
                    }
                    else
                    {
                        _pontoID = default(int);
                    }
                }
            }
        }

        private DbLinq.Data.Linq.EntityRef<Usuario> _usUarIo;
        [Association(Storage = "_usUarIo", OtherKey = "ID", ThisKey = "UsuarioID", Name = "fk_Produto_Usuario1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Usuario Usuario
        {
            get
            {
                return _usUarIo.Entity;
            }
            set
            {
                if (value != _usUarIo.Entity)
                {
                    if (_usUarIo.Entity != null)
                    {
                        var previousUsuario = _usUarIo.Entity;
                        _usUarIo.Entity = null;
                        previousUsuario.Produto.Remove(this);
                    }
                    _usUarIo.Entity = value;
                    if (value != null)
                    {
                        value.Produto.Add(this);
                        _usuarioID = value.ID;
                    }
                    else
                    {
                        _usuarioID = default(int);
                    }
                }
            }
        }


        #endregion

        #region ctor

        public Produto()
        {
            _catEgoRiA = new DbLinq.Data.Linq.EntityRef<Categoria>();
            _poNto = new DbLinq.Data.Linq.EntityRef<Ponto>();
            _usUarIo = new DbLinq.Data.Linq.EntityRef<Usuario>();
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.profiles")]
    public partial class Profiles : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnApplicationNameChanged();
        partial void OnApplicationNameChanging(string value);
        partial void OnIsAnonymousChanged();
        partial void OnIsAnonymousChanging(sbyte? value);
        partial void OnLastActivityDateChanged();
        partial void OnLastActivityDateChanging(DateTime? value);
        partial void OnLastUpdatedDateChanged();
        partial void OnLastUpdatedDateChanging(DateTime? value);
        partial void OnUniqueIDChanged();
        partial void OnUniqueIDChanging(int value);
        partial void OnUsernameChanged();
        partial void OnUsernameChanging(string value);

        #endregion

        #region string ApplicationName

        private string _applicationName;
        [DebuggerNonUserCode]
        [Column(Storage = "_applicationName", Name = "ApplicationName", DbType = "varchar(255)", AutoSync = AutoSync.Never, CanBeNull = false)]
        public string ApplicationName
        {
            get
            {
                return _applicationName;
            }
            set
            {
                if (value != _applicationName)
                {
                    OnApplicationNameChanging(value);
                    SendPropertyChanging();
                    _applicationName = value;
                    SendPropertyChanged("ApplicationName");
                    OnApplicationNameChanged();
                }
            }
        }

        #endregion

        #region sbyte? IsAnonymous

        private sbyte? _isAnonymous;
        [DebuggerNonUserCode]
        [Column(Storage = "_isAnonymous", Name = "IsAnonymous", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
        public sbyte? IsAnonymous
        {
            get
            {
                return _isAnonymous;
            }
            set
            {
                if (value != _isAnonymous)
                {
                    OnIsAnonymousChanging(value);
                    SendPropertyChanging();
                    _isAnonymous = value;
                    SendPropertyChanged("IsAnonymous");
                    OnIsAnonymousChanged();
                }
            }
        }

        #endregion

        #region DateTime? LastActivityDate

        private DateTime? _lastActivityDate;
        [DebuggerNonUserCode]
        [Column(Storage = "_lastActivityDate", Name = "LastActivityDate", DbType = "datetime", AutoSync = AutoSync.Never)]
        public DateTime? LastActivityDate
        {
            get
            {
                return _lastActivityDate;
            }
            set
            {
                if (value != _lastActivityDate)
                {
                    OnLastActivityDateChanging(value);
                    SendPropertyChanging();
                    _lastActivityDate = value;
                    SendPropertyChanged("LastActivityDate");
                    OnLastActivityDateChanged();
                }
            }
        }

        #endregion

        #region DateTime? LastUpdatedDate

        private DateTime? _lastUpdatedDate;
        [DebuggerNonUserCode]
        [Column(Storage = "_lastUpdatedDate", Name = "LastUpdatedDate", DbType = "datetime", AutoSync = AutoSync.Never)]
        public DateTime? LastUpdatedDate
        {
            get
            {
                return _lastUpdatedDate;
            }
            set
            {
                if (value != _lastUpdatedDate)
                {
                    OnLastUpdatedDateChanging(value);
                    SendPropertyChanging();
                    _lastUpdatedDate = value;
                    SendPropertyChanged("LastUpdatedDate");
                    OnLastUpdatedDateChanged();
                }
            }
        }

        #endregion

        #region int UniqueID

        private int _uniqueID;
        [DebuggerNonUserCode]
        [Column(Storage = "_uniqueID", Name = "UniqueID", DbType = "int(8)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int UniqueID
        {
            get
            {
                return _uniqueID;
            }
            set
            {
                if (value != _uniqueID)
                {
                    OnUniqueIDChanging(value);
                    SendPropertyChanging();
                    _uniqueID = value;
                    SendPropertyChanged("UniqueID");
                    OnUniqueIDChanged();
                }
            }
        }

        #endregion

        #region string Username

        private string _username;
        [DebuggerNonUserCode]
        [Column(Storage = "_username", Name = "Username", DbType = "varchar(255)", AutoSync = AutoSync.Never, CanBeNull = false)]
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value != _username)
                {
                    OnUsernameChanging(value);
                    SendPropertyChanging();
                    _username = value;
                    SendPropertyChanged("Username");
                    OnUsernameChanged();
                }
            }
        }

        #endregion

        #region ctor

        public Profiles()
        {
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.projeto")]
    public partial class Projeto : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnDescricaoChanged();
        partial void OnDescricaoChanging(string value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnImagemGrandeChanged();
        partial void OnImagemGrandeChanging(Byte[] value);
        partial void OnImagemMediaChanged();
        partial void OnImagemMediaChanging(Byte[] value);
        partial void OnImagemPequenaChanged();
        partial void OnImagemPequenaChanging(Byte[] value);
        partial void OnNomeChanged();
        partial void OnNomeChanging(string value);
        partial void OnPontoIDChanged();
        partial void OnPontoIDChanging(int value);
        partial void OnUsuarioIDChanged();
        partial void OnUsuarioIDChanging(int value);

        #endregion

        #region string Descricao

        private string _descricao;
        [DebuggerNonUserCode]
        [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                if (value != _descricao)
                {
                    OnDescricaoChanging(value);
                    SendPropertyChanging();
                    _descricao = value;
                    SendPropertyChanged("Descricao");
                    OnDescricaoChanged();
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemGrande

        private Byte[] _imagemGrande;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemGrande", Name = "ImagemGrande", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemGrande
        {
            get
            {
                return _imagemGrande;
            }
            set
            {
                if (value != _imagemGrande)
                {
                    OnImagemGrandeChanging(value);
                    SendPropertyChanging();
                    _imagemGrande = value;
                    SendPropertyChanged("ImagemGrande");
                    OnImagemGrandeChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemMedia

        private Byte[] _imagemMedia;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemMedia", Name = "ImagemMedia", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemMedia
        {
            get
            {
                return _imagemMedia;
            }
            set
            {
                if (value != _imagemMedia)
                {
                    OnImagemMediaChanging(value);
                    SendPropertyChanging();
                    _imagemMedia = value;
                    SendPropertyChanged("ImagemMedia");
                    OnImagemMediaChanged();
                }
            }
        }

        #endregion

        #region Byte[] ImagemPequena

        private Byte[] _imagemPequena;
        [DebuggerNonUserCode]
        [Column(Storage = "_imagemPequena", Name = "ImagemPequena", DbType = "longblob", AutoSync = AutoSync.Never)]
        public Byte[] ImagemPequena
        {
            get
            {
                return _imagemPequena;
            }
            set
            {
                if (value != _imagemPequena)
                {
                    OnImagemPequenaChanging(value);
                    SendPropertyChanging();
                    _imagemPequena = value;
                    SendPropertyChanged("ImagemPequena");
                    OnImagemPequenaChanged();
                }
            }
        }

        #endregion

        #region string Nome

        private string _nome;
        [DebuggerNonUserCode]
        [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != _nome)
                {
                    OnNomeChanging(value);
                    SendPropertyChanging();
                    _nome = value;
                    SendPropertyChanged("Nome");
                    OnNomeChanged();
                }
            }
        }

        #endregion

        #region int PontoID

        private int _pontoID;
        [DebuggerNonUserCode]
        [Column(Storage = "_pontoID", Name = "PontoID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int PontoID
        {
            get
            {
                return _pontoID;
            }
            set
            {
                if (value != _pontoID)
                {
                    if (_poNto.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnPontoIDChanging(value);
                    SendPropertyChanging();
                    _pontoID = value;
                    SendPropertyChanged("PontoID");
                    OnPontoIDChanged();
                }
            }
        }

        #endregion

        #region int UsuarioID

        private int _usuarioID;
        [DebuggerNonUserCode]
        [Column(Storage = "_usuarioID", Name = "UsuarioID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int UsuarioID
        {
            get
            {
                return _usuarioID;
            }
            set
            {
                if (value != _usuarioID)
                {
                    if (_usUarIo.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnUsuarioIDChanging(value);
                    SendPropertyChanging();
                    _usuarioID = value;
                    SendPropertyChanged("UsuarioID");
                    OnUsuarioIDChanged();
                }
            }
        }

        #endregion

        #region Parents

        private DbLinq.Data.Linq.EntityRef<Ponto> _poNto;
        [Association(Storage = "_poNto", OtherKey = "ID", ThisKey = "PontoID", Name = "fk_Projeto_Ponto", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Ponto Ponto
        {
            get
            {
                return _poNto.Entity;
            }
            set
            {
                if (value != _poNto.Entity)
                {
                    if (_poNto.Entity != null)
                    {
                        var previousPonto = _poNto.Entity;
                        _poNto.Entity = null;
                        previousPonto.Projeto.Remove(this);
                    }
                    _poNto.Entity = value;
                    if (value != null)
                    {
                        value.Projeto.Add(this);
                        _pontoID = value.ID;
                    }
                    else
                    {
                        _pontoID = default(int);
                    }
                }
            }
        }

        private DbLinq.Data.Linq.EntityRef<Usuario> _usUarIo;
        [Association(Storage = "_usUarIo", OtherKey = "ID", ThisKey = "UsuarioID", Name = "fk_Projeto_Usuario1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Usuario Usuario
        {
            get
            {
                return _usUarIo.Entity;
            }
            set
            {
                if (value != _usUarIo.Entity)
                {
                    if (_usUarIo.Entity != null)
                    {
                        var previousUsuario = _usUarIo.Entity;
                        _usUarIo.Entity = null;
                        previousUsuario.Projeto.Remove(this);
                    }
                    _usUarIo.Entity = value;
                    if (value != null)
                    {
                        value.Projeto.Add(this);
                        _usuarioID = value.ID;
                    }
                    else
                    {
                        _usuarioID = default(int);
                    }
                }
            }
        }


        #endregion

        #region ctor

        public Projeto()
        {
            _poNto = new DbLinq.Data.Linq.EntityRef<Ponto>();
            _usUarIo = new DbLinq.Data.Linq.EntityRef<Usuario>();
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.roles")]
    public partial class Roles : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnApplicationNameChanged();
        partial void OnApplicationNameChanging(string value);
        partial void OnRolenameChanged();
        partial void OnRolenameChanging(string value);

        #endregion

        #region string ApplicationName

        private string _applicationName;
        [DebuggerNonUserCode]
        [Column(Storage = "_applicationName", Name = "ApplicationName", DbType = "varchar(255)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public string ApplicationName
        {
            get
            {
                return _applicationName;
            }
            set
            {
                if (value != _applicationName)
                {
                    OnApplicationNameChanging(value);
                    SendPropertyChanging();
                    _applicationName = value;
                    SendPropertyChanged("ApplicationName");
                    OnApplicationNameChanged();
                }
            }
        }

        #endregion

        #region string Rolename

        private string _rolename;
        [DebuggerNonUserCode]
        [Column(Storage = "_rolename", Name = "Rolename", DbType = "varchar(255)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public string Rolename
        {
            get
            {
                return _rolename;
            }
            set
            {
                if (value != _rolename)
                {
                    OnRolenameChanging(value);
                    SendPropertyChanging();
                    _rolename = value;
                    SendPropertyChanged("Rolename");
                    OnRolenameChanged();
                }
            }
        }

        #endregion

        #region ctor

        public Roles()
        {
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.sitemap")]
    public partial class SiteMap : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnApplicationNameChanged();
        partial void OnApplicationNameChanging(string value);
        partial void OnDescriptionChanged();
        partial void OnDescriptionChanging(string value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnParentChanged();
        partial void OnParentChanging(int? value);
        partial void OnRolesChanged();
        partial void OnRolesChanging(string value);
        partial void OnTitleChanged();
        partial void OnTitleChanging(string value);
        partial void OnUrlChanged();
        partial void OnUrlChanging(string value);

        #endregion

        #region string ApplicationName

        private string _applicationName;
        [DebuggerNonUserCode]
        [Column(Storage = "_applicationName", Name = "ApplicationName", DbType = "varchar(255)", AutoSync = AutoSync.Never, CanBeNull = false)]
        public string ApplicationName
        {
            get
            {
                return _applicationName;
            }
            set
            {
                if (value != _applicationName)
                {
                    OnApplicationNameChanging(value);
                    SendPropertyChanging();
                    _applicationName = value;
                    SendPropertyChanged("ApplicationName");
                    OnApplicationNameChanged();
                }
            }
        }

        #endregion

        #region string Description

        private string _description;
        [DebuggerNonUserCode]
        [Column(Storage = "_description", Name = "Description", DbType = "text", AutoSync = AutoSync.Never)]
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value != _description)
                {
                    OnDescriptionChanging(value);
                    SendPropertyChanging();
                    _description = value;
                    SendPropertyChanged("Description");
                    OnDescriptionChanged();
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region int? Parent

        private int? _parent;
        [DebuggerNonUserCode]
        [Column(Storage = "_parent", Name = "Parent", DbType = "int", AutoSync = AutoSync.Never)]
        public int? Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                if (value != _parent)
                {
                    OnParentChanging(value);
                    SendPropertyChanging();
                    _parent = value;
                    SendPropertyChanged("Parent");
                    OnParentChanged();
                }
            }
        }

        #endregion

        #region string Roles

        private string _roles;
        [DebuggerNonUserCode]
        [Column(Storage = "_roles", Name = "Roles", DbType = "text", AutoSync = AutoSync.Never)]
        public string Roles
        {
            get
            {
                return _roles;
            }
            set
            {
                if (value != _roles)
                {
                    OnRolesChanging(value);
                    SendPropertyChanging();
                    _roles = value;
                    SendPropertyChanged("Roles");
                    OnRolesChanged();
                }
            }
        }

        #endregion

        #region string Title

        private string _title;
        [DebuggerNonUserCode]
        [Column(Storage = "_title", Name = "Title", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value != _title)
                {
                    OnTitleChanging(value);
                    SendPropertyChanging();
                    _title = value;
                    SendPropertyChanged("Title");
                    OnTitleChanged();
                }
            }
        }

        #endregion

        #region string Url

        private string _url;
        [DebuggerNonUserCode]
        [Column(Storage = "_url", Name = "Url", DbType = "text", AutoSync = AutoSync.Never)]
        public string Url
        {
            get
            {
                return _url;
            }
            set
            {
                if (value != _url)
                {
                    OnUrlChanging(value);
                    SendPropertyChanging();
                    _url = value;
                    SendPropertyChanged("Url");
                    OnUrlChanged();
                }
            }
        }

        #endregion

        #region ctor

        public SiteMap()
        {
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.users")]
    public partial class Users : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnApplicationNameChanged();
        partial void OnApplicationNameChanging(string value);
        partial void OnCommentChanged();
        partial void OnCommentChanging(string value);
        partial void OnCreationDateChanged();
        partial void OnCreationDateChanging(DateTime? value);
        partial void OnEmailChanged();
        partial void OnEmailChanging(string value);
        partial void OnFailedPasswordAnswerAttemptCountChanged();
        partial void OnFailedPasswordAnswerAttemptCountChanging(int? value);
        partial void OnFailedPasswordAnswerAttemptWindowStartChanged();
        partial void OnFailedPasswordAnswerAttemptWindowStartChanging(DateTime? value);
        partial void OnFailedPasswordAttemptCountChanged();
        partial void OnFailedPasswordAttemptCountChanging(int? value);
        partial void OnFailedPasswordAttemptWindowStartChanged();
        partial void OnFailedPasswordAttemptWindowStartChanging(DateTime? value);
        partial void OnIsApprovedChanged();
        partial void OnIsApprovedChanging(sbyte value);
        partial void OnIsLockedOutChanged();
        partial void OnIsLockedOutChanging(sbyte? value);
        partial void OnIsOnLineChanged();
        partial void OnIsOnLineChanging(sbyte? value);
        partial void OnLastActivityDateChanged();
        partial void OnLastActivityDateChanging(DateTime? value);
        partial void OnLastLockedOutDateChanged();
        partial void OnLastLockedOutDateChanging(DateTime? value);
        partial void OnLastLoginDateChanged();
        partial void OnLastLoginDateChanging(DateTime? value);
        partial void OnLastPasswordChangedDateChanged();
        partial void OnLastPasswordChangedDateChanging(DateTime? value);
        partial void OnPasswordChanged();
        partial void OnPasswordChanging(string value);
        partial void OnPasswordAnswerChanged();
        partial void OnPasswordAnswerChanging(string value);
        partial void OnPasswordQuestionChanged();
        partial void OnPasswordQuestionChanging(string value);
        partial void OnPKidChanged();
        partial void OnPKidChanging(string value);
        partial void OnUsernameChanged();
        partial void OnUsernameChanging(string value);

        #endregion

        #region string ApplicationName

        private string _applicationName;
        [DebuggerNonUserCode]
        [Column(Storage = "_applicationName", Name = "ApplicationName", DbType = "varchar(255)", AutoSync = AutoSync.Never, CanBeNull = false)]
        public string ApplicationName
        {
            get
            {
                return _applicationName;
            }
            set
            {
                if (value != _applicationName)
                {
                    OnApplicationNameChanging(value);
                    SendPropertyChanging();
                    _applicationName = value;
                    SendPropertyChanged("ApplicationName");
                    OnApplicationNameChanged();
                }
            }
        }

        #endregion

        #region string Comment

        private string _comment;
        [DebuggerNonUserCode]
        [Column(Storage = "_comment", Name = "Comment", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
        public string Comment
        {
            get
            {
                return _comment;
            }
            set
            {
                if (value != _comment)
                {
                    OnCommentChanging(value);
                    SendPropertyChanging();
                    _comment = value;
                    SendPropertyChanged("Comment");
                    OnCommentChanged();
                }
            }
        }

        #endregion

        #region DateTime? CreationDate

        private DateTime? _creationDate;
        [DebuggerNonUserCode]
        [Column(Storage = "_creationDate", Name = "CreationDate", DbType = "datetime", AutoSync = AutoSync.Never)]
        public DateTime? CreationDate
        {
            get
            {
                return _creationDate;
            }
            set
            {
                if (value != _creationDate)
                {
                    OnCreationDateChanging(value);
                    SendPropertyChanging();
                    _creationDate = value;
                    SendPropertyChanged("CreationDate");
                    OnCreationDateChanged();
                }
            }
        }

        #endregion

        #region string Email

        private string _email;
        [DebuggerNonUserCode]
        [Column(Storage = "_email", Name = "Email", DbType = "varchar(128)", AutoSync = AutoSync.Never)]
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value != _email)
                {
                    OnEmailChanging(value);
                    SendPropertyChanging();
                    _email = value;
                    SendPropertyChanged("Email");
                    OnEmailChanged();
                }
            }
        }

        #endregion

        #region int? FailedPasswordAnswerAttemptCount

        private int? _failedPasswordAnswerAttemptCount;
        [DebuggerNonUserCode]
        [Column(Storage = "_failedPasswordAnswerAttemptCount", Name = "FailedPasswordAnswerAttemptCount", DbType = "int(8)", AutoSync = AutoSync.Never)]
        public int? FailedPasswordAnswerAttemptCount
        {
            get
            {
                return _failedPasswordAnswerAttemptCount;
            }
            set
            {
                if (value != _failedPasswordAnswerAttemptCount)
                {
                    OnFailedPasswordAnswerAttemptCountChanging(value);
                    SendPropertyChanging();
                    _failedPasswordAnswerAttemptCount = value;
                    SendPropertyChanged("FailedPasswordAnswerAttemptCount");
                    OnFailedPasswordAnswerAttemptCountChanged();
                }
            }
        }

        #endregion

        #region DateTime? FailedPasswordAnswerAttemptWindowStart

        private DateTime? _failedPasswordAnswerAttemptWindowStart;
        [DebuggerNonUserCode]
        [Column(Storage = "_failedPasswordAnswerAttemptWindowStart", Name = "FailedPasswordAnswerAttemptWindowStart", DbType = "datetime", AutoSync = AutoSync.Never)]
        public DateTime? FailedPasswordAnswerAttemptWindowStart
        {
            get
            {
                return _failedPasswordAnswerAttemptWindowStart;
            }
            set
            {
                if (value != _failedPasswordAnswerAttemptWindowStart)
                {
                    OnFailedPasswordAnswerAttemptWindowStartChanging(value);
                    SendPropertyChanging();
                    _failedPasswordAnswerAttemptWindowStart = value;
                    SendPropertyChanged("FailedPasswordAnswerAttemptWindowStart");
                    OnFailedPasswordAnswerAttemptWindowStartChanged();
                }
            }
        }

        #endregion

        #region int? FailedPasswordAttemptCount

        private int? _failedPasswordAttemptCount;
        [DebuggerNonUserCode]
        [Column(Storage = "_failedPasswordAttemptCount", Name = "FailedPasswordAttemptCount", DbType = "int(8)", AutoSync = AutoSync.Never)]
        public int? FailedPasswordAttemptCount
        {
            get
            {
                return _failedPasswordAttemptCount;
            }
            set
            {
                if (value != _failedPasswordAttemptCount)
                {
                    OnFailedPasswordAttemptCountChanging(value);
                    SendPropertyChanging();
                    _failedPasswordAttemptCount = value;
                    SendPropertyChanged("FailedPasswordAttemptCount");
                    OnFailedPasswordAttemptCountChanged();
                }
            }
        }

        #endregion

        #region DateTime? FailedPasswordAttemptWindowStart

        private DateTime? _failedPasswordAttemptWindowStart;
        [DebuggerNonUserCode]
        [Column(Storage = "_failedPasswordAttemptWindowStart", Name = "FailedPasswordAttemptWindowStart", DbType = "datetime", AutoSync = AutoSync.Never)]
        public DateTime? FailedPasswordAttemptWindowStart
        {
            get
            {
                return _failedPasswordAttemptWindowStart;
            }
            set
            {
                if (value != _failedPasswordAttemptWindowStart)
                {
                    OnFailedPasswordAttemptWindowStartChanging(value);
                    SendPropertyChanging();
                    _failedPasswordAttemptWindowStart = value;
                    SendPropertyChanged("FailedPasswordAttemptWindowStart");
                    OnFailedPasswordAttemptWindowStartChanged();
                }
            }
        }

        #endregion

        #region sbyte IsApproved

        private sbyte _isApproved;
        [DebuggerNonUserCode]
        [Column(Storage = "_isApproved", Name = "IsApproved", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
        public sbyte IsApproved
        {
            get
            {
                return _isApproved;
            }
            set
            {
                if (value != _isApproved)
                {
                    OnIsApprovedChanging(value);
                    SendPropertyChanging();
                    _isApproved = value;
                    SendPropertyChanged("IsApproved");
                    OnIsApprovedChanged();
                }
            }
        }

        #endregion

        #region sbyte? IsLockedOut

        private sbyte? _isLockedOut;
        [DebuggerNonUserCode]
        [Column(Storage = "_isLockedOut", Name = "IsLockedOut", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
        public sbyte? IsLockedOut
        {
            get
            {
                return _isLockedOut;
            }
            set
            {
                if (value != _isLockedOut)
                {
                    OnIsLockedOutChanging(value);
                    SendPropertyChanging();
                    _isLockedOut = value;
                    SendPropertyChanged("IsLockedOut");
                    OnIsLockedOutChanged();
                }
            }
        }

        #endregion

        #region sbyte? IsOnLine

        private sbyte? _isOnLine;
        [DebuggerNonUserCode]
        [Column(Storage = "_isOnLine", Name = "IsOnLine", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
        public sbyte? IsOnLine
        {
            get
            {
                return _isOnLine;
            }
            set
            {
                if (value != _isOnLine)
                {
                    OnIsOnLineChanging(value);
                    SendPropertyChanging();
                    _isOnLine = value;
                    SendPropertyChanged("IsOnLine");
                    OnIsOnLineChanged();
                }
            }
        }

        #endregion

        #region DateTime? LastActivityDate

        private DateTime? _lastActivityDate;
        [DebuggerNonUserCode]
        [Column(Storage = "_lastActivityDate", Name = "LastActivityDate", DbType = "datetime", AutoSync = AutoSync.Never)]
        public DateTime? LastActivityDate
        {
            get
            {
                return _lastActivityDate;
            }
            set
            {
                if (value != _lastActivityDate)
                {
                    OnLastActivityDateChanging(value);
                    SendPropertyChanging();
                    _lastActivityDate = value;
                    SendPropertyChanged("LastActivityDate");
                    OnLastActivityDateChanged();
                }
            }
        }

        #endregion

        #region DateTime? LastLockedOutDate

        private DateTime? _lastLockedOutDate;
        [DebuggerNonUserCode]
        [Column(Storage = "_lastLockedOutDate", Name = "LastLockedOutDate", DbType = "datetime", AutoSync = AutoSync.Never)]
        public DateTime? LastLockedOutDate
        {
            get
            {
                return _lastLockedOutDate;
            }
            set
            {
                if (value != _lastLockedOutDate)
                {
                    OnLastLockedOutDateChanging(value);
                    SendPropertyChanging();
                    _lastLockedOutDate = value;
                    SendPropertyChanged("LastLockedOutDate");
                    OnLastLockedOutDateChanged();
                }
            }
        }

        #endregion

        #region DateTime? LastLoginDate

        private DateTime? _lastLoginDate;
        [DebuggerNonUserCode]
        [Column(Storage = "_lastLoginDate", Name = "LastLoginDate", DbType = "datetime", AutoSync = AutoSync.Never)]
        public DateTime? LastLoginDate
        {
            get
            {
                return _lastLoginDate;
            }
            set
            {
                if (value != _lastLoginDate)
                {
                    OnLastLoginDateChanging(value);
                    SendPropertyChanging();
                    _lastLoginDate = value;
                    SendPropertyChanged("LastLoginDate");
                    OnLastLoginDateChanged();
                }
            }
        }

        #endregion

        #region DateTime? LastPasswordChangedDate

        private DateTime? _lastPasswordChangedDate;
        [DebuggerNonUserCode]
        [Column(Storage = "_lastPasswordChangedDate", Name = "LastPasswordChangedDate", DbType = "datetime", AutoSync = AutoSync.Never)]
        public DateTime? LastPasswordChangedDate
        {
            get
            {
                return _lastPasswordChangedDate;
            }
            set
            {
                if (value != _lastPasswordChangedDate)
                {
                    OnLastPasswordChangedDateChanging(value);
                    SendPropertyChanging();
                    _lastPasswordChangedDate = value;
                    SendPropertyChanged("LastPasswordChangedDate");
                    OnLastPasswordChangedDateChanged();
                }
            }
        }

        #endregion

        #region string Password

        private string _password;
        [DebuggerNonUserCode]
        [Column(Storage = "_password", Name = "Password", DbType = "varchar(128)", AutoSync = AutoSync.Never, CanBeNull = false)]
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value != _password)
                {
                    OnPasswordChanging(value);
                    SendPropertyChanging();
                    _password = value;
                    SendPropertyChanged("Password");
                    OnPasswordChanged();
                }
            }
        }

        #endregion

        #region string PasswordAnswer

        private string _passwordAnswer;
        [DebuggerNonUserCode]
        [Column(Storage = "_passwordAnswer", Name = "PasswordAnswer", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
        public string PasswordAnswer
        {
            get
            {
                return _passwordAnswer;
            }
            set
            {
                if (value != _passwordAnswer)
                {
                    OnPasswordAnswerChanging(value);
                    SendPropertyChanging();
                    _passwordAnswer = value;
                    SendPropertyChanged("PasswordAnswer");
                    OnPasswordAnswerChanged();
                }
            }
        }

        #endregion

        #region string PasswordQuestion

        private string _passwordQuestion;
        [DebuggerNonUserCode]
        [Column(Storage = "_passwordQuestion", Name = "PasswordQuestion", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
        public string PasswordQuestion
        {
            get
            {
                return _passwordQuestion;
            }
            set
            {
                if (value != _passwordQuestion)
                {
                    OnPasswordQuestionChanging(value);
                    SendPropertyChanging();
                    _passwordQuestion = value;
                    SendPropertyChanged("PasswordQuestion");
                    OnPasswordQuestionChanged();
                }
            }
        }

        #endregion

        #region string PKid

        private string _pkID;
        [DebuggerNonUserCode]
        [Column(Storage = "_pkID", Name = "PKID", DbType = "varchar(255)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public string PKid
        {
            get
            {
                return _pkID;
            }
            set
            {
                if (value != _pkID)
                {
                    OnPKidChanging(value);
                    SendPropertyChanging();
                    _pkID = value;
                    SendPropertyChanged("PKid");
                    OnPKidChanged();
                }
            }
        }

        #endregion

        #region string Username

        private string _username;
        [DebuggerNonUserCode]
        [Column(Storage = "_username", Name = "Username", DbType = "varchar(255)", AutoSync = AutoSync.Never, CanBeNull = false)]
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value != _username)
                {
                    OnUsernameChanging(value);
                    SendPropertyChanging();
                    _username = value;
                    SendPropertyChanged("Username");
                    OnUsernameChanged();
                }
            }
        }

        #endregion

        #region ctor

        public Users()
        {
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.usersinroles")]
    public partial class UsersInRoles : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnApplicationNameChanged();
        partial void OnApplicationNameChanging(string value);
        partial void OnRolenameChanged();
        partial void OnRolenameChanging(string value);
        partial void OnUsernameChanged();
        partial void OnUsernameChanging(string value);

        #endregion

        #region string ApplicationName

        private string _applicationName;
        [DebuggerNonUserCode]
        [Column(Storage = "_applicationName", Name = "ApplicationName", DbType = "varchar(255)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public string ApplicationName
        {
            get
            {
                return _applicationName;
            }
            set
            {
                if (value != _applicationName)
                {
                    OnApplicationNameChanging(value);
                    SendPropertyChanging();
                    _applicationName = value;
                    SendPropertyChanged("ApplicationName");
                    OnApplicationNameChanged();
                }
            }
        }

        #endregion

        #region string Rolename

        private string _rolename;
        [DebuggerNonUserCode]
        [Column(Storage = "_rolename", Name = "Rolename", DbType = "varchar(255)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public string Rolename
        {
            get
            {
                return _rolename;
            }
            set
            {
                if (value != _rolename)
                {
                    OnRolenameChanging(value);
                    SendPropertyChanging();
                    _rolename = value;
                    SendPropertyChanged("Rolename");
                    OnRolenameChanged();
                }
            }
        }

        #endregion

        #region string Username

        private string _username;
        [DebuggerNonUserCode]
        [Column(Storage = "_username", Name = "Username", DbType = "varchar(255)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value != _username)
                {
                    OnUsernameChanging(value);
                    SendPropertyChanging();
                    _username = value;
                    SendPropertyChanged("Username");
                    OnUsernameChanged();
                }
            }
        }

        #endregion

        #region ctor

        public UsersInRoles()
        {
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.usuario")]
    public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnLoginChanged();
        partial void OnLoginChanging(string value);
        partial void OnNomeChanged();
        partial void OnNomeChanging(string value);
        partial void OnPKidChanged();
        partial void OnPKidChanging(string value);
        partial void OnSenhaChanged();
        partial void OnSenhaChanging(string value);

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region string Login

        private string _login;
        [DebuggerNonUserCode]
        [Column(Storage = "_login", Name = "Login", DbType = "varchar(300)", AutoSync = AutoSync.Never)]
        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                if (value != _login)
                {
                    OnLoginChanging(value);
                    SendPropertyChanging();
                    _login = value;
                    SendPropertyChanged("Login");
                    OnLoginChanged();
                }
            }
        }

        #endregion

        #region string Nome

        private string _nome;
        [DebuggerNonUserCode]
        [Column(Storage = "_nome", Name = "Nome", DbType = "varchar(300)", AutoSync = AutoSync.Never)]
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != _nome)
                {
                    OnNomeChanging(value);
                    SendPropertyChanging();
                    _nome = value;
                    SendPropertyChanged("Nome");
                    OnNomeChanged();
                }
            }
        }

        #endregion

        #region string PKid

        private string _pkID;
        [DebuggerNonUserCode]
        [Column(Storage = "_pkID", Name = "PKID", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
        public string PKid
        {
            get
            {
                return _pkID;
            }
            set
            {
                if (value != _pkID)
                {
                    OnPKidChanging(value);
                    SendPropertyChanging();
                    _pkID = value;
                    SendPropertyChanged("PKid");
                    OnPKidChanged();
                }
            }
        }

        #endregion

        #region string Senha

        private string _senha;
        [DebuggerNonUserCode]
        [Column(Storage = "_senha", Name = "Senha", DbType = "varchar(300)", AutoSync = AutoSync.Never)]
        public string Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                if (value != _senha)
                {
                    OnSenhaChanging(value);
                    SendPropertyChanging();
                    _senha = value;
                    SendPropertyChanged("Senha");
                    OnSenhaChanged();
                }
            }
        }

        #endregion

        #region Children

        private DbLinq.Data.Linq.EntitySet<Banner> _banner;
        [Association(Storage = "_banner", OtherKey = "UsuarioID", ThisKey = "ID", Name = "fk_Banner_Usuario1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Banner> Banner
        {
            get
            {
                return _banner;
            }
            set
            {
                _banner = value;
            }
        }

        private DbLinq.Data.Linq.EntitySet<Galeria> _galeRiA;
        [Association(Storage = "_galeRiA", OtherKey = "UsuarioID", ThisKey = "ID", Name = "fk_Galeria_Usuario1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Galeria> Galeria
        {
            get
            {
                return _galeRiA;
            }
            set
            {
                _galeRiA = value;
            }
        }

        private DbLinq.Data.Linq.EntitySet<Imagem> _imageM;
        [Association(Storage = "_imageM", OtherKey = "UsuarioID", ThisKey = "ID", Name = "fk_Imagem_Usuario1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Imagem> Imagem
        {
            get
            {
                return _imageM;
            }
            set
            {
                _imageM = value;
            }
        }

        private DbLinq.Data.Linq.EntitySet<Noticia> _notIcIa;
        [Association(Storage = "_notIcIa", OtherKey = "UsuarioID", ThisKey = "ID", Name = "fk_Noticia_Usuario1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Noticia> Noticia
        {
            get
            {
                return _notIcIa;
            }
            set
            {
                _notIcIa = value;
            }
        }

        private DbLinq.Data.Linq.EntitySet<Produto> _prodUtO;
        [Association(Storage = "_prodUtO", OtherKey = "UsuarioID", ThisKey = "ID", Name = "fk_Produto_Usuario1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Produto> Produto
        {
            get
            {
                return _prodUtO;
            }
            set
            {
                _prodUtO = value;
            }
        }

        private DbLinq.Data.Linq.EntitySet<Projeto> _proJetO;
        [Association(Storage = "_proJetO", OtherKey = "UsuarioID", ThisKey = "ID", Name = "fk_Projeto_Usuario1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Projeto> Projeto
        {
            get
            {
                return _proJetO;
            }
            set
            {
                _proJetO = value;
            }
        }

        private DbLinq.Data.Linq.EntitySet<UsuarioPonto> _usUarIoPoNto;
        [Association(Storage = "_usUarIoPoNto", OtherKey = "UsuarioID", ThisKey = "ID", Name = "fk_UsuarioPonto_Usuario1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<UsuarioPonto> UsuarioPonto
        {
            get
            {
                return _usUarIoPoNto;
            }
            set
            {
                _usUarIoPoNto = value;
            }
        }

        private DbLinq.Data.Linq.EntitySet<Video> _video;
        [Association(Storage = "_video", OtherKey = "UsuarioID", ThisKey = "ID", Name = "fk_Video_Usuario1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Video> Video
        {
            get
            {
                return _video;
            }
            set
            {
                _video = value;
            }
        }


        #endregion

        #region Attachement handlers

        private void Banner_Attach(Banner entity)
        {
            entity.Usuario = this;
        }

        private void Banner_Detach(Banner entity)
        {
            entity.Usuario = null;
        }

        private void Galeria_Attach(Galeria entity)
        {
            entity.Usuario = this;
        }

        private void Galeria_Detach(Galeria entity)
        {
            entity.Usuario = null;
        }

        private void Imagem_Attach(Imagem entity)
        {
            entity.Usuario = this;
        }

        private void Imagem_Detach(Imagem entity)
        {
            entity.Usuario = null;
        }

        private void Noticia_Attach(Noticia entity)
        {
            entity.Usuario = this;
        }

        private void Noticia_Detach(Noticia entity)
        {
            entity.Usuario = null;
        }

        private void Produto_Attach(Produto entity)
        {
            entity.Usuario = this;
        }

        private void Produto_Detach(Produto entity)
        {
            entity.Usuario = null;
        }

        private void Projeto_Attach(Projeto entity)
        {
            entity.Usuario = this;
        }

        private void Projeto_Detach(Projeto entity)
        {
            entity.Usuario = null;
        }

        private void UsuarioPonto_Attach(UsuarioPonto entity)
        {
            entity.Usuario = this;
        }

        private void UsuarioPonto_Detach(UsuarioPonto entity)
        {
            entity.Usuario = null;
        }

        private void Video_Attach(Video entity)
        {
            entity.Usuario = this;
        }

        private void Video_Detach(Video entity)
        {
            entity.Usuario = null;
        }


        #endregion

        #region ctor

        public Usuario()
        {
            _banner = new DbLinq.Data.Linq.EntitySet<Banner>(Banner_Attach, Banner_Detach);
            _galeRiA = new DbLinq.Data.Linq.EntitySet<Galeria>(Galeria_Attach, Galeria_Detach);
            _imageM = new DbLinq.Data.Linq.EntitySet<Imagem>(Imagem_Attach, Imagem_Detach);
            _notIcIa = new DbLinq.Data.Linq.EntitySet<Noticia>(Noticia_Attach, Noticia_Detach);
            _prodUtO = new DbLinq.Data.Linq.EntitySet<Produto>(Produto_Attach, Produto_Detach);
            _proJetO = new DbLinq.Data.Linq.EntitySet<Projeto>(Projeto_Attach, Projeto_Detach);
            _usUarIoPoNto = new DbLinq.Data.Linq.EntitySet<UsuarioPonto>(UsuarioPonto_Attach, UsuarioPonto_Detach);
            _video = new DbLinq.Data.Linq.EntitySet<Video>(Video_Attach, Video_Detach);
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.usuarioponto")]
    public partial class UsuarioPonto : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnPontoIDChanged();
        partial void OnPontoIDChanging(int value);
        partial void OnUsuarioIDChanged();
        partial void OnUsuarioIDChanging(int value);

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region int PontoID

        private int _pontoID;
        [DebuggerNonUserCode]
        [Column(Storage = "_pontoID", Name = "PontoID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int PontoID
        {
            get
            {
                return _pontoID;
            }
            set
            {
                if (value != _pontoID)
                {
                    if (_poNto.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnPontoIDChanging(value);
                    SendPropertyChanging();
                    _pontoID = value;
                    SendPropertyChanged("PontoID");
                    OnPontoIDChanged();
                }
            }
        }

        #endregion

        #region int UsuarioID

        private int _usuarioID;
        [DebuggerNonUserCode]
        [Column(Storage = "_usuarioID", Name = "UsuarioID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int UsuarioID
        {
            get
            {
                return _usuarioID;
            }
            set
            {
                if (value != _usuarioID)
                {
                    if (_usUarIo.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnUsuarioIDChanging(value);
                    SendPropertyChanging();
                    _usuarioID = value;
                    SendPropertyChanged("UsuarioID");
                    OnUsuarioIDChanged();
                }
            }
        }

        #endregion

        #region Children

        private DbLinq.Data.Linq.EntitySet<Evento> _eventO;
        [Association(Storage = "_eventO", OtherKey = "UsuarioPontoID", ThisKey = "ID", Name = "fk_Evento_UsuarioPonto1")]
        [DebuggerNonUserCode]
        public DbLinq.Data.Linq.EntitySet<Evento> Evento
        {
            get
            {
                return _eventO;
            }
            set
            {
                _eventO = value;
            }
        }


        #endregion

        #region Parents

        private DbLinq.Data.Linq.EntityRef<Ponto> _poNto;
        [Association(Storage = "_poNto", OtherKey = "ID", ThisKey = "PontoID", Name = "fk_UsuarioPonto_Ponto1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Ponto Ponto
        {
            get
            {
                return _poNto.Entity;
            }
            set
            {
                if (value != _poNto.Entity)
                {
                    if (_poNto.Entity != null)
                    {
                        var previousPonto = _poNto.Entity;
                        _poNto.Entity = null;
                        previousPonto.UsuarioPonto.Remove(this);
                    }
                    _poNto.Entity = value;
                    if (value != null)
                    {
                        value.UsuarioPonto.Add(this);
                        _pontoID = value.ID;
                    }
                    else
                    {
                        _pontoID = default(int);
                    }
                }
            }
        }

        private DbLinq.Data.Linq.EntityRef<Usuario> _usUarIo;
        [Association(Storage = "_usUarIo", OtherKey = "ID", ThisKey = "UsuarioID", Name = "fk_UsuarioPonto_Usuario1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Usuario Usuario
        {
            get
            {
                return _usUarIo.Entity;
            }
            set
            {
                if (value != _usUarIo.Entity)
                {
                    if (_usUarIo.Entity != null)
                    {
                        var previousUsuario = _usUarIo.Entity;
                        _usUarIo.Entity = null;
                        previousUsuario.UsuarioPonto.Remove(this);
                    }
                    _usUarIo.Entity = value;
                    if (value != null)
                    {
                        value.UsuarioPonto.Add(this);
                        _usuarioID = value.ID;
                    }
                    else
                    {
                        _usuarioID = default(int);
                    }
                }
            }
        }


        #endregion

        #region Attachement handlers

        private void Evento_Attach(Evento entity)
        {
            entity.UsuarioPonto = this;
        }

        private void Evento_Detach(Evento entity)
        {
            entity.UsuarioPonto = null;
        }


        #endregion

        #region ctor

        public UsuarioPonto()
        {
            _eventO = new DbLinq.Data.Linq.EntitySet<Evento>(Evento_Attach, Evento_Detach);
            _poNto = new DbLinq.Data.Linq.EntityRef<Ponto>();
            _usUarIo = new DbLinq.Data.Linq.EntityRef<Usuario>();
            OnCreated();
        }

        #endregion

    }

    [Table(Name = "PontaoCanavialDB.video")]
    public partial class Video : INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region INotifyPropertyChanging handling

        public event PropertyChangingEventHandler PropertyChanging;

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
        protected virtual void SendPropertyChanging()
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        #endregion

        #region INotifyPropertyChanged handling

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region Extensibility Method Definitions

        partial void OnCreated();
        partial void OnConteudoChanged();
        partial void OnConteudoChanging(string value);
        partial void OnDescricaoChanged();
        partial void OnDescricaoChanging(string value);
        partial void OnIDChanged();
        partial void OnIDChanging(int value);
        partial void OnPontoIDChanged();
        partial void OnPontoIDChanging(int value);
        partial void OnTituloChanged();
        partial void OnTituloChanging(string value);
        partial void OnUsuarioIDChanged();
        partial void OnUsuarioIDChanging(int value);

        #endregion

        #region string Conteudo

        private string _conteudo;
        [DebuggerNonUserCode]
        [Column(Storage = "_conteudo", Name = "Conteudo", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Conteudo
        {
            get
            {
                return _conteudo;
            }
            set
            {
                if (value != _conteudo)
                {
                    OnConteudoChanging(value);
                    SendPropertyChanging();
                    _conteudo = value;
                    SendPropertyChanged("Conteudo");
                    OnConteudoChanged();
                }
            }
        }

        #endregion

        #region string Descricao

        private string _descricao;
        [DebuggerNonUserCode]
        [Column(Storage = "_descricao", Name = "Descricao", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                if (value != _descricao)
                {
                    OnDescricaoChanging(value);
                    SendPropertyChanging();
                    _descricao = value;
                    SendPropertyChanged("Descricao");
                    OnDescricaoChanged();
                }
            }
        }

        #endregion

        #region int ID

        private int _id;
        [DebuggerNonUserCode]
        [Column(Storage = "_id", Name = "ID", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    OnIDChanging(value);
                    SendPropertyChanging();
                    _id = value;
                    SendPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }

        #endregion

        #region int PontoID

        private int _pontoID;
        [DebuggerNonUserCode]
        [Column(Storage = "_pontoID", Name = "PontoID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int PontoID
        {
            get
            {
                return _pontoID;
            }
            set
            {
                if (value != _pontoID)
                {
                    if (_poNto.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnPontoIDChanging(value);
                    SendPropertyChanging();
                    _pontoID = value;
                    SendPropertyChanged("PontoID");
                    OnPontoIDChanged();
                }
            }
        }

        #endregion

        #region string Titulo

        private string _titulo;
        [DebuggerNonUserCode]
        [Column(Storage = "_titulo", Name = "Titulo", DbType = "varchar(8000)", AutoSync = AutoSync.Never)]
        public string Titulo
        {
            get
            {
                return _titulo;
            }
            set
            {
                if (value != _titulo)
                {
                    OnTituloChanging(value);
                    SendPropertyChanging();
                    _titulo = value;
                    SendPropertyChanged("Titulo");
                    OnTituloChanged();
                }
            }
        }

        #endregion

        #region int UsuarioID

        private int _usuarioID;
        [DebuggerNonUserCode]
        [Column(Storage = "_usuarioID", Name = "UsuarioID", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
        public int UsuarioID
        {
            get
            {
                return _usuarioID;
            }
            set
            {
                if (value != _usuarioID)
                {
                    if (_usUarIo.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    OnUsuarioIDChanging(value);
                    SendPropertyChanging();
                    _usuarioID = value;
                    SendPropertyChanged("UsuarioID");
                    OnUsuarioIDChanged();
                }
            }
        }

        #endregion

        #region Parents

        private DbLinq.Data.Linq.EntityRef<Ponto> _poNto;
        [Association(Storage = "_poNto", OtherKey = "ID", ThisKey = "PontoID", Name = "fk_Video_Ponto1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Ponto Ponto
        {
            get
            {
                return _poNto.Entity;
            }
            set
            {
                if (value != _poNto.Entity)
                {
                    if (_poNto.Entity != null)
                    {
                        var previousPonto = _poNto.Entity;
                        _poNto.Entity = null;
                        previousPonto.Video.Remove(this);
                    }
                    _poNto.Entity = value;
                    if (value != null)
                    {
                        value.Video.Add(this);
                        _pontoID = value.ID;
                    }
                    else
                    {
                        _pontoID = default(int);
                    }
                }
            }
        }

        private DbLinq.Data.Linq.EntityRef<Usuario> _usUarIo;
        [Association(Storage = "_usUarIo", OtherKey = "ID", ThisKey = "UsuarioID", Name = "fk_Video_Usuario1", IsForeignKey = true)]
        [DebuggerNonUserCode]
        public Usuario Usuario
        {
            get
            {
                return _usUarIo.Entity;
            }
            set
            {
                if (value != _usUarIo.Entity)
                {
                    if (_usUarIo.Entity != null)
                    {
                        var previousUsuario = _usUarIo.Entity;
                        _usUarIo.Entity = null;
                        previousUsuario.Video.Remove(this);
                    }
                    _usUarIo.Entity = value;
                    if (value != null)
                    {
                        value.Video.Add(this);
                        _usuarioID = value.ID;
                    }
                    else
                    {
                        _usuarioID = default(int);
                    }
                }
            }
        }


        #endregion

        #region ctor

        public Video()
        {
            _poNto = new DbLinq.Data.Linq.EntityRef<Ponto>();
            _usUarIo = new DbLinq.Data.Linq.EntityRef<Usuario>();
            OnCreated();
        }

        #endregion

    }


   
