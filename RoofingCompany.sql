use master;

drop database RoofingCompany;
create database RoofingCompany;

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
	ControlStatus bit not null,
	Comments nvarchar(255),
	Quantity int not null
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
	ControlDate DateTime not null,
	ControlStatus bit not null,
	Comments nvarchar(255),
	Quantity int not null
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
	IdProduct int primary key not null,
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
	InputDate DateTime not null
	);

--============/SALES DEPARTMENT/==============================

CREATE TABLE Customer
	(IdCustomer int IDENTITY(1,1)  PRIMARY KEY NOT NULL,
	CustomerName nvarchar(100) NOT NULL,
	PhoneNumber int NOT NULL,
	Email nvarchar(50) NOT NULL,
	City nvarchar(30) NOT NULL,
	ZipCode nvarchar(7) NOT NULL,
	Street nvarchar(30) NOT NULL,
	HouseNumber int NOT NULL,
	ApartmentNumber int NOT NULL,
	Pesel float NULL,
	NIP float NULL,
	KRS float NULL,
	Description nvarchar(100) NOT NULL); 

CREATE TABLE OrderCustomer
	(IdOrderCustomer int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IdCustomer int NOT NULL,
	IdEmployee int NOT NULL,
	OrderDate datetime NOT NULL,
	Cost money NOT NULL,
	Markup int NOT NULL);

CREATE TABLE OrderDetail
	(IdDetail int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IdOrderCustomer int NOT NULL,
	IdProduct int NOT NULL,
	Quantity int NOT NULL);

CREATE TABLE SupplierType
	(IdSupplierType int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Type nvarchar(50) NOT NULL);

CREATE TABLE Supplier
	(IdSupplier int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IdSupplierType int NOT NULL,
	SupplierName nvarchar(100) NOT NULL,
	PhoneNumber int NOT NULL,
	Email nvarchar(50) NOT NULL,
	City nvarchar(30) NOT NULL,
	ZipCode nvarchar(7) NOT NULL,
	Street nvarchar(30) NOT NULL,
	HouseNumber int NOT NULL,
	ApartmentNumber int NOT NULL,
	NIP float NOT NULL,
	KRS float NOT NULL,
	Description nvarchar(100) NOT NULL);

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
	PhoneNumber int NOT NULL,
	Email nvarchar(50) NOT NULL,
	City nvarchar(30) NOT NULL,
	ZipCode nvarchar(7) NOT NULL,
	Street nvarchar(30) NOT NULL,
	HouseNumber int NOT NULL,
	ApartmentNumber int NOT NULL,
	NIP float NOT NULL,
	KRS float NOT NULL,
	Description nvarchar(100) NOT NULL);

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
	PlannedStartd DATE,
	PlannedEndd DATE,
	Inproduction BIT
	);
	
-- planned_prod_empl_det table--
	CREATE TABLE PlannedProductionEmployeeDetails
	(IdDetail INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	IdProces INT NOT NULL,
	IdEmployee INT NOT NULL,
	StartDate DATE,
	EndDate DATE,
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
	FailureDate DATE NOT NULL
	);
	
	--Production_proces table--  
	CREATE TABLE ProductionProces
	(IdProces INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	--zmiana IdPlan z nvarchar na int
	IdPlan INT NOT NULL,
	StartDate DATE,
	EndDate DATE,
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
ValidityOfOshTraining tinyint null,
VailidityOfMedicalExam tinyint null
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
Number tinyint,
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
alter table OutControl add constraint FkOutControlProcess foreign key (IdProcess) references ProductionProces(IdProces);

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

-- planned_prod_empl_det FOREING KEYS--------
ALTER TABLE PlannedProductionEmployeeDetails ADD CONSTRAINT FKPlannedProductionEmployeeDetailsAllocation
FOREIGN KEY (IdEmployee) REFERENCES Allocation(IdAllocation)

ALTER TABLE PlannedProductionEmployeeDetails ADD CONSTRAINT FKPlannedProductionEmployeeDetailsPlannedProduction
FOREIGN KEY (IdProces) REFERENCES PlannedProduction(IdPlan)

-- Failures FOREIGN KEYS ------
ALTER TABLE Failure ADD CONSTRAINT FKProductionProces
FOREIGN KEY (IdProces) REFERENCES ProductionProces(IdProces)

--Production_proces FOREING KEYS--------
ALTER TABLE ProductionProces ADD CONSTRAINT FKProductionProcesPlannedProduction
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
create view EntranceControlView as
select IdSfDetail, SfCode, Thickness, Width, SfWeight, Color, ChemicalComposition from SemiFinished
Right Join SfOrderDetail
on SemiFinished.IdSemiFinished = SfOrderDetail.IdSemiFinished

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
select Employee.EmployeeName, Employee.EmployeeSurName, SafetyTraining.TrainingDate, [NeedPos].ValidityOfOshTraining, [NeedPos].DepartmentName
from Employee
join Contract
on Employee.IdEmployee = Contract.IdEmployee
join(
select Department.DepartmentName, Staff.IdPosition, Position.ValidityOfOshTraining
from Staff
join Department
on Staff.IdDeparment = Department.IdDepartment
join Position
on Staff.IdPosition = Position.IdPosition) as [NeedPos]
on [NeedPos].IdPosition = Contract.IdPosition
join SafetyTraining
on Employee.IdEmployee = SafetyTraining.IdEmployee;