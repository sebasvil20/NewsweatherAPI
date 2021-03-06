USE [master]
GO
/****** Object:  Database [newsweatherapi]    Script Date: 5/05/2021 1:31:30 p. m. ******/
CREATE DATABASE [newsweatherapi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'newsweatherapi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\newsweatherapi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'newsweatherapi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\newsweatherapi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [newsweatherapi] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [newsweatherapi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [newsweatherapi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [newsweatherapi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [newsweatherapi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [newsweatherapi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [newsweatherapi] SET ARITHABORT OFF 
GO
ALTER DATABASE [newsweatherapi] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [newsweatherapi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [newsweatherapi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [newsweatherapi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [newsweatherapi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [newsweatherapi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [newsweatherapi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [newsweatherapi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [newsweatherapi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [newsweatherapi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [newsweatherapi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [newsweatherapi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [newsweatherapi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [newsweatherapi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [newsweatherapi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [newsweatherapi] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [newsweatherapi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [newsweatherapi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [newsweatherapi] SET  MULTI_USER 
GO
ALTER DATABASE [newsweatherapi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [newsweatherapi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [newsweatherapi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [newsweatherapi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [newsweatherapi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [newsweatherapi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [newsweatherapi] SET QUERY_STORE = OFF
GO
USE [newsweatherapi]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/05/2021 1:31:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 5/05/2021 1:31:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[City_Name] [nvarchar](max) NULL,
	[City_Population] [nvarchar](max) NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 5/05/2021 1:31:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Author] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[UrlToImage] [nvarchar](max) NULL,
	[PublishedAt] [nvarchar](max) NULL,
	[Content] [nvarchar](max) NULL,
	[CityId] [int] NOT NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SearchHistory]    Script Date: 5/05/2021 1:31:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SearchHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HistoryName] [nvarchar](max) NULL,
	[CityId] [int] NULL,
 CONSTRAINT [PK_SearchHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Weather]    Script Date: 5/05/2021 1:31:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Weather](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Weather_Time] [nvarchar](max) NULL,
	[Temperature] [nvarchar](max) NULL,
	[Weather_Description] [nvarchar](max) NULL,
	[Wind_Speed] [nvarchar](max) NULL,
	[Wind_Degree] [nvarchar](max) NULL,
	[Wind_Direction] [nvarchar](max) NULL,
	[Presure] [nvarchar](max) NULL,
	[CityId] [int] NOT NULL,
 CONSTRAINT [PK_Weather] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210504210643_Initializing', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210504211004_CitiesUpdate', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210504211300_wheaterUpdate', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210504211740_FixingDatabase', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210504214707_FixingDatabaseAgain', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210504215100_FixingDatabaseAgainn', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210504221411_FixingDatabaseAgainna', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210504230619_RestartingDatabase', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210505130640_AddingNewsSchema', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210505134016_FixingHistorySchema', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210505134232_FixingHistorySchema2', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210505134315_FixingHistorySchema3', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210505134325_FixingHistorySchema4', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210505140940_FixingHistorySchema5', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210505142306_FixingHistorySchema6', N'5.0.5')
GO
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([Id], [City_Name], [City_Population]) VALUES (1, N'Medellin', N'2.529.403')
INSERT [dbo].[Cities] ([Id], [City_Name], [City_Population]) VALUES (2, N'Bogota', N'7.743.955')
INSERT [dbo].[Cities] ([Id], [City_Name], [City_Population]) VALUES (3, N'Cartagena', N'1.028.736')
INSERT [dbo].[Cities] ([Id], [City_Name], [City_Population]) VALUES (4, N'New York', N'8.398.748')
INSERT [dbo].[Cities] ([Id], [City_Name], [City_Population]) VALUES (5, N'Ibague', N'541.010')
INSERT [dbo].[Cities] ([Id], [City_Name], [City_Population]) VALUES (6, N'California', N'39.538.223')
INSERT [dbo].[Cities] ([Id], [City_Name], [City_Population]) VALUES (7, N'Cucuta', N'777.948')
SET IDENTITY_INSERT [dbo].[Cities] OFF
GO
SET IDENTITY_INSERT [dbo].[News] ON 

INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (1, N'Wilson Wong', N'At least four dead after small plane crashes into Mississippi home - NBC News', N'The plane crashed into a home on Annie Christie Drive in Hattiesburg, about 90 miles southwest of Jackson, late Tuesday, authorities said.', N'https://www.nbcnews.com/news/us-news/least-four-dead-after-small-plane-crashes-mississippi-home-n1266356', N'https://media4.s-nbcnews.com/j/newscms/2021_18/3470420/210505-hattiesburg-crash-mb-1659_60e76ebef43846e8d41bf4441b55fdcc.nbcnews-fp-1200-630.png', N'2021-05-05 16:18:36', N'At least four people died after a small airplane crashed into a Mississippi home late Tuesday, officials said.\r\nA Mitsubishi twin-engine plane with three passengers crashed at about 11:20 p.m. CT at … [+980 chars]', 1)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (2, N'Sophie Lewis', N'Falling debris from a Chinese rocketis hurtling back to Earth — and scientists aren''t sure where it will land - CBS News', N'Its fast speed makes its landing place nearly impossible to predict, but it is expected to make landfall in the coming days', N'https://www.cbsnews.com/news/china-rocket-debris-falling-earth/', N'https://cbsnews1.cbsistatic.com/hub/i/r/2021/05/04/4e125a3e-4696-41e7-87f8-f6c5c0e3b16e/thumbnail/1200x630/f48ddc96a9f623f639a048dbc848867c/gettyimages-1315232701.jpg', N'2021-05-05 15:41:01', N'A huge piece of space junk is about to make an uncontrolled re-entry back into Earth''s atmosphere, threatening to drop debris on a number of cities around the world in the coming days. It''s leftover … [+3263 chars]', 1)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (3, N'Chris Welch', N'Google’s Entertainment Space makes Android tablets look like Google TV - The Verge', N'Google’s new Entertainment Space is an all-in-one hub that brings together movies, TV shows, games, and books on Android tablets. It’s coming to tablets from Walmart soon and more devices later this year', N'https://www.theverge.com/2021/5/5/22420405/google-entertainment-space-announced-android-tablets', N'https://cdn.vox-cdn.com/thumbor/0iOyCwBnbLmXMOxrAp11tEzBF5E=/0x225:1987x1265/fit-in/1200x630/cdn.vox-cdn.com/uploads/chorus_asset/file/22492735/entspace1.jpg', N'2021-05-05 15:30:00', N'Rolling out to Walmarts tablets soon and more devices by the end of the year\r\nGoogle is today announcing a new feature on Android tablets that plays to one of their greatest strengths: media consumpt… [+4373 chars]', 1)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (4, N'Daniel Victor', N'Peloton Recalls Treadmills After Injuries and a Child’s Death - The New York Times', N'The chief executive of Peloton said the company “made a mistake” by initially resisting a U.S. safety agency’s warning about the devices last month', N'https://www.nytimes.com/2021/05/05/business/peloton-recall-tread-plus.html', N'https://static01.nyt.com/images/2021/05/05/multimedia/05xp-peloton/05xp-peloton-facebookJumbo.jpg', N'2021-05-05 15:20:13', N'The machines were sold in the United States from November to March. The company is working on a repair to be offered to customers in the coming weeks, the commission said in a statement. The software… [+787 chars]', 1)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (6, N'Harriet Johnston', N'Kate Middleton and Prince William are launching YouTube channel - Daily Mail', N'The Duke, 38, and Duchess of Cambridge, 39, shared a short video on their social media channels today called: ''Welcome to our official YouTube channel!''', N'https://www.dailymail.co.uk/femail/article-9546207/Kate-Middleton-Prince-William-launching-YouTube-channel.html', N'https://i.dailymail.co.uk/1s/2021/05/05/16/42612772-0-image-a-52_1620229881481.jpg', N'2021-05-05 15:19:37', N'Kate Middleton and Prince William have announced they are launching a YouTube channel by sharing a slick promotional video. \r\nThe Duke, 38, and Duchess of Cambridge, 39, posted a 25-second clip on th… [+9008 chars]', 2)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (7, N'CBS Sports', N'Ranking every NFL running back drafted in Round 1 since 2000: LaDainian Tomlinson leads the list - CBS Sports', N'First-round running backs have had varying levels of success', N'https://www.cbssports.com/nfl/news/ranking-every-nfl-running-back-drafted-in-round-1-since-2000-ladainian-tomlinson-leads-the-list/', N'https://sportshub.cbsistatic.com/i/r/2021/05/04/df8171fc-51ea-4f2a-bfd0-c71638a743e8/thumbnail/1200x675/962020aaa354584bd3a9342e295768cd/lt.png', N'2021-05-05 15:15:00', N'Najee Harris was quite pleased upon being selected by the Steelers in this year''s NFL Draft. That being said, he didn''t love seeing 23 players get selected before his name was called. \r\nFive quarterb… [+25919 chars]', 2)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (8, N'Berkeley Lovelace Jr.', N'CDC projects a surge in U.S. Covid cases through May due to variants before vaccinations drive a ''sharp decline'' - CNBC', N'While Covid cases are expected to increase this month, hospitalizations and deaths will likely remain low nationally, the U.S. agency said.', N'https://www.cnbc.com/2021/05/05/cdc-projects-a-surge-in-us-covid-cases-through-may-due-to-bpoint1point1point7-variant-before-a-sharp-decline-.html', N'https://image.cnbcfm.com/api/v1/image/106851215-1615296268868-gettyimages-1231609028-US-NEW_YORK-COVID-19_CASES-29_MLN.jpeg?v=1615296368', N'2021-05-05 15:04:25', N'Covid-19 cases will likely surge again in the U.S. as the highly contagious B.1.1.7 variant takes hold across the country, peaking in May before sharply declining by July, according to new data relea… [+3355 chars]', 2)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (9, N'Cristina Marcos', N'Hoyer: GOP lawmakers mad at Cheney because she ''believes in the truth'' | TheHill - The Hill', N'House Majority Leader Steny Hoyer (D-Md.) said Wednesday that it is a \"shame\" that Republicans ar...', N'https://thehill.com/homenews/house/551906-hoyer-gop-lawmakers-mad-at-cheney-because-she-believes-in-the-truth', N'https://thehill.com/sites/default/files/cheneyliz_041421gn3_lead.jpg', N'2021-05-05 15:01:32', N'House Majority Leader Steny HoyerSteny Hamilton HoyerNC House ending remote voting for lawmakersOn The Money: Breaking down Biden''s .8T American Families Plan | Powell voices confidence in Fed''s hand… [+3537 chars]', 3)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (10, N'Ian Sample', N'Archaeologists uncover oldest human burial in Africa - The Guardian', N'Quite spectacular’ discovery shows three-year-old child was carefully laid to rest nearly 80,000 years ago', N'https://amp.theguardian.com/science/2021/may/05/archaeologists-uncover-oldest-human-burial-in-africa', NULL, N'2021-05-05 15:00:00', N'ArchaeologyQuite spectacular discovery shows three-year-old child was carefully laid to rest nearly 80,000 years ago\r\nArchaeologists have identified the oldest known human burial in Africa during fie… [+4383 chars]', 3)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (11, N'Tatiana Tenreyro', N'Model Ashley Smithline shares detailed account of alleged abuse during relationship with Marilyn Manson - The A.V. Club', N'Model Ashley Morgan Smithline shared details of the alleged abused she faced during her two-year relationship with Manson, including rape and other forms of physical violence', N'https://music.avclub.com/model-ashley-smithline-shares-detailed-account-of-alleg-1846827589', N'https://i.kinja-img.com/gawker-media/image/upload/c_fill,f_auto,fl_progressive,g_center,h_675,pg_1,q_80,w_1200/5f4c7b0684ac073b9c8b4b4e1e54a06f.png', N'2021-05-05 14:33:00', N'In 2019, Evan Rachel Wood testified on behalf of the Phoenix Acta bill that extends the time domestic abuse survivors have to press charges against their abusersbefore the State Senate, giving a deta… [+2636 chars]', 3)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (12, N'Tim Britton', N'How is the Mets'' Jacob deGrom throwing this hard and still getting better? ‘I’ve never seen anything like... - The Athletic', N'He''s a generational pitcher,” Mets pitching coach Jeremy Hefner said of deGrom. “We''re witnessing something that most guys can''t do', N'https://theathletic.com/2556671/2021/05/05/how-is-the-mets-jacob-degrom-throwing-this-hard-and-still-getting-better-ive-never-seen-anything-like-it/', N'https://cdn.theathletic.com/app/uploads/2021/03/24202343/GettyImages-1231656051-1024x682.jpg', N'2021-05-05 14:28:55', N'Jacob deGrom does not, as far as anyone knows, play the French horn. He pitches with two cleats on, his hat on straight, and with total commitment to his craft.And yet, when Randy Sullivan, founder o… [+385 chars]', 4)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (13, N'Max Colchester', N'Covid-19 Hits Indian Delegation Attending London G-7 Meeting - The Wall Street Journal', N'Meeting goes ahead after members of Indian delegation test positive', N'https://www.wsj.com/articles/covid-19-hits-indias-g-7-diplomats-in-london-11620215947', N'https://images.wsj.net/im-334257/social', N'2021-05-05 14:21:00', N'LONDONA meeting of the foreign ministers of the Group of Seven in London suffered a Covid-19 scare when the delegation from India went into self-isolation after two officials tested positive, pointin… [+1114 chars]', 4)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (14, N'Adrian Horton', N'I want people to understand what really happened’: did the Son of Sam serial killer act alone? - The Guardian', N'Netflix’s The Sons of Sam: A Descent into Darkness re-examines the infamous New York serial killer through the eyes of one man’s obsession with the case', N'https://amp.theguardian.com/tv-and-radio/2021/may/05/the-sons-of-sam-netflix-docuseries-serial-killer', N'https://i.guim.co.uk/img/media/8a5628eb665962edb0276fda0fba7a83938097ab/22_0_1350_810/master/1350.jpg?width=1200&height=630&quality=85&auto=format&fit=crop&overlay-align=bottom%2Cleft&overlay-width=100p&overlay-base64=L2ltZy9zdGF0aWMvb3ZlcmxheXMvdGctZGVmYXVsdC5wbmc&enable=upscale&s=266d628c3c92a167bdb8255b33e4d4d8', N'2021-05-05 14:11:00', N'The arrest of David Berkowitz on 10 August 1977 brought to an end the largest manhunt yet in the New York City police departments (NYPD) history and the citys notorious summer of fear.\r\nThe city was … [+7294 chars]', 4)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (16, N'William Wan', N'U.S. birthrate falls to its lowest rate in decades in wake of the pandemic - The Washington Post', N'It is the biggest annual decrease in almost half a century -- suggesting the coronavirus pandemic has accelerated an existing trend', N'https://www.washingtonpost.com/health/2021/05/05/birth-rate-falls-pandemic/', N'https://www.washingtonpost.com/wp-apps/imrs.php?src=https://arc-anglerfish-washpost-prod-washpost.s3.amazonaws.com/public/V5FFOATJMAI6XJTO4JYEN2PITA.jpg&w=1440', N'2021-05-05 14:02:00', N'The birthrate fell across races and ethnicity and almost all age groups. For years, American women have increasingly postponed having children and had fewer when they do. That led to declining births… [+130 chars]', 5)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (17, N'Semana', N'Video | Claudia López casi rompe en llanto al reportar el atentado al CAI Aurora en Bogotá - Semana', N'Los ciudadanos de Bogotá vivieron en las últimas horas momentos de terror, debido a los actos vandálicos que se presentaron en algunas localidades de la ciudad', N'https://www.semana.com/nacion/articulo/video-claudia-lopez-casi-rompe-en-llanto-al-reportar-el-atentando-al-cai-aurora-en-bogota/202107/', N'https://www.semana.com/resizer/Jv8Z6YWmVcxeUwiG7Bf4-XMB8gw=/1200x646/filters:format(jpg):quality(70)/cloudfront-us-east-1.images.arcpublishing.com/semana/6FN57OMORVAUXGADYN2JOMHKDM.jpeg', N'2021-05-05 15:42:19', N'Los ciudadanos de Bogotá vivieron en las últimas horas momentos de terror, debido a los actos vandálicos que se presentaron en algunas localidades de la ciudad', 5)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (18, N'Pulzo.com', N'Jessi Uribe, admirador de Álvaro Uribe, ahora dice que no es uribista - Pulzo', N'Jessi Uribe aseguró que no es uribista, a pesar de que meses atrás había confesado su admiración por Álvaro Uribe', N'https://www.pulzo.com/entretenimiento/jessi-uribe-dice-que-no-es-uribista-arrepiente-hablar-politica-PP1049009', N'http://static.pulzo.com/images/20210505094958/alvaro-uribe-y-jessi-uribe-900x485.jpg', N'2021-05-05 15:11:40', N'Jessi Uribe se unió a la larga lista de famosos que usó sus redes sociales en las últimas horas para dejar un mensaje de unión, a propósito de la crisis social que vive el país desde hace días por el… [+1510 chars]', 5)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (19, N'Vanguardia', N'recio del huevo aumentaría $700 si continúan los bloqueos - Vanguardia', N'A una semana del cese de actividades productivas e interrupción de las cadenas de suministro, el abastecimiento de bienes de primera necesidad del suroccidente del país se ve en riesgo y tiene en vilo a muchos empresarios. Juan Felipe Montoya, presidente de H…', N'https://www.vanguardia.com/economia/nacional/precio-del-huevo-aumentaria-700-si-continuan-los-bloqueos-EE3732226', N'https://www.vanguardia.com/binrepository/1200x800/0c86/1200d628/upper-right/12204/QXSU/gettyimages-540736440_5639949_20210505100625.jpg', N'2021-05-05 15:07:12', N'A una semana del cese de actividades productivas e interrupción de las cadenas de suministro, el abastecimiento de bienes de primera necesidad del suroccidente del país se ve en riesgo y tiene en vil… [+3010 chars]', 6)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (21, N'Pulzo', N'“Es inútil hacer falsas promesas”: Egan advierte sobre posible dolor de espalda en el Giro - Pulzo.com', N'Egan Bernal dice estar en buena forma para el Giro de Italia, pero todo dependerá de sus dolores de espalda', N'https://www.pulzo.com/deportes/egan-bernal-habla-sobre-sus-dolores-espalda-giro-italia-PP1049000', N'http://static.pulzo.com/images/20210505085044/egan1-900x485.jpg', N'2021-05-05 13:52:43', N'Por tal razón, el equipo Ineos decidió que el liderato de la escuadra será compartido entre Egan Bernal y el ruso Pavel Sivakov, por si Bernal llegara a desfallecer, informa el portal especializado C… [+2196 chars]', 6)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (22, N'Caracol Radio', N'NetBlocks confirma bloqueo del servicio de internet en Cali - Caracol Radio', N'Las métricas de la red corroboran los informes de los usuarios sobre dificultades para conectarse en medio de protestas generalizadas', N'https://caracol.com.co/programa/2021/05/05/6am_hoy_por_hoy/1620215929_739991.html', N'https://cr00.epimg.net/radio/imagenes/2020/05/01/nacional/1588366168_074591_1588366226_noticia_normal.jpg', N'2021-05-05 11:58:49', N'Diversas denuncias de manifestantes en Cali se han escuchado en las últimas horas sobre el bloqueo de servicios de internet y bloqueo del servicio de datos en la ciudad en medio de las protestas.\r\nLo… [+1251 chars]', 6)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (23, N'Elespectador', N'“No renunciamos a ninguna herramienta”: Duque sobre conmoción interior - El Espectador', N'El primer mandatario explicó que esta se podría aplicar de manera focalizada en un determinado territorio', N'https://www.elespectador.com/noticias/politica/no-renunciamos-a-ninguna-herramienta-que-nos-de-la-constitucion-duque-sobre-conmocion-interior/', N'https://www.elespectador.com/resizer/XdBPkmYh8DygDlRP4BgcmQptupc=/657x0/cloudfront-us-east-1.images.arcpublishing.com/elespectador/UUDJSL75PJFXBDABOYF3BK3GHY.jpeg', N'2021-05-05 11:25:00', N'El primer mandatario explicó que esta se podría aplicar de manera focalizada en un determinado territorio. No estoy diciendo que lo voy a hacer ni que es inminente, dijo.\r\nEl presidente Iván Duque Má… [+1931 chars]', 7)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (24, N'El tiempo', N'Paro Nacional 5M: Así opera TransMilenio en Bogotá - El Tiempo', N'El servicio de transporte público estará operando hasta las 3 p.m. Programe sus viajes.', N'https://search.google.com/structured-data/testing-tool/article-586118', N'https://www.eltiempo.com/files/og_paste_img/uploads/2021/05/05/609291852fcfc.jpeg', N'2021-05-05 11:14:32', N'El primer mandatario explicó que esta se podría aplicar de manera focalizada en un determinado territorio. No estoy diciendo que lo voy a hacer ni que es inminente, dijo.\r\nEl presidente Iván Duque Má… [+1931 chars]', 7)
INSERT [dbo].[News] ([Id], [Author], [Title], [Description], [Url], [UrlToImage], [PublishedAt], [Content], [CityId]) VALUES (25, N'CNN', N'¿Qué está pasando en Colombia? Reforma tributaria, protestas, militarización de ciudades y amenazas a la ONU - CNN', N'Una polémica reforma tributaria impulsada por el gobierno de Iván Duque llevó a miles de colombianos a protestar en varias ciudades de Colombia', N'https://cnnespanol.cnn.com/2021/05/05/protestas-colombia-reforma-tributaria-violentas-militarizacion-ciudades-amenazas-a-la-onu-orix/', N'https://cnnespanol.cnn.com/wp-content/uploads/2021/04/210429111315-colombia-protest-full-169.jpg?quality=100&strip=info', N'2021-05-05 11:00:00', N'¿Por qué hay protestas masivas en Colombia? 2:36\r\n(CNN Español) — Una polémica reforma tributaria impulsada por el gobierno de Iván Duque llevó hace una semana a miles de personas a las calles de Col… [+15419 chars]', 7)
SET IDENTITY_INSERT [dbo].[News] OFF
GO
SET IDENTITY_INSERT [dbo].[Weather] ON 

INSERT [dbo].[Weather] ([Id], [Weather_Time], [Temperature], [Weather_Description], [Wind_Speed], [Wind_Degree], [Wind_Direction], [Presure], [CityId]) VALUES (1, N'12:54 PM', N'19', N'Scattered Clouds', N'3', N'30', N'N', N'1028', 1)
INSERT [dbo].[Weather] ([Id], [Weather_Time], [Temperature], [Weather_Description], [Wind_Speed], [Wind_Degree], [Wind_Direction], [Presure], [CityId]) VALUES (2, N'12:57 PM', N'19', N'Scattered Clouds', N'1.5', N'20', N'N', N'1028', 2)
INSERT [dbo].[Weather] ([Id], [Weather_Time], [Temperature], [Weather_Description], [Wind_Speed], [Wind_Degree], [Wind_Direction], [Presure], [CityId]) VALUES (3, N'01:24 AM', N'31', N'Gentle Breeze', N'3.6', N'280', N'S', N'1013', 3)
INSERT [dbo].[Weather] ([Id], [Weather_Time], [Temperature], [Weather_Description], [Wind_Speed], [Wind_Degree], [Wind_Direction], [Presure], [CityId]) VALUES (4, N'05:42 PM', N'12', N'Moderate Rain', N'3.6', N'40', N'W', N'1005', 4)
INSERT [dbo].[Weather] ([Id], [Weather_Time], [Temperature], [Weather_Description], [Wind_Speed], [Wind_Degree], [Wind_Direction], [Presure], [CityId]) VALUES (5, N'01:01 PM', N'25', N'Few Clouds', N'2.6', N'280', N'E', N'1019', 5)
INSERT [dbo].[Weather] ([Id], [Weather_Time], [Temperature], [Weather_Description], [Wind_Speed], [Wind_Degree], [Wind_Direction], [Presure], [CityId]) VALUES (6, N'02:33 AM', N'26', N'Scattered Clouds', N'4.1', N'280', N'W', N'1006', 6)
INSERT [dbo].[Weather] ([Id], [Weather_Time], [Temperature], [Weather_Description], [Wind_Speed], [Wind_Degree], [Wind_Direction], [Presure], [CityId]) VALUES (7, N'10:23 PM', N'28', N'Sunny Day', N'5.1', N'360', N'E', N'1015', 7)
SET IDENTITY_INSERT [dbo].[Weather] OFF
GO
/****** Object:  Index [IX_News_CityId]    Script Date: 5/05/2021 1:31:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_News_CityId] ON [dbo].[News]
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SearchHistory_CityId]    Script Date: 5/05/2021 1:31:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_SearchHistory_CityId] ON [dbo].[SearchHistory]
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Weather_CityId]    Script Date: 5/05/2021 1:31:30 p. m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Weather_CityId] ON [dbo].[Weather]
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Weather] ADD  DEFAULT ((0)) FOR [CityId]
GO
ALTER TABLE [dbo].[News]  WITH CHECK ADD  CONSTRAINT [FK_News_Cities_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[News] CHECK CONSTRAINT [FK_News_Cities_CityId]
GO
ALTER TABLE [dbo].[SearchHistory]  WITH CHECK ADD  CONSTRAINT [FK_SearchHistory_Cities_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[SearchHistory] CHECK CONSTRAINT [FK_SearchHistory_Cities_CityId]
GO
ALTER TABLE [dbo].[Weather]  WITH CHECK ADD  CONSTRAINT [FK_Weather_Cities_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Weather] CHECK CONSTRAINT [FK_Weather_Cities_CityId]
GO
USE [master]
GO
ALTER DATABASE [newsweatherapi] SET  READ_WRITE 
GO
