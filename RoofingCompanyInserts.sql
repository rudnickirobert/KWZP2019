use RoofingCompany;

--HR
insert into Employee (EmployeeName, EmployeeSurname, ZipCode, City, Street, HouseNumber, ApartmentNum, PhoneNumber, PESEL)
	values
		('Andrzej', 'Kowalski', '01-493', 'Warszawa', 'Niepodleg³oœci', '105', '102', '589 603 804', '78121611920'),
		('Stefan', 'Nowak', '04-905', 'Warszawa', 'Powstañców', '10', '20', '607 894 489', '66123111809'),
		('Witold', 'Wiœniewski', '03-444', 'Otwock', 'G³ówna', '23A', '5', '555 555 444', '33112244560'),
		('Szymon', 'Wójcik', '40-404', 'Wroc³aw', 'Gen. Maczka', '50B', '10', '666 666 321', '55100511890'),
		('Darek', 'Kowalczyk', '30-400', 'Lublin', 'Marii Curie', '300C', '11', '555 312 123', '89011588290');


insert into Position (Workplace, ValidityOfOshTraining, VailidityOfMedicalExam)
	values
		('Kierownik', 2, 2),
		('Ksiêgowy', 3, 99),
		('Pracownik produkcji', 1, 1),
		('Konserwator', 1, 1),
		('Dyrektor', 4, 5);


insert into Contract(StartDate, EndDate, Salary, IdEmployee, IdPosition, HealTestDate, WorkplaceTrainingDate)
	values
		('2010-04-10', '2012-04-12', 5000, 1, 1, '2010-04-09', '2010-04-10'),
		('2010-04-10', '2012-04-12', 4000, 2, 2, '2010-04-09', '2010-04-10'),
		('2010-04-10', '2012-04-12', 2000, 3, 3, '2010-04-09', '2010-04-10'),
		('2010-04-10', '2012-04-12', 3000, 4, 4, '2010-04-09', '2010-04-10'),
		('2010-04-10', '2012-04-12', 6000, 5, 5, '2010-04-09', '2010-04-10');

insert into SkillsForMachine(IdMachine, IdPosition)
	values
		(1, 3),
		(2, 3),
		(3, 3),
		(4, 3),
		(5, 3);

Insert into AbsenceType(AbscenceReason, Multiplier)
	values 
		('Urlop p³atny', 1),
		('Urlop bezp³atny', 0),
		('Na ¿¹danie', 0),
		('Nieusprawiedliwiona', 0),
		('L4', 0.75);

insert into Absence(IdAbsenceType, IdEmployee, StartOfAbsence, EndOfAbsence)
	values
		(1, 1, '2012-02-10', '2012-02-24'),
		(2, 2, '2013-06-01', '2013-06-04'),
		(3, 3, '2014-07-21', '2014-07-21'),
		(4, 4, '2015-03-02', '2015-03-02'),
		(5, 5, '2016-08-15', '2016-08-23');

insert into Payment(Bonus, IdEmployee, Date, Sum)
	values
		(DEFAULT, 1, '2010-03-01', 3500),
		(300, 2, '2010-03-01', 3000),
		(100, 3, '2010-03-01', 3000),
		(500, 4, '2010-03-01', 3000),
		(250, 5, '2010-03-01', 3000);

INSERT INTO Department(DepartmentName)
	values
		('Produkcja'),
		('Utrzymanie ruchu'),
		('HR i Finanse'),
		('Logistyka'),
		('Kontrola jakoœci');

insert into Staff(IdDeparment, IdPosition, Number, DateFrom)
	values 
		(1, 3, 10, '2019-04-04'),
		(1, 3, 10, '2019-04-04'),
		(1, 3, 10, '2019-04-04'),
		(1, 3, 10, '2019-04-04'),
		(1, 3, 10, '2019-04-04');

INSERT INTO Contractor(ContractorName,Phone,Email,City,PostalCode,Street,HouseNumber,ApartmentNumber,NIP,KRS)
	values
		('PGNiG',520325652,'pgnigo@o2.pl','Warszawa',00537,'ul.Krucza','14','6',525008028,0000059492),
		('Energa',652232522,'energa.sa@energa.pl','Gdañsk',80309,'al. Grunwaldzka','472','',9570957722,0000271591),
		('MPWiK',224455000,'dok@mpwik.com.pl','Warszawa',02015,'pl. Starynkiewicza','5','',5250005662,0000146138),
		('T-Mobile',602913000,'pr@t-mobile.pl','Warszawa',02674,'ul. Marynarska','12','',5261040567,0000391193),
		('T-Mobile',222200000,'nc+@canal+.pl','£ódŸ',31535,'al. gen. W. Sikorskiego','12','2',5210082774,0000469644)
		;

INSERT INTO InvoiceType(Type)
	values
		('Energia elektryczna'),
		('Wodoci¹gi'), 
		('Œmieci'),
		('Artyku³y biurowe'),
		('Inwestycje');


INSERT INTO Invoice(IdContractor,IdInvoiceType,Date,Sum)
	values
		(1,2,'2019-02-10',550.45),
		(3,3,'2019-03-10',1250),
		(2,4,'2019-04-05',5504),
		(5,2,'2019-02-22',1550.15),
		(4,5,'2019-02-22',50);

INSERT INTO Expense(IdDepartment,IdInvoice)
	values
		(1,1),
		(3,3),
		(2,5),
		(1,2),
		(5,4);

insert into Allocation(IdEmployee, IdDepartment, StartDate, EndDate)
	Values
		(1, 1, '2011-10-11', NULL),
		(2, 2, '2011-10-11', NULL),
		(3, 3, '2011-10-11', NULL),
		(4, 4, '2011-10-11', NULL),
		(5, 5, '2011-10-11', NULL);

insert into MedicalExamination(IdEmployee, Date)
	values 
		(1, '2012-05-06'),
		(2, '2012-07-04'),
		(3, '2012-06-16'),
		(4, '2012-04-16'),
		(5, '2012-04-16');

insert into EducationLevel(EducationLevel, Degree, DegreeShort)
	values 
		('Podstawowe', Null, null),
		('Gimnazjalne', Null, null),
		('Ponadgimnazjalne', Null, null),
		('Policealne', Null, null),
		('Studium', Null, null),
		('Wy¿sze I stopnia techniczne', 'in¿ynier', 'in¿'),
		('Wy¿sze I stopnia', 'licencjat', null);


insert into Training(IdEmployee, TrainingName, TrainingStartDate, TrainingEndDate, TrainingPrice)
	values 
		(1, 'Szkolenie kierownicze', '2020-01-05', '2020-01-06', 600),
		(2, 'Szkolenie kierownicze', '2020-01-05', '2020-01-06', 1000),
		(3, 'Szkolenie kierownicze', '2020-01-05', '2020-01-06', 400),
		(4, 'Szkolenie kierownicze', '2020-01-05', '2020-01-06', 500),
		(5, 'Szkolenie kierownicze', '2020-01-05', '2020-01-06', 1500);
		

insert into Education(IdEmployee, IdEducationLevel, GraduationDate)
	values
		(1, 5, '2009-06-06'), 
		(2, 6, '2009-06-06'), 
		(3, 4, '2009-06-06'), 
		(4, 3, '2009-06-06'), 
		(5, 2, '2009-06-06');

--Quality control

--Accident
insert into Accident (IdEmployee, AccidentDate, AccidentDescription) values
		(1, '2019-01-07 09:30:00', 'Skaleczenie d³oni arkuszem blachy'),
		(2, '2019-02-01 10:15:00', 'Potkniêcie o niezabezpieczony kabel, uraz kostki'),
		(3, '2019-03-11 11:25:00', 'Skaleczenie d³oni podczas rozwijania blachy'),
		(4, '2019-03-12 13:35:00', 'Uraz rêki na skutek w³o¿enia jej do maszyny'),
		(5, '2019-04-01 10:50:00', 'Spadek rolki blachy z uszkodzonej pó³ki magazynowej');


--FEMAnalysis
insert into FEMAnalysis (IdEmployee, NewPattern, AnalysisResults) values
		(2, ' ', 'Wzór nr 1, odporny na du¿e naciski, idealny na górskie dachy'),
		(2, ' ', 'Wzór nr 2, nowatorskie t³oczenia'),
		(2, ' ', 'Wzór nr 3, test blachy od nowego producenta'),
		(2, ' ', 'Wzór nr 4, wersja ekonomiczna dla lekkiej wiêŸby'),
		(2, ' ', 'Wzór nr 5, dla monta¿u o najmniejszym odpadzie');

/*Insert Into FEMAnalysis (IdEmployee, NewPattern, AnalysisResults)
Select '2', BulkColumn, 'Wzór nr 1, odporny na du¿e naciski, idealny na górskie dachy'
from Openrowset (Bulk 'C:\Users\Milenka\Documents\SQL Server Management Studio\1.jpg', Single_Blob) as Image;
Insert Into FEMAnalysis (IdEmployee, NewPattern, AnalysisResults)
Select , '2', BulkColumn, 'Wzór nr 2, nowatorskie t³oczenia'
from Openrowset (Bulk 'C:\Users\Milenka\Documents\SQL Server Management Studio\2.jpg', Single_Blob) as Image;
Insert Into FEMAnalysis (IdEmployee, NewPattern, AnalysisResults)
Select '2', BulkColumn, 'Wzór nr 3, test blachy od nowego producenta'
from Openrowset (Bulk 'C:\Users\Milenka\Documents\SQL Server Management Studio\3.jpg', Single_Blob) as Image;
Insert Into FEMAnalysis (IdEmployee, NewPattern, AnalysisResults)
Select '2', BulkColumn, 'Wzór nr 4, wersja ekonomiczna dla lekkiej wiêŸby'
from Openrowset (Bulk 'C:\Users\Milenka\Documents\SQL Server Management Studio\4.jpg', Single_Blob) as Image;
Insert Into FEMAnalysis (IdEmployee, NewPattern, AnalysisResults)
Select '2', BulkColumn, 'Wzór nr 5, dla monta¿u o najmniejszym odpadzie'
from Openrowset (Bulk 'C:\Users\Milenka\Documents\SQL Server Management Studio\5.jpg', Single_Blob) as Image;*/



--SafetyControl
insert into SafetyControl (IdSafetyEmployee, IdInspectedEmployee, SaftyControlDate, SafetyControlDescription, CompanyName) values
		('Dêbek Jaros³aw 423452', 1, '2019-01-07 10:20:00', 'Œrodki ochrony indywidualnej, pozytywnie', 'TBF'),
		('Dêbek Jaros³aw 423452', 2, '2019-01-07 10:30:00', 'Œrodki ochrony indywidualnej, pozytywnie', 'TBF'),
		('Dêbek Jaros³aw 423452', 3, '2019-01-07 10:40:00', 'Œrodki ochrony indywidualnej, pozytywnie', 'TBF'),
		('Dêbek Jaros³aw 423452', 4, '2019-01-07 10:50:00', 'Œrodki ochrony indywidualnej, pozytywnie', 'TBF'),
		('Dêbek Jaros³aw 423452', 5, '2019-01-07 11:00:00', 'Œrodki ochrony indywidualnej, pozytywnie', 'TBF');

--SafetyTraining
insert into SafetyTraining (IdEmployee, TrainingDate) values
		(1, '2019-01-02 08:00:00'),
		(2, '2019-01-02 08:00:00'),
		(3, '2019-01-02 08:00:00'),
		(4, '2019-01-02 08:00:00'),
		(5, '2019-01-02 08:00:00');

--SemiFinished
/*gruboœci blachy u Pruszyñskiego: 0,5; 0,7, 1; 1,25
kolory G - grafit, C - ceg³a, W - wiœnia, B - br¹z, X - czerñ
po # numer rolki
jednostki: mm, kg
przyk³adowa rolka https://sprzedajemy.pl/blacha-aluminiowa-0-7-mm-konstancin-jeziorna-2-a1d299-nr58670589*/
insert into SemiFinished (SfCode, Thickness, Width, SfWeight, Color, ChemicalComposition) values
		('C05#1', 0.5, 1000, 580, 'ceg³a', 'C, Fe, Ni, Cr'),
		('G05#1', 0.5, 1000, 580, 'grafit', 'C, Fe, Ni, Cr'),
		('C07#1', 0.7, 1000, 750, 'ceg³a', 'C, Fe, Ni, Cr'),
		('W10#1', 1.0, 1000, 950, 'wiœnia', 'C, Fe, Ni, Cr'),
		('B125#1', 1.25, 1000, 1400, 'br¹z', 'C, Fe, Ni, Cr');

insert into Technology(TechnologyName, TimePermeter, SpeedFactor)
	Values
		('Trapez maly', 3, 0.9),
		('Trapez duzy', 2, 0.8),
		('Plaski', 5, 1),
		('Dachowka', 3, 1),
		('Falisty', 2.5, 1);

--Product
/*TD - trapez du¿y, TM - trapez ma³y P - p³aski, D - dachówka, F - falisty*/
insert into Product (IdSemiFinished, ProductCode, IdTechnology, InputDate) values
		(1, 'C05#1D', 4, '2019-01-07 10:30:00'),
		(2, 'G05#1D', 4, '2019-01-07 10:40:00'),
		(3, 'C07#1D', 4, '2019-01-07 10:50:00'),
		(4, 'W10#1D', 4, '2019-01-07 11:00:00'),
		(5, 'B125#1D', 4, '2019-01-07 11:10:00');

--TechnicalProductData
insert into TechnicalProductData (IdProduct, Pattern, Width, WeightPerMeter, Lenght, PricePerMeter) values
		(1, '', 800, 50, 5000, 40),
		(2, '', 800, 55, 5000, 45),
		(3, '', 800, 48, 5000, 38),
		(4, '', 800, 55, 5000, 35),
		(5, '', 800, 57, 5000, 40);


/*Insert Into TechnicalProductData (IdProduct, Pattern, Width, WeightPerMeter, Lenght, PricePerMeter)
Select '1', BulkColumn, '800', '50', '5000', '40'
from Openrowset (Bulk 'C:\Users\Milenka\Documents\SQL Server Management Studio\1.jpg', Single_Blob) as Image;
Insert Into TechnicalProductData (IdProduct, Pattern, Width, WeightPerMeter, Lenght, PricePerMeter)
Select '2', BulkColumn, '800', '55', '5000', '45'
from Openrowset (Bulk 'C:\Users\Milenka\Documents\SQL Server Management Studio\2.jpg', Single_Blob) as Image;
Insert Into TechnicalProductData (IdProduct, Pattern, Width, WeightPerMeter, Lenght, PricePerMeter)
Select '3' BulkColumn, '800', '48', '5000', '38'
from Openrowset (Bulk 'C:\Users\Milenka\Documents\SQL Server Management Studio\3.jpg', Single_Blob) as Image;
Insert Into TechnicalProductData (IdProduct, Pattern, Width, WeightPerMeter, Lenght, PricePerMeter)
Select '4' BulkColumn, '800', '55', '5000', '35'
from Openrowset (Bulk 'C:\Users\Milenka\Documents\SQL Server Management Studio\4.jpg', Single_Blob) as Image;
Insert Into TechnicalProductData (IdProduct, Pattern, Width, WeightPerMeter, Lenght, PricePerMeter)
Select '5' BulkColumn, '800', '57', '5000', '40'
from Openrowset (Bulk 'C:\Users\Milenka\Documents\SQL Server Management Studio\5.jpg', Single_Blob) as Image;*/

--UR

insert into Unit values (1, 'Szt');
insert into Unit values (2, 'Litr');
insert into Unit values (3, 'Metr');
insert into Unit values (4, 'Kilogram');

insert into MachineType values (1, '¿³obiarka');
insert into MachineType values (2, 'Walcarka');
insert into MachineType values (3, 'Profilarka');
insert into MachineType values (4, 'Zaginarka');
insert into MachineType values (5, 'Gilotyna');

insert into Machine values (1, 4, 'ZDR', 'Dachdecker', 2017, '2', '7m2', '87WF', 360);
insert into Machine values (2, 5, 'ZRA', 'Dachdecker', 2015, '5', NULL, '10DW', 80);
insert into Machine values (3, 4, 'SEG-L', 'Dachdecker', 2016, '3', '8m2', '9EF2', 400);
insert into Machine values (4, 2, 'ZRC', 'Dachdecker', 2018, '4', NULL, 'P12D', 200);
insert into Machine values (5, 1, 'ZRA', 'Dachdecker', 2014, '3', NULL, 'E21M', 100);
 
insert into MaintType values (1, 'Awaria');
insert into MaintType values (2, 'Przegl¹d');
insert into MaintType values (3, 'Konserwacja');

insert into MaintDescription values (1, 'Smarowanie ³añcucha', null, 0.25);
insert into MaintDescription values (2, 'Wymiana ³o¿ysk', null, 6);
insert into MaintDescription values (3, 'Regulacja luzu napinacza', null, 1);
insert into MaintDescription values (4, 'Pomiar zu¿ycia kó³ zêbatych', null, 2);
insert into MaintDescription values (5, 'Wymiana pasa napêdowego', null, 0.25);

insert into PartType values (1, '£o¿ysko');
insert into PartType values (2, 'Pasek');
insert into PartType values (3, 'Ko³o zêbate');
insert into PartType values (4, 'Smar');
insert into PartType values (5, '£añcuch');

insert into Part values (1, 1, 1, '£o¿ysko kulkowe', 'SKF', 6305, 10);
insert into Part values (2, 3, 1, 'Ko³o zêbate M5', 'Tente', 516, 3);
insert into Part values (3, 4, 4, 'Smar maszynowy', 'CX80', 43681554, 2);
insert into Part values (4, 5, 3, '£añcuch krzy¿akowy', 'Kort', 5735, 5);
insert into Part values (5, 2, 3, 'Pasek zêbaty', 'Oscar', 450, 12);

insert into Maintenance values (1, 2, 2, 3, '2019-03-07 09:43:21 AM', '2019-03-08 10:34:09 AM', '2019-03-08 02:25:53 PM', '8753T78B');
insert into Maintenance values (2, 4, 1, 2, '2019-03-11 08:23:32 AM', '2019-03-11 09:14:09 AM', '2019-03-11 11:45:13 AM', '8912YEY9');
insert into Maintenance values (3, 1, 3, 1, '2019-03-12 08:00:42 AM', '2019-03-12 08:36:59 AM', '2019-03-12 09:10:14 AM', 'P13I1NE1');
insert into Maintenance values (4, 5, 2, 3, '2019-03-13 12:15:54 PM', '2019-03-13 12:20:42 PM', '2019-03-13 12:40:32 PM', 'J4K1EHU1');
insert into Maintenance values (5, 3, 2, 4, '2019-04-10 08:33:21 AM', '2019-05-20 08:12:47 AM', '2019-05-20 10:53:40 AM', 'T0D3B1L3');

insert into MaintPart values (1, 1, 5, 2);
insert into MaintPart values (2, 2, 1, 4);
insert into MaintPart values (3, 3, 3, 1);
insert into MaintPart values (4, 4, 5, 3);
insert into MaintPart values (5, 5, 2, 1);

insert into PartRequest values (1, 2, 5, 0, '2019-04-07 12:12:47 AM');
insert into PartRequest values (2, 3, 10, 0, '2019-04-08 08:42:27 AM');
insert into PartRequest values (3, 5, 25, 0, '2019-04-08 10:25:45 AM');
insert into PartRequest values (4, 1, 8, 0, '2019-04-09 09:10:26 AM');
insert into PartRequest values (5, 4, 20, 0, '2019-04-10 11:31:24 AM');

insert into PartOrder values (1, 1, '2019-04-07 12:32:42 PM', 0, 50);
insert into PartOrder values (2, 2, '2019-04-08 08:55:10 AM', 0, 125);
insert into PartOrder values (3, 3, '2019-04-08 11:40:15 AM', 0, 30);
insert into PartOrder values (4, 4, '2019-04-09 09:26:53 AM', 0, 47);
insert into PartOrder values (5, 5, '2019-04-10 12:05:25 PM', 0, 215);

insert into PartOrderRequest values (1, 1, 1);
insert into PartOrderRequest values (2, 2, 2);
insert into PartOrderRequest values (3, 3, 3);
insert into PartOrderRequest values (4, 4, 4);
insert into PartOrderRequest values (5, 5, 5);

insert into PartOrderDetail values (1, 1, 1, 5);
insert into PartOrderDetail values (2, 2, 2, 20);
insert into PartOrderDetail values (3, 3, 3, 13);
insert into PartOrderDetail values (4, 4, 4, 100);
insert into PartOrderDetail values (5, 5, 5, 32);

insert into Realization values (1, 1, 1, '2019-03-08 10:34:09 AM', '2019-03-08 02:25:53 PM');
insert into Realization values (2, 1, 2, '2019-03-08 10:34:09 AM', '2019-03-08 02:25:53 PM');
insert into Realization values (3, 2, 3, '2019-03-11 09:14:09 AM', '2019-03-11 11:45:13 AM');
insert into Realization values (4, 2, 1, '2019-03-11 09:14:09 AM', '2019-03-11 11:45:13 AM');
insert into Realization values (5, 3, 2, '2019-03-12 08:36:59 AM', '2019-03-12 09:10:14 AM');

insert into EmployeePlan values (1, 1, 1, '2019-03-08 10:34:09 AM', '2019-03-08 02:25:53 PM');
insert into EmployeePlan values (2, 1, 2, '2019-03-08 10:34:09 AM', '2019-03-08 02:25:53 PM');
insert into EmployeePlan values (3, 2, 3, '2019-03-11 09:14:09 AM', '2019-03-11 11:45:13 AM');
insert into EmployeePlan values (4, 2, 1, '2019-03-11 09:14:09 AM', '2019-03-11 11:45:13 AM');
insert into EmployeePlan values (5, 3, 2, '2019-03-12 08:36:59 AM', '2019-03-12 09:10:14 AM');


--SD
insert into Customer values('AndrzejBlach Sp. z o.o.', '606842134', 'AnBlach@gmail.com', 'Kraków',
'12-852', 'Wolnoœci', '6', '', '', '1021256487', '974131497', ' ');
insert into Customer values('BlachPOL Sp. z o.o.', '504897425', 'BPPL@gmail.com', 'Bytom',
'97-234', 'Sosnowa', '7', '16', '', '1023259852', '134863918', '');
insert into Customer values('BlachLAND Sp. akcyjna', '506487412', 'blachland@wp.pl', 'Kielce',
'41-262', 'Œwierkowa', '9', '26', '', '2012549782', '654316487', '');
insert into Customer values('Zdzis³aw £om¿ysñki', '602352148', 'zdzisiek58@gmail.com', 'Sosnowiec',
'62-234', 'Pusta', '2', '', '1021112065', ' ', '', 'Wa¿ny klient');
insert into Customer values('Zenon ¯eliwny', '605987412', 'ZenonZET@pocztaonet.pl', '¯yrardów',
'05-813', 'Sosnowa', '43', '', '1021023158', ' ', '', '');

insert into OrderCustomer values('2', '1', '2019-04-05 14:00', '5500', '20');
insert into OrderCustomer values('2', '2', '2019-04-02 12:00', '6800', '30');
insert into OrderCustomer values('3', '2', '2019-04-08 10:00', '1200', '40');
insert into OrderCustomer values('1', '2', '2019-03-28 10:00', '5800', '10');
insert into OrderCustomer values('5', '1', '2019-03-21 11:00', '9600', '10');
insert into OrderCustomer values('4', '2', '2019-03-18 09:30', '4580', '50');
insert into OrderCustomer values('2', '1', '2019-03-12 11:00', '12000', '15');

insert into OrderDetail values('1', '1', '100');
insert into OrderDetail values('1', '2', '200');
insert into OrderDetail values('2', '1', '150');
insert into OrderDetail values('2', '2', '80');
insert into OrderDetail values('3', '2', '40');
insert into OrderDetail values('4', '2', '60');
insert into OrderDetail values('5', '2', '800');
insert into OrderDetail values('6', '1', '400');
insert into OrderDetail values('6', '2', '900');
insert into OrderDetail values('7', '2', '1200');

insert into SupplierType values('Pó³fabrykaty');
insert into SupplierType values('Czêœci');

insert into Supplier values('1', 'BlachoSprzedawca s.a.', '604215468', 'BlachoSprzedawca@wp.pl', '¯yrardów',
'05-813', 'D³uga', '11', '', '1023254186','56168496', '');
insert into Supplier values('1', 'Urimarex s.a.', '616201425', 'unimarex@gmail.com', 'Warszawa',
'02-111', 'Pu³awska', '98', '2', '1203256475','61543244', ' ');
insert into Supplier values('1', 'BlachMAN s.j.', '807412345', 'BlachMAN@pocztaonet.pl', 'Gdañsk',
'11-025', 'Morska', '2', '', '1023256412','7564231', '');
insert into Supplier values('2', 'RoboMAN s.j.', '978085413', 'RoboMAN@gmail.com', 'P³oñsk',
'07-514', 'Sroga', '34', '11', '1202325142','2483213', '');
insert into Supplier values('2', 'Vortex s.j.', '504123520', 'Vortex@gmail.com', 'Katowice',
'02-134', 'Po³udniowa', '214', '', '1102012584','123135468', '');

insert into SemiFinishedOrder values('1', '2019-03-02 10:00', '2019-03-05 10:00', '8000');
insert into SemiFinishedOrder values('2', '2019-03-03 10:00', '2019-03-05 10:00', '400');
insert into SemiFinishedOrder values('1', '2019-03-15 10:00', '2019-04-18 10:00', '3500');
insert into SemiFinishedOrder values('2', '2019-04-02 10:00', '2019-04-05 10:00', '1200');
insert into SemiFinishedOrder values('3', '2019-04-08 10:00', '', '')

insert into SfOrderDetail values('1', '1', '750');
insert into SfOrderDetail values('1', '2', '1500');
insert into SfOrderDetail values('2', '1', '3500');
insert into SfOrderDetail values('2', '2', '1450');
insert into SfOrderDetail values('3', '1', '2700');
insert into SfOrderDetail values('4', '2', '1450');
insert into SfOrderDetail values('5', '3', '705');

--EntranceControl
insert into EntranceControl (IdSfDetail, IdEmployee, ControlDate, ControlStatus, Comments, Quantity) values
		(1, 1, '2019-01-02 08:03:36', 1, 'Rozerwana folia ochronna', 2),
		(2, 1, '2019-01-02 08:07:36', 1, 'Brak wad', 1),
		(3, 1, '2019-01-02 08:13:36', 1, 'Brak wad', 3),
		(4, 1, '2019-01-02 08:20:36', 1, 'Brak wad', 1),
		(6, 1, '2019-01-02 08:25:36', 0, 'Z³y kolor', 2);

insert into OutsourcingType values('Gosp. odpadami');
insert into OutsourcingType values('Transport do klienta');
insert into OutsourcingType values('Reklama');

insert into Outsourcing values('1', 'Œmieciorex s.a.', '807412621', 'Œmieciorex@gmail.com', 'Poznañ',
'02-144', 'Brudna', '123', '321', '7452145876','32165498', '');
insert into Outsourcing values('2', 'TirPower s.a.', '604215120', 'TirPower@gmail.com', 'Gdynia',
'04-741', 'Daleka', '84', '', '1202325489','10231512', '');
insert into Outsourcing values('3', 'Reda SA s.a.', '908741521', 'CleanHouse@gmail.com', 'Zamoœæ',
'01-121', 'Toporna', '24', '1', '1203254158','102135157', '');

insert into OutsourcingCommitment values('1', '2019-07-31', '');
insert into OutsourcingCommitment values('2', '2019-08-30', '');
insert into OutsourcingCommitment values('3', '2019-06-30', '');
insert into OutsourcingCommitment values('1', '2019-03-12', '4000');
insert into OutsourcingCommitment values('2', '2019-04-02', '3500');
insert into OutsourcingCommitment values('2', '2019-03-31', '5000');
insert into OutsourcingCommitment values('3', '2019-11-30', '');

--production

 insert into PlannedProduction (IdDetail, IdMachine, PlannedStartd,PlannedEndd,Inproduction)
 values 
	('1', '1', '2019-07-31','2019-02-15','0'),
	('2', '2', '2019-07-31','2019-03-30','0'),
	('3', '3', '2019-07-31','2019-03-30','1'),
	('4', '4', '2019-07-31','2019-04-30','1'),
	('5', '5', '2019-07-31','2019-05-30','1');

insert into PlannedProductionEmployeeDetails (IdProces, IdEmployee, StartDate, EndDate)
 values
	('1','1', '2019-01-27', '2019-02-15'),
	('2','2', '2019-02-15', '2019-03-27'),
	('3','3', '2019-03-27', '2019-04-27'),
	('4','4', '2019-04-27', '2019-05-27'),
	('5','5', '2019-05-27', '2019-06-27');

 insert into ProductionProces(IdPlan, StartDate, EndDate)
 values  
	('1', '2019-03-23','2019-04-23'),
	('2', '2019-04-23','2019-05-23'),
	('3', '2019-05-23','2019-06-23'),
	('4', '2019-06-23','2019-07-23'),
	('5', '2019-08-23','2019-09-23');

 insert into Failure(IdProces, Specification, FailureDate)
 values 
	('1','wybuch³o','2019-02-23'),
	('2','pali siê','2019-03-23'),
	('3','stuka','2019-04-23'),
	('4','ale urwa³','2019-05-23'),
	('5','nie dziala','2019-06-23');

insert into FailureMaintenance values (1, 1, 2);

 --OutControl
insert into OutControl (IdProces, IdEmployee, ControlDate, ControlStatus, Comments, Quantity) values
(1, 3, '2019-01-02 15:28:36', 1, 'Wszystkie zmierzone parametry prawid³owe', 10),
(2, 3, '2019-01-03 14:55:17', 1, 'Wszystkie zmierzone parametry prawid³owe', 10),
(3, 3, '2019-01-04 15:23:55', 1, 'Wszystkie zmierzone parametry prawid³owe', 10),
(4, 3, '2019-01-07 16:05:45', 1, 'Wszystkie zmierzone parametry prawid³owe', 10),
(5, 3, '2019-01-08 15:42:22', 0, 'Nierówne t³oczenie', 10);
