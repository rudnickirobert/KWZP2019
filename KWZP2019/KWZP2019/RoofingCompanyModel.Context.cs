﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2019
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RoofingCompanyEntities : DbContext
    {
        public RoofingCompanyEntities()
            : base("name=RoofingCompanyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Absence> Absences { get; set; }
        public virtual DbSet<AbsenceType> AbsenceTypes { get; set; }
        public virtual DbSet<Accident> Accidents { get; set; }
        public virtual DbSet<Allocation> Allocations { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Contractor> Contractors { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<EducationLevel> EducationLevels { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeePlan> EmployeePlans { get; set; }
        public virtual DbSet<EntranceControl> EntranceControls { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<Failure> Failures { get; set; }
        public virtual DbSet<FailureMaintenance> FailureMaintenances { get; set; }
        public virtual DbSet<FEMAnalysi> FEMAnalysis { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceType> InvoiceTypes { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<MachineType> MachineTypes { get; set; }
        public virtual DbSet<MaintDescription> MaintDescriptions { get; set; }
        public virtual DbSet<Maintenance> Maintenances { get; set; }
        public virtual DbSet<MaintPart> MaintParts { get; set; }
        public virtual DbSet<MaintType> MaintTypes { get; set; }
        public virtual DbSet<MedicalExamination> MedicalExaminations { get; set; }
        public virtual DbSet<OrderCustomer> OrderCustomers { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OutControl> OutControls { get; set; }
        public virtual DbSet<OutputProductMeasurement> OutputProductMeasurements { get; set; }
        public virtual DbSet<Outsourcing> Outsourcings { get; set; }
        public virtual DbSet<OutsourcingCommitment> OutsourcingCommitments { get; set; }
        public virtual DbSet<OutsourcingType> OutsourcingTypes { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<PartOrder> PartOrders { get; set; }
        public virtual DbSet<PartOrderDetail> PartOrderDetails { get; set; }
        public virtual DbSet<PartOrderRequest> PartOrderRequests { get; set; }
        public virtual DbSet<PartRequest> PartRequests { get; set; }
        public virtual DbSet<PartType> PartTypes { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PlannedProduction> PlannedProductions { get; set; }
        public virtual DbSet<PlannedProductionEmployeeDetail> PlannedProductionEmployeeDetails { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductionProcess> ProductionProcesses { get; set; }
        public virtual DbSet<Realization> Realizations { get; set; }
        public virtual DbSet<SafetyControl> SafetyControls { get; set; }
        public virtual DbSet<SafetyTraining> SafetyTrainings { get; set; }
        public virtual DbSet<SemiFinished> SemiFinisheds { get; set; }
        public virtual DbSet<SemiFinishedOrder> SemiFinishedOrders { get; set; }
        public virtual DbSet<SfOrderDetail> SfOrderDetails { get; set; }
        public virtual DbSet<SkillsForMachine> SkillsForMachines { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplierType> SupplierTypes { get; set; }
        public virtual DbSet<TechnicalProductData> TechnicalProductDatas { get; set; }
        public virtual DbSet<Technology> Technologies { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<SafetyControlHistoryView> SafetyControlHistoryViews { get; set; }
        public virtual DbSet<vAbsence> vAbsences { get; set; }
        public virtual DbSet<vAbsenceType> vAbsenceTypes { get; set; }
        public virtual DbSet<vAddTraining> vAddTrainings { get; set; }
        public virtual DbSet<vComboBoxEmployee> vComboBoxEmployees { get; set; }
        public virtual DbSet<vComboBoxMachine> vComboBoxMachines { get; set; }
        public virtual DbSet<vContract> vContracts { get; set; }
        public virtual DbSet<vCustomer> vCustomers { get; set; }
        public virtual DbSet<vDeparment> vDeparments { get; set; }
        public virtual DbSet<vDevotionsInMeasuremntsPerProcess> vDevotionsInMeasuremntsPerProcesses { get; set; }
        public virtual DbSet<vEducationForm> vEducationForms { get; set; }
        public virtual DbSet<vEducationLevel> vEducationLevels { get; set; }
        public virtual DbSet<vEmployeeDetail> vEmployeeDetails { get; set; }
        public virtual DbSet<vEmployeeList> vEmployeeLists { get; set; }
        public virtual DbSet<vEmployeeSD> vEmployeeSDs { get; set; }
        public virtual DbSet<vExamination> vExaminations { get; set; }
        public virtual DbSet<vExpencePartOrder> vExpencePartOrders { get; set; }
        public virtual DbSet<vExpencesInvoice> vExpencesInvoices { get; set; }
        public virtual DbSet<vExpencesOrder> vExpencesOrders { get; set; }
        public virtual DbSet<vExpencesOutsourcing> vExpencesOutsourcings { get; set; }
        public virtual DbSet<vExpencesPayment> vExpencesPayments { get; set; }
        public virtual DbSet<vHR> vHRs { get; set; }
        public virtual DbSet<vHRContract> vHRContracts { get; set; }
        public virtual DbSet<vHRExamination> vHRExaminations { get; set; }
        public virtual DbSet<ViewDailySfDelivery> ViewDailySfDeliveries { get; set; }
        public virtual DbSet<ViewOshTraining> ViewOshTrainings { get; set; }
        public virtual DbSet<vIncomesProfit> vIncomesProfits { get; set; }
        public virtual DbSet<vInputMagazine> vInputMagazines { get; set; }
        public virtual DbSet<vInvoiceType> vInvoiceTypes { get; set; }
        public virtual DbSet<vMaintPartsView> vMaintPartsViews { get; set; }
        public virtual DbSet<vOrder> vOrders { get; set; }
        public virtual DbSet<vOrderDetail> vOrderDetails { get; set; }
        public virtual DbSet<vOutputMagazine> vOutputMagazines { get; set; }
        public virtual DbSet<vOutsourcingWithType> vOutsourcingWithTypes { get; set; }
        public virtual DbSet<vPartsView> vPartsViews { get; set; }
        public virtual DbSet<vPaymentHistory> vPaymentHistories { get; set; }
        public virtual DbSet<vPosition> vPositions { get; set; }
        public virtual DbSet<vPositionExaminationValidity> vPositionExaminationValidities { get; set; }
        public virtual DbSet<vPredictedPriceForCustomer> vPredictedPriceForCustomers { get; set; }
        public virtual DbSet<vProductionProcessFullData> vProductionProcessFullDatas { get; set; }
        public virtual DbSet<vSafetyControlHistoryView> vSafetyControlHistoryViews { get; set; }
        public virtual DbSet<vSalariesSummary> vSalariesSummaries { get; set; }
        public virtual DbSet<vSuccesfullyProcess> vSuccesfullyProcesses { get; set; }
        public virtual DbSet<vSuccesfullyProducedPerProcess> vSuccesfullyProducedPerProcesses { get; set; }
        public virtual DbSet<vSupplierPart> vSupplierParts { get; set; }
        public virtual DbSet<vSupplierSemi> vSupplierSemis { get; set; }
        public virtual DbSet<vTechnicalProductDataPerProcess> vTechnicalProductDataPerProcesses { get; set; }
        public virtual DbSet<vUnfinishedProcess> vUnfinishedProcesses { get; set; }
        public virtual DbSet<vUnhandledOrderDetail> vUnhandledOrderDetails { get; set; }
    }
}
