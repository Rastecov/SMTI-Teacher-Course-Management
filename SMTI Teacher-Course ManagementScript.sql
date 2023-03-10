USE [master]
GO
/****** Object:  Database [SMTI Teacher-Course ManagementDB]    Script Date: 12/7/2022 6:17:22 PM ******/
CREATE DATABASE [SMTI Teacher-Course ManagementDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SMTI Teacher-Course ManagementDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SMTI Teacher-Course ManagementDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SMTI Teacher-Course ManagementDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SMTI Teacher-Course ManagementDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SMTI Teacher-Course ManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET  MULTI_USER 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET QUERY_STORE = OFF
GO
USE [SMTI Teacher-Course ManagementDB]
GO
/****** Object:  Table [dbo].[CourseAssignments ]    Script Date: 12/7/2022 6:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseAssignments ](
	[AssignId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeNumber] [int] NOT NULL,
	[CourseNumber] [nchar](10) NOT NULL,
	[GroupNumber] [int] NOT NULL,
 CONSTRAINT [PK_AssignCourses] PRIMARY KEY CLUSTERED 
(
	[AssignId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 12/7/2022 6:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseNumber] [nchar](10) NOT NULL,
	[CourseTitle] [nvarchar](50) NOT NULL,
	[TotalHour] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CourseNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 12/7/2022 6:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeNumber] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[JobTitle] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 12/7/2022 6:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[GroupNumber] [int] NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[GroupNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/7/2022 6:17:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Courses] ([CourseNumber], [CourseTitle], [TotalHour]) VALUES (N'COMP101   ', N'Introduction to C# Programming', 75)
INSERT [dbo].[Courses] ([CourseNumber], [CourseTitle], [TotalHour]) VALUES (N'COMP102   ', N'Advanced Programming in C#', 75)
INSERT [dbo].[Courses] ([CourseNumber], [CourseTitle], [TotalHour]) VALUES (N'COMP103   ', N'Client-Side Web Applications Development', 90)
INSERT [dbo].[Courses] ([CourseNumber], [CourseTitle], [TotalHour]) VALUES (N'COMP104   ', N'Web Server Applications in ASP.Net Core I', 90)
INSERT [dbo].[Courses] ([CourseNumber], [CourseTitle], [TotalHour]) VALUES (N'COMP105   ', N'Web Server Applications in ASP.Net Core II', 90)
INSERT [dbo].[Courses] ([CourseNumber], [CourseTitle], [TotalHour]) VALUES (N'COMP201   ', N'Python Programming I', 75)
INSERT [dbo].[Courses] ([CourseNumber], [CourseTitle], [TotalHour]) VALUES (N'COMP202   ', N'Python Programming II', 75)
INSERT [dbo].[Courses] ([CourseNumber], [CourseTitle], [TotalHour]) VALUES (N'COMP203   ', N'Python Programming III', 90)
GO
INSERT [dbo].[Employees] ([EmployeeNumber], [FirstName], [LastName], [JobTitle]) VALUES (11111, N'Mary', N'Brown', N'Teacher')
INSERT [dbo].[Employees] ([EmployeeNumber], [FirstName], [LastName], [JobTitle]) VALUES (22222, N'Richard', N'Green', N'Teacher')
INSERT [dbo].[Employees] ([EmployeeNumber], [FirstName], [LastName], [JobTitle]) VALUES (33333, N'Michael', N'Freitag', N'Teacher')
INSERT [dbo].[Employees] ([EmployeeNumber], [FirstName], [LastName], [JobTitle]) VALUES (44444, N'Mary', N'Green', N'Teacher')
INSERT [dbo].[Employees] ([EmployeeNumber], [FirstName], [LastName], [JobTitle]) VALUES (55555, N'Thomas', N'Moore', N'Teacher')
INSERT [dbo].[Employees] ([EmployeeNumber], [FirstName], [LastName], [JobTitle]) VALUES (66666, N'John', N'Abbot', N'Program Coordinator')
GO
INSERT [dbo].[Groups] ([GroupNumber], [Description]) VALUES (10001, N'DEC Programming')
INSERT [dbo].[Groups] ([GroupNumber], [Description]) VALUES (10002, N'DEC Programming')
INSERT [dbo].[Groups] ([GroupNumber], [Description]) VALUES (10003, N'AEC Programming')
INSERT [dbo].[Groups] ([GroupNumber], [Description]) VALUES (10004, N'AEC Programming')
INSERT [dbo].[Groups] ([GroupNumber], [Description]) VALUES (10005, N'DEC Networking')
INSERT [dbo].[Groups] ([GroupNumber], [Description]) VALUES (10006, N'AEC Networking')
GO
INSERT [dbo].[Users] ([UserId], [Password]) VALUES (11111, N'Mary_11111')
INSERT [dbo].[Users] ([UserId], [Password]) VALUES (22222, N'Richard_22222')
INSERT [dbo].[Users] ([UserId], [Password]) VALUES (33333, N'Michael_33333')
INSERT [dbo].[Users] ([UserId], [Password]) VALUES (44444, N'Mary_44444')
INSERT [dbo].[Users] ([UserId], [Password]) VALUES (55555, N'Thomas_55555')
INSERT [dbo].[Users] ([UserId], [Password]) VALUES (66666, N'John_66666')
GO
ALTER TABLE [dbo].[CourseAssignments ]  WITH CHECK ADD  CONSTRAINT [FK_AssignCourses_AssignCourses] FOREIGN KEY([EmployeeNumber])
REFERENCES [dbo].[Employees] ([EmployeeNumber])
GO
ALTER TABLE [dbo].[CourseAssignments ] CHECK CONSTRAINT [FK_AssignCourses_AssignCourses]
GO
ALTER TABLE [dbo].[CourseAssignments ]  WITH CHECK ADD  CONSTRAINT [FK_AssignCourses_Courses] FOREIGN KEY([CourseNumber])
REFERENCES [dbo].[Courses] ([CourseNumber])
GO
ALTER TABLE [dbo].[CourseAssignments ] CHECK CONSTRAINT [FK_AssignCourses_Courses]
GO
ALTER TABLE [dbo].[CourseAssignments ]  WITH CHECK ADD  CONSTRAINT [FK_AssignCourses_Groups] FOREIGN KEY([GroupNumber])
REFERENCES [dbo].[Groups] ([GroupNumber])
GO
ALTER TABLE [dbo].[CourseAssignments ] CHECK CONSTRAINT [FK_AssignCourses_Groups]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Employees] FOREIGN KEY([UserId])
REFERENCES [dbo].[Employees] ([EmployeeNumber])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Employees]
GO
USE [master]
GO
ALTER DATABASE [SMTI Teacher-Course ManagementDB] SET  READ_WRITE 
GO
