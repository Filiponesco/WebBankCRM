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

namespace BankCRM
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
    partial void Insertuzytkownicy(uzytkownicy instance);
    partial void Updateuzytkownicy(uzytkownicy instance);
    partial void Deleteuzytkownicy(uzytkownicy instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::BankCRM.Properties.Settings.Default.bankcrmConnectionString, mappingSource)
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
		
		private string _uprawnienia;
		
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
    partial void OnuprawnieniaChanging(string value);
    partial void OnuprawnieniaChanged();
    #endregion
		
		public uzytkownicy()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uprawnienia", DbType="NChar(255) NOT NULL", CanBeNull=false)]
		public string uprawnienia
		{
			get
			{
				return this._uprawnienia;
			}
			set
			{
				if ((this._uprawnienia != value))
				{
					this.OnuprawnieniaChanging(value);
					this.SendPropertyChanging();
					this._uprawnienia = value;
					this.SendPropertyChanged("uprawnienia");
					this.OnuprawnieniaChanged();
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
