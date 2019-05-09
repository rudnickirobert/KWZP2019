use master;
go
drop database if exists RoofingCompany;
create database RoofingCompany;
go
use RoofingCompany;

create table Accident(
	IdAccident int primary key identity (1,1) not null,
	IdEmployee int not null,
	AccidentDate DateTime not null,
	-- YYYY-MM-DD HH:MI:SS
	AccidentDescription text not null
	);

create table EntranceControl(
	IdEntranceControl int primary key identity (1,1) not null,
	IdSfDetail int not null,
	IdEmployee int not null,
	ControlDate DateTime not null,
	ControlStatus bit null,
	Comments nvarchar(255),
	Quantity int null,
	RealThickness decimal(3, 2) not null,
	RealWidth decimal(6, 2) not null,
	RealWeight decimal(6,2) not null,
	RealColor nvarchar(20) not null,
	ChemicalComposition bit not null
	);

create table FEMAnalysis(
	IdFEMAnalysis int primary key identity (1,1) not null,
	IdEmployee int not null,
	NewPattern image not null,
	AnalysisResults text not null,
	AnalysisDate DateTime not null
	);

create table OutControl(
	IdProcess int primary key not null,
	IdEmployee int not null,
	StartControlDate DateTime not null,
   	EndControlDate DateTime,
   	WidthAcceptableDeviation float not null,
	LenghtAcceptableDeviation float not null
    );

create table OutputProductMeasurements(
    IdMeasurement int primary key not null,
    IdProcess int not null,
    MeasuredLenght float not null,
    MeasuredWidth float not null
	);

create table SafetyControl(
	IdInspection int primary key identity (1,1) not null,
	IdSafetyEmployee nvarchar(60) not null,
	IdInspectedEmployee int not null,
	SaftyControlDate DateTime not null,
	SafetyControlDescription nvarchar(255),
	CompanyName nvarchar(255)
	);

create table SafetyTraining(
	IdEmployee int primary key not null,
	TrainingDate datetime not null
	);

create table SemiFinished(
	IdSemiFinished int primary key identity (1,1) not null,
	SfCode nvarchar(30) not null,
	Thickness float not null,
	Width float not null,
	SfWeight float not null,
	Color nvarchar(50) not null,
	ChemicalComposition nvarchar(255) not null,
	RollLength int not null -- wartość w metrach
	);

create table TechnicalProductData(
	IdTechnicalProductData int primary key identity(1,1) not null,
	IdProduct int not null,
	Pattern image not null,
	Width float not null,
	WeightPerMeter float not null,
	Lenght float not null,
	PricePerMeter float not null
	);

create table Product(
	IdProduct int primary key identity (1,1) not null,
	IdSemiFinished int not null,
	ProductCode nvarchar(50),
	IdTechnology int not null,
	InputDate DateTime not null,
	InProduction bit
	);

--============/SALES DEPARTMENT/==============================

CREATE TABLE Customer
	(IdCustomer int IDENTITY(1,1)  PRIMARY KEY NOT NULL,
	CustomerName nvarchar(100) NOT NULL,
	PhoneNumber nvarchar(12) NOT NULL,
	Email nvarchar(50) NOT NULL,
	City nvarchar(30) NOT NULL,
	ZipCode nvarchar(7) NOT NULL,
	Street nvarchar(30) NOT NULL,
	HouseNumber nvarchar(5) NOT NULL,
	ApartmentNumber nvarchar(5) NOT NULL,
	Pesel nvarchar(11) NULL,
	NIP nvarchar(10) NULL,
	KRS nvarchar(10) NULL,
	CustomerDescription nvarchar(100) NULL); 

CREATE TABLE OrderCustomer
	(IdOrderCustomer int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IdCustomer int NOT NULL,
	IdEmployee int NOT NULL,
	OrderDate datetime NOT NULL,
	Cost money NOT NULL,
	Markup float NOT NULL,
	NewOrderInfo bit NULL);

CREATE TABLE OrderDetail
	(IdDetail int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IdOrderCustomer int NOT NULL,
	IdProduct int NOT NULL,
	Quantity int NOT NULL);

CREATE TABLE SupplierType
	(IdSupplierType int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	SupplierNameType nvarchar(50) NOT NULL);

CREATE TABLE Supplier
	(IdSupplier int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IdSupplierType int NOT NULL,
	SupplierName nvarchar(100) NOT NULL,
	PhoneNumber nvarchar(12) NOT NULL,
	Email nvarchar(50) NOT NULL,
	City nvarchar(30) NOT NULL,
	ZipCode nvarchar(7) NOT NULL,
	Street nvarchar(30) NOT NULL,
	HouseNumber nvarchar(5) NOT NULL,
	ApartmentNumber nvarchar(5) NOT NULL,
	NIP nvarchar(10) NOT NULL,
	KRS nvarchar(10) NOT NULL,
	SupplierDescription nvarchar(100) NULL);

CREATE TABLE SemiFinishedOrder
	(IdSfOrder int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IdSupplier int NOT NULL,
	SfOrderDate datetime NOT NULL,
	SfDeliveryDate datetime NOT NULL,
	Cost money NOT NULL);

CREATE TABLE SfOrderDetail
	(IdSfDetail int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IdSfOrder int NOT NULL,
	IdSemiFinished int NOT NULL,
	Quantity int NOT NULL);

CREATE TABLE OutsourcingType
	(IdOutsourcingType int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	OutsourcingType nvarchar(50) NOT NULL);

CREATE TABLE Outsourcing
	(IdOutsourcing int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IdOutsourcingType int NOT NULL,
	CompanyName nvarchar(100) NOT NULL, 
	PhoneNumber nvarchar(12) NOT NULL,
	Email nvarchar(50) NOT NULL,
	City nvarchar(30) NOT NULL,
	ZipCode nvarchar(7) NOT NULL,
	Street nvarchar(30) NOT NULL,
	HouseNumber nvarchar(5) NOT NULL,
	ApartmentNumber nvarchar(5) NOT NULL,
	NIP nvarchar(10) NOT NULL,
	KRS nvarchar(10) NOT NULL,
	OutsourcingDescription nvarchar(100) NULL);

CREATE TABLE OutsourcingCommitment
	(IdCommitment int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IdOutsourcing int NOT NULL,
	EndCommitmentDate datetime NOT NULL,
	Cost money NOT NULL);

--============/PRODUCTION TABLES/==============================

-- planned production table--
	CREATE TABLE PlannedProduction
	(IdPlan INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	IdDetail INT NOT NULL,
	IdMachine INT NOT NULL,
	PlannedStartd DATETIME,
	PlannedEndd DATETIME,
	Inproduction BIT
	);
	
-- planned_prod_empl_det table--
	CREATE TABLE PlannedProductionEmployeeDetails
	(IdDetail INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	IdProces INT NOT NULL,
	IdEmployee INT NOT NULL,
	StartDate DATETIME,
	EndDate DATETIME,
	);

-- technology table--
	CREATE TABLE Technology
	(IdTechnology INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	TechnologyName nvarchar(50) NOT NULL,
	TimePermeter INT NOT NULL,
	SpeedFactor INT NOT NULL,
	);
-- failures table---
	CREATE TABLE Failure
	(
	IdFailure INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	IdProces INT NOT NULL,
	Specification nvarchar(50) NOT NULL, --changed name from description (slq syntax word) to specification
	FailureDate DATETIME NOT NULL
	);
	
	--Production_proces table--  
	CREATE TABLE ProductionProcess
	(IdProces INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	--zmiana IdPlan z nvarchar na int
	IdPlan INT NOT NULL,
	StartDate DATETIME,
	EndDate DATETIME,
	);


--UR
create table Unit (
IdUnit int primary key identity (1,1) not null,
UnitName varchar (50) not null
);

create table PartRequest (
IdPartRequest int primary key identity (1,1) not null,
IdPart int not null,
Quantity int not null,
StatusPart int not null,
RequestDate datetime not null
);

create table PartOrder (
IdPartOrder int primary key identity (1,1) not null,
IdSupplier int not null,
OrderDate datetime not null,
StatusPartOrder varchar (50) not null,
CostPartOrder int not null
);

create table PartOrderRequest (
IdPartOrderRequest int primary key identity (1,1) not null,
IdPartOrder int not null,
IdPartRequest int not null
);

create table Part (
IdPart int primary key identity (1,1) not null,
IdPartType int not null,
IdUnit int not null,
PartName varchar (50) not null,
Producer varchar (50) not null,
CatalogPartNr int not null,
QuantityWarehouse int not null,
QuantityMinimum int null
);

create table MaintPart (
IdMaintPart int primary key identity (1,1) not null,
IdMaintenance int not null,
IdPart int not null,
PartQuantity int not null
);

create table PartType (
IdPartType int primary key identity (1,1) not null,
PartType varchar (50) not null
);

create table Maintenance (
IdMaintenance int primary key identity (1,1) not null,
IdMachine int not null,
IdMaintType int not null,
IdMaintDesc int null,
DateAcceptOrder datetime not null,
StartDatePlan datetime not null,
EndDatePlan datetime not null,
MaintenanceNr varchar (50) not null
);
--Table created earlier by Production
/*
create table Failure (
IdFailure int primary key not null,
IdProces int not null,
DescriptionFailure varchar (50) null,
FailureDate datetime not null
);
*/
create table PartOrderDetail (
IdPartOrderDetail int primary key identity (1,1) not null,
IdPartOrder int not null,
IdPart int not null,
Quantity int not null
);

create table FailureMaintenance (
IdFailureMaint int primary key identity (1,1) not null,
IdFailure int not null,
IdMaintenance int not null
);

create table EmployeePlan (
IdEmployeePlan int primary key identity (1,1) not null,
IdMaintenance int not null,
IdEmployee int not null,
StartDate datetime not null,
EndDate datetime not null
);

create table MaintType (
IdMaintenanceType int primary key identity (1,1) not null,
MaintenanceType varchar (50) not null
);

create table MaintenanceDescription (
IdMaintDesc int primary key identity (1,1) not null,
DescriptionShort varchar (50) not null,
DescriptionLong varchar (255) null
);

create table Machine (
IdMachine int primary key identity (1,1) not null,
IdMachineType int not null,
MachineName varchar (50) null,
ProducerMachine varchar (50) null,
ProductionYear int null,
PowerMachine float (2) null,
WorkingArea varchar (50) null,
CatalogMachineNr varchar (50) not null,
MetersPerHour float (2) not null,
InspectionTimeInterval float (2) not null
);

create table MachineType (
IdMachineType int primary key identity (1,1) not null,
MachineTypeName varchar (50) not null
);

create table Realization (
IdRealization int primary key identity (1,1) not null,
IdMaintenance int not null,
IdEmployee int not null,
StartRealDate datetime not null,
EndRealDate datetime null
);

--------------------------------------------------------------------------hr

create table Employee(
IdEmployee int primary key identity(1,1) not null,
EmployeeName nvarchar(50) not null,
EmployeeSurname nvarchar(50) null,
ZipCode nvarchar(50) null,
City nvarchar(50) null,
Street nvarchar(50) null,
HouseNumber nvarchar(50) null,
ApartmentNum nvarchar(50) null,
PhoneNumber nvarchar(50) null,
PESEL nvarchar(11),
);

create table Position(
IdPosition int not null Primary key identity(1,1),
Workplace nvarchar(50) null,
ValidityOfOshTraining int null,
VailidityOfMedicalExam int null
);

create table Contract(
IdContract int not null primary key identity(1,1),
StartDate date null,
EndDate date null,
Salary money null,
IdEmployee int Foreign Key references Employee(IdEmployee),
IdPosition int not null Foreign Key references Position(IdPosition),
HealTestDate date null,
WorkplaceTrainingDate Date null
);

create table SkillsForMachine(
IdSkill int primary key identity(1,1) not null,
IdMachine int foreign key references Machine(IdMachine),
IdPosition int not null Foreign Key references Position(IdPosition)
);

Create table AbsenceType(
IdAbsenceType int primary key identity(1,1) not null,
AbscenceReason nvarchar(50),
Multiplier float
);

Create table Absence(
IdAbsence int primary key identity(1,1) not null,
IdAbsenceType int Foreign Key references AbsenceType(IdAbsenceType),
IdEmployee int Foreign Key references Employee(IdEmployee),
StartOfAbsence date,
EndOfAbsence date
);

Create table Payment(
IdPayment int primary key identity(1,1) not null,
Bonus money Default(0),
IdEmployee int foreign key references Employee(IdEmployee),
Date date,
Sum money
);

Create table Department(
IdDepartment int primary key identity(1,1) not null,
DepartmentName nvarchar(50)
);

Create table Staff(
IdStaff int primary key identity(1,1) not null,
IdDeparment int foreign key references Department(IdDepartment),
IdPosition int foreign key references Position(IdPosition),
Number int,
DateFrom date
);

create table Allocation(
IdAllocation int primary key identity(1,1) not null,
IdEmployee int foreign key references Employee(IdEmployee),
IdDepartment int foreign key references Department(IdDepartment),
StartDate date,
EndDate date
);

Create table EducationLevel(
IdEducationLevel int primary key identity(1,1) not null,
EducationLevel nvarchar(50),
Degree nvarchar(50),
DegreeShort nvarchar(10)
);

Create table Education(
IdEducation int primary key identity(1,1) not null,
IdEmployee int foreign key references Employee(IdEmployee),
IdEducationLevel int foreign key references EducationLevel(IdEducationLevel),
GraduationDate date,
);

Create table Training(
IdTraining int primary key identity(1,1) not null,
IdEmployee int foreign key references Employee(IdEmployee),
TrainingName nvarchar(200),
TrainingStartDate date,
TrainingEndDate date,
TrainingPrice money
);

Create table MedicalExamination(
IdMedicalExamination int primary key identity(1,1) not null,
IdEmployee int foreign key references Employee(IdEmployee),
Date date
);

create table InvoiceType(
IdInvoiceType int primary key identity(1,1) not null,
Type nvarchar(50)
);

create table Contractor(
IdContractor int primary key identity(1,1) not null,
ContractorName nvarchar(50),
Phone int,
Email nvarchar(50),
City nvarchar(50),
PostalCode nvarchar(10),
Street nvarchar(50),
HouseNumber nvarchar(10),
ApartmentNumber nvarchar(10),
NIP bigint,
KRS bigint,
Description nvarchar(200)
);

Create table Invoice(
IdInvoice int primary key identity(1,1) not null,
IdContractor int foreign key references Contractor(IdContractor),
IdInvoiceType int foreign key references InvoiceType(IdInvoiceType),
Date date,
Sum money
);

Create table Expense(
IdExpense int primary key identity(1,1) not null,
IdDepartment int foreign key references Department(IdDepartment),
IdInvoice int foreign key references Invoice(IdInvoice)
);

-- -----------------------------------------------------END HR & FINANCES

alter table Accident add constraint FKAccidentEmployee foreign key (IdEmployee) references Employee(IdEmployee);

alter table EntranceControl add constraint FKSfDetail foreign key (IdSfDetail) references SfOrderDetail(IdSfDetail);
alter table EntranceControl add constraint FKEnteranceControlEmployee foreign key (IdEmployee) references Employee(IdEmployee);

alter table FEMAnalysis add constraint FkFEMAnalysisEmployee foreign key (IdEmployee) references Employee(IdEmployee);

alter table OutControl add constraint FkOutControlEmployee foreign key (IdEmployee) references Employee(IdEmployee);
alter table OutControl add constraint FkOutControlProcess foreign key (IdProcess) references ProductionProcess(IdProces);

alter table OutputProductMeasurements add constraint FkOutputProductMeasurements foreign key (IdProcess) references OutControl(IdProcess);

alter table SafetyControl add constraint FkInspectedEmployee foreign key (IdInspectedEmployee) references Employee(IdEmployee);

alter table SafetyTraining add constraint FkTrainedEmployee foreign key (IdEmployee) references Employee(IdEmployee);

alter table TechnicalProductData add constraint FkTechProdDataId foreign key (IdProduct) references Product(IdProduct);

alter table Product add constraint FkProductIdSF foreign key (IdSemiFinished) references SemiFinished(IdSemiFinished);
alter table Product add constraint FkProductIdTech foreign key (IdTechnology) references Technology(IdTechnology);

--============/SALES DEPARTMENT/==============================

ALTER TABLE OrderCustomer ADD CONSTRAINT FkOrderCustomerCustomer FOREIGN KEY (IdCustomer) REFERENCES Customer (IdCustomer);

ALTER TABLE OrderDetail ADD CONSTRAINT FkOrderDetailOrderCustomer FOREIGN KEY (IdOrderCustomer) REFERENCES OrderCustomer (IdOrderCustomer);

ALTER TABLE OrderCustomer ADD CONSTRAINT FkOrderCustomerEmployee FOREIGN KEY (IdEmployee) REFERENCES  Employee(IdEmployee);

ALTER TABLE OrderDetail ADD CONSTRAINT FkOrderDetailProduct FOREIGN KEY (IdProduct) REFERENCES Product (IdProduct);

ALTER TABLE Supplier ADD CONSTRAINT FkSupplierSupplierType FOREIGN KEY (IdSupplierType) REFERENCES SupplierType (IdSupplierType);

ALTER TABLE SemiFinishedOrder ADD CONSTRAINT FkSemiFinishedOrderSupplier FOREIGN KEY (IdSupplier)  REFERENCES Supplier (IdSupplier);

ALTER TABLE SfOrderDetail ADD CONSTRAINT FkSfOrderDetailSemiFinishedOrder FOREIGN KEY (IdSfOrder) REFERENCES SemiFinishedOrder (IdSfOrder);

ALTER TABLE EntranceControl ADD CONSTRAINT FkEntranceControlSfOrderDetail FOREIGN KEY (IdSfDetail) REFERENCES SfOrderDetail (IdSfDetail);

ALTER TABLE Outsourcing ADD CONSTRAINT FkOutsourcingOutsourcingType FOREIGN KEY (IdOutsourcingType) REFERENCES  OutsourcingType (IdOutsourcingType);

ALTER TABLE OutsourcingCommitment ADD CONSTRAINT FkOutsourcingCommitmentOutsourcing FOREIGN KEY (IdOutsourcing) REFERENCES Outsourcing (IdOutsourcing); 

ALTER TABLE SfOrderDetail ADD CONSTRAINT FkSfOrderDetailSemiFinished FOREIGN KEY (IdSemiFinished) REFERENCES SemiFinished (IdSemiFinished); 


--============/PRODUCTION CONSTRAINTS -> FOREIGN KEYS==========
--planned_production FOREING KEYS--------
ALTER TABLE PlannedProduction ADD CONSTRAINT FkOrderDetail
FOREIGN KEY (IdDetail) REFERENCES OrderDetail(IdDetail)

ALTER TABLE PlannedProduction ADD CONSTRAINT FkMachine
FOREIGN KEY (IdMachine) REFERENCES Maintenance(IdMaintenance)
-- planned_prod_empl_det FOREING KEYS--------
ALTER TABLE PlannedProductionEmployeeDetails ADD CONSTRAINT FKPlannedProductionEmployeeDetailsAllocation
FOREIGN KEY (IdEmployee) REFERENCES Allocation(IdAllocation)

ALTER TABLE PlannedProductionEmployeeDetails ADD CONSTRAINT FKPlannedProductionEmployeeDetailsPlannedProduction
FOREIGN KEY (IdProces) REFERENCES PlannedProduction(IdPlan)

-- Failures FOREIGN KEYS ------
ALTER TABLE Failure ADD CONSTRAINT FKProductionProces
FOREIGN KEY (IdProces) REFERENCES ProductionProcess(IdProces)

--Production_proces FOREING KEYS--------
ALTER TABLE ProductionProcess ADD CONSTRAINT FKProductionProcesPlannedProduction
FOREIGN KEY (IdPlan) REFERENCES PlannedProduction(IdPlan)

--utrzymanie ruchu
alter table Part add constraint FK_UnitPart foreign key (IdUnit) references Unit(IdUnit);
alter table Part add constraint FK_PartTypePart foreign key (IdPartType) references PartType(IdPartType);
alter table PartRequest add constraint FK_PartPartRequest foreign key (IdPart) references Part(IdPart);
alter table PartOrderRequest add constraint FK_PartRequestPartOrderRequest foreign key (IdPartRequest) references PartRequest(IdPartRequest);
alter table MaintPart add constraint FK_PartMainPart foreign key (IdPart) references Part(IdPart);
alter table PartOrderDetail add constraint FK_PartOrderPartOrderDetail foreign key (IdPartOrder) references PartOrder(IdPartOrder);
alter table PartOrderDetail add constraint FK_PartRequestPartOrderDetail foreign key (IdPart) references Part(IdPart);
alter table Maintenance add constraint FK_MachineMaintenance foreign key (IdMachine) references Machine(IdMachine);
alter table Maintenance add constraint FK_MaintTypeMaintenance foreign key (IdMaintType) references MaintType(IdMaintenanceType);
alter table Maintenance add constraint FK_MainDescriptionMaintenance foreign key (IdMaintDesc) references MaintenanceDescription(IdMaintDesc);
alter table FailureMaintenance add constraint FK_FailureFailureMaintenance foreign key (IdFailure) references Failure(IdFailure);
alter table FailureMaintenance add constraint FK_MaintenanceFailureMaintenance foreign key (IdMaintenance) references Maintenance(IdMaintenance);
alter table EmployeePlan add constraint FK_MaintenanceEmployee foreign key (IdMaintenance) references Maintenance(IdMaintenance);
alter table Machine add  constraint FK_MachineTypeMachine foreign key (IdMachineType) references MachineType(IdMachineType);
alter table Realization add constraint FK_MaintenanceRealization foreign key (IdMaintenance) references Maintenance(IdMaintenance);

/*alter table PartsOrder add constraint FK_SupplierPartsOrder foreign key (IdSupplier) references Supplier(IdSupplier);*/
/*alter table EployeePlan add constraint FK_EmployeeEmployeePlan foreign key (IdEmployee) references Employee(IdEmployee);*/
go

-- ===BB===
go
create view ViewSemiFinishedOrder as
select SfOrderDetail.IdSfOrder as [Nr_zamówienia], SemiFinished.SfCode as [Kod_półfabrykatu], Supplier.SupplierName as [Dostawca], SemiFinishedOrder.SfDeliveryDate as [Dostarczono]
from
	SfOrderDetail
join
	SemiFinishedOrder
on SfOrderDetail.IdSfOrder = SemiFinishedOrder.IdSfOrder
join
	SemiFinished
on
	SfOrderDetail.IdSemiFinished = SemiFinished.IdSemiFinished
join
	Supplier
on
	SemiFinishedOrder.IdSupplier = Supplier.IdSupplier;

go
create view ViewEntranceControlResultsBySfCode as
select SemiFinished.SfCode, EntranceControl.ControlDate, EntranceControl.ControlStatus, EntranceControl.RealThickness, EntranceControl.RealWidth, EntranceControl.RealWeight
from
	EntranceControl
join
	SfOrderDetail
on 
	EntranceControl.IdSfDetail = SfOrderDetail.IdSfDetail
join
	SemiFinished
on
	SfOrderDetail.IdSemiFinished = SemiFinished.IdSemiFinished;
	
go
create view ViewEntranceControlHistory as
select SfOrderDetail.IdSfOrder, SfOrderDetail.IdSemiFinished, EntranceControl.IdEmployee, EntranceControl.RealThickness,
EntranceControl.RealWidth, EntranceControl.RealWeight, EntranceControl.RealColor, EntranceControl.Quantity, EntranceControl.ControlStatus,
EntranceControl.ChemicalComposition, EntranceControl.Comments
from
	EntranceControl
join
	SfOrderDetail
on
	EntranceControl.IdSfDetail = SfOrderDetail.IdSfDetail;

go
create view ViewMinAndMaxEntranceControlDate as
select SemiFinished.SfCode, min(EntranceControl.ControlDate) as [MinControlDate], max(EntranceControl.ControlDate) as[MaxControlDate]
from
	EntranceControl
join
	SfOrderDetail
on
	EntranceControl.IdSfDetail = SfOrderDetail.IdSfDetail
join
	SemiFinished
on SfOrderDetail.IdSemiFinished = SemiFinished.IdSemiFinished
group by SemiFinished.SfCode;

go
create view ViewSemiFinishedCode as
select SfCode as [Kod_półfabrykatu]
from
	SemiFinished;

go
create view ViewQualityControlerList as
select Employee.IdEmployee, Employee.EmployeeName, Employee.EmployeeSurname
from Employee
join Contract
on Employee.IdEmployee = Contract.IdEmployee
join Position
on Contract.IdPosition = Position.IdPosition
where Position.IdPosition = 2 and Contract.EndDate > getdate();
-- ===BB===

go
create view ViewOshTraining as
select Department.DepartmentName as [Dział], Employee.PESEL as [PESEL], Employee.EmployeeName as [Imię], Employee.EmployeeSurname as [Nazwisko], (Dateadd(Day, Position.ValidityOfOshTraining, SafetyTraining.TrainingDate)) as [Data wygaśniecia szkolenia]
from Employee
join Contract
on Employee.IdEmployee = Contract.IdEmployee
join SafetyTraining
on Employee.IdEmployee = SafetyTraining.IdEmployee
join Position
on Position.IdPosition = Contract.IdPosition
join Allocation
on Employee.IdEmployee = Allocation.IdEmployee
join Department
on Department.IdDepartment = Allocation.IdDepartment
where Contract.EndDate > (GETDATE() + 45) and (Dateadd(Day, Position.ValidityOfOshTraining, SafetyTraining.TrainingDate) < (Getdate() + 45));
GO 

/*====SALES DEPARTMENT===*/

CREATE VIEW vSupplierParts
AS
SELECT IdSupplier as [Numer], SupplierNameType as [Typ], SupplierName as [Nazwa], PhoneNumber as [Telefon], Email as [E-mail], City as [Miasto],  
ZipCode as [Kod pocztowy], Street as [Ulica], HouseNumber as [Nr domu], ApartmentNumber as [Nr lokalu], NIP, KRS, SupplierDescription as [Opis]  
FROM Supplier
JOIN SupplierType
ON Supplier.IdSupplierType = SupplierType.IdSupplierType
WHERE (SupplierNameType = 'Części');
GO

CREATE VIEW vSupplierSemis
AS
SELECT IdSupplier as [Numer], SupplierNameType as [Typ], SupplierName as [Nazwa], PhoneNumber as [Telefon], Email as [E-mail], City as [Miasto],  
ZipCode as [Kod pocztowy], 
Street as [Ulica], HouseNumber as [Nr domu], ApartmentNumber as [Numer lokalu], NIP, KRS, SupplierDescription as [Opis]
FROM Supplier
JOIN SupplierType
ON Supplier.IdSupplierType = SupplierType.IdSupplierType
WHERE (SupplierNameType = 'Półfabrykaty');
GO

CREATE VIEW vOutsourcingWithType
AS
SELECT IdOutsourcing as [Numer], OutsourcingType as [Typ], CompanyName as [Nazwa], PhoneNumber as [Telefon], Email as [E-mail], City [Miasto],  
ZipCode as [Kod pocztowy], 
Street as [Ulica], HouseNumber as [Nr domu], ApartmentNumber as [Nr lokalu], NIP, KRS, OutsourcingDescription as [Opis]
FROM Outsourcing
JOIN OutsourcingType
ON Outsourcing.IdOutsourcingType = OutsourcingType.IdOutsourcingType;
GO

CREATE VIEW vCustomer
AS
SELECT Customer.IdCustomer as [Numer], CustomerName as [Nazwa], PhoneNumber as [Telefon], Email as [E-mail], City as [Miasto], ZipCode as [Kod pocztowy],  
Street as [Ulica], HouseNumber as [Nr domu], ApartmentNumber as [Nr lokalu], Pesel, NIP, KRS, CustomerDescription as [Opis]
FROM Customer;

/*====SALES DEPARTMENT END===*/

GO
CREATE VIEW vTechnicalProductDataPerProcess
AS
SELECT D.IdProces as IdProcess, B.ProductCode, B.IdProduct, F.Lenght, F.Width, A.Quantity
FROM OrderDetail A, Product B, PlannedProduction C, ProductionProcess D, TechnicalProductData F
WHERE A.IdProduct = B.IdProduct and C.IdDetail = A.IdDetail and D.IdPlan = C.IdPlan and F.IdProduct = B.IdProduct
GO

CREATE VIEW vDevotionsInMeasuremntsPerProcess
AS
SELECT B.IdMeasurement, A.IdProcess, A.Quantity as QuantityToBeProducted, CAST(ROUND((((A.Lenght - B.MeasuredLenght)/B.MeasuredLenght)*100),2) AS NUMERIC (12,2)) as LenghtDeviation, 
		CAST(ROUND((((A.Width - B.MeasuredWidth)/B.MeasuredWidth)*100),2) AS NUMERIC (12,2))  as WidthDeviation, C.LenghtAcceptableDeviation, C.WidthAcceptableDeviation
FROM vTechnicalProductDataPerProcess A, OutputProductMeasurements B, OutControl C
WHERE A.IdProcess = B.IdProcess and  B.IdProcess = C.IdProcess
GO

CREATE VIEW vSuccesfullyProducedPerProcess
AS
SELECT IdProcess, COUNT(IdMeasurement) as SuccesfullProduced, QuantityToBeProducted
FROM vDevotionsInMeasuremntsPerProcess
WHERE ABS(LenghtDeviation)<= LenghtAcceptableDeviation And ABS(WidthDeviation)<= WidthAcceptableDeviation
GROUP BY IdProcess, QuantityToBeProducted

GO

CREATE VIEW vTotalNumberOfMeasuresPerProcess
AS
SELECT IdProcess, COUNT(IdMeasurement) as Produced, QuantityToBeProducted
FROM vDevotionsInMeasuremntsPerProcess
GROUP BY IdProcess, QuantityToBeProducted
GO

CREATE VIEW vSuccesfullyProcess
AS
SELECT IdProcess
FROM vSuccesfullyProducedPerProcess
WHERE SuccesfullProduced >= QuantityToBeProducted
GO

CREATE VIEW vUnfinishedProcess
AS
SELECT IdProces
FROM ProductionProcess, vSuccesfullyProcess
WHERE IdProces != IdProcess
GO

CREATE VIEW SafetyControlHistoryView 
AS
SELECT SafetyControl.IdInspection, SafetyControl.CompanyName, SafetyControl.IdSafetyEmployee, SafetyControl.SaftyControlDate, Employee.EmployeeName + Employee.EmployeeSurname as "InspectedEmpolyee", SafetyControl.SafetyControlDescription
FROM SafetyControl
JOIN Employee
ON SafetyControl.IdInspectedEmployee = Employee.IdEmployee;
GO

/*====SALES DEPARTMENT START===*/

CREATE VIEW vOutputMagazine
AS
SELECT OutControl.IdProcess as [Numer], vTechnicalProductDataPerProcess.ProductCode as [Kod produktu],  
vSuccesfullyProducedPerProcess.SuccesfullProduced as [Ilość], OutControl.EndControlDate [Data przyjęcia na magazyn] 
FROM vTechnicalProductDataPerProcess, OutControl, vSuccesfullyProducedPerProcess 
WHERE  vTechnicalProductDataPerProcess.IdProcess = OutControl.IdProcess AND vTechnicalProductDataPerProcess.IdProcess = vSuccesfullyProducedPerProcess.IdProcess
GO


CREATE VIEW vInputMagazine
AS
SELECT IdEntranceControl as [Numer], SfCode as [Kod Produktu], Quantity as [Ilość], ControlDate as [Data przyjęcia na magazyn]
FROM EntranceControl, SemiFinished;
GO


CREATE VIEW vPredictedPriceForCustomer
AS
SELECT DISTINCT OrderDetail.IdOrderCustomer, Customer.CustomerName, OrderCustomer.OrderDate, OrderCustomer.Cost, OrderCustomer.Markup
FROM OrderDetail
JOIN OrderCustomer
ON OrderCustomer.IdOrderCustomer = OrderDetail.IdOrderCustomer
JOIN TechnicalProductData
ON TechnicalProductData.IdProduct = OrderDetail.IdProduct
JOIN Customer
ON OrderCustomer.IdCustomer = Customer.IdCustomer;
GO


CREATE VIEW vOrderDetail 
AS
SELECT OrderDetail.IdDetail, OrderCustomer.IdOrderCustomer as [Nr zamówienia], Product.ProductCode as [Kod produktu], OrderDetail.Quantity as [Ilość]
FROM OrderCustomer
JOIN Customer
ON Customer.IdCustomer = OrderCustomer.IdCustomer
JOIN OrderDetail
ON OrderCustomer.IdOrderCustomer = OrderDetail.IdOrderCustomer
JOIN Product
ON OrderDetail.IdProduct = Product.IdProduct;
/*====SALES DEPARTMENT END===*/ 

/*====PRODUCTION===*/

GO
CREATE VIEW vUnhandledOrderDetails
AS
SELECT OrderDetail.IdDetail, OrderDetail.Quantity, Product.ProductCode
FROM OrderDetail
JOIN Product
ON OrderDetail.IdProduct = Product.IdProduct
WHERE NOT EXISTS (SELECT * FROM PlannedProduction WHERE PlannedProduction.IdDetail = OrderDetail.IdDetail )
GO

CREATE VIEW vSafetyControlHistoryView 
AS
SELECT SafetyControl.IdInspection, SafetyControl.CompanyName, SafetyControl.IdSafetyEmployee, SafetyControl.SaftyControlDate, Employee.EmployeeName + Employee.EmployeeSurname as "InspectedEmpolyee", SafetyControl.SafetyControlDescription
FROM SafetyControl
JOIN Employee
ON SafetyControl.IdInspectedEmployee = Employee.IdEmployee;
GO

CREATE VIEW vComboBoxMachine
AS
SELECT DISTINCT Maintenance.IdMachine, Machine.MachineName + ' ' + Machine.CatalogMachineNr as machineFullName
FROM Maintenance
JOIN Machine
ON Maintenance.IdMachine = Machine.IdMachine;
GO

CREATE VIEW vComboBoxEmployee
AS
SELECT Employee.IdEmployee, Employee.EmployeeName + ' ' + Employee.EmployeeSurname as employeeFullName
FROM Employee
JOIN Allocation
ON Employee.IdEmployee = Allocation.IdEmployee
WHERE Allocation.IdDepartment = '1';
GO

--Views UR--

CREATE VIEW vPartsView
AS
SELECT Part.PartName, 
PartType.partType,
Part.Producer,
Part.CatalogPartNr, 
Part.QuantityWarehouse,
Unit.UnitName
FROM Unit INNER JOIN (PartType INNER JOIN Part ON PartType.IdPartType = Part.IdPartType) 
ON Unit.IdUnit = Part.IdUnit
GO

CREATE VIEW vMaintPartsView
AS
SELECT Maintenance.MaintenanceNr, Maintenance.DateAcceptOrder, 
Part.PartName, MaintPart.PartQuantity, Unit.UnitName
FROM Unit INNER JOIN (Maintenance INNER JOIN (Part INNER JOIN MaintPart 
ON Part.IdPart = MaintPart.IdPart) 
ON Maintenance.IdMaintenance = MaintPart.IdMaintenance) 
ON Unit.IdUnit = Part.IdUnit
GO

CREATE VIEW vPartsRequestView
AS
SELECT PartRequest.IdPartRequest, Part.PartName, PartRequest.RequestDate, PartRequest.Quantity, PartRequest.StatusPart
FROM PartRequest
JOIN Part
ON Part.IdPart = PartRequest.IdPart
GO

/*====SALES DEPARTMENT START===*/

CREATE VIEW vOrder
AS
SELECT DISTINCT OrderCustomer.IdOrderCustomer as [Nr zamówienia], Customer.IdCustomer, OrderDate as [Data zamówienia], Cost as [Wycena], Markup as [Marża],  
EmployeeSurname as [Pracownik]
FROM OrderCustomer
INNER JOIN OrderDetail
ON OrderCustomer.IdOrderCustomer = OrderDetail.IdOrderCustomer
INNER JOIN Product
ON OrderDetail.IdProduct = Product.IdProduct
INNER JOIN Employee
ON OrderCustomer.IdEmployee = Employee.IdEmployee
INNER JOIN Customer
ON Customer.IdCustomer = OrderCustomer.IdCustomer;

GO

CREATE VIEW vEmployeeSalesDepartment
AS
SELECT Employee.IdEmployee as [Numer], EmployeeName as [Imię], EmployeeSurname as [Nazwisko], ZipCode as [Kod pocztowy], City as [Miasto], Street as [Ulica],  
HouseNumber as [Nr domu], ApartmentNum as [Nr lokalu], PhoneNumber as [Telefon], PESEL, DepartmentName as [Dział], StartDate as [Data początku],  
EndDate as [Data końca]
FROM Allocation
JOIN Employee
ON Allocation.IdEmployee = Employee.IdEmployee
JOIN Department
ON Allocation.IdDepartment = Department.IdDepartment
WHERE (DepartmentName = 'Logistyka');
GO 

CREATE VIEW vEmployeeSD
AS
SELECT Employee.IdEmployee as [Numer], EmployeeName as [Imię], EmployeeSurname as [Nazwisko] 
FROM Allocation
JOIN Employee
ON Allocation.IdEmployee = Employee.IdEmployee
JOIN Department
ON Allocation.IdDepartment = Department.IdDepartment
WHERE (DepartmentName = 'Logistyka');
GO
-------- VIEWS HR

CREATE VIEW vAbsences
AS
SELECT IdAbsence, EmployeeSurname as [Nazwisko], EmployeeName as [Imię], AbscenceReason [Powód], StartOfAbsence as [Początek], EndOfAbsence [Koniec], Employee.IdEmployee
FROM Absence
INNER JOIN AbsenceType ON Absence.IdAbsenceType = AbsenceType.IdAbsenceType
INNER JOIN Employee ON Absence.IdEmployee = Employee.IdEmployee;
GO

CREATE VIEW	vAddTraining
AS
SELECT IdTraining, EmployeeSurname as [Nazwisko], EmployeeName as [Imię], TrainingName as [Nazwa], TrainingStartDate as [Początek], TrainingEndDate as [koniec], Cast(TrainingPrice as decimal(10,2)) as [Cena], Employee.IdEmployee
FROM dbo.Employee 
INNER JOIN Training ON Employee.IdEmployee = Training.IdEmployee;
GO

CREATE VIEW vEmployeeList
AS
SELECT Employee.IdEmployee, Employee.EmployeeSurname, Employee.EmployeeName 
FROM Employee;
GO

CREATE VIEW vContracts
AS
SELECT IdContract, EmployeeSurname as [Nazwisko], EmployeeName as [Imię], Workplace as [Stanowisko], StartDate as [Początek], EndDate as [Koniec], Salary as [Wypłata], WorkplaceTrainingDate as [Szkolenie stanowiskowe]
FROM Employee
INNER JOIN Contract ON Employee.IdEmployee = Contract.IdEmployee 
INNER JOIN Position ON Contract.IdPosition = Position.IdPosition;
GO 

CREATE VIEW vEducationForm
AS
SELECT IdEducation, EmployeeSurname as [Nazwisko], EmployeeName as [Imię], EducationLevel as [Stopień wykształcenia], Degree as [Degree], DegreeShort as [Tytuły naukowe], GraduationDate as [Data ukończenia], Employee.IdEmployee 
FROM dbo.Employee
INNER JOIN dbo.Education ON Employee.IdEmployee = Education.IdEmployee
INNER JOIN dbo.EducationLevel ON Education.IdEducationLevel = EducationLevel.IdEducationLevel;
GO

CREATE VIEW vEmployeeDetails
AS
SELECT Employee.IdEmployee, EmployeeSurname as [Nazwisko], EmployeeName as [Imię], ZipCode as [Kod pocztowy], City as [Miasto], Street as [Ulica], HouseNumber as [Nr Domu], ApartmentNum as [Nr lokalu], PhoneNumber as [Nr telefonu], PESEL, EducationLevel as [Stopień wykształcenia], DegreeShort as [Tytułu naukowe], GraduationDate [Data ukończenia studiów], Workplace as [Stanowisko], StartDate as [Początek umowy], EndDate as [Koniec umowy], Salary as [Wynagrodzenie], WorkplaceTrainingDate as [rening Stanowiskowy], Date as [Data badania lekarskiego] 
FROM dbo.Contract
RIGHT OUTER JOIN Employee ON Contract.IdEmployee = Employee.IdEmployee
LEFT OUTER JOIN MedicalExamination ON Employee.IdEmployee = MedicalExamination.IdEmployee
LEFT OUTER JOIN Position ON Contract.IdPosition = Position.IdPosition
LEFT OUTER JOIN Education ON Employee.IdEmployee = Education.IdEmployee
LEFT OUTER JOIN EducationLevel ON Education.IdEducationLevel = EducationLevel.IdEducationLevel

GO

CREATE VIEW vExamination
AS
SELECT IdMedicalExamination, EmployeeSurname as [Nazwisko], EmployeeName as [Imię], Date as [Data badania lekarskiego], Employee.IdEmployee
FROM Employee
INNER JOIN RoofingCompany.dbo.MedicalExamination
ON RoofingCompany.dbo.Employee.IdEmployee = RoofingCompany.dbo.MedicalExamination.IdEmployee;
GO

CREATE VIEW vHR
AS
SELECT Employee.IdEmployee, EmployeeSurname as [Nazwisko], EmployeeName as [Imię], PESEL, Workplace as [Stanowisko], PhoneNumber as [Nr telefonu] 
FROM Employee
INNER JOIN Contract ON Employee.IdEmployee = Contract.IdEmployee
INNER JOIN Position ON Contract.IdPosition = Position.IdPosition;
GO

CREATE VIEW vIncomesProfits
AS
SELECT Customer.IdCustomer,Customer.CustomerName, OrderCustomer.OrderDate, OrderCustomer.Cost
FROM Customer
INNER JOIN OrderCustomer ON Customer.IdCustomer = OrderCustomer.IdCustomer;
GO

CREATE VIEW vExpencesInvoices
AS
SELECT Invoice.IdInvoice,Invoice.Date, Invoice.Sum, Contractor.ContractorName, InvoiceType.Type
FROM InvoiceType
INNER JOIN Invoice ON InvoiceType.IdInvoiceType = Invoice.IdInvoiceType INNER JOIN
Contractor ON Invoice.IdContractor = Contractor.IdContractor;
GO

CREATE VIEW vExpencesPayment
AS
SELECT Payment.IdPayment,Payment.Sum, Payment.Date, Payment.Bonus, Employee.EmployeeName, Employee.EmployeeSurname
FROM Payment
INNER JOIN Employee ON Payment.IdEmployee = Employee.IdEmployee;
GO

CREATE VIEW vExpencesOrders
AS
SELECT SemiFinishedOrder.IdSfOrder,SemiFinishedOrder.Cost, SemiFinishedOrder.SfOrderDate, Supplier.SupplierName
FROM SemiFinishedOrder
INNER JOIN Supplier ON SemiFinishedOrder.IdSupplier = Supplier.IdSupplier;
GO

CREATE VIEW vExpencesOutsourcing
AS
SELECT Outsourcing.IdOutsourcing,OutsourcingCommitment.Cost, OutsourcingCommitment.EndCommitmentDate, Outsourcing.CompanyName
FROM OutsourcingCommitment
INNER JOIN Outsourcing ON OutsourcingCommitment.IdOutsourcing = Outsourcing.IdOutsourcing;
GO

CREATE VIEW vPaymentHistory
AS
SELECT Employee.EmployeeName, Employee.EmployeeSurname, Employee.PESEL, Payment.Bonus, Payment.Sum, Payment.Date, Employee.IdEmployee
FROM Employee
INNER JOIN Payment ON Employee.IdEmployee = Payment.IdEmployee;
GO

CREATE VIEW vInvoiceType
as
SELECT IdInvoiceType, Type
FROM InvoiceType;
GO

CREATE VIEW vHRContract
AS
SELECT IdContract
FROM Contract
WHERE (Contract.EndDate < DATEADD(month, 3, GETDATE())) and (Contract.EndDate > GETDATE());
GO

CREATE VIEW vHRExamination
AS
SELECT DISTINCT Employee.IdEmployee, Employee.EmployeeName, Employee.EmployeeSurname, Employee.PESEL, Position.Workplace, Position.VailidityOfMedicalExam, (ISNULL(MedicalExamination.Date, '2000-01-01')) as PreviousExamination, (ISNULL(DATEADD(day, VailidityOfMedicalExam, MedicalExamination.Date),CONVERT(date,GETDATE()))) as NextExamination, MedicalExamination.IdMedicalExamination
FROM Employee 
inner JOIN Contract ON Employee.IdEmployee = Contract.IdEmployee 
inner JOIN Position ON Contract.IdPosition = Position.IdPosition 
left outer JOIN MedicalExamination ON Employee.IdEmployee = MedicalExamination.IdEmployee
Where (Contract.EndDate > GETDATE()) AND ((DATEADD(Day, VailidityOfMedicalExam,(ISNULL(MedicalExamination.Date,'2000-01-01')))) < GETDATE()+14)
GO

CREATE VIEW vAbsenceType
AS
SELECT IdAbsenceType, AbscenceReason
FROM AbsenceType

GO

CREATE VIEW vExpencePartOrder
AS
SELECT Supplier.IdSupplier, Supplier.SupplierName, PartOrder.OrderDate, PartOrder.StatusPartOrder, PartOrder.CostPartOrder
FROM PartOrder 
INNER JOIN Supplier ON PartOrder.IdSupplier = Supplier.IdSupplier

GO

CREATE VIEW vEducationLevel
AS
SELECT IdEducationLevel, EducationLevel, Degree
FROM EducationLevel

GO

CREATE VIEW vL4
AS
SELECT Employee.IdEmployee, SUM(Datediff(day, StartOfAbsence, EndOfAbsence))+1 as 'L4Days', AbsenceType.Multiplier as 'L4X'
FROM Absence  
inner JOIN AbsenceType ON Absence.IdAbsenceType = AbsenceType.IdAbsenceType 
INNER JOIN Employee ON Absence.IdEmployee = Employee.IdEmployee
where (AbscenceReason = 'L4') AND (StartOfAbsence > (SELECT CONVERT(Date,DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()) - 1, 0)))) AND (EndOfAbsence < (SELECT CONVERT(Date,DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), -1))))
GROUP by Employee.IdEmployee, AbsenceType.Multiplier

GO	

CREATE VIEW vPaidAbsence
AS
SELECT Employee.IdEmployee, SUM(Datediff(day, StartOfAbsence, EndOfAbsence))+1 as 'PADays', AbsenceType.Multiplier as 'PAX'
FROM Absence  
inner JOIN AbsenceType ON Absence.IdAbsenceType = AbsenceType.IdAbsenceType 
INNER JOIN Employee ON Absence.IdEmployee = Employee.IdEmployee
where (AbscenceReason = 'Urlop Płatny') AND (StartOfAbsence > (SELECT CONVERT(Date,DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()) - 1, 0)))) AND (EndOfAbsence < (SELECT CONVERT(Date,DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), -1))))
GROUP by Employee.IdEmployee, AbsenceType.Multiplier

GO

CREATE VIEW vUnpaidAbsence
AS
SELECT Employee.IdEmployee, SUM(Datediff(day, StartOfAbsence, EndOfAbsence))+1 as 'NPADays', AbsenceType.Multiplier as 'NPAX'
FROM Absence  
inner JOIN AbsenceType ON Absence.IdAbsenceType = AbsenceType.IdAbsenceType 
INNER JOIN Employee ON Absence.IdEmployee = Employee.IdEmployee
where (AbscenceReason = 'Urlop Bezpłatny') AND (StartOfAbsence > (SELECT CONVERT(Date,DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()) - 1, 0)))) AND (EndOfAbsence < (SELECT CONVERT(Date,DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), -1))))
GROUP by Employee.IdEmployee, AbsenceType.Multiplier

GO

CREATE VIEW vUnexcused 
as
SELECT Employee.IdEmployee, SUM(Datediff(day, StartOfAbsence, EndOfAbsence))+1 as 'NUDays', AbsenceType.Multiplier as 'NUX'
FROM Absence  
inner JOIN AbsenceType ON Absence.IdAbsenceType = AbsenceType.IdAbsenceType 
INNER JOIN Employee ON Absence.IdEmployee = Employee.IdEmployee
where (AbscenceReason = 'Nieusprawiedliwiona') AND (StartOfAbsence > (SELECT CONVERT(Date,DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()) - 1, 0)))) AND (EndOfAbsence < (SELECT CONVERT(Date,DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), -1))))
GROUP by Employee.IdEmployee, AbsenceType.Multiplier

GO

CREATE VIEW vOD
as
SELECT Employee.IdEmployee, SUM(Datediff(day, StartOfAbsence, EndOfAbsence))+1 as 'ODDays', AbsenceType.Multiplier as 'ODX'
FROM Absence  
inner JOIN AbsenceType ON Absence.IdAbsenceType = AbsenceType.IdAbsenceType 
INNER JOIN Employee ON Absence.IdEmployee = Employee.IdEmployee
where AbscenceReason = 'Na żądanie' AND (StartOfAbsence > (SELECT CONVERT(Date,DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()) - 1, 0)))) AND (EndOfAbsence < (SELECT CONVERT(Date,DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), -1))))
GROUP by Employee.IdEmployee, AbsenceType.Multiplier

GO

CREATE VIEW vSalariesSummary
AS
SELECT DISTINCT Employee.IdEmployee, Employee.EmployeeName, Employee.EmployeeSurname, Employee.PESEL,CAST((Contract.Salary/21) as decimal(10,2)) as DailyWage, 
Convert(date ,Getdate()) as Date, 
ISNULL(vL4.L4Days,0) as [Dni L4],CAST(ISNULL(((Contract.Salary/21)*vL4.L4Days*L4X),0) as decimal(10,2)) as L4Pay, 
ISNULL(vPaidAbsence.PADays,0) as [Urlop płatny],CAST(ISNULL(((Contract.Salary/21)*vPaidAbsence.PADays*PAX),0) as decimal(10,2)) as PAPay,
ISNULL(vUnpaidAbsence.NPADays,0) as [Urlop bezpłatny],CAST(ISNULL(((Contract.Salary/21)*vUnpaidAbsence.NPADays*NPAX),0) as decimal(10,2)) as NPAPay,
ISNULL(vUnexcused.NUDays,0) as [Nieusprawiedliowiona],CAST(ISNULL(((Contract.Salary/21)*vUnexcused.NUDays*NUX),0) as decimal(10,2)) as NPAay,
ISNULL(vOD.ODDays,0) as [Na żądanie],CAST(ISNULL(((Contract.Salary/21)*vOD.ODDays*ODX),0) as decimal(10,2)) as ODPay,
Ceiling(((21-(ISNULL(vL4.L4Days,0)+ISNULL(vPaidAbsence.PADays,0)+ISNULL(vUnpaidAbsence.NPADays,0)+ISNULL(vUnexcused.NUDays,0)+ISNULL(vOD.ODDays,0)))*(Contract.Salary/21))+ISNULL(((Contract.Salary/21)*vL4.L4Days*L4X),0)+ISNULL(((Contract.Salary/21)*vPaidAbsence.PADays*PAX),0)+ISNULL(((Contract.Salary/21)*vUnpaidAbsence.NPADays*NPAX),0)+ISNULL(((Contract.Salary/21)*vUnexcused.NUDays*NUX),0)+ISNULL(((Contract.Salary/21)*vOD.ODDays*ODX),0)) as TotalSalary
FROM Absence 
right outer JOIN Employee ON Absence.IdEmployee = Employee.IdEmployee 
Left outer JOIN Contract ON Employee.IdEmployee = Contract.IdEmployee 
left outer join Payment ON Employee.IdEmployee = Payment.IdEmployee
left outer join vL4 on Employee.IdEmployee = vL4.IdEmployee
Left outer join vPaidAbsence on Employee.IdEmployee = vPaidAbsence.IdEmployee
Left outer join vUnpaidAbsence on Employee.IdEmployee = vUnpaidAbsence.IdEmployee
Left outer join vUnexcused on Employee.IdEmployee = vUnexcused.IdEmployee
Left outer join vOD on Employee.IdEmployee = vOD.IdEmployee
Where Contract.EndDate > (SELECT CONVERT(Date,DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()) - 1, 0)))
GO

CREATE VIEW vPosition 
as
SELECT Position.IdPosition, Position.Workplace 
FROM Position

GO

CREATE VIEW vDeparment
as
SELECT Department.IdDepartment, Department.DepartmentName
FROM Department

GO

CREATE VIEW vProductionProcessFullData
AS
SELECT ProductionProcess.IdProces, Product.ProductCode, OrderDetail.Quantity, ProductionProcess.StartDate, ProductionProcess.EndDate, PlannedProductionEmployeeDetails.IdEmployee, Employee.EmployeeName, Employee.EmployeeSurname, Machine.MachineName, Machine.CatalogMachineNr
FROM ProductionProcess
JOIN PlannedProduction
ON ProductionProcess.IdPlan = PlannedProduction.IdPlan
JOIN PlannedProductionEmployeeDetails
ON PlannedProductionEmployeeDetails.IdDetail = PlannedProduction.IdDetail
JOIN Employee
ON PlannedProductionEmployeeDetails.IdEmployee = Employee.IdEmployee
JOIN Machine
ON PlannedProduction.IdMachine = Machine.IdMachine
JOIN OrderDetail
ON PlannedProduction.IdDetail = OrderDetail.IdDetail
JOIN Product
ON OrderDetail.IdProduct = Product.IdProduct
GO

GO
CREATE VIEW vOutsourcingType
AS
SELECT IdOutsourcingType as [Numer], OutsourcingType as [Typ]
FROM OutsourcingType;

GO
CREATE VIEW vOutsourcing
AS
SELECT IdOutsourcing as [Numer], CompanyName as [Nazwa], PhoneNumber as [Telefon], Email as [E-mail], City [Miasto], ZipCode as [Kod pocztowy],  
Street as [Ulica], HouseNumber as [Nr domu], ApartmentNumber as [Nr lokalu], NIP, KRS, OutsourcingDescription as [Opis]
FROM Outsourcing;

GO
CREATE VIEW vOutsourcingCommitment
AS
SELECT Outsourcing.IdOutsourcing as [Numer], CompanyName as [Nazwa], EndCommitmentDate as [Koniec zobowiązania], Cost as [Cena]
FROM Outsourcing
JOIN OutsourcingCommitment
ON Outsourcing.IdOutsourcing = OutsourcingCommitment.IdOutsourcing;
GO 
CREATE VIEW vSupplierPartsMinusType
AS
SELECT IdSupplier as [Numer], SupplierName as [Nazwa], PhoneNumber as [Telefon], Email as [E-mail], City as [Miasto], 
ZipCode as [Kod pocztowy], Street as [Ulica], HouseNumber as [Nr domu], ApartmentNumber as [Nr lokalu], NIP, KRS, SupplierDescription as [Opis]  
FROM Supplier
JOIN SupplierType
ON Supplier.IdSupplierType = SupplierType.IdSupplierType
WHERE (SupplierNameType = 'Części');

GO
CREATE VIEW vSupplierSemisMinusType
AS
SELECT IdSupplier as [Numer], SupplierName as [Nazwa], PhoneNumber as [Telefon], Email as [E-mail], City as [Miasto], 
ZipCode as [Kod pocztowy], Street as [Ulica], HouseNumber as [Nr domu], ApartmentNumber as [Nr lokalu], NIP, KRS, SupplierDescription as [Opis]
FROM Supplier
JOIN SupplierType
ON Supplier.IdSupplierType = SupplierType.IdSupplierType
WHERE (SupplierNameType = 'Półfabrykaty');

GO
CREATE VIEW vNewFailures
AS
SELECT Failure.IdFailure, Failure.Specification, Failure.FailureDate, Machine.MachineName
FROM   Failure
INNER JOIN ProductionProcess ON Failure.IdProces = ProductionProcess.IdProces 
INNER JOIN PlannedProduction ON ProductionProcess.IdPlan = PlannedProduction.IdPlan 
INNER JOIN Machine ON PlannedProduction.IdMachine = Machine.IdMachine
WHERE        
(NOT EXISTS (SELECT IdFailureMaint, IdFailure, IdMaintenance
FROM FailureMaintenance AS FailureMaintenance_1
WHERE (IdFailure = Failure.IdFailure)))
GO

CREATE VIEW vComboboxNewFailures
AS
SELECT IdFailure, Specification
FROM Failure
WHERE 
(NOT EXISTS (SELECT IdFailureMaint, IdFailure, IdMaintenance
FROM FailureMaintenance
WHERE (IdFailure = Failure.IdFailure)))
GO

CREATE VIEW vMachineFailure
AS
SELECT Failure.IdFailure, Machine.IdMachine, Machine.MachineName
FROM Failure 
INNER JOIN ProductionProcess ON Failure.IdProces = ProductionProcess.IdProces 
INNER JOIN PlannedProduction ON ProductionProcess.IdPlan = PlannedProduction.IdPlan 
INNER JOIN Machine ON PlannedProduction.IdMachine = Machine.IdMachine
GO

CREATE VIEW vMaintenanceEmployees
AS
SELECT Employee.IdEmployee, Employee.EmployeeName, Employee.EmployeeSurname
FROM Employee 
INNER JOIN Allocation ON Employee.IdEmployee = Allocation.IdEmployee 
INNER JOIN Department ON Allocation.IdDepartment = Department.IdDepartment
WHERE (Department.DepartmentName = 'Utrzymanie ruchu')
GO

CREATE VIEW vMaintenanceAssignEmployees
AS
SELECT EmployeePlan.IdEmployeePlan, EmployeePlan.IdMaintenance, EmployeePlan.IdEmployee, Employee.EmployeeName, Employee.EmployeeSurname, 
EmployeePlan.StartDate, EmployeePlan.EndDate
FROM Employee 
INNER JOIN EmployeePlan ON Employee.IdEmployee = EmployeePlan.IdEmployee
GO

CREATE VIEW vMaintenanceEmployeesCalendar
AS
SELECT EmployeePlan.IdEmployee, EmployeePlan.IdMaintenance, Employee.EmployeeName, Employee.EmployeeSurname, 
EmployeePlan.StartDate, EmployeePlan.EndDate, Maintenance.MaintenanceNr
FROM Employee 
INNER JOIN EmployeePlan ON Employee.IdEmployee = EmployeePlan.IdEmployee 
INNER JOIN Maintenance ON EmployeePlan.IdMaintenance = Maintenance.IdMaintenance
GO

CREATE VIEW vMaintenanceAssignParts
AS
SELECT Maintenance.IdMaintenance, Part.IdPart, Part.PartName, MaintPart.PartQuantity, Part.QuantityWarehouse, Unit.UnitName
FROM Maintenance 
INNER JOIN MaintPart ON Maintenance.IdMaintenance = MaintPart.IdMaintenance 
INNER JOIN Part ON MaintPart.IdPart = Part.IdPart 
INNER JOIN Unit ON dbo.Part.IdUnit = Unit.IdUnit
GO

CREATE VIEW vProductionProducts
AS
SELECT Product.IdProduct, Product.ProductCode, SemiFinished.SfCode, Technology.TechnologyName, Product.InputDate
FROM Product
JOIN SemiFinished
ON Product.IdSemiFinished = SemiFinished.IdSemiFinished
JOIN Technology
ON Product.IdTechnology = Technology.IdTechnology
GO

CREATE VIEW vSF
AS
SELECT DISTINCT SfOrderDetail.IdSFDetail as [Nr szczegółu], Supplier.SupplierName as [Dostawca], SemiFinished.SfCode as [Kod półfabrykatu], SfOrderDetail.Quantity as [Ilość], SemiFinishedOrder.SfOrderDate as [Data zamówienia], 
SemiFinishedOrder.SfDeliveryDate as [Data dostawy], SemiFinishedOrder.Cost as [Cena]
FROM SfOrderDetail
INNER JOIN SemiFinished
ON SfOrderDetail.IdSemiFinished = SemiFinished.IdSemiFinished
INNER JOIN SemiFinishedOrder
ON SemiFinishedOrder.IdSfOrder = SfOrderDetail.IdSfOrder
INNER JOIN Supplier
ON SemiFinishedOrder.IdSupplier = Supplier.IdSupplier;

GO
CREATE VIEW vSFOrderDetail
AS
SELECT DISTINCT SfOrderDetail.IdSFDetail as [Nr szczegółu], SemiFinished.SfCode as [Kod półfabrykatu], SfOrderDetail.Quantity as [Ilość], SemiFinishedOrder.IdSfOrder as [Nr zamówienia]
FROM SfOrderDetail
INNER JOIN SemiFinished
ON SfOrderDetail.IdSemiFinished = SemiFinished.IdSemiFinished
INNER JOIN SemiFinishedOrder
ON SfOrderDetail.IdSfOrder = SemiFinishedOrder.IdSfOrder;

GO
CREATE VIEW vSFOrder
AS
SELECT DISTINCT SemiFinishedOrder.IdSfOrder as [Nr zamówienia], Supplier.SupplierName as [Dostawca], SemiFinishedOrder.SfOrderDate as [Data zamówienia], SemiFinishedOrder.SfDeliveryDate as [Data dostawy],  
SemiFinishedOrder.Cost as [Cena]
FROM SemiFinishedOrder
INNER JOIN Supplier
ON SemiFinishedOrder.IdSupplier = Supplier.IdSupplier;

/*====SALES DEPARTMENT END===*/




