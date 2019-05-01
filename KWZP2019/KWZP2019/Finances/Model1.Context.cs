﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2019.Finances
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RoofingCompanyEntities1 : DbContext
    {
        public RoofingCompanyEntities1()
            : base("name=RoofingCompanyEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Absence> Absence { get; set; }
        public virtual DbSet<AbsenceType> AbsenceType { get; set; }
        public virtual DbSet<Accident> Accident { get; set; }
        public virtual DbSet<Allocation> Allocation { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Contractor> Contractor { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<EducationLevel> EducationLevel { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeePlan> EmployeePlan { get; set; }
        public virtual DbSet<EntranceControl> EntranceControl { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<Failure> Failure { get; set; }
        public virtual DbSet<FailureMaintenance> FailureMaintenance { get; set; }
        public virtual DbSet<FEMAnalysis> FEMAnalysis { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceType> InvoiceType { get; set; }
        public virtual DbSet<Machine> Machine { get; set; }
        public virtual DbSet<MachineType> MachineType { get; set; }
        public virtual DbSet<MaintDescription> MaintDescription { get; set; }
        public virtual DbSet<Maintenance> Maintenance { get; set; }
        public virtual DbSet<MaintPart> MaintPart { get; set; }
        public virtual DbSet<MaintType> MaintType { get; set; }
        public virtual DbSet<MedicalExamination> MedicalExamination { get; set; }
        public virtual DbSet<OrderCustomer> OrderCustomer { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<OutControl> OutControl { get; set; }
        public virtual DbSet<Outsourcing> Outsourcing { get; set; }
        public virtual DbSet<OutsourcingCommitment> OutsourcingCommitment { get; set; }
        public virtual DbSet<OutsourcingType> OutsourcingType { get; set; }
        public virtual DbSet<Part> Part { get; set; }
        public virtual DbSet<PartOrder> PartOrder { get; set; }
        public virtual DbSet<PartOrderDetail> PartOrderDetail { get; set; }
        public virtual DbSet<PartOrderRequest> PartOrderRequest { get; set; }
        public virtual DbSet<PartRequest> PartRequest { get; set; }
        public virtual DbSet<PartType> PartType { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PlannedProduction> PlannedProduction { get; set; }
        public virtual DbSet<PlannedProductionEmployeeDetails> PlannedProductionEmployeeDetails { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductionProces> ProductionProces { get; set; }
        public virtual DbSet<Realization> Realization { get; set; }
        public virtual DbSet<SafetyControl> SafetyControl { get; set; }
        public virtual DbSet<SafetyTraining> SafetyTraining { get; set; }
        public virtual DbSet<SemiFinished> SemiFinished { get; set; }
        public virtual DbSet<SemiFinishedOrder> SemiFinishedOrder { get; set; }
        public virtual DbSet<SfOrderDetail> SfOrderDetail { get; set; }
        public virtual DbSet<SkillsForMachine> SkillsForMachine { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierType> SupplierType { get; set; }
        public virtual DbSet<TechnicalProductData> TechnicalProductData { get; set; }
        public virtual DbSet<Technology> Technology { get; set; }
        public virtual DbSet<Training> Training { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
    }
}