USE [master]
GO
/****** Object:  Database [bankcrm]    Script Date: 16.01.2020 18:26:28 ******/
CREATE DATABASE [bankcrm]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bankcrm', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\bankcrm.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bankcrm_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\bankcrm_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [bankcrm] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bankcrm].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bankcrm] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bankcrm] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bankcrm] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bankcrm] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bankcrm] SET ARITHABORT OFF 
GO
ALTER DATABASE [bankcrm] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bankcrm] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bankcrm] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bankcrm] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bankcrm] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bankcrm] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bankcrm] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bankcrm] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bankcrm] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bankcrm] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bankcrm] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bankcrm] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bankcrm] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bankcrm] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bankcrm] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bankcrm] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bankcrm] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bankcrm] SET RECOVERY FULL 
GO
ALTER DATABASE [bankcrm] SET  MULTI_USER 
GO
ALTER DATABASE [bankcrm] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bankcrm] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bankcrm] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bankcrm] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bankcrm] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'bankcrm', N'ON'
GO
ALTER DATABASE [bankcrm] SET QUERY_STORE = OFF
GO
USE [bankcrm]
GO
/****** Object:  Table [dbo].[klienci]    Script Date: 16.01.2020 18:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[klienci](
	[id_klienci] [int] IDENTITY(1,1) NOT NULL,
	[imie] [nchar](255) NOT NULL,
	[nazwisko] [nchar](255) NOT NULL,
	[e-mail] [nchar](255) NULL,
	[telefon] [nchar](255) NOT NULL,
	[pesel] [nchar](255) NOT NULL,
 CONSTRAINT [PK_klienci] PRIMARY KEY CLUSTERED 
(
	[id_klienci] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kredyty]    Script Date: 16.01.2020 18:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kredyty](
	[id_kredyty] [int] IDENTITY(1,1) NOT NULL,
	[id_klienci] [int] NOT NULL,
	[kwota] [nchar](255) NOT NULL,
	[zgoda_pracownika] [bit] NOT NULL,
	[zgoda_kierownika] [bit] NOT NULL,
 CONSTRAINT [PK_kredyty] PRIMARY KEY CLUSTERED 
(
	[id_kredyty] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[uzytkownicy]    Script Date: 16.01.2020 18:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uzytkownicy](
	[id_uzytkownicy] [int] IDENTITY(1,1) NOT NULL,
	[login] [nchar](255) NOT NULL,
	[haslo] [nchar](255) NOT NULL,
	[imie] [nchar](255) NOT NULL,
	[nazwisko] [nchar](255) NOT NULL,
	[administrator] [bit] NOT NULL,
	[kierownik] [bit] NOT NULL,
	[pracownik] [bit] NOT NULL,
 CONSTRAINT [PK_uzytkownicy] PRIMARY KEY CLUSTERED 
(
	[id_uzytkownicy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[zadania]    Script Date: 16.01.2020 18:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[zadania](
	[id_zadania] [int] IDENTITY(1,1) NOT NULL,
	[tytul] [nchar](255) NOT NULL,
	[tresc] [text] NULL,
	[autor_id_uzytkownicy] [int] NOT NULL,
	[status] [nchar](255) NOT NULL,
	[id_klienci] [int] NOT NULL,
	[termin] [date] NOT NULL,
 CONSTRAINT [PK_zadania] PRIMARY KEY CLUSTERED 
(
	[id_zadania] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[klienci] ON 

INSERT [dbo].[klienci] ([id_klienci], [imie], [nazwisko], [e-mail], [telefon], [pesel]) VALUES (1, N'Aleksandra                                                                                                                                                                                                                                                     ', N'Gawron                                                                                                                                                                                                                                                         ', N'olagawron@poczta.pl                                                                                                                                                                                                                                            ', N'123456789                                                                                                                                                                                                                                                      ', N'98765412345                                                                                                                                                                                                                                                    ')
INSERT [dbo].[klienci] ([id_klienci], [imie], [nazwisko], [e-mail], [telefon], [pesel]) VALUES (2, N'Adam                                                                                                                                                                                                                                                           ', N'Nowak                                                                                                                                                                                                                                                          ', N'adamnowak@poczta.pl                                                                                                                                                                                                                                            ', N'987654321                                                                                                                                                                                                                                                      ', N'94567334567                                                                                                                                                                                                                                                    ')
INSERT [dbo].[klienci] ([id_klienci], [imie], [nazwisko], [e-mail], [telefon], [pesel]) VALUES (25, N'Marcin                                                                                                                                                                                                                                                         ', N'Kowal                                                                                                                                                                                                                                                          ', N'marcinkowal@poczta.pl                                                                                                                                                                                                                                          ', N'123123123                                                                                                                                                                                                                                                      ', N'93125498765                                                                                                                                                                                                                                                    ')
INSERT [dbo].[klienci] ([id_klienci], [imie], [nazwisko], [e-mail], [telefon], [pesel]) VALUES (29, N'Ewa                                                                                                                                                                                                                                                            ', N'Gruszka                                                                                                                                                                                                                                                        ', N'ewagruszka@poczta.pl                                                                                                                                                                                                                                           ', N'555555555                                                                                                                                                                                                                                                      ', N'87121245673                                                                                                                                                                                                                                                    ')
INSERT [dbo].[klienci] ([id_klienci], [imie], [nazwisko], [e-mail], [telefon], [pesel]) VALUES (30, N'Piotr                                                                                                                                                                                                                                                          ', N'Ryba                                                                                                                                                                                                                                                           ', N'piotrryba@poczta.pl                                                                                                                                                                                                                                            ', N'456234789                                                                                                                                                                                                                                                      ', N'65070857684                                                                                                                                                                                                                                                    ')
SET IDENTITY_INSERT [dbo].[klienci] OFF
SET IDENTITY_INSERT [dbo].[kredyty] ON 

INSERT [dbo].[kredyty] ([id_kredyty], [id_klienci], [kwota], [zgoda_pracownika], [zgoda_kierownika]) VALUES (16, 2, N'15000                                                                                                                                                                                                                                                          ', 1, 0)
INSERT [dbo].[kredyty] ([id_kredyty], [id_klienci], [kwota], [zgoda_pracownika], [zgoda_kierownika]) VALUES (22, 2, N'123456                                                                                                                                                                                                                                                         ', 1, 0)
INSERT [dbo].[kredyty] ([id_kredyty], [id_klienci], [kwota], [zgoda_pracownika], [zgoda_kierownika]) VALUES (23, 1, N'750000                                                                                                                                                                                                                                                         ', 1, 0)
INSERT [dbo].[kredyty] ([id_kredyty], [id_klienci], [kwota], [zgoda_pracownika], [zgoda_kierownika]) VALUES (24, 1, N'5250000                                                                                                                                                                                                                                                        ', 1, 0)
INSERT [dbo].[kredyty] ([id_kredyty], [id_klienci], [kwota], [zgoda_pracownika], [zgoda_kierownika]) VALUES (27, 25, N'1000000                                                                                                                                                                                                                                                        ', 1, 0)
INSERT [dbo].[kredyty] ([id_kredyty], [id_klienci], [kwota], [zgoda_pracownika], [zgoda_kierownika]) VALUES (30, 25, N'120000                                                                                                                                                                                                                                                         ', 1, 0)
INSERT [dbo].[kredyty] ([id_kredyty], [id_klienci], [kwota], [zgoda_pracownika], [zgoda_kierownika]) VALUES (31, 29, N'50000000                                                                                                                                                                                                                                                       ', 1, 1)
INSERT [dbo].[kredyty] ([id_kredyty], [id_klienci], [kwota], [zgoda_pracownika], [zgoda_kierownika]) VALUES (32, 1, N'120000                                                                                                                                                                                                                                                         ', 0, 0)
INSERT [dbo].[kredyty] ([id_kredyty], [id_klienci], [kwota], [zgoda_pracownika], [zgoda_kierownika]) VALUES (36, 25, N'120000                                                                                                                                                                                                                                                         ', 1, 0)
SET IDENTITY_INSERT [dbo].[kredyty] OFF
SET IDENTITY_INSERT [dbo].[uzytkownicy] ON 

INSERT [dbo].[uzytkownicy] ([id_uzytkownicy], [login], [haslo], [imie], [nazwisko], [administrator], [kierownik], [pracownik]) VALUES (1, N'admin                                                                                                                                                                                                                                                          ', N'admin                                                                                                                                                                                                                                                          ', N'Filip                                                                                                                                                                                                                                                          ', N'Gaweł                                                                                                                                                                                                                                                          ', 1, 0, 0)
INSERT [dbo].[uzytkownicy] ([id_uzytkownicy], [login], [haslo], [imie], [nazwisko], [administrator], [kierownik], [pracownik]) VALUES (2, N'user                                                                                                                                                                                                                                                           ', N'user                                                                                                                                                                                                                                                           ', N'Adam                                                                                                                                                                                                                                                           ', N'Nowakowski                                                                                                                                                                                                                                                     ', 0, 0, 1)
INSERT [dbo].[uzytkownicy] ([id_uzytkownicy], [login], [haslo], [imie], [nazwisko], [administrator], [kierownik], [pracownik]) VALUES (10, N'pracownik                                                                                                                                                                                                                                                      ', N'pracownik                                                                                                                                                                                                                                                      ', N'Jan                                                                                                                                                                                                                                                            ', N'Kowalski                                                                                                                                                                                                                                                       ', 0, 0, 1)
INSERT [dbo].[uzytkownicy] ([id_uzytkownicy], [login], [haslo], [imie], [nazwisko], [administrator], [kierownik], [pracownik]) VALUES (12, N'kierownik                                                                                                                                                                                                                                                      ', N'kierownik                                                                                                                                                                                                                                                      ', N'Bolesław                                                                                                                                                                                                                                                       ', N'Chrobry                                                                                                                                                                                                                                                        ', 0, 1, 0)
INSERT [dbo].[uzytkownicy] ([id_uzytkownicy], [login], [haslo], [imie], [nazwisko], [administrator], [kierownik], [pracownik]) VALUES (14, N'                                                                                                                                                                                                                                                               ', N'                                                                                                                                                                                                                                                               ', N'Test                                                                                                                                                                                                                                                           ', N'Test                                                                                                                                                                                                                                                           ', 1, 1, 1)
SET IDENTITY_INSERT [dbo].[uzytkownicy] OFF
SET IDENTITY_INSERT [dbo].[zadania] ON 

INSERT [dbo].[zadania] ([id_zadania], [tytul], [tresc], [autor_id_uzytkownicy], [status], [id_klienci], [termin]) VALUES (1, N'Kredyt                                                                                                                                                                                                                                                         ', N'Zadzwonic i zapytać o kredyt', 1, N'nowe                                                                                                                                                                                                                                                           ', 1, CAST(N'2020-01-16' AS Date))
INSERT [dbo].[zadania] ([id_zadania], [tytul], [tresc], [autor_id_uzytkownicy], [status], [id_klienci], [termin]) VALUES (2, N'Hasło                                                                                                                                                                                                                                                          ', N'Zresetować hasło', 2, N'nowe                                                                                                                                                                                                                                                           ', 25, CAST(N'2020-01-17' AS Date))
INSERT [dbo].[zadania] ([id_zadania], [tytul], [tresc], [autor_id_uzytkownicy], [status], [id_klienci], [termin]) VALUES (3, N'Karta                                                                                                                                                                                                                                                          ', N'Wymienić kartę', 10, N'nowe                                                                                                                                                                                                                                                           ', 30, CAST(N'2020-01-23' AS Date))
SET IDENTITY_INSERT [dbo].[zadania] OFF
ALTER TABLE [dbo].[kredyty] ADD  CONSTRAINT [DF_kredyty_zgoda_pracownika]  DEFAULT ((0)) FOR [zgoda_pracownika]
GO
ALTER TABLE [dbo].[kredyty] ADD  CONSTRAINT [DF_kredyty_zgoda_kierownika]  DEFAULT ((0)) FOR [zgoda_kierownika]
GO
ALTER TABLE [dbo].[uzytkownicy] ADD  CONSTRAINT [DF_uzytkownicy2_administrator]  DEFAULT ((0)) FOR [administrator]
GO
ALTER TABLE [dbo].[uzytkownicy] ADD  CONSTRAINT [DF_uzytkownicy2_kierownik]  DEFAULT ((0)) FOR [kierownik]
GO
ALTER TABLE [dbo].[uzytkownicy] ADD  CONSTRAINT [DF_uzytkownicy2_pracownik]  DEFAULT ((0)) FOR [pracownik]
GO
ALTER TABLE [dbo].[kredyty]  WITH CHECK ADD  CONSTRAINT [FK_kredyty_klienci] FOREIGN KEY([id_klienci])
REFERENCES [dbo].[klienci] ([id_klienci])
GO
ALTER TABLE [dbo].[kredyty] CHECK CONSTRAINT [FK_kredyty_klienci]
GO
ALTER TABLE [dbo].[zadania]  WITH CHECK ADD  CONSTRAINT [FK_zadania_klienci] FOREIGN KEY([id_klienci])
REFERENCES [dbo].[klienci] ([id_klienci])
GO
ALTER TABLE [dbo].[zadania] CHECK CONSTRAINT [FK_zadania_klienci]
GO
ALTER TABLE [dbo].[zadania]  WITH CHECK ADD  CONSTRAINT [FK_zadania_uzytkownicy] FOREIGN KEY([autor_id_uzytkownicy])
REFERENCES [dbo].[uzytkownicy] ([id_uzytkownicy])
GO
ALTER TABLE [dbo].[zadania] CHECK CONSTRAINT [FK_zadania_uzytkownicy]
GO
USE [master]
GO
ALTER DATABASE [bankcrm] SET  READ_WRITE 
GO
