USE telephone_directory_DB;
GO

-- 1. Роли
CREATE TABLE Roles (
    IdRole INT IDENTITY(1,1) PRIMARY KEY,
    RoleName NVARCHAR(50) NOT NULL UNIQUE,
);
GO

-- 2. Пользователи
CREATE TABLE Users (
    IdUser INT IDENTITY(1,1) PRIMARY KEY,
    Email NVARCHAR(255) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    Username NVARCHAR(150) NOT NULL UNIQUE,
    RoleId INT NOT NULL,

    CONSTRAINT FK_AppUsers_Roles
        FOREIGN KEY (RoleId) REFERENCES Roles(IdRole)
);
GO

-- 3. Должности
CREATE TABLE Positions (
    IdPosition INT IDENTITY(1,1) PRIMARY KEY,
    PositionName NVARCHAR(200) NOT NULL UNIQUE
);
GO

-- 4. Подразделения
CREATE TABLE Departments (
    IdDepartment INT IDENTITY(1,1) PRIMARY KEY,
    DepartmentName NVARCHAR(200) NOT NULL UNIQUE
);
GO

-- 5. Корпусы
CREATE TABLE Buildings (
    IdBuilding INT IDENTITY(1,1) PRIMARY KEY,
    BuildingName NVARCHAR(200) NOT NULL UNIQUE
);
GO

-- 6. Номера кабинетов
CREATE TABLE Offices (
    IdOffice INT IDENTITY(1,1) PRIMARY KEY,
    BuildingId INT NOT NULL,
    RoomNumber NVARCHAR(50) NOT NULL,

    CONSTRAINT FK_Offices_Buildings
        FOREIGN KEY (BuildingId) REFERENCES Buildings(IdBuilding),
);
GO

-- 7. Абоненты
CREATE TABLE Subscribers (
    IdSubscriber INT IDENTITY(1,1) PRIMARY KEY,
    Fio NVARCHAR(300) NOT NULL,
    PositionId INT NOT NULL,
    DepartmentId INT NOT NULL,
    BuildingId INT NOT NULL,
    OfficeId INT NOT NULL,
    WorkPhoneNumber NVARCHAR(50) NULL,
    PersonalPhoneNumber NVARCHAR(50) NULL,
    EmailAdress NVARCHAR(50) NULL,

    CONSTRAINT FK_Subscribers_Positions
        FOREIGN KEY (PositionId) REFERENCES Positions(IdPosition),

    CONSTRAINT FK_Subscribers_Departments
        FOREIGN KEY (DepartmentId) REFERENCES Departments(IdDepartment),

    CONSTRAINT FK_Subscribers_Buildings
        FOREIGN KEY (BuildingId) REFERENCES Buildings(IdBuilding),

    CONSTRAINT FK_Subscribers_Offices
        FOREIGN KEY (OfficeId) REFERENCES Offices(IdOffice)
);
GO

--Заполнение

-- 1. Роли
INSERT INTO Roles (RoleName)
VALUES
(N'Администратор'),
( N'Абонент');
GO

-- 2. Должности
INSERT INTO Positions (PositionName)
VALUES
(N'Директор'),
(N'Главный бухгалтер'),
(N'Инженер'),
(N'Системный администратор'),
(N'Менеджер'),
(N'Специалист');
GO

-- 3. Подразделения
INSERT INTO Departments (DepartmentName)
VALUES
(N'Администрация'),
(N'Бухгалтерия'),
(N'ИТ-отдел'),
(N'Отдел продаж'),
(N'Отдел кадров');
GO

-- 4. Корпусы
INSERT INTO Buildings (BuildingName)
VALUES
(N'Корпус А'),
(N'Корпус Б');
GO

-- 5. Кабинеты
INSERT INTO Offices (BuildingId, RoomNumber)
VALUES
(1, N'101'),
(1, N'102'),
(1, N'203'),
(1, N'305'),
(2, N'11'),
(2, N'12'),
(2, N'25'),
(2, N'44');
GO

-- 6. Пользователи
INSERT INTO Users (Email, Password, Username, RoleId)
VALUES
(N'admin@gmail.com', N'Admin123', N'admin', 1),
(N'sidorov@gmail.com', N'sidorov', N'sidorov.v', 2),
(N'ivanov@gmail.com', N'ivanov', N'ivanov.i', 2),
(N'frolova@gmail.com', N'frolova', N'frolova.a', 2),
(N'weber@gmail.com', N'weber', N'weber.r', 2),
(N'petrova@gmail.com', N'petrova', N'petrova.a', 2),
GO

-- 7. Абоненты
INSERT INTO Subscribers
(
    Fio,
    PositionId,
    DepartmentId,
    BuildingId,
    OfficeId,
    WorkPhoneNumber,
    PersonalPhoneNumber,
    EmailAdress
)s
VALUES
(N'Иванов Иван Иванович', 3, 3, 1, 3, N'1234', N'+7-900-111-22-33', N'ivanov@gmail.com'),
(N'Петрова Анна Сергеевна', 5, 4, 2, 6, N'2345', N'+7-900-222-33-44', N'petrova@gmail.com'),
(N'Сидоров Пётр Николаевич', 4, 3, 1, 4, N'3456', N'+7-900-333-44-55', N'sidorov@gmail.com'),
(N'Фролова Елена Викторовна', 6, 5, 2, 7, N'4567', N'+7-900-444-55-66', N'frolova@gmail.com'),
(N'Вебер Алексей Павлович', 2, 2, 1, 2, N'5678', N'+7-900-555-66-77', N'weber@gmail.com'),
(N'Орлова Марина Игоревна', 1, 1, 2, 5, N'6789', N'+7-900-666-77-88', N'admin@gmail.com');
GO