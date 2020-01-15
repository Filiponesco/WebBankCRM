﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBankCRM
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bankcrm")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertklienci(klienci instance);
    partial void Updateklienci(klienci instance);
    partial void Deleteklienci(klienci instance);
    partial void Insertzadania(zadania instance);
    partial void Updatezadania(zadania instance);
    partial void Deletezadania(zadania instance);
    partial void Insertkredyty(kredyty instance);
    partial void Updatekredyty(kredyty instance);
    partial void Deletekredyty(kredyty instance);
    partial void Insertuzytkownicy(uzytkownicy instance);
    partial void Updateuzytkownicy(uzytkownicy instance);
    partial void Deleteuzytkownicy(uzytkownicy instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["bankcrmConnectionString"].ConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<klienci> klienci
		{
			get
			{
				return this.GetTable<klienci>();
			}
		}
		
		public System.Data.Linq.Table<zadania> zadania
		{
			get
			{
				return this.GetTable<zadania>();
			}
		}
		
		public System.Data.Linq.Table<kredyty> kredyty
		{
			get
			{
				return this.GetTable<kredyty>();
			}
		}
		
		public System.Data.Linq.Table<uzytkownicy> uzytkownicy
		{
			get
			{
				return this.GetTable<uzytkownicy>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.klienci")]
	public partial class klienci : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_klienci;
		
		private string _imie;
		
		private string _nazwisko;
		
		private string _e_mail;
		
		private string _telefon;
		
		private string _pesel;
		
		private EntitySet<zadania> _zadania;
		
		private EntitySet<kredyty> _kredyty;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_klienciChanging(int value);
    partial void Onid_klienciChanged();
    partial void OnimieChanging(string value);
    partial void OnimieChanged();
    partial void OnnazwiskoChanging(string value);
    partial void OnnazwiskoChanged();
    partial void One_mailChanging(string value);
    partial void One_mailChanged();
    partial void OntelefonChanging(string value);
    partial void OntelefonChanged();
    partial void OnpeselChanging(string value);
    partial void OnpeselChanged();
    #endregion
		
		public klienci()
		{
			this._zadania = new EntitySet<zadania>(new Action<zadania>(this.attach_zadania), new Action<zadania>(this.detach_zadania));
			this._kredyty = new EntitySet<kredyty>(new Action<kredyty>(this.attach_kredyty), new Action<kredyty>(this.detach_kredyty));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_klienci", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_klienci
		{
			get
			{
				return this._id_klienci;
			}
			set
			{
				if ((this._id_klienci != value))
				{
					this.Onid_klienciChanging(value);
					this.SendPropertyChanging();
					this._id_klienci = value;
					this.SendPropertyChanged("id_klienci");
					this.Onid_klienciChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imie", DbType="NChar(255) NOT NULL", CanBeNull=false)]
		public string imie
		{
			get
			{
				return this._imie;
			}
			set
			{
				if ((this._imie != value))
				{
					this.OnimieChanging(value);
					this.SendPropertyChanging();
					this._imie = value;
					this.SendPropertyChanged("imie");
					this.OnimieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nazwisko", DbType="NChar(255) NOT NULL", CanBeNull=false)]
		public string nazwisko
		{
			get
			{
				return this._nazwisko;
			}
			set
			{
				if ((this._nazwisko != value))
				{
					this.OnnazwiskoChanging(value);
					this.SendPropertyChanging();
					this._nazwisko = value;
					this.SendPropertyChanged("nazwisko");
					this.OnnazwiskoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[e-mail]", Storage="_e_mail", DbType="NChar(255)")]
		public string e_mail
		{
			get
			{
				return this._e_mail;
			}
			set
			{
				if ((this._e_mail != value))
				{
					this.One_mailChanging(value);
					this.SendPropertyChanging();
					this._e_mail = value;
					this.SendPropertyChanged("e_mail");
					this.One_mailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefon", DbType="NChar(255) NOT NULL", CanBeNull=false)]
		public string telefon
		{
			get
			{
				return this._telefon;
			}
			set
			{
				if ((this._telefon != value))
				{
					this.OntelefonChanging(value);
					this.SendPropertyChanging();
					this._telefon = value;
					this.SendPropertyChanged("telefon");
					this.OntelefonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pesel", DbType="NChar(255) NOT NULL", CanBeNull=false)]
		public string pesel
		{
			get
			{
				return this._pesel;
			}
			set
			{
				if ((this._pesel != value))
				{
					this.OnpeselChanging(value);
					this.SendPropertyChanging();
					this._pesel = value;
					this.SendPropertyChanged("pesel");
					this.OnpeselChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="klienci_zadania", Storage="_zadania", ThisKey="id_klienci", OtherKey="id_klienci")]
		public EntitySet<zadania> zadania
		{
			get
			{
				return this._zadania;
			}
			set
			{
				this._zadania.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="klienci_kredyty", Storage="_kredyty", ThisKey="id_klienci", OtherKey="id_klienci")]
		public EntitySet<kredyty> kredyty
		{
			get
			{
				return this._kredyty;
			}
			set
			{
				this._kredyty.Assign(value);
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
		
		private void attach_zadania(zadania entity)
		{
			this.SendPropertyChanging();
			entity.klienci = this;
		}
		
		private void detach_zadania(zadania entity)
		{
			this.SendPropertyChanging();
			entity.klienci = null;
		}
		
		private void attach_kredyty(kredyty entity)
		{
			this.SendPropertyChanging();
			entity.klienci = this;
		}
		
		private void detach_kredyty(kredyty entity)
		{
			this.SendPropertyChanging();
			entity.klienci = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.zadania")]
	public partial class zadania : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_zadania;
		
		private string _tytul;
		
		private string _tresc;
		
		private int _autor_id_uzytkownicy;
		
		private string _status;
		
		private int _id_klienci;
		
		private System.DateTime _termin;
		
		private EntityRef<klienci> _klienci;
		
		private EntityRef<uzytkownicy> _uzytkownicy;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_zadaniaChanging(int value);
    partial void Onid_zadaniaChanged();
    partial void OntytulChanging(string value);
    partial void OntytulChanged();
    partial void OntrescChanging(string value);
    partial void OntrescChanged();
    partial void Onautor_id_uzytkownicyChanging(int value);
    partial void Onautor_id_uzytkownicyChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    partial void Onid_klienciChanging(int value);
    partial void Onid_klienciChanged();
    partial void OnterminChanging(System.DateTime value);
    partial void OnterminChanged();
    #endregion
		
		public zadania()
		{
			this._klienci = default(EntityRef<klienci>);
			this._uzytkownicy = default(EntityRef<uzytkownicy>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_zadania", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_zadania
		{
			get
			{
				return this._id_zadania;
			}
			set
			{
				if ((this._id_zadania != value))
				{
					this.Onid_zadaniaChanging(value);
					this.SendPropertyChanging();
					this._id_zadania = value;
					this.SendPropertyChanged("id_zadania");
					this.Onid_zadaniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tytul", DbType="NChar(255) NOT NULL", CanBeNull=false)]
		public string tytul
		{
			get
			{
				return this._tytul;
			}
			set
			{
				if ((this._tytul != value))
				{
					this.OntytulChanging(value);
					this.SendPropertyChanging();
					this._tytul = value;
					this.SendPropertyChanged("tytul");
					this.OntytulChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tresc", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string tresc
		{
			get
			{
				return this._tresc;
			}
			set
			{
				if ((this._tresc != value))
				{
					this.OntrescChanging(value);
					this.SendPropertyChanging();
					this._tresc = value;
					this.SendPropertyChanged("tresc");
					this.OntrescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_autor_id_uzytkownicy", DbType="Int NOT NULL")]
		public int autor_id_uzytkownicy
		{
			get
			{
				return this._autor_id_uzytkownicy;
			}
			set
			{
				if ((this._autor_id_uzytkownicy != value))
				{
					if (this._uzytkownicy.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onautor_id_uzytkownicyChanging(value);
					this.SendPropertyChanging();
					this._autor_id_uzytkownicy = value;
					this.SendPropertyChanged("autor_id_uzytkownicy");
					this.Onautor_id_uzytkownicyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NChar(255) NOT NULL", CanBeNull=false)]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_klienci", DbType="Int NOT NULL")]
		public int id_klienci
		{
			get
			{
				return this._id_klienci;
			}
			set
			{
				if ((this._id_klienci != value))
				{
					if (this._klienci.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_klienciChanging(value);
					this.SendPropertyChanging();
					this._id_klienci = value;
					this.SendPropertyChanged("id_klienci");
					this.Onid_klienciChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_termin", DbType="Date NOT NULL")]
		public System.DateTime termin
		{
			get
			{
				return this._termin;
			}
			set
			{
				if ((this._termin != value))
				{
					this.OnterminChanging(value);
					this.SendPropertyChanging();
					this._termin = value;
					this.SendPropertyChanged("termin");
					this.OnterminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="klienci_zadania", Storage="_klienci", ThisKey="id_klienci", OtherKey="id_klienci", IsForeignKey=true)]
		public klienci klienci
		{
			get
			{
				return this._klienci.Entity;
			}
			set
			{
				klienci previousValue = this._klienci.Entity;
				if (((previousValue != value) 
							|| (this._klienci.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._klienci.Entity = null;
						previousValue.zadania.Remove(this);
					}
					this._klienci.Entity = value;
					if ((value != null))
					{
						value.zadania.Add(this);
						this._id_klienci = value.id_klienci;
					}
					else
					{
						this._id_klienci = default(int);
					}
					this.SendPropertyChanged("klienci");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="uzytkownicy_zadania", Storage="_uzytkownicy", ThisKey="autor_id_uzytkownicy", OtherKey="id_uzytkownicy", IsForeignKey=true)]
		public uzytkownicy uzytkownicy
		{
			get
			{
				return this._uzytkownicy.Entity;
			}
			set
			{
				uzytkownicy previousValue = this._uzytkownicy.Entity;
				if (((previousValue != value) 
							|| (this._uzytkownicy.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._uzytkownicy.Entity = null;
						previousValue.zadania.Remove(this);
					}
					this._uzytkownicy.Entity = value;
					if ((value != null))
					{
						value.zadania.Add(this);
						this._autor_id_uzytkownicy = value.id_uzytkownicy;
					}
					else
					{
						this._autor_id_uzytkownicy = default(int);
					}
					this.SendPropertyChanged("uzytkownicy");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.kredyty")]
	public partial class kredyty : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_kredyty;
		
		private int _id_klienci;
		
		private string _kwota;
		
		private bool _zgoda_pracownika;
		
		private bool _zgoda_kierownika;
		
		private EntityRef<klienci> _klienci;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_kredytyChanging(int value);
    partial void Onid_kredytyChanged();
    partial void Onid_klienciChanging(int value);
    partial void Onid_klienciChanged();
    partial void OnkwotaChanging(string value);
    partial void OnkwotaChanged();
    partial void Onzgoda_pracownikaChanging(bool value);
    partial void Onzgoda_pracownikaChanged();
    partial void Onzgoda_kierownikaChanging(bool value);
    partial void Onzgoda_kierownikaChanged();
    #endregion
		
		public kredyty()
		{
			this._klienci = default(EntityRef<klienci>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_kredyty", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_kredyty
		{
			get
			{
				return this._id_kredyty;
			}
			set
			{
				if ((this._id_kredyty != value))
				{
					this.Onid_kredytyChanging(value);
					this.SendPropertyChanging();
					this._id_kredyty = value;
					this.SendPropertyChanged("id_kredyty");
					this.Onid_kredytyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_klienci", DbType="Int NOT NULL")]
		public int id_klienci
		{
			get
			{
				return this._id_klienci;
			}
			set
			{
				if ((this._id_klienci != value))
				{
					if (this._klienci.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_klienciChanging(value);
					this.SendPropertyChanging();
					this._id_klienci = value;
					this.SendPropertyChanged("id_klienci");
					this.Onid_klienciChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kwota", DbType="NChar(255) NOT NULL", CanBeNull=false)]
		public string kwota
		{
			get
			{
				return this._kwota;
			}
			set
			{
				if ((this._kwota != value))
				{
					this.OnkwotaChanging(value);
					this.SendPropertyChanging();
					this._kwota = value;
					this.SendPropertyChanged("kwota");
					this.OnkwotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zgoda_pracownika", DbType="Bit NOT NULL")]
		public bool zgoda_pracownika
		{
			get
			{
				return this._zgoda_pracownika;
			}
			set
			{
				if ((this._zgoda_pracownika != value))
				{
					this.Onzgoda_pracownikaChanging(value);
					this.SendPropertyChanging();
					this._zgoda_pracownika = value;
					this.SendPropertyChanged("zgoda_pracownika");
					this.Onzgoda_pracownikaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zgoda_kierownika", DbType="Bit NOT NULL")]
		public bool zgoda_kierownika
		{
			get
			{
				return this._zgoda_kierownika;
			}
			set
			{
				if ((this._zgoda_kierownika != value))
				{
					this.Onzgoda_kierownikaChanging(value);
					this.SendPropertyChanging();
					this._zgoda_kierownika = value;
					this.SendPropertyChanged("zgoda_kierownika");
					this.Onzgoda_kierownikaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="klienci_kredyty", Storage="_klienci", ThisKey="id_klienci", OtherKey="id_klienci", IsForeignKey=true)]
		public klienci klienci
		{
			get
			{
				return this._klienci.Entity;
			}
			set
			{
				klienci previousValue = this._klienci.Entity;
				if (((previousValue != value) 
							|| (this._klienci.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._klienci.Entity = null;
						previousValue.kredyty.Remove(this);
					}
					this._klienci.Entity = value;
					if ((value != null))
					{
						value.kredyty.Add(this);
						this._id_klienci = value.id_klienci;
					}
					else
					{
						this._id_klienci = default(int);
					}
					this.SendPropertyChanged("klienci");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.uzytkownicy")]
	public partial class uzytkownicy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_uzytkownicy;
		
		private string _login;
		
		private string _haslo;
		
		private string _imie;
		
		private string _nazwisko;
		
		private bool _administrator;
		
		private bool _kierownik;
		
		private bool _pracownik;
		
		private EntitySet<zadania> _zadania;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_uzytkownicyChanging(int value);
    partial void Onid_uzytkownicyChanged();
    partial void OnloginChanging(string value);
    partial void OnloginChanged();
    partial void OnhasloChanging(string value);
    partial void OnhasloChanged();
    partial void OnimieChanging(string value);
    partial void OnimieChanged();
    partial void OnnazwiskoChanging(string value);
    partial void OnnazwiskoChanged();
    partial void OnadministratorChanging(bool value);
    partial void OnadministratorChanged();
    partial void OnkierownikChanging(bool value);
    partial void OnkierownikChanged();
    partial void OnpracownikChanging(bool value);
    partial void OnpracownikChanged();
    #endregion
		
		public uzytkownicy()
		{
			this._zadania = new EntitySet<zadania>(new Action<zadania>(this.attach_zadania), new Action<zadania>(this.detach_zadania));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_uzytkownicy", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_uzytkownicy
		{
			get
			{
				return this._id_uzytkownicy;
			}
			set
			{
				if ((this._id_uzytkownicy != value))
				{
					this.Onid_uzytkownicyChanging(value);
					this.SendPropertyChanging();
					this._id_uzytkownicy = value;
					this.SendPropertyChanged("id_uzytkownicy");
					this.Onid_uzytkownicyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_login", DbType="NChar(255) NOT NULL", CanBeNull=false)]
		public string login
		{
			get
			{
				return this._login;
			}
			set
			{
				if ((this._login != value))
				{
					this.OnloginChanging(value);
					this.SendPropertyChanging();
					this._login = value;
					this.SendPropertyChanged("login");
					this.OnloginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_haslo", DbType="NChar(255) NOT NULL", CanBeNull=false)]
		public string haslo
		{
			get
			{
				return this._haslo;
			}
			set
			{
				if ((this._haslo != value))
				{
					this.OnhasloChanging(value);
					this.SendPropertyChanging();
					this._haslo = value;
					this.SendPropertyChanged("haslo");
					this.OnhasloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imie", DbType="NChar(255) NOT NULL", CanBeNull=false)]
		public string imie
		{
			get
			{
				return this._imie;
			}
			set
			{
				if ((this._imie != value))
				{
					this.OnimieChanging(value);
					this.SendPropertyChanging();
					this._imie = value;
					this.SendPropertyChanged("imie");
					this.OnimieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nazwisko", DbType="NChar(255) NOT NULL", CanBeNull=false)]
		public string nazwisko
		{
			get
			{
				return this._nazwisko;
			}
			set
			{
				if ((this._nazwisko != value))
				{
					this.OnnazwiskoChanging(value);
					this.SendPropertyChanging();
					this._nazwisko = value;
					this.SendPropertyChanged("nazwisko");
					this.OnnazwiskoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_administrator", DbType="Bit NOT NULL")]
		public bool administrator
		{
			get
			{
				return this._administrator;
			}
			set
			{
				if ((this._administrator != value))
				{
					this.OnadministratorChanging(value);
					this.SendPropertyChanging();
					this._administrator = value;
					this.SendPropertyChanged("administrator");
					this.OnadministratorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kierownik", DbType="Bit NOT NULL")]
		public bool kierownik
		{
			get
			{
				return this._kierownik;
			}
			set
			{
				if ((this._kierownik != value))
				{
					this.OnkierownikChanging(value);
					this.SendPropertyChanging();
					this._kierownik = value;
					this.SendPropertyChanged("kierownik");
					this.OnkierownikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pracownik", DbType="Bit NOT NULL")]
		public bool pracownik
		{
			get
			{
				return this._pracownik;
			}
			set
			{
				if ((this._pracownik != value))
				{
					this.OnpracownikChanging(value);
					this.SendPropertyChanging();
					this._pracownik = value;
					this.SendPropertyChanged("pracownik");
					this.OnpracownikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="uzytkownicy_zadania", Storage="_zadania", ThisKey="id_uzytkownicy", OtherKey="autor_id_uzytkownicy")]
		public EntitySet<zadania> zadania
		{
			get
			{
				return this._zadania;
			}
			set
			{
				this._zadania.Assign(value);
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
		
		private void attach_zadania(zadania entity)
		{
			this.SendPropertyChanging();
			entity.uzytkownicy = this;
		}
		
		private void detach_zadania(zadania entity)
		{
			this.SendPropertyChanging();
			entity.uzytkownicy = null;
		}
	}
}
#pragma warning restore 1591
