use RoofingCompany;

--HR
insert into Employee (EmployeeName, EmployeeSurname, ZipCode, City, Street, HouseNumber, ApartmentNum, PhoneNumber, PESEL)
	values
		('Andrzej', 'Kowalski', '01-493', 'Warszawa', 'Niepodległości', '105', '102', '589 603 804', '78121611920'),
		('Stefan', 'Nowak', '04-905', 'Warszawa', 'Powstańców', '10', '20', '607 894 489', '66123111809'),
		('Witold', 'Wiśniewski', '03-444', 'Otwock', 'Główna', '23A', '5', '555 555 444', '33112244560'),
		('Szymon', 'Wójcik', '40-404', 'Wrocław', 'Gen. Maczka', '50B', '10', '666 666 321', '55100511890'),
		('Dariusz', 'Kowalczyk', '30-400', 'Lublin', 'Marii Curie', '300C', '11', '555 312 123', '89011588290'),
		('Andrzej', 'Andrzej', '99-351', 'Włocławek', 'Główna', '3E', '3', '543 123 888', '88061155443'),
		('Jakub', 'Kowal', '33-230', 'Warszawa', 'Puławska', '33', Null, '777 777 777', '55112234562'),
		('Michał', 'Bromiński', '09-212', 'Warszawa', 'Ekologiczna', '25', '22', '666 666 666', '95031355232'),
		('Michał', 'Kujda', '01-494', 'Warszawa', 'Rosy Bailly', '1C', Null, '666 626 234', '94032312455'),
		('Paweł', 'Kusicielek', '30-303', 'Pruszków', Null, '401', 'Null', '555 321 123', '55012155222'),
		('Anna', 'Kowalczyk', '01-505', 'Warszawa', 'Nadwodna', '30', '12', '546 879 659', '89021585230'),
		('Jacław', 'Rozmus', '20-350', 'Kraków', 'Marii Curie', '300C', '22', '667 631 557', '71073067344'),
		('Huberta', 'Bartosiak', '30-500', 'Lublin', 'Główna', '3', null, '287 254 650', '74061973058'),
		('Andromeda', 'Adamek', '10-800', 'Warszawa', 'Racławicka', '20', null, '723 420 610', '89051334881'),
		('Niecisław', 'ŚWitała', '22-555', 'Kraków', 'Rakowiecka', '81', '12', '708 154 330', '67082435131'),
		('Iwa', 'Szymanek', '33-440', 'Zakopane', 'Puławska', '35', '2', '595 810 620', '65062863154'),
		('Anna', 'Zielonka', '07-400', 'Gliwice', 'Niepodległości', '32', '10', '172 537 850', '57102456561'),
		('Marek', 'Góralczyk', '05-333', 'Sosnowiec', 'Dolna', '33', '15', '139 523 658', '91031803733'),
		('Dorota', 'Kosicka', '19-303', 'Gdańsk', 'Górna', '121', Null, '321 479 793', '98122988203'),
		('Małgorzata', 'Brzóska', '10-105', 'Gdynia', 'Boczna', '78', null, '142 553 559', '57041566600'),
		('Marcin', 'Kot', '02-708', 'Szczecin', 'Poznańska', '58', '11', '136 516 860', '87082457595'),
		('Dariusz', 'Dzik', '23-567', 'Sopot', 'Mazowiecka', '96', '9', '467 153 414', '85040624829'),
		('Diana', 'Nycz', '67-324', 'Białystok', 'Krakowska', '10', '25', '538 343 829', '96050977429'),
		('Edyta', 'Sagan', '06-632', 'Bielsk Podlaski', 'Kremowa', '9', null, '817 857 290', '99083052624'),
		('Gabriel', 'Kowalczy', '20-455', 'Bielsko-Biała', 'Biała', '1B', null, '196 622 270', '66070613575'),
		('Wojciech', 'Konieczny', '80-505', 'Poznań', 'Czarna', '3C', '5', '277 105 690', '51012491533'),
		('Mariusz', 'Podgórski', '90-606', 'Toruń', 'Kwiatowa', '8B', '3', '831 794 577', '81072821397'),
		('Klaudia', 'Badura', '55-555', 'Wadowice', 'Różana', '20A', '8', '886 232 342', '64020854245'),
		('Marceli', 'Milewski', '66-666', 'Częstochowa', 'Jaskółki', '11', '20', '187 680 053', '89011588290');

		
insert into Position (Workplace, ValidityOfOshTraining, VailidityOfMedicalExam) --Validity in days
	values
		('Kierownik', 2190, 730),				--1 All
		('Kontroler jakości', 730, 730),		--2	Quality control
		('Inżynier projektant', 730, 730),		--3 Quality control
		('Operator', 365, 365),					--4	Production
		('Elektromechanik', 365, 365),			--5	Maintenance
		('Automatyk', 365, 365),				--6 Maintenance
		('Handlowiec', 2190, 730),				--7 Logistics
		('Księgowy', 2190, 730),				--8	HR&Finances
		('Pracownik HR', 2190, 730),			--9	HR&Finances
		('Dyrektor', null, null);				--10


insert into Contract(StartDate, EndDate, Salary, IdEmployee, IdPosition, HealTestDate, WorkplaceTrainingDate)
	values
		('2018-03-22', '2020-03-22', 25000, 1, 10, '2018-03-20', '2018-03-23'),
		('2018-05-06', '2020-05-06', 8000, 2, 1, '2018-05-05', '2018-05-06'),
		('2018-06-13', '2020-06-13', 7000, 3, 1, '2018-06-10', '2018-06-13'),
		('2018-03-16', '2020-03-16', 9000, 4, 1, '2018-03-12', '2018-03-16'),
		('2018-02-15', '2020-02-15', 7500, 5, 1, '2018-02-13', '2018-02-15'),
		('2018-03-22', '2020-03-22', 8000, 6, 1, '2018-03-20', '2018-03-23'),
		('2018-05-06', '2020-05-06', 5000, 7, 2, '2018-05-05', '2018-05-06'),
		('2018-06-13', '2020-06-13', 4000, 8, 2, '2018-06-10', '2018-06-13'),
		('2018-03-16', '2020-03-16', 4500, 9, 3, '2018-03-12', '2018-03-16'),
		('2018-02-15', '2020-02-15', 4000, 10, 3, '2018-02-13', '2018-02-15'),
		('2018-03-22', '2019-05-22', 4000, 11, 4, '2018-03-20', '2018-03-23'),
		('2018-05-06', '2019-05-06', 4700, 12, 4, '2018-05-05', '2018-05-06'),
		('2018-06-13', '2020-06-13', 4300, 13, 4, '2018-06-10', '2018-06-13'),
		('2018-03-16', '2020-03-16', 3700, 14, 4, '2018-03-12', '2018-03-16'),
		('2018-02-15', '2020-02-15', 3500, 15, 4, '2018-02-13', '2018-02-15'),
		('2018-03-22', '2020-03-22', 4500, 16, 4, '2018-03-20', '2018-03-23'),
		('2018-05-06', '2020-05-06', 4000, 17, 4, '2018-05-05', '2018-05-06'),
		('2018-06-13', '2019-07-13', 4200, 18, 4, '2018-06-10', '2018-06-13'),
		('2018-03-16', '2020-03-16', 4100, 19, 4, '2018-03-12', '2018-03-16'),
		('2018-02-15', '2020-02-15', 4700, 20, 4, '2018-02-13', '2018-02-15'),
		('2018-03-22', '2020-03-22', 5000, 21, 5, '2018-03-20', '2018-03-23'),
		('2018-05-06', '2020-05-06', 5100, 22, 5, '2018-05-05', '2018-05-06'),
		('2018-06-13', '2019-06-13', 4700, 23, 6, '2018-06-10', '2018-06-13'),
		('2018-03-16', '2020-03-16', 4500, 24, 6, '2018-03-12', '2018-03-16'),
		('2018-02-15', '2020-02-15', 3500, 25, 7, '2018-02-13', '2018-02-15'),
		('2018-03-22', '2020-03-22', 3500, 26, 7, '2018-03-20', '2018-03-23'),
		('2018-05-06', '2020-05-06', 6500, 27, 8, '2018-05-05', '2018-05-06'),
		('2018-06-13', '2019-07-13', 4500, 28, 9, '2018-06-10', '2018-06-13');


Insert into AbsenceType(AbscenceReason, Multiplier)
	values 
		('Urlop płatny', 1),
		('Urlop bezpłatny', 0),
		('Na żądanie', 0),
		('Nieusprawiedliwiona', 0),
		('L4', 0.75);

insert into Absence(IdAbsenceType, IdEmployee, StartOfAbsence, EndOfAbsence)
	values
		(1, 1, '2018-05-12', '2018-05-19'),
		(2, 2, '2018-08-01', '2018-08-08'),
		(3, 3, '2018-10-21', '2018-10-22'),
		(4, 4, '2018-11-02', '2018-11-02'),
		(5, 5, '2018-12-15', '2018-12-20'),
		(1, 7, '2019-01-12', '2019-01-19'),
		(1, 11, '2019-01-01', '2019-01-08'),
		(3, 13, '2019-01-21', '2019-01-23'),
		(5, 17, '2019-01-02', '2019-01-22'),
		(3, 20, '2019-02-15', '2019-02-20'),
		(1, 21, '2019-02-12', '2019-02-19'),
		(5, 22, '2019-02-01', '2019-02-08'),
		(2, 9, '2019-02-21', '2019-02-22'),
		(2, 19, '2019-03-02', '2019-03-02'),
		(5, 28, '2019-03-15', '2019-03-20'),
		(1, 6, '2019-05-12', '2019-05-19'),
		(2, 12, '2019-06-01', '2019-06-08'),
		(2, 1, '2019-06-21', '2019-06-22'),
		(2, 2, '2019-07-02', '2019-07-02'),
		(1, 3, '2019-06-15', '2019-06-20'),
		(1, 4, '2019-05-12', '2019-05-19'),
		(1, 5, '2019-05-01', '2019-05-08'),
		(2, 6, '2019-04-21', '2019-04-22'),
		(2, 11, '2019-07-02', '2019-07-10'),
		(1, 23, '2019-05-15', '2019-05-20');

insert into Payment(Bonus, IdEmployee, Date, Sum)
	values
		(DEFAULT, 1, '2018-07-01', 3500),
		(300, 2, '2018-07-01', 3000),
		(100, 3, '2018-07-01', 3000),
		(500, 4, '2018-07-01', 3000),
		(250, 5, '2018-07-01', 3000),
		(230, 7, '2018-08-01', 3630),--
		(630, 6, '2018-08-01', 3210),
		(140, 8, '2018-08-01', 3340),
		(330, 9, '2018-09-01', 3750),
		(250, 10, '2018-09-01', 2950),
		(170, 11, '2018-09-01', 3170),
		(100, 13, '2018-09-01', 3850),
		(440, 15, '2018-10-01', 4440),
		(160, 12, '2018-10-01', 3660),
		(200, 14, '2018-11-01', 2910),
		(default, 17, '2018-11-01', 3100),
		(550, 20, '2018-12-01', 3450),
		(350, 19, '2018-12-01', 3250),
		(125, 21, '2018-12-01', 3565),
		(325, 22, '2018-12-01', 2865),
		(350, 23, '2019-01-01', 3450),
		(450, 24, '2019-01-01', 3350),
		(default, 25, '2019-01-01', 4100),
		(default, 26, '2019-02-01', 3560),
		(120, 27, '2019-02-01', 3420),
		(170, 28, '2019-02-01', 4420);

INSERT INTO Department(DepartmentName)
	values
		('Produkcja'),
		('Utrzymanie ruchu'),
		('HR i Finanse'),
		('Logistyka'),
		('Kontrola jakoci');

insert into Staff(IdDeparment, IdPosition, Number, DateFrom)
	values 
		(1, 1, 1, '2019-04-04'),
		(1, 4, 5, '2019-04-04'),
		(2, 1, 1, '2019-04-04'),
		(2, 5, 2, '2019-04-04'),
		(2, 6, 2, '2019-04-04'),
		(3, 1, 1, '2019-04-04'),
		(3, 8, 1, '2019-04-04'),
		(3, 9, 2, '2019-04-04'),
		(4, 1, 1, '2019-04-04'),
		(4, 7, 2, '2019-04-04'),
		(5, 9, 2, '2019-04-04'),
		(5, 1, 1, '2019-04-04'),
		(5, 7, 2, '2019-04-04');


INSERT INTO Contractor(ContractorName,Phone,Email,City,PostalCode,Street,HouseNumber,ApartmentNumber,NIP,KRS)
	values
		('PGNiG',520325652,'pgnigo@o2.pl','Warszawa',00537,'ul.Krucza','14','6',525008028,0000059492),
		('Energa',652232522,'energa.sa@energa.pl','Gdańsk',80309,'al. Grunwaldzka','472','',9570957722,0000271591),
		('MPWiK',224455000,'dok@mpwik.com.pl','Warszawa',02015,'pl. Starynkiewicza','5','',5250005662,0000146138),
		('T-Mobile',602913000,'pr@t-mobile.pl','Warszawa',02674,'ul. Marynarska','12','',5261040567,0000391193),
		('T-Mobile',222200000,'nc+@canal+.pl','Łódź',31535,'al. gen. W. Sikorskiego','12','2',5210082774,0000469644);

INSERT INTO InvoiceType(Type)
	values
		('Energia elektryczna'),
		('Wodociągi'), 
		('Śmieci'),
		('Artykuły biurowe'),
		('Inwestycje');

INSERT INTO Invoice(IdContractor,IdInvoiceType,Date,Sum)
	values
		(1, 2, '2019-02-10', 550.45),
		(3, 3, '2019-03-10', 1250),
		(2, 4, '2019-04-05', 5504),
		(5, 2, '2019-02-22', 1550.15),
		(4, 5, '2019-02-22', 50),
		(2, 4, '2019-02-23', 1532),
		(1, 2, '2019-03-03', 876),
		(3, 3, '2019-03-06', 1452),
		(4, 5, '2019-03-08', 2563),
		(5, 5, '2019-03-16', 12325),
		(1, 2, '2019-04-04', 3210),
		(2, 4, '2019-04-06', 425),
		(3, 3, '2019-04-10', 3200),
		(4, 5, '2019-04-11', 1250),
		(5, 5, '2019-04-17', 6500);

INSERT INTO Expense(IdDepartment,IdInvoice)
	values
		(1,1),
		(3,3),
		(2,5),
		(1,2),
		(5,4),
		(2, 5),
		(1, 7),
		(3, 8),
		(5, 9),
		(1, 11),
		(2, 10),
		(3, 12),
		(4, 15);

insert into Allocation(IdEmployee, IdDepartment, StartDate, EndDate)
	Values
		(2, 1, '2018-03-22', NULL),
		(3, 2, '2018-05-06', NULL),
		(4, 3, '2018-06-13', NULL),
		(5, 4, '2018-03-16', NULL),
		(6, 5, '2018-02-15', NULL),
		(7, 5, '2018-03-22', NULL),
		(8, 5, '2018-05-06', NULL),
		(9, 5, '2018-06-13', NULL),
		(10, 5, '2018-03-13', NULL),
		(11, 1, '2018-02-22', NULL),
		(12, 1, '2018-03-06', NULL),
		(13, 1, '2018-05-13', NULL),
		(14, 1, '2018-06-16', NULL),
		(15, 1, '2018-03-15', NULL),
		(16, 1, '2018-02-22', NULL),
		(17, 1, '2018-03-06', NULL),
		(18, 1, '2018-05-13', NULL),
		(19, 1, '2018-06-16', NULL),
		(20, 1, '2018-03-15', NULL),
		(21, 2, '2018-02-22', NULL),
		(22, 2, '2018-03-06', NULL),
		(23, 2, '2018-05-13', NULL),
		(24, 2, '2018-06-16', NULL),
		(25, 4, '2018-03-15', NULL),
		(26, 4, '2018-02-22', NULL),
		(27, 3, '2018-05-06', NULL),
		(28, 3, '2018-06-13', NULL);
		

insert into MedicalExamination(IdEmployee, Date)
	values 
		(8, '2018-05-06'),
		(2, '2018-07-04'),
		(3, '2018-06-16'),
		(4, '2018-04-16'),
		(5, '2018-04-16'),
		(6, '2018-05-06'),
		(7, '2018-07-04'),
		(9, '2018-06-16'),
		(10, '2018-04-16'),
		(11, '2018-04-16'),
		(21, '2018-05-06'),
		(12, '2018-07-04'),
		(13, '2018-06-16'),
		(14, '2018-04-16'),
		(15, '2018-04-16'),
		(16, '2018-05-06'),
		(17, '2018-07-04'),
		(18, '2018-06-16'),
		(19, '2018-04-16'),
		(20, '2018-04-16');

insert into EducationLevel(EducationLevel, Degree, DegreeShort)
	values 
		('Podstawowe', Null, null),
		('Gimnazjalne', Null, null),
		('Ponadgimnazjalne', Null, null),
		('Średnie', Null, null),
		('Policealne', Null, null),
		('Studium', Null, null),
		('Wyższe I stopnia techniczne', 'inżynier', 'inż'),
		('Wyższe I stopnia', 'licencjat', null);

insert into Training(IdEmployee, TrainingName, TrainingStartDate, TrainingEndDate, TrainingPrice)
	values 
		(2, 'Szkolenie kierownicze', '2020-01-05', '2020-01-05', 1000),
		(3, 'Szkolenie kierownicze', '2020-01-05', '2020-01-05', 1000),
		(4, 'Szkolenie kierownicze', '2020-01-05', '2020-01-05', 1000),
		(5, 'Szkolenie kierownicze', '2020-01-05', '2020-01-05', 1000),
		(6, 'Szkolenie kierownicze', '2020-01-05', '2020-01-05', 1000);
		

insert into Education(IdEmployee, IdEducationLevel, GraduationDate)
	values
		(1, 5, '2009-06-10'), 
		(2, 6, '2010-06-21'), 
		(3, 4, '2012-06-22'), 
		(4, 3, '2009-06-23'), 
		(5, 2, '2001-06-24');

--Quality control

--Accident
insert into Accident (IdEmployee, AccidentDate, AccidentDescription) values
		(1, '2019-01-07 09:30:00', 'Skaleczenie dłoni arkuszem blachy'),
		(2, '2019-02-01 10:15:00', 'Potknięcie o niezabezpieczony kabel, uraz kostki'),
		(3, '2019-03-11 11:25:00', 'Skaleczenie dłoni podczas rozwijania blachy'),
		(4, '2019-03-12 13:35:00', 'Uraz ręki na skutek włożenia jej do maszyny'),
		(5, '2019-04-01 10:50:00', 'Spadek rolki blachy z uszkodzonej półki magazynowej');


--FEMAnalysis
insert into FEMAnalysis (IdEmployee, NewPattern, AnalysisResults) values
		(2, ' ', 'Wzór nr 1, odporny na duże naciski, idealny na górskie dachy'),
		(2, ' ', 'Wzór nr 2, nowatorskie tłoczenia'),
		(2, ' ', 'Wzór nr 3, test blachy od nowego producenta'),
		(2, ' ', 'Wzór nr 4, wersja ekonomiczna dla lekkiej więźby'),
		(2, ' ', 'Wzór nr 5, dla montażu o najmniejszym odpadzie');

/*Insert Into FEMAnalysis (IdEmployee, NewPattern, AnalysisResults)
Select '2', BulkColumn, 'Wz�r nr 1, odporny na du�e naciski, idealny na g�rskie dachy'
from Openrowset (Bulk 'C:\Users\Milenka\Documents\SQL Server Management Studio\1.jpg', Single_Blob) as Image;
Insert Into FEMAnalysis (IdEmployee, NewPattern, AnalysisResults)
Select , '2', BulkColumn, 'Wz�r nr 2, nowatorskie t�oczenia'
from Openrowset (Bulk 'C:\Users\Milenka\Documents\SQL Server Management Studio\2.jpg', Single_Blob) as Image;
Insert Into FEMAnalysis (IdEmployee, NewPattern, AnalysisResults)
Select '2', BulkColumn, 'Wz�r nr 3, test blachy od nowego producenta'
from Openrowset (Bulk 'C:\Users\Milenka\Documents\SQL Server Management Studio\3.jpg', Single_Blob) as Image;
Insert Into FEMAnalysis (IdEmployee, NewPattern, AnalysisResults)
Select '2', BulkColumn, 'Wz�r nr 4, wersja ekonomiczna dla lekkiej wi�by'
from Openrowset (Bulk 'C:\Users\Milenka\Documents\SQL Server Management Studio\4.jpg', Single_Blob) as Image;
Insert Into FEMAnalysis (IdEmployee, NewPattern, AnalysisResults)
Select '2', BulkColumn, 'Wz�r nr 5, dla monta�u o najmniejszym odpadzie'
from Openrowset (Bulk 'C:\Users\Milenka\Documents\SQL Server Management Studio\5.jpg', Single_Blob) as Image;*/


--SafetyControl
insert into SafetyControl (IdSafetyEmployee, IdInspectedEmployee, SaftyControlDate, SafetyControlDescription, CompanyName) values
		('Dąbek Jarosław 423452', 1, '2019-01-07 10:20:00', 'środki ochrony indywidualnej, pozytywnie', 'TBF'),
		('Dąbek Jarosław 423452', 2, '2019-01-07 10:30:00', 'środki ochrony indywidualnej, pozytywnie', 'TBF'),
		('Dąbek Jarosław 423452', 3, '2019-01-07 10:40:00', 'środki ochrony indywidualnej, pozytywnie', 'TBF'),
		('Dąbek Jarosław 423452', 4, '2019-01-07 10:50:00', 'środki ochrony indywidualnej, pozytywnie', 'TBF'),
		('Dąbek Jarosław 423452', 5, '2019-01-07 11:00:00', 'środki ochrony indywidualnej, pozytywnie', 'TBF');

--SafetyTraining
insert into SafetyTraining (IdEmployee, TrainingDate) values
		(1, '2019-01-02 08:00:00'),
		(2, '2019-01-02 08:00:00'),
		(3, '2019-01-02 08:00:00'),
		(4, '2019-01-02 08:00:00'),
		(5, '2019-01-02 08:00:00');

--SemiFinished
/*grubo�ci blachy u Pruszy�skiego: 0,5; 0,7, 1; 1,25
kolory G - grafit, C - ceg�a, W - wi�nia, B - br�z, X - czer�
po # numer rolki
jednostki: mm, kg
przyk�adowa rolka https://sprzedajemy.pl/blacha-aluminiowa-0-7-mm-konstancin-jeziorna-2-a1d299-nr58670589*/
insert into SemiFinished (SfCode, Thickness, Width, SfWeight, Color, ChemicalComposition) values
		('C05#1', 0.5, 1000, 580, 'cegła', 'C, Fe, Ni, Cr'),
		('G05#1', 0.5, 1000, 580, 'grafit', 'C, Fe, Ni, Cr'),
		('C07#1', 0.7, 1000, 750, 'cegła', 'C, Fe, Ni, Cr'),
		('W10#1', 1.0, 1000, 950, 'wiśnia', 'C, Fe, Ni, Cr'),
		('B125#1', 1.25, 1000, 1400, 'brąz', 'C, Fe, Ni, Cr');

insert into Technology(TechnologyName, TimePermeter, SpeedFactor)
	Values
		('Trapez maly', 3, 0.9),
		('Trapez duzy', 2, 0.8),
		('Plaski', 5, 1),
		('Dachowka', 3, 1),
		('Falisty', 2.5, 1);


		--Product
/*TD - trapez du�y, TM - trapez ma�y P - p�aski, D - dach�wka, F - falisty*/
insert into Product (IdSemiFinished, ProductCode, IdTechnology, InputDate,InProduction) values
		(1, 'C05#1D', 4, '2019-01-07 10:30:00',1),
		(2, 'G05#1D', 4, '2019-01-07 10:40:00',1),
		(3, 'C07#1D', 4, '2019-01-07 10:50:00',0),
		(4, 'W10#1D', 4, '2019-01-07 11:00:00',1),
		(5, 'B125#1D', 4, '2019-01-07 11:10:00',1);
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

insert into Unit values ('Szt');
insert into Unit values ('Litr');
insert into Unit values ('Metr');
insert into Unit values ('Kilogram');

insert into MachineType values ('Żłobiarka');
insert into MachineType values ('Walcarka');
insert into MachineType values ('Profilarka');
insert into MachineType values ('Zaginarka');
insert into MachineType values ('Gilotyna');


insert into Machine values (4, 'ZDR', 'Dachdecker', 2017, '2', '7m2', '87WF', 360);
insert into Machine values (5, 'ZRA', 'Dachdecker', 2015, '5', NULL, '10DW', 80);
insert into Machine values (4, 'SEG-L', 'Dachdecker', 2016, '3', '8m2', '9EF2', 400);
insert into Machine values (2, 'ZRC', 'Dachdecker', 2018, '4', NULL, 'P12D', 200);
insert into Machine values (1, 'ZRA', 'Dachdecker', 2014, '3', NULL, 'E21M', 100);

insert into SkillsForMachine(IdMachine, IdPosition)
	values
		(1, 3),
		(2, 3),
		(3, 3),
		(4, 3),
		(5, 3);
 
insert into MaintType values ('Awaria');
insert into MaintType values ('Przegląd');
insert into MaintType values ('Konserwacja');

insert into MaintDescription values ('Smarowanie łańcucha', null, 0.25);
insert into MaintDescription values ('Wymiana łożysk', null, 6);
insert into MaintDescription values ('Regulacja luzu napinacza', null, 1);
insert into MaintDescription values ('Pomiar zużycia kół zębatych', null, 2);
insert into MaintDescription values ('Wymiana pasa napędowego', null, 0.25);

insert into PartType values ('Łożysko');
insert into PartType values ('Pasek');
insert into PartType values ('Koło zębate');
insert into PartType values ('Smar');
insert into PartType values ('Łańcuch');

insert into Part values (1, 1, 'Łożysko kulkowe', 'SKF', 6305, 10);
insert into Part values (3, 1, 'Koło zębate M5', 'Tente', 516, 3);
insert into Part values (4, 4, 'Smar maszynowy', 'CX80', 43681554, 2);
insert into Part values (5, 3, 'Łańcuch krzyżakowy', 'Kort', 5735, 5);
insert into Part values (2, 3, 'Pasek zębaty', 'Oscar', 450, 12);

insert into Maintenance values (2, 2, 3, '2019-03-07 09:43:21 AM', '2019-03-08 10:34:09 AM', '2019-03-08 02:25:53 PM', '8753T78B');
insert into Maintenance values (4, 1, 2, '2019-03-11 08:23:32 AM', '2019-03-11 09:14:09 AM', '2019-03-11 11:45:13 AM', '8912YEY9');
insert into Maintenance values (1, 3, 1, '2019-03-12 08:00:42 AM', '2019-03-12 08:36:59 AM', '2019-03-12 09:10:14 AM', 'P13I1NE1');
insert into Maintenance values (5, 2, 3, '2019-03-13 12:15:54 PM', '2019-03-13 12:20:42 PM', '2019-03-13 12:40:32 PM', 'J4K1EHU1');
insert into Maintenance values (3, 2, 4, '2019-04-10 08:33:21 AM', '2019-05-20 08:12:47 AM', '2019-05-20 10:53:40 AM', 'T0D3B1L3');

insert into MaintPart values (1, 5, 2);
insert into MaintPart values (2, 1, 4);
insert into MaintPart values (3, 3, 1);
insert into MaintPart values (4, 5, 3);
insert into MaintPart values (5, 2, 1);

insert into PartRequest values (2, 5, 0, '2019-04-07 12:12:47 AM');
insert into PartRequest values (3, 10, 0, '2019-04-08 08:42:27 AM');
insert into PartRequest values (5, 25, 0, '2019-04-08 10:25:45 AM');
insert into PartRequest values (1, 8, 0, '2019-04-09 09:10:26 AM');
insert into PartRequest values (4, 20, 0, '2019-04-10 11:31:24 AM');

insert into PartOrder values (1, '2019-04-07 12:32:42 PM', 0, 50);
insert into PartOrder values (2, '2019-04-08 08:55:10 AM', 0, 125);
insert into PartOrder values (3, '2019-04-08 11:40:15 AM', 0, 30);
insert into PartOrder values (4, '2019-04-09 09:26:53 AM', 0, 47);
insert into PartOrder values (5, '2019-04-10 12:05:25 PM', 0, 215);

insert into PartOrderRequest values (1, 1);
insert into PartOrderRequest values (2, 2);
insert into PartOrderRequest values (3, 3);
insert into PartOrderRequest values (4, 4);
insert into PartOrderRequest values (5, 5);

insert into PartOrderDetail values (1, 1, 5);
insert into PartOrderDetail values (2, 2, 20);
insert into PartOrderDetail values (3, 3, 13);
insert into PartOrderDetail values (4, 4, 100);
insert into PartOrderDetail values (5, 5, 32);

insert into Realization values (1, 1, '2019-03-08 10:34:09 AM', '2019-03-08 02:25:53 PM');
insert into Realization values (1, 2, '2019-03-08 10:34:09 AM', '2019-03-08 02:25:53 PM');
insert into Realization values (2, 3, '2019-03-11 09:14:09 AM', '2019-03-11 11:45:13 AM');
insert into Realization values (2, 1, '2019-03-11 09:14:09 AM', '2019-03-11 11:45:13 AM');
insert into Realization values (3, 2, '2019-03-12 08:36:59 AM', '2019-03-12 09:10:14 AM');

insert into EmployeePlan values (1, 1, '2019-03-08 10:34:09 AM', '2019-03-08 02:25:53 PM');
insert into EmployeePlan values (1, 2, '2019-03-08 10:34:09 AM', '2019-03-08 02:25:53 PM');
insert into EmployeePlan values (2, 3, '2019-03-11 09:14:09 AM', '2019-03-11 11:45:13 AM');
insert into EmployeePlan values (2, 1, '2019-03-11 09:14:09 AM', '2019-03-11 11:45:13 AM');
insert into EmployeePlan values (3, 2, '2019-03-12 08:36:59 AM', '2019-03-12 09:10:14 AM');


--SD
insert into Customer values('AndrzejBlach Sp. z o.o.', '606842134', 'AnBlach@gmail.com', 'Kraków',
'12-852', 'Wolnosci', '6', '', '', '1021256487', '974131497', ' ');
insert into Customer values('BlachPOL Sp. z o.o.', '504897425', 'BPPL@gmail.com', 'Bytom',
'97-234', 'Sosnowa', '7', '16', '', '1023259852', '134863918', '');
insert into Customer values('BlachLAND Sp. akcyjna', '506487412', 'blachland@wp.pl', 'Kielce',
'41-262', 'Świerkowa', '9', '26', '', '2012549782', '654316487', '');
insert into Customer values('Zdzisław Kręcinai', '602352148', 'zdzisiek58@gmail.com', 'Sosnowiec',
'62-234', 'Pusta', '2', '', '1021112065', ' ', '', 'Ważny klient');
insert into Customer values('Krzysztof Kononowicz', '605987412', 'konon@pocztaonet.pl', 'Białystok',
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
insert into OrderDetail values('5', '3', '800');
insert into OrderDetail values('6', '1', '400');
insert into OrderDetail values('6', '2', '900');
insert into OrderDetail values('7', '2', '1200');
insert into OrderDetail values('3', '1', '200');
insert into OrderDetail values('2', '4', '400');
insert into OrderDetail values('4', '3', '500');

insert into SupplierType values('Półfabrykaty');
insert into SupplierType values('Części');

insert into Supplier values('1', 'BlachoSprzedawca s.a.', '604215468', 'BlachoSprzedawca@wp.pl', 'Żyrardów',
'05-813', 'Długa', '11', '', '1023254186','56168496', '');
insert into Supplier values('1', 'Urimarex s.a.', '616201425', 'unimarex@gmail.com', 'Warszawa',
'02-111', 'Puławska', '98', '2', '1203256475','61543244', ' ');
insert into Supplier values('1', 'BlachMAN s.j.', '807412345', 'BlachMAN@pocztaonet.pl', 'Gdańsk',
'11-025', 'Morska', '2', '', '1023256412','7564231', '');
insert into Supplier values('2', 'RoboMAN s.j.', '978085413', 'RoboMAN@gmail.com', 'Płońsk',
'07-514', 'Sroga', '34', '11', '1202325142','2483213', '');
insert into Supplier values('2', 'Vortex s.j.', '504123520', 'Vortex@gmail.com', 'Katowice',
'02-134', 'Południowa', '214', '', '1102012584','123135468', '');

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
insert into EntranceControl (IdSfDetail, IdEmployee, ControlDate, ControlStatus, Comments, Quantity, RealThickness, RealWidth, RealWeight, RealColor, ChemicalComposition) values
		(1, 1, '2019-01-02 08:03:36', 1, 'Rozerwana folia ochronna', 2, 1, 1, 500, 'czerwony', 1),
		(2, 1, '2019-01-02 08:07:36', 1, 'Brak wad', 1, 1, 1, 500, 'czerwony', 1),
		(3, 1, '2019-01-02 08:13:36', 1, 'Brak wad', 3, 1, 1, 500, 'czerwony', 1),
		(4, 1, '2019-01-02 08:20:36', 1, 'Brak wad', 1, 1, 1, 500, 'czerwony', 1),
		(6, 1, '2019-01-02 08:25:36', 0, 'Zły kolor', 2, 1, 1, 500, 'czerwony', 1);

insert into OutsourcingType values('Gosp. odpadami');
insert into OutsourcingType values('Transport do klienta');
insert into OutsourcingType values('Reklama');

insert into Outsourcing values('1', 'Śmieciorex s.a.', '807412621', 'Śmieciorex@gmail.com', 'Poznań',
'02-144', 'Brudna', '123', '321', '7452145876','32165498', '');
insert into Outsourcing values('2', 'TirPower s.a.', '604215120', 'TirPower@gmail.com', 'Gdynia',
'04-741', 'Daleka', '84', '', '1202325489','10231512', '');
insert into Outsourcing values('3', 'Reda SA s.a.', '908741521', 'CleanHouse@gmail.com', 'Zamość',
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
	(1, 2, '2019-07-31','2019-02-15','0'),
	(2, 2, '2019-07-31','2019-03-30','0'),
	(3, 1, '2019-07-31','2019-03-30','1'),
	(4, 1, '2019-07-31','2019-04-30','1'),
	(5, 3, '2019-07-31','2019-05-30','1'),
	(6, 3, '2019-08-15','2019-09-15','0'),
	(7, 2, '2019-08-15','2019-09-10','0'),
	(8, 4, '2019-08-15','2019-09-20','1'),
	(9, 1, '2019-08-15','2019-09-25','1'),
	(10, 3, '2019-08-15','2019-09-30','1');

insert into PlannedProductionEmployeeDetails (IdProces, IdEmployee, StartDate, EndDate)
 values
	(1,1, '2019-01-27', '2019-02-15'),
	(2,2, '2019-02-15', '2019-03-27'),
	(3,3, '2019-03-27', '2019-04-27'),
	(4,4, '2019-04-27', '2019-05-27'),
	(5,5, '2019-05-27', '2019-06-27'),
	(6,5, '2019-08-15', '2019-09-15'),
	(7,2, '2019-08-15', '2019-09-10'),
	(8,2, '2019-08-15', '2019-09-20'),
	(9,4, '2019-08-15', '2019-09-25'),
	(10,1, '2019-08-15','2019-09-30');

 insert into ProductionProcess(IdPlan, StartDate, EndDate)
 values  
	(1, '2019-03-23','2019-04-23'),
	(2, '2019-04-23','2019-05-23'),
	(3, '2019-05-23','2019-06-23'),
	(4, '2019-06-23','2019-07-23'),
	(5, '2019-08-23','2019-09-23'),
	(6, '2019-09-20', '2019-09-15'),
	(7, '2019-09-05', '2019-09-10'),
	(8, '2019-09-15', '2019-09-20'),
	(9, '2019-09-20', '2019-09-25'),
	(10, '2019-09-25','2019-09-30');

 insert into Failure(IdProces, Specification, FailureDate)
 values 
	(1,'wybuchło','2019-02-23'),
	(2,'pali się','2019-03-23'),
	(3,'stuka','2019-04-23'),
	(4,'ale urwał','2019-05-23'),
	(5,'nie dziala','2019-06-23');

insert into FailureMaintenance values (1, 2);

insert into OutControl (IdProcess, IdEmployee, StartControlDate, EndControlDate, WidthAcceptableDeviation, LenghtAcceptableDeviation)
values
	('1', '3', '2019-01-02', '2019-01-02', '2.2','2.3'),
	('2', '3', '2019-02-01', '2019-02-12', '1.2','1.3'),
	('3', '3', '2019-02-03', '2019-02-03', '1.2','1.3'),
	('4', '3', '2019-02-13', '2019-03-13', '1.2','1.4'),
	('5', '3', '2019-02-15', '2019-02-15', '1.2','1.3');
	
	/*('6', '3', '2019-03-02', '2019-03-02', '1.3','1.2'),
	('7', '3', '2019-03-02', '2019-03-15', '1.2','1.3'),
	('8', '3', '2019-03-03', '2019-03-03', '1.2','1.3'),
	('9', '3', '2019-03-06', '2019-03-06', '1.2','1.3'),
	('10', '3', '2019-03-08', '2019-03-08', '1.2','1.3');*/

insert into OutputProductMeasurements(IdMeasurement, IdProcess, MeasuredLenght, MeasuredWidth)
values
	('1', '1', '4941.97', '795.96'),
	('2', '1', '5012.61', '802.36'),
	('3', '1', '4982.76', '804.22'),
	('4', '1', '4941.90', '806.25'),
	('5', '1', '4941.45', '799.16'),
	('6', '1', '4986.32', '811.98'),
	('7', '1', '5051.11', '793.39'),
	('8', '1', '5094.12', '808.26'),
	('9', '1', '5002.77', '814.69'),
	('10', '1', '5016.18', '807.23'),
	('11', '1', '5104.41', '794.16'),
	('12', '1', '4961.59', '798.28'),
	('13', '1', '5092.71', '791.99'),
	('14', '1', '5091.14', '803.42'),
	('15', '1', '5065.69', '816.23'),
	('16', '1', '5091.62', '812.43'),
	('17', '1', '5085.67', '803.76'),
	('18', '1', '5058.13', '804.91'),
	('19', '1', '4966.28', '814.65'),
	('20', '1', '5018.04', '793.53'),
	('21', '1', '5078.21', '800.53'),
	('22', '1', '5103.89', '816.91'),
	('23', '1', '5100.74', '805.18'),
	('24', '1', '5041.10', '812.19'),
	('25', '1', '4987.47', '808.59'),
	('26', '1', '5008.67', '811.29'),
	('27', '1', '5068.32', '815.12'),
	('28', '1', '4950.07', '816.99'),
	('29', '1', '5057.11', '815.13'),
	('30', '1', '5047.78', '806.34'),
	('31', '1', '4960.98', '791.63'),
	('32', '1', '4992.15', '796.49'),
	('33', '1', '5079.27', '806.66'),
	('34', '1', '4967.89', '800.36'),
	('35', '1', '4997.69', '791.56'),
	('36', '1', '5093.02', '806.16'),
	('37', '1', '5049.79', '807.04'),
	('38', '1', '5061.09', '802.95'),
	('39', '1', '4969.75', '805.32'),
	('40', '1', '5090.70', '810.23'),
	('41', '1', '5055.13', '816.63'),
	('42', '1', '4995.19', '814.50'),
	('43', '1', '4971.66', '810.48'),
	('44', '1', '5068.40', '805.71'),
	('45', '1', '5091.48', '790.76'),
	('46', '1', '4949.04', '799.46'),
	('47', '1', '5030.83', '793.48'),
	('48', '1', '5048.40', '804.01'),
	('49', '1', '5049.47', '790.24'),
	('50', '1', '4988.66', '807.00'),
	('51', '1', '5043.00', '817.59'),
	('52', '1', '4956.59', '814.39'),
	('53', '1', '5031.66', '793.37'),
	('54', '1', '4977.35', '793.12'),
	('55', '1', '4966.36', '805.90'),
	('56', '1', '5050.84', '792.88'),
	('57', '1', '4983.39', '795.85'),
	('58', '1', '5029.69', '799.12'),
	('59', '1', '4962.42', '793.49'),
	('60', '1', '5064.13', '805.84'),
	('61', '1', '5061.66', '800.52'),
	('62', '1', '5094.55', '812.19'),
	('63', '1', '5033.60', '813.94'),
	('64', '1', '5048.55', '791.29'),
	('65', '1', '5041.78', '797.07'),
	('66', '1', '5106.21', '799.63'),
	('67', '1', '4996.87', '815.68'),
	('68', '1', '4974.87', '798.82'),
	('69', '1', '5020.62', '794.12'),
	('70', '1', '5098.39', '791.03'),
	('71', '1', '5030.66', '792.52'),
	('72', '1', '5023.99', '805.01'),
	('73', '1', '4980.56', '791.35'),
	('74', '1', '4948.28', '798.24'),
	('75', '1', '5076.00', '811.76'),
	('76', '1', '5095.73', '807.78'),
	('77', '1', '5053.69', '815.76'),
	('78', '1', '5032.65', '793.72'),
	('79', '1', '5099.25', '794.05'),
	('80', '1', '4993.36', '807.38'),
	('81', '1', '5060.13', '808.33'),
	('82', '1', '4960.51', '801.14'),
	('83', '1', '5010.76', '794.17'),
	('84', '1', '4948.86', '814.76'),
	('85', '1', '5108.50', '805.68'),
	('86', '1', '4988.02', '814.12'),
	('87', '1', '5028.63', '800.96'),
	('88', '1', '5008.35', '809.39'),
	('89', '1', '4955.47', '790.71'),
	('90', '1', '5063.92', '799.60'),
	('91', '1', '5010.24', '805.16'),
	('92', '1', '5007.60', '805.42'),
	('93', '1', '4943.74', '815.50'),
	('94', '1', '5106.01', '806.15'),
	('95', '1', '5079.71', '801.76'),
	('96', '1', '5075.15', '816.26'),
	('97', '1', '4951.60', '801.65'),
	('98', '1', '4953.18', '795.16'),
	('99', '1', '4977.38', '814.90'),
	('100', '1', '4996.76', '755.03'),
	('101', '1', '4993.76', '797.03');

UPDATE OrderCustomer
SET Cost = (TechnicalProductData.PricePerMeter*OrderDetail.Quantity*(1+OrderCustomer.Markup/100))
FROM OrderDetail
JOIN OrderCustomer
ON OrderCustomer.IdOrderCustomer = OrderDetail.IdOrderCustomer
JOIN TechnicalProductData
ON TechnicalProductData.IdProduct = OrderDetail.IdProduct
JOIN Customer
ON OrderCustomer.IdCustomer = Customer.IdCustomer