use master;
go
drop database RoofingCompany;
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
	AnalysisResults text not null
	);

create table OutControl(
	IdProcess int primary key not null,
	IdEmployee int not null,
	StartControlDate DateTime not null,
    EndControlDate DateTime not null,
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
QuantityWarehouse int not null
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
IdMaintDesc int not null,
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

create table MaintDescription (
IdMaintDesc int primary key identity (1,1) not null,
MaintDescName varchar (50) not null,
MaintDescription varchar (50) null,
InspectionTimeInterval float (2) not null
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
MetersPerHour float (2) not null
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
EmployeeName nvarchar(50) null,
EmployeeSurname nvarchar(50) null,
ZipCode nvarchar(50) null,
City nvarchar(50) null,
Street nvarchar(50) null,
HouseNumber nvarchar(50) null,
ApartmentNum nvarchar(50) null,
PhoneNumber nvarchar(50) null,
PESEL bigint,
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
alter table Maintenance add constraint FK_MainDescriptionMaintenance foreign key (IdMaintDesc) references MaintDescription(IdMaintDesc);
alter table FailureMaintenance add constraint FK_FailureFailureMaintenance foreign key (IdFailure) references Failure(IdFailure);
alter table FailureMaintenance add constraint FK_MaintenanceFailureMaintenance foreign key (IdMaintenance) references Maintenance(IdMaintenance);
alter table EmployeePlan add constraint FK_MaintenanceEmployee foreign key (IdMaintenance) references Maintenance(IdMaintenance);
alter table Machine add  constraint FK_MachineTypeMachine foreign key (IdMachineType) references MachineType(IdMachineType);
alter table Realization add constraint FK_MaintenanceRealization foreign key (IdMaintenance) references Maintenance(IdMaintenance);

/*alter table PartsOrder add constraint FK_SupplierPartsOrder foreign key (IdSupplier) references Supplier(IdSupplier);*/
/*alter table EployeePlan add constraint FK_EmployeeEmployeePlan foreign key (IdEmployee) references Employee(IdEmployee);*/

go
create view ViewDailySfDelivery as
select SemiFinishedOrder.SfDeliveryDate as [Delivery], Supplier.SupplierName, [Material].SfCode, [Material].Quantity
from SemiFinishedOrder
join
Supplier
on SemiFinishedOrder.IdSupplier = Supplier.IdSupplier
join
(select SemiFinished.SfCode, SfOrderDetail.Quantity, SfOrderDetail.IdSfOrder
from SfOrderDetail
join
SemiFinished
on SemiFinished.IdSemiFinished = SfOrderDetail.IdSemiFinished) as [Material]
on SemiFinishedOrder.IdSfOrder = [Material].IdSfOrder;

go
create view ViewOshTraining as
select Department.DepartmentName as [Dział], Employee.IdEmployee as [Numer pracownika], Employee.EmployeeName as [Imię], Employee.EmployeeSurname as [Nazwisko], (Dateadd(Day, Position.ValidityOfOshTraining, SafetyTraining.TrainingDate)) as [Data wygaśniecia szkolenia]
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


/*====SALES DEPARTMENT START==*/

GO 
CREATE VIEW vSupplierParts
AS
SELECT SupplierNameType as [Typ], SupplierName as [Firma], PhoneNumber as [Telefon], Email as [E-mail], City as [Miasto], ZipCode as [Kod pocztowy], 
Street as [Ulica], HouseNumber as [Numer], ApartmentNumber as [Numer lokalu], NIP, KRS, SupplierDescription as [Opis]  
FROM Supplier
JOIN SupplierType
ON Supplier.IdSupplierType = SupplierType.IdSupplierType
WHERE (SupplierNameType = 'Części');

GO
CREATE VIEW vSupplierSemis
AS
SELECT SupplierNameType as [Typ], SupplierName as [Firma], PhoneNumber as [Telefon], Email as [E-mail], City as [Miasto], ZipCode as [Kod pocztowy], 
Street as [Ulica], HouseNumber as [Numer], ApartmentNumber as [Numer lokalu], NIP, KRS, SupplierDescription as [Opis]
FROM Supplier
JOIN SupplierType
ON Supplier.IdSupplierType = SupplierType.IdSupplierType
WHERE (SupplierNameType = 'Półfabrykaty');

GO
CREATE VIEW vOutsourcingWithType
AS
SELECT  OutsourcingType as [Typ], CompanyName as [Firma], PhoneNumber as [Telefon], Email as [E-mail], City [Miasto], ZipCode as [Kod pocztowy], 
Street as [Ulica], HouseNumber as [Numer], ApartmentNumber as [Numer lokalu], NIP, KRS, OutsourcingDescription as [Opis]
FROM Outsourcing
JOIN OutsourcingType
ON Outsourcing.IdOutsourcingType = OutsourcingType.IdOutsourcingType;

GO
CREATE VIEW vCustomer
AS
SELECT CustomerName as [Klient], PhoneNumber as [Telefon], Email as [E-mail], City as [Miasto], 
ZipCode as [Kod pocztowy], Street as [Ulica], HouseNumber as [Numer], ApartmentNumber as [Numer lokalu], Pesel, NIP, KRS, CustomerDescription as [Opis]
FROM Customer;
GO
/*====SALES DEPARTMENT END===*/
GO
GO
CREATE VIEW vTechnicalProductDataPerProcess
AS
SELECT E.IdProcess, B.ProductCode, B.IdProduct, F.Lenght, F.Width, A.Quantity
FROM OrderDetail A, Product B, PlannedProduction C, ProductionProcess D, OutControl E, TechnicalProductData F
WHERE A.IdProduct = B.IdProduct and C.IdDetail = A.IdDetail and D.IdPlan = C.IdPlan and E.IdProcess = D.IdProces and F.IdProduct = B.IdProduct

GO
CREATE VIEW vDevotionsInMeasuremntsPerProcess
AS
SELECT B.IdMeasurement, A.IdProcess, A.Quantity as QuantityToBeProducted, ((A.Lenght - B.MeasuredLenght)/B.MeasuredLenght)*100 as LenghtDeviation, ((A.Width - B.MeasuredWidth)/B.MeasuredWidth)*100 as WidthDeviation, C.LenghtAcceptableDeviation, C.WidthAcceptableDeviation
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

/*====SALES DEPARTMENT START===*/

GO
CREATE VIEW vOutputMagazine
AS
SELECT A.ProductCode as [Kod produktu], C.SuccesfullProduced as [Ilość], B.EndControlDate [Data przyjęcia na magazyn] 
FROM vTechnicalProductDataPerProcess A, OutControl B, vSuccesfullyProducedPerProcess C
WHERE  A.IdProcess = B.IdProcess AND A.IdProcess = C.IdProcess

GO
CREATE VIEW vInputMagazine
AS
SELECT SfCode as [Kod Produktu], Quantity as [Ilość], ControlDate as [Data przyjęcia na magazyn]
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
SELECT OrderCustomer.IdOrderCustomer as [Numer zamówienia], Product.ProductCode as [Kod produktu], OrderDetail.Quantity as [Ilość]
FROM OrderCustomer
JOIN OrderDetail
ON OrderCustomer.IdOrderCustomer = OrderDetail.IdOrderCustomer
JOIN Product
ON OrderDetail.IdProduct = Product.IdProduct;
GO

/*====PRODUCTION===*/

GO
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
SELECT Part.PartName as [Nazwa części], 
PartType.partType as [Typ części], 
Unit.UnitName as [Jednostka], 
Part.QuantityWarehouse as [Stan magazynowy]
FROM Unit INNER JOIN (PartType INNER JOIN Part ON PartType.IdPartType = Part.IdPartType) 
ON Unit.IdUnit = Part.IdUnit
GO

CREATE VIEW vMaintPartsView
AS
SELECT Maintenance.MaintenanceNr as [Nr Obsługi], Maintenance.DateAcceptOrder as [Data przyjęcia], 
Part.PartName as [Nazwa części], MaintPart.PartQuantity as [Ilość], Unit.UnitName as [Jednostka]
FROM Unit INNER JOIN (Maintenance INNER JOIN (Part INNER JOIN MaintPart 
ON Part.IdPart = MaintPart.IdPart) 
ON Maintenance.IdMaintenance = MaintPart.IdMaintenance) 
ON Unit.IdUnit = Part.IdUnit
GO

/*====SALES DEPARTMENT START===*/

GO
CREATE VIEW vOrder
AS
SELECT Part.PartName as [Nazwa części], 
PartType.partType as [Typ części], 
Unit.UnitName as [Jednostka], 
Part.QuantityWarehouse as [Stan magazynowy]
FROM Unit INNER JOIN (PartType INNER JOIN Part ON PartType.IdPartType = Part.IdPartType) 
ON Unit.IdUnit = Part.IdUnit
ORDER BY Part.PartName;
SELECT OrderCustomer.IdOrderCustomer as [Numer zamówienia] , OrderDate as [Data zamówienia], Cost as [Wycena],
Markup as [Marża], EmployeeSurname as [Pracownik odpowiedzialny]
FROM OrderCustomer
INNER JOIN OrderDetail
ON OrderCustomer.IdOrderCustomer = OrderDetail.IdOrderCustomer
INNER JOIN Product
ON OrderDetail.IdProduct = Product.IdProduct
INNER JOIN Employee
ON OrderCustomer.IdEmployee = Employee.IdEmployee;

GO
CREATE VIEW vEmployeeSalesDepartment
AS
SELECT EmployeeName as [Imię], EmployeeSurname as [Nazwisko], ZipCode as [Kod pocztowy], City as [Miasto], Street as [Ulica], HouseNumber as [Numer], 
ApartmentNum as [Numer lokalu], PhoneNumber as [Telefon], PESEL, DepartmentName as [Dział], StartDate as [Data początku], EndDate as [Data końca]
FROM Allocation
JOIN Employee
ON Allocation.IdEmployee = Employee.IdEmployee
JOIN Department
ON Allocation.IdDepartment = Department.IdDepartment
WHERE (DepartmentName = 'Logistyka');

GO 
CREATE VIEW vEmployeeSD
AS
SELECT Maintenance.MaintenanceNr as [Nr Obsługi], Maintenance.DateAcceptOrder as [Data przyjęcia], 
Part.PartName as [Nazwa części], MaintPart.PartQuantity as [Ilość], Unit.UnitName as [Jednostka]
FROM Unit INNER JOIN (Maintenance INNER JOIN (Part INNER JOIN MaintPart 
ON Part.IdPart = MaintPart.IdPart) 
ON Maintenance.IdMaintenance = MaintPart.IdMaintenance) 
ON Unit.IdUnit = Part.IdUnit
ORDER BY Maintenance.DateAcceptOrder DESC;
GO

SELECT EmployeeName as [Imię], EmployeeSurname as [Nazwisko] 
FROM Allocation
JOIN Employee
ON Allocation.IdEmployee = Employee.IdEmployee
JOIN Department
ON Allocation.IdDepartment = Department.IdDepartment
WHERE (DepartmentName = 'Logistyka');
GO

CREATE VIEW vAbsences
AS
SELECT Employee.IdEmployee, EmployeeName, EmployeeSurname, StartOfAbsence, EndOfAbsence, AbscenceReason 
FROM Absence
INNER JOIN AbsenceType ON Absence.IdAbsenceType = AbsenceType.IdAbsenceType
INNER JOIN Employee ON Absence.IdEmployee = Employee.IdEmployee;

GO
CREATE VIEW	vAddTraining
AS
SELECT Employee.IdEmployee, EmployeeName, EmployeeSurname, TrainingName, TrainingStartDate, TrainingEndDate, TrainingPrice
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
SELECT Employee.IdEmployee, EmployeeName, EmployeeSurname, StartDate, EndDate, Salary, WorkplaceTrainingDate, HealTestDate, Workplace
FROM Employee
INNER JOIN Contract ON Employee.IdEmployee = Contract.IdEmployee 
INNER JOIN Position ON Contract.IdPosition = Position.IdPosition;

GO 

CREATE VIEW vEducationForm
AS
SELECT Employee.IdEmployee, EmployeeName, EmployeeSurname, EducationLevel, Degree, DegreeShort, GraduationDate
FROM dbo.Employee
INNER JOIN dbo.Education ON Employee.IdEmployee = Education.IdEmployee
INNER JOIN dbo.EducationLevel ON Education.IdEducationLevel = EducationLevel.IdEducationLevel;

GO

CREATE VIEW vEmployeeDetails
AS
SELECT Employee.IdEmployee, EmployeeName, EmployeeSurname, ZipCode, City, Street, HouseNumber, ApartmentNum, PhoneNumber, PESEL, EducationLevel, DegreeShort, GraduationDate, Workplace, StartDate, EndDate, Salary, HealTestDate, WorkplaceTrainingDate, Date 
FROM dbo.Contract
INNER JOIN Employee ON Contract.IdEmployee = Employee.IdEmployee
INNER JOIN MedicalExamination ON Employee.IdEmployee = MedicalExamination.IdEmployee
INNER JOIN Position ON Contract.IdPosition = Position.IdPosition
INNER JOIN Education ON Employee.IdEmployee = Education.IdEmployee
INNER JOIN EducationLevel ON Education.IdEducationLevel = EducationLevel.IdEducationLevel;

GO

CREATE VIEW vExamination
AS
SELECT Employee.IdEmployee, EmployeeSurname, EmployeeName, Date
FROM Employee
INNER JOIN RoofingCompany.dbo.MedicalExamination
ON RoofingCompany.dbo.Employee.IdEmployee = RoofingCompany.dbo.MedicalExamination.IdEmployee;

GO

CREATE VIEW vHR
AS
SELECT Employee.IdEmployee, EmployeeSurname, EmployeeName, City, PhoneNumber, Workplace
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
WHERE  Contract.EndDate < DATEADD(month, 3, GETDATE());

GO

CREATE VIEW vHRExamination
AS
SELECT IdMedicalExamination
FROM MedicalExamination
WHERE  MedicalExamination.Date < DATEADD(day, 14, GETDATE());


GO

CREATE VIEW vProductionProcessFullData
AS
SELECT ProductionProcess.IdProces, ProductionProcess.IdPlan, ProductionProcess.StartDate, ProductionProcess.EndDate, PlannedProductionEmployeeDetails.IdEmployee, Employee.EmployeeName, Employee.EmployeeSurname, Machine.MachineName, Machine.CatalogMachineNr
FROM ProductionProcess
JOIN PlannedProduction
ON ProductionProcess.IdPlan = PlannedProduction.IdPlan
JOIN PlannedProductionEmployeeDetails
ON PlannedProductionEmployeeDetails.IdDetail = PlannedProduction.IdDetail
JOIN Employee
ON PlannedProductionEmployeeDetails.IdEmployee = Employee.IdEmployee
JOIN Machine
ON PlannedProduction.IdMachine = Machine.IdMachine
GO

