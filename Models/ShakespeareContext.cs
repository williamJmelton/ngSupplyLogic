using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Globalization;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using ngSupplyLogic.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ngSupplyLogic.Models
{
    public partial class ShakespeareContext : DbContext
    {
        public ShakespeareContext()
        {
        }

        public ShakespeareContext(DbContextOptions<ShakespeareContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AradjustmentReason> AradjustmentReason { get; set; }
        public virtual DbSet<ArtransAppliedTo> ArtransAppliedTo { get; set; }
        public virtual DbSet<Artransaction> Artransaction { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<BuyingAllowance> BuyingAllowance { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<ComboItemComponent> ComboItemComponent { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanySalesOrderMessage> CompanySalesOrderMessage { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<CreditReason> CreditReason { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerAr> CustomerAr { get; set; }
        public virtual DbSet<CustomerItemPricing> CustomerItemPricing { get; set; }
        public virtual DbSet<CustomerSalesOrderMessage> CustomerSalesOrderMessage { get; set; }
        public virtual DbSet<DailyMovementItem> DailyMovementItem { get; set; }
        public virtual DbSet<DeliveryRoute> DeliveryRoute { get; set; }
        public virtual DbSet<DeliveryRouteStop> DeliveryRouteStop { get; set; }
        public virtual DbSet<InvBatch> InvBatch { get; set; }
        public virtual DbSet<InvBatchDetail> InvBatchDetail { get; set; }
        public virtual DbSet<InvTranReason> InvTranReason { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ItemAuth> ItemAuth { get; set; }
        public virtual DbSet<ItemCosting> ItemCosting { get; set; }
        public virtual DbSet<ItemInventoryLocation> ItemInventoryLocation { get; set; }
        public virtual DbSet<ItemInventoryOnHand> ItemInventoryOnHand { get; set; }
        public virtual DbSet<ItemInventoryPurchased> ItemInventoryPurchased { get; set; }
        public virtual DbSet<ItemInventorySold> ItemInventorySold { get; set; }
        public virtual DbSet<ItemInventoryTrans> ItemInventoryTrans { get; set; }
        public virtual DbSet<ItemTempTrans> ItemTempTrans { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<ManufacturerReporting> ManufacturerReporting { get; set; }
        public virtual DbSet<MenuFunction> MenuFunction { get; set; }
        public virtual DbSet<MenuOption> MenuOption { get; set; }
        public virtual DbSet<MonthlyCategorySales> MonthlyCategorySales { get; set; }
        public virtual DbSet<MonthlyClassSales> MonthlyClassSales { get; set; }
        public virtual DbSet<MonthlyCustomerSales> MonthlyCustomerSales { get; set; }
        public virtual DbSet<MonthlyItemSales> MonthlyItemSales { get; set; }
        public virtual DbSet<MonthlySales> MonthlySales { get; set; }
        public virtual DbSet<MonthlySalesRepSales> MonthlySalesRepSales { get; set; }
        public virtual DbSet<MonthlybrandSales> MonthlybrandSales { get; set; }
        public virtual DbSet<MonthlymanufacturerSales> MonthlymanufacturerSales { get; set; }
        public virtual DbSet<Msacusts> Msacusts { get; set; }
        public virtual DbSet<Msaitems> Msaitems { get; set; }
        public virtual DbSet<Object> Object { get; set; }
        public virtual DbSet<PaymentTerm> PaymentTerm { get; set; }
        public virtual DbSet<PoadjustmentReason> PoadjustmentReason { get; set; }
        public virtual DbSet<Poexpense> Poexpense { get; set; }
        public virtual DbSet<Pospayments> Pospayments { get; set; }
        public virtual DbSet<PricingGroup> PricingGroup { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual DbSet<PurchaseOrderLine> PurchaseOrderLine { get; set; }
        public virtual DbSet<PurchaseOrderSalesTax> PurchaseOrderSalesTax { get; set; }
        public virtual DbSet<Qbcustomer> Qbcustomer { get; set; }
        public virtual DbSet<Qbitem> Qbitem { get; set; }
        public virtual DbSet<RemoteOrder> RemoteOrder { get; set; }
        public virtual DbSet<RemoteOrderLine> RemoteOrderLine { get; set; }
        public virtual DbSet<ReportFormat> ReportFormat { get; set; }
        public virtual DbSet<ReportFormatAddIns> ReportFormatAddIns { get; set; }
        public virtual DbSet<ReportFormatCategory> ReportFormatCategory { get; set; }
        public virtual DbSet<ReportFormatMnfr> ReportFormatMnfr { get; set; }
        public virtual DbSet<SalesOrder> SalesOrder { get; set; }
        public virtual DbSet<SalesOrderLine> SalesOrderLine { get; set; }
        public virtual DbSet<SalesOrderLineTax> SalesOrderLineTax { get; set; }
        public virtual DbSet<SalesOrderMessage> SalesOrderMessage { get; set; }
        public virtual DbSet<SalesOrderSalesTax> SalesOrderSalesTax { get; set; }
        public virtual DbSet<SalesRep> SalesRep { get; set; }
        public virtual DbSet<ScanCode> ScanCode { get; set; }
        public virtual DbSet<SellingAllowance> SellingAllowance { get; set; }
        public virtual DbSet<SellingContract> SellingContract { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<Sldatabase> Sldatabase { get; set; }
        public virtual DbSet<Slupdate> Slupdate { get; set; }
        public virtual DbSet<Soexpense> Soexpense { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<SystemNotification> SystemNotification { get; set; }
        public virtual DbSet<SystemOption> SystemOption { get; set; }
        public virtual DbSet<SystemUser> SystemUser { get; set; }
        public virtual DbSet<TaxAuthority> TaxAuthority { get; set; }
        public virtual DbSet<TaxJurisdiction> TaxJurisdiction { get; set; }
        public virtual DbSet<TaxJurisdictionType> TaxJurisdictionType { get; set; }
        public virtual DbSet<TaxRate> TaxRate { get; set; }
        public virtual DbSet<TaxStamp> TaxStamp { get; set; }
        public virtual DbSet<TaxStampDenom> TaxStampDenom { get; set; }
        public virtual DbSet<TaxStampItem> TaxStampItem { get; set; }
        public virtual DbSet<TaxType> TaxType { get; set; }
        public virtual DbSet<Uda> Uda { get; set; }
        public virtual DbSet<UdaobjectValue> UdaobjectValue { get; set; }
        public virtual DbSet<Udavalue> Udavalue { get; set; }
        public virtual DbSet<UnitSurcharge> UnitSurcharge { get; set; }
        public virtual DbSet<UpdateCustomerInfo> UpdateCustomerInfo { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorPaymentTerm> VendorPaymentTerm { get; set; }
        public virtual DbSet<WeeklyCategorySales> WeeklyCategorySales { get; set; }
        public virtual DbSet<WeeklyClassSales> WeeklyClassSales { get; set; }
        public virtual DbSet<WeeklyCustomerSales> WeeklyCustomerSales { get; set; }
        public virtual DbSet<WeeklyItemSales> WeeklyItemSales { get; set; }
        public virtual DbSet<WeeklySales> WeeklySales { get; set; }
        public virtual DbSet<WeeklySalesRepSales> WeeklySalesRepSales { get; set; }
        public virtual DbSet<WeeklybrandSales> WeeklybrandSales { get; set; }
        public virtual DbSet<WeeklymanufacturerSales> WeeklymanufacturerSales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=cdrserver\\supplylogic;Initial Catalog=Shakespeare;User ID=bas; Password=bas;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "bas");

            modelBuilder.Entity<AradjustmentReason>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxARAdjustmentReasonObjID")
                    .IsClustered(false);

                entity.ToTable("ARAdjustmentReason", "cdr");

                entity.HasIndex(e => e.Code)
                    .HasName("IxARAdjustmentReasonCode")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("IxARAdjustmentReasonDescr")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArtransAppliedTo>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxARTransAppliedToOjID")
                    .IsClustered(false);

                entity.ToTable("ARTransAppliedTo", "cdr");

                entity.HasIndex(e => new { e.CustomerOid, e.ArdebitTransNum, e.ArcreditTransNum })
                    .HasName("IxARTransAppliedToCusDebCrd")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.AppliedAmount).HasColumnType("money");

                entity.Property(e => e.AppliedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ArcreditTransNum).HasColumnName("ARCreditTransNum");

                entity.Property(e => e.ArdebitTransNum).HasColumnName("ARDebitTransNum");

                entity.Property(e => e.CustomerOid).HasColumnName("CustomerOID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Artransaction>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxARTransactionObjID")
                    .IsClustered(false);

                entity.ToTable("ARTransaction", "cdr");

                entity.HasIndex(e => new { e.CustomerOid, e.EntryDate })
                    .HasName("IxARTransaction");

                entity.HasIndex(e => new { e.CustomerOid, e.TransNum })
                    .HasName("IxARTransactionCusTrans")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerOid, e.Status, e.TransNum })
                    .HasName("IxARTransCustStatNum");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.AradjustmentReasonOid).HasColumnName("ARAdjustmentReasonOID");

                entity.Property(e => e.CustomerOid).HasColumnName("CustomerOID");

                entity.Property(e => e.DiscountAmountAvailable).HasColumnType("money");

                entity.Property(e => e.DiscountAmountTaken).HasColumnType("money");

                entity.Property(e => e.DiscountDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EntryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTermOid).HasColumnName("PaymentTermOID");

                entity.Property(e => e.SalesOrderOid).HasColumnName("SalesOrderOID");

                entity.Property(e => e.StrRef)
                    .HasColumnName("strRef")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TransactionAmount).HasColumnType("money");

                entity.Property(e => e.UnappliedAmount).HasColumnType("money");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxBrandObjID")
                    .IsClustered(false);

                entity.ToTable("Brand", "cdr");

                entity.HasIndex(e => e.Name)
                    .HasName("IxBrandName")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.Name })
                    .HasName("IxBrandC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.BrandId)
                    .HasColumnName("BrandID")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.BrandType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LegalName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerOid).HasColumnName("ManufacturerOID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BuyingAllowance>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxBuyingAllowanceObjID")
                    .IsClustered(false);

                entity.ToTable("BuyingAllowance", "cdr");

                entity.HasIndex(e => e.Description)
                    .HasName("IxBuyingAllowanceDescr")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Amount1).HasColumnType("money");

                entity.Property(e => e.Amount2).HasColumnType("money");

                entity.Property(e => e.Amount3).HasColumnType("money");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FreeItemOid).HasColumnName("FreeItemOID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.WhatCid).HasColumnName("WhatCID");

                entity.Property(e => e.WhatOid).HasColumnName("WhatOID");

                entity.Property(e => e.WhoCid).HasColumnName("WhoCID");

                entity.Property(e => e.WhoOid).HasColumnName("WhoOID");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxCategoryObjID")
                    .IsClustered(false);

                entity.ToTable("Category", "cdr");

                entity.HasIndex(e => e.Name)
                    .HasName("IxCategoryName")
                    .IsUnique();

                entity.HasIndex(e => e.Num)
                    .HasName("IxCategoryNum")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.Num })
                    .HasName("IxCategoryC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.TobCat)
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxClassObjID")
                    .IsClustered(false);

                entity.ToTable("Class", "cdr");

                entity.HasIndex(e => e.Name)
                    .HasName("IxClassName")
                    .IsUnique();

                entity.HasIndex(e => e.Num)
                    .HasName("IxClassNum")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.Num })
                    .HasName("IxClassC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.BrandOid).HasColumnName("BrandOID");

                entity.Property(e => e.CategoryOid).HasColumnName("CategoryOID");

                entity.Property(e => e.ListPrice).HasColumnType("money");

                entity.Property(e => e.MnfrOid).HasColumnName("MnfrOID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.NetCost).HasColumnType("money");

                entity.Property(e => e.TaxStampDenomOid).HasColumnName("TaxStampDenomOID");

                entity.Property(e => e.Unit1Depth).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit1Height).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit1Msrp)
                    .HasColumnName("Unit1MSRP")
                    .HasColumnType("money");

                entity.Property(e => e.Unit1Ounces).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.Unit1Um)
                    .HasColumnName("Unit1UM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Unit1Width).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit2Depth).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit2Height).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit2Msrp)
                    .HasColumnName("Unit2MSRP")
                    .HasColumnType("money");

                entity.Property(e => e.Unit2Um)
                    .HasColumnName("Unit2UM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Unit2Width).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit3Depth).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit3Height).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit3Msrp)
                    .HasColumnName("Unit3MSRP")
                    .HasColumnType("money");

                entity.Property(e => e.Unit3Um)
                    .HasColumnName("Unit3UM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Unit3Width).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit4Depth).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit4Height).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit4Msrp)
                    .HasColumnName("Unit4MSRP")
                    .HasColumnType("money");

                entity.Property(e => e.Unit4Um)
                    .HasColumnName("Unit4UM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Unit4Width).HasColumnType("decimal(8, 4)");
            });

            modelBuilder.Entity<ComboItemComponent>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxComboItemObjID")
                    .IsClustered(false);

                entity.ToTable("ComboItemComponent", "cdr");

                entity.HasIndex(e => new { e.ComboItemOid, e.ComponentItemOid })
                    .HasName("IxComboItemComponent")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.ComboItemOid).HasColumnName("ComboItemOID");

                entity.Property(e => e.ComponentItemOid).HasColumnName("ComponentItemOID");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxCompanyObjID")
                    .IsClustered(false);

                entity.ToTable("Company", "cdr");

                entity.HasIndex(e => e.Name)
                    .HasName("IxCompanyName")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.Name })
                    .HasName("IxCompanyC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorLicenseNum)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Pofax)
                    .HasColumnName("POFax")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StateOid).HasColumnName("StateOID");

                entity.Property(e => e.TaxJurisdictionOid)
                    .HasColumnName("TaxJurisdictionOID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanySalesOrderMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CompanySalesOrderMessage", "cdr");

                entity.Property(e => e.Message)
                    .HasMaxLength(240)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxContactObjID")
                    .IsClustered(false);

                entity.ToTable("Contact", "cdr");

                entity.HasIndex(e => new { e.ParentCid, e.ParentOid })
                    .HasName("IxContactParent");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddressHome)
                    .HasColumnName("EMailAddressHome")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddressWork)
                    .HasColumnName("EMailAddressWork")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentCid).HasColumnName("ParentCID");

                entity.Property(e => e.ParentOid).HasColumnName("ParentOID");

                entity.Property(e => e.PhoneCell)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneData)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneFax)
                    .HasColumnName("PhoneFAX")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneHome)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhonePager)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneWork)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CreditReason>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxCreditReasonObjID")
                    .IsClustered(false);

                entity.ToTable("CreditReason", "cdr");

                entity.HasIndex(e => e.Description)
                    .HasName("IxCreditReasonDescr")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxCustomerObjID")
                    .IsClustered(false);

                entity.ToTable("Customer", "cdr");

                entity.HasIndex(e => e.Name)
                    .HasName("IxCustomerName")
                    .IsUnique();

                entity.HasIndex(e => e.Num)
                    .HasName("IxCustomerNum")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.Num })
                    .HasName("IxCustomerC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.BillToAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAttention)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToStateOid).HasColumnName("BillToStateOID");

                entity.Property(e => e.BillToZipCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CigaretteLicenseNum)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLimit).HasColumnType("money");

                entity.Property(e => e.Ediemail)
                    .HasColumnName("EDIEmail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfInvoices).HasDefaultValueSql("((1))");

                entity.Property(e => e.PaymentTermOid).HasColumnName("PaymentTermOID");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PricingGroupOid).HasColumnName("PricingGroupOID");

                entity.Property(e => e.PrintWeCard).HasDefaultValueSql("((1))");

                entity.Property(e => e.ResaleNum)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.SalesRepOid).HasColumnName("SalesRepOID");

                entity.Property(e => e.ShipToAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAttention)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToStateOid).HasColumnName("ShipToStateOID");

                entity.Property(e => e.ShipToZipCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.StatemntCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TaxJurisdictionOid).HasColumnName("TaxJurisdictionOID");

                entity.Property(e => e.TobaccoLicenseExpirationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TobaccoLicenseNum)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UseEdi).HasColumnName("UseEDI");
            });

            modelBuilder.Entity<CustomerAr>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxCustomerAROjID")
                    .IsClustered(false);

                entity.ToTable("CustomerAR", "cdr");

                entity.HasIndex(e => e.CustomerOid)
                    .HasName("IxCustomerAR")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.BalanceDue).HasColumnType("money");

                entity.Property(e => e.CustomerOid).HasColumnName("CustomerOID");

                entity.Property(e => e.LastOrderDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastPaymentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastStatementDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TotalOpenAdjCredits).HasColumnType("money");

                entity.Property(e => e.TotalOpenAdjDebits).HasColumnType("money");

                entity.Property(e => e.TotalOpenCreditMemos).HasColumnType("money");

                entity.Property(e => e.TotalOpenInvoices).HasColumnType("money");

                entity.Property(e => e.TotalOpenPayments).HasColumnType("money");
            });

            modelBuilder.Entity<CustomerItemPricing>(entity =>
            {
                entity.HasKey(e => new { e.CustomerOid, e.ItemOid, e.TaxStampOid })
                    .HasName("IxCustomerItemPricingPKey")
                    .IsClustered(false);

                entity.ToTable("CustomerItemPricing", "cdr");

                entity.Property(e => e.CustomerOid).HasColumnName("CustomerOID");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.TaxStampOid).HasColumnName("TaxStampOID");

                entity.Property(e => e.ObjId)
                    .HasColumnName("ObjID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<CustomerSalesOrderMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustomerSalesOrderMessage", "cdr");

                entity.Property(e => e.CustomerOid).HasColumnName("CustomerOID");

                entity.Property(e => e.Message)
                    .HasMaxLength(240)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DailyMovementItem>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxDailyMovementItemOjID")
                    .IsClustered(false);

                entity.ToTable("DailyMovementItem", "cdr");

                entity.HasIndex(e => new { e.CategoryOid, e.Occurred })
                    .HasName("IxDailyMovementItemCategoryDate");

                entity.HasIndex(e => new { e.ClassOid, e.Occurred })
                    .HasName("IxDailyMovementItemClassDate");

                entity.HasIndex(e => new { e.ItemOid, e.Occurred })
                    .HasName("IxDailyMovementItemItemDate");

                entity.HasIndex(e => new { e.ItemOid, e.CategoryOid, e.ClassOid, e.Occurred })
                    .HasName("IxDailyMovementItemC")
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.AdjustmentsActualCost).HasColumnType("money");

                entity.Property(e => e.AdjustmentsNetCost).HasColumnType("money");

                entity.Property(e => e.AuditsActualCost).HasColumnType("money");

                entity.Property(e => e.AuditsNetCost).HasColumnType("money");

                entity.Property(e => e.BeginActualCost).HasColumnType("money");

                entity.Property(e => e.BeginNetCost).HasColumnType("money");

                entity.Property(e => e.CategoryOid).HasColumnName("CategoryOID");

                entity.Property(e => e.ClassOid).HasColumnName("ClassOID");

                entity.Property(e => e.EndActualCost).HasColumnType("money");

                entity.Property(e => e.EndNetCost).HasColumnType("money");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Occurred).HasColumnType("smalldatetime");

                entity.Property(e => e.OtherActualCost).HasColumnType("money");

                entity.Property(e => e.OtherNetCost).HasColumnType("money");

                entity.Property(e => e.PurchasesActualCost).HasColumnType("money");

                entity.Property(e => e.PurchasesNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.StampAdjActualCost).HasColumnType("money");

                entity.Property(e => e.StampAdjNetCost).HasColumnType("money");

                entity.Property(e => e.TaxStampOid)
                    .HasColumnName("TaxStampOID")
                    .HasDefaultValueSql("((2))");
            });

            modelBuilder.Entity<DeliveryRoute>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxDeliveryRouteObjID")
                    .IsClustered(false);

                entity.ToTable("DeliveryRoute", "cdr");

                entity.HasIndex(e => e.Code)
                    .HasName("IxDeliveryRouteCode")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("IxDeliveryRouteDescr")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.Code })
                    .HasName("IxDeliveryRouteC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeliveryRouteStop>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxDeliveryRouteStopObjID")
                    .IsClustered(false);

                entity.ToTable("DeliveryRouteStop", "cdr");

                entity.HasIndex(e => new { e.CustomerOid, e.DeliveryRouteOid })
                    .HasName("IxDeliveryRouteStopCust")
                    .IsClustered();

                entity.HasIndex(e => new { e.DeliveryRouteOid, e.CustomerOid })
                    .HasName("IxDeliveryRouteStopKey")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.CustomerOid).HasColumnName("CustomerOID");

                entity.Property(e => e.DeliveryRouteOid).HasColumnName("DeliveryRouteOID");
            });

            modelBuilder.Entity<InvBatch>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxInvBatchObjID")
                    .IsClustered(false);

                entity.ToTable("InvBatch", "cdr");

                entity.HasIndex(e => e.BatchId)
                    .HasName("IxInvBatchBatchID")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.BatchId })
                    .HasName("IxInvBatchC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.BatchDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BatchDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.CancelDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CloseDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DefaultInvTranReasonOid).HasColumnName("DefaultInvTranReasonOID");

                entity.Property(e => e.DefaultTaxStampOid).HasColumnName("DefaultTaxStampOID");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SystemUserOid).HasColumnName("SystemUserOID");

                entity.Property(e => e.TotalCost).HasColumnType("money");

                entity.Property(e => e.TotalTax).HasColumnType("money");

                entity.Property(e => e.VendorOid).HasColumnName("VendorOID");
            });

            modelBuilder.Entity<InvBatchDetail>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxInvBatchDetailObjID")
                    .IsClustered(false);

                entity.ToTable("InvBatchDetail", "cdr");

                entity.HasIndex(e => new { e.BatchOid, e.LineNum })
                    .HasName("IxInvBatchDetailLine")
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.BatchOid).HasColumnName("BatchOID");

                entity.Property(e => e.InvTranReasonOid).HasColumnName("InvTranReasonOID");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.TaxStampOid).HasColumnName("TaxStampOID");

                entity.Property(e => e.TotalActualCost).HasColumnType("money");

                entity.Property(e => e.TotalNetCost).HasColumnType("money");
            });

            modelBuilder.Entity<InvTranReason>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxInvTranReasonObjID")
                    .IsClustered(false);

                entity.ToTable("InvTranReason", "cdr");

                entity.HasIndex(e => e.Code)
                    .HasName("IxInvTranReasonCode")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("IxInvTranReasonDescr")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxItemObjID")
                    .IsClustered(false);

                entity.ToTable("Item", "cdr");

                entity.HasIndex(e => e.Name)
                    .HasName("IxItemName")
                    .IsUnique();

                entity.HasIndex(e => e.Num)
                    .HasName("IxItemNum")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.Num })
                    .HasName("IxItemC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.BrandOid).HasColumnName("BrandOID");

                entity.Property(e => e.CategoryOid).HasColumnName("CategoryOID");

                entity.Property(e => e.ClassOid).HasColumnName("ClassOID");

                entity.Property(e => e.Description)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.LastReceivedCost).HasColumnType("money");

                entity.Property(e => e.LastReceivedUnit).HasColumnType("money");

                entity.Property(e => e.ListPrice).HasColumnType("money");

                entity.Property(e => e.MnfrOid).HasColumnName("MnfrOID");

                entity.Property(e => e.MnfrPartNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.NetCost).HasColumnType("money");

                entity.Property(e => e.PictureFileName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PrintComboComponents).HasDefaultValueSql("((0))");

                entity.Property(e => e.SlotLocation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubstituteItemOid).HasColumnName("SubstituteItemOID");

                entity.Property(e => e.TaxStampDenomOid).HasColumnName("TaxStampDenomOID");

                entity.Property(e => e.Unit1Depth).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit1Height).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit1Msrp)
                    .HasColumnName("Unit1MSRP")
                    .HasColumnType("money");

                entity.Property(e => e.Unit1Ounces).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.Unit1Um)
                    .HasColumnName("Unit1UM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Unit1Width).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit2Depth).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit2Height).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit2Msrp)
                    .HasColumnName("Unit2MSRP")
                    .HasColumnType("money");

                entity.Property(e => e.Unit2Um)
                    .HasColumnName("Unit2UM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Unit2Width).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit3Depth).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit3Height).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit3Msrp)
                    .HasColumnName("Unit3MSRP")
                    .HasColumnType("money");

                entity.Property(e => e.Unit3Um)
                    .HasColumnName("Unit3UM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Unit3Width).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit4Depth).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit4Height).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.Unit4Msrp)
                    .HasColumnName("Unit4MSRP")
                    .HasColumnType("money");

                entity.Property(e => e.Unit4Um)
                    .HasColumnName("Unit4UM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Unit4Width).HasColumnType("decimal(8, 4)");
            });

            modelBuilder.Entity<ItemAuth>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxItemAuthObjID")
                    .IsClustered(false);

                entity.ToTable("ItemAuth", "cdr");

                entity.HasIndex(e => new { e.CategoryOid, e.ClassOid, e.ItemOid, e.ObjectClassId, e.ObjectOid })
                    .HasName("IxItemAuthCatClsItmTypObj")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.CategoryOid).HasColumnName("CategoryOID");

                entity.Property(e => e.ClassOid).HasColumnName("ClassOID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.ObjectClassId).HasColumnName("ObjectClassID");

                entity.Property(e => e.ObjectOid).HasColumnName("ObjectOID");
            });

            modelBuilder.Entity<ItemCosting>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxItemCostingObjID")
                    .IsClustered(false);

                entity.ToTable("ItemCosting", "cdr");

                entity.HasIndex(e => new { e.ItemOid, e.TaxStampOid, e.VendorOid, e.Unit })
                    .HasName("IxItemCostingItemTaxVenUnitID")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.TaxStampOid).HasColumnName("TaxStampOID");

                entity.Property(e => e.VendorItem)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VendorOid).HasColumnName("VendorOID");
            });

            modelBuilder.Entity<ItemInventoryLocation>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxItemInvLocationObjID")
                    .IsClustered(false);

                entity.ToTable("ItemInventoryLocation", "cdr");

                entity.HasIndex(e => new { e.ItemOid, e.TaxStampOid })
                    .HasName("IxItemInvLocationItem")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.ItemOid })
                    .HasName("IxItemInventoryLocationC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.SlotLocation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxStampOid).HasColumnName("TaxStampOID");
            });

            modelBuilder.Entity<ItemInventoryOnHand>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxItemInventoryOnHandObjID")
                    .IsClustered(false);

                entity.ToTable("ItemInventoryOnHand", "cdr");

                entity.HasIndex(e => e.ItemOid)
                    .HasName("IxItemInventoryOnHandC")
                    .IsClustered();

                entity.HasIndex(e => new { e.ItemOid, e.TaxStampOid, e.Received })
                    .HasName("IxItemInventoryOnHandTier");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.ExpirationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ItemInventoryTransOid).HasColumnName("ItemInventoryTransOID");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.LotNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Received).HasColumnType("smalldatetime");

                entity.Property(e => e.TaxStampOid).HasColumnName("TaxStampOID");

                entity.Property(e => e.TransCid).HasColumnName("TransCID");

                entity.Property(e => e.TransOid).HasColumnName("TransOID");

                entity.Property(e => e.UnitActualCost).HasColumnType("money");

                entity.Property(e => e.VendorOid).HasColumnName("VendorOID");
            });

            modelBuilder.Entity<ItemInventoryPurchased>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxItemInventoryPurchasedObjID")
                    .IsClustered(false);

                entity.ToTable("ItemInventoryPurchased", "cdr");

                entity.HasIndex(e => new { e.PurchaseOrderOid, e.LineNum })
                    .HasName("IxIIPOrderLine")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemOid, e.TaxStampOid, e.ExpectedReceiptDate })
                    .HasName("IxItemInventoryPurchased");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.ExpectedReceiptDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.PurchaseOrderOid).HasColumnName("PurchaseOrderOID");

                entity.Property(e => e.TaxStampOid).HasColumnName("TaxStampOID");
            });

            modelBuilder.Entity<ItemInventorySold>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxItemInventorySoldObjID")
                    .IsClustered(false);

                entity.ToTable("ItemInventorySold", "cdr");

                entity.HasIndex(e => new { e.ObjId, e.ItemOid })
                    .HasName("IxItemInventorySoldC")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.SalesOrderOid, e.LineNum })
                    .HasName("IxIISOrderLine")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemOid, e.TaxStampOid, e.RequestedDeliveryDate })
                    .HasName("IxItemInventorySold");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.RequestedDeliveryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SalesOrderOid).HasColumnName("SalesOrderOID");

                entity.Property(e => e.TaxStampOid).HasColumnName("TaxStampOID");
            });

            modelBuilder.Entity<ItemInventoryTrans>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxItemInventoryTransObjID")
                    .IsClustered(false);

                entity.ToTable("ItemInventoryTrans", "cdr");

                entity.HasIndex(e => e.DailyPostFlag)
                    .HasName("IxItemInventoryTransDPF")
                    .IsClustered();

                entity.HasIndex(e => new { e.ItemOid, e.TaxStampOid, e.Occurred })
                    .HasName("IxItemInventoryTrans");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.CategoryOid).HasColumnName("CategoryOID");

                entity.Property(e => e.ClassOid).HasColumnName("ClassOID");

                entity.Property(e => e.CreditReasonOid).HasColumnName("CreditReasonOID");

                entity.Property(e => e.CustomerOid).HasColumnName("CustomerOID");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.Occurred).HasColumnType("datetime");

                entity.Property(e => e.SalesRepOid).HasColumnName("SalesRepOID");

                entity.Property(e => e.SystemUserOid).HasColumnName("SystemUserOID");

                entity.Property(e => e.TaxStampOid).HasColumnName("TaxStampOID");

                entity.Property(e => e.TotalActualCost).HasColumnType("money");

                entity.Property(e => e.TotalNetCost).HasColumnType("money");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.TransCid).HasColumnName("TransCID");

                entity.Property(e => e.TransOid).HasColumnName("TransOID");
            });

            modelBuilder.Entity<ItemTempTrans>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ItemTempTrans", "cdr");

                entity.HasIndex(e => new { e.ItemOid, e.TaxStampOid, e.Occurred })
                    .HasName("IxItemTempTrans");

                entity.Property(e => e.CategoryOid).HasColumnName("CategoryOID");

                entity.Property(e => e.ClassOid).HasColumnName("ClassOID");

                entity.Property(e => e.CreditReasonOid).HasColumnName("CreditReasonOID");

                entity.Property(e => e.CustomerOid).HasColumnName("CustomerOID");

                entity.Property(e => e.DailyPostFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ImmedPostFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.ItemType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Occurred).HasColumnType("datetime");

                entity.Property(e => e.SalesRepOid).HasColumnName("SalesRepOID");

                entity.Property(e => e.SystemUserOid).HasColumnName("SystemUserOID");

                entity.Property(e => e.TaxStampOid).HasColumnName("TaxStampOID");

                entity.Property(e => e.TotalActualCost).HasColumnType("money");

                entity.Property(e => e.TotalNetCost).HasColumnType("money");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.TransCid).HasColumnName("TransCID");

                entity.Property(e => e.TransOid).HasColumnName("TransOID");
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxManufacturerObjID")
                    .IsClustered(false);

                entity.ToTable("Manufacturer", "cdr");

                entity.HasIndex(e => e.Code)
                    .HasName("IxManufacturerCode")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("IxManufacturerName")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.Code })
                    .HasName("IxManufacturerC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Addr1)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Addr2)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FeinNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ForMan)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LegalName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.St)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManufacturerReporting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ManufacturerReporting", "cdr");

                entity.HasIndex(e => e.ReportingId)
                    .HasName("IxManufacturerReporting")
                    .IsUnique();

                entity.Property(e => e.ReportingId).HasColumnName("ReportingID");

                entity.Property(e => e.Value)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MenuFunction>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxMenuFunctionObjID")
                    .IsClustered(false);

                entity.ToTable("MenuFunction", "cdr");

                entity.HasIndex(e => e.Name)
                    .HasName("IxMenuFunctionName")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.FunctionCall)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MenuOption>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxMenuOptionObjID")
                    .IsClustered(false);

                entity.ToTable("MenuOption", "cdr");

                entity.HasIndex(e => new { e.ParentMenuOid, e.MenuSequence })
                    .HasName("IxMenuSequence")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.FunctionOid).HasColumnName("FunctionOID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ParentMenuOid).HasColumnName("ParentMenuOID");
            });

            modelBuilder.Entity<MonthlyCategorySales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxMonthlyCategorySalesOjID")
                    .IsClustered(false);

                entity.ToTable("MonthlyCategorySales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Month, e.CategoryOid })
                    .HasName("IxMonthlyCategorySales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.CategoryOid).HasColumnName("CategoryOID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");
            });

            modelBuilder.Entity<MonthlyClassSales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxMonthlyClassSalesOjID")
                    .IsClustered(false);

                entity.ToTable("MonthlyClassSales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Month, e.ClassOid })
                    .HasName("IxMonthlyClassSales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.ClassOid).HasColumnName("ClassOID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");
            });

            modelBuilder.Entity<MonthlyCustomerSales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxMonthlyCustomerSalesOjID")
                    .IsClustered(false);

                entity.ToTable("MonthlyCustomerSales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Month, e.CustomerOid })
                    .HasName("IxMonthlyCustomerSales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.CustomerOid).HasColumnName("CustomerOID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");
            });

            modelBuilder.Entity<MonthlyItemSales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxMonthlyItemSalesOjID")
                    .IsClustered(false);

                entity.ToTable("MonthlyItemSales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Month, e.ItemOid, e.TaxStampOid })
                    .HasName("IxMonthlyItemSales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.TaxStampOid)
                    .HasColumnName("TaxStampOID")
                    .HasDefaultValueSql("((2))");
            });

            modelBuilder.Entity<MonthlySales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxMonthlySalesOjID")
                    .IsClustered(false);

                entity.ToTable("MonthlySales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Month, e.CustomerOid, e.ItemOid, e.TaxStampOid, e.CategoryOid, e.ClassOid, e.ManufacturerOid, e.BrandOid, e.SalesRepOid })
                    .HasName("IxMonthlySales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.BrandOid).HasColumnName("BrandOID");

                entity.Property(e => e.CategoryOid).HasColumnName("CategoryOID");

                entity.Property(e => e.ClassOid).HasColumnName("ClassOID");

                entity.Property(e => e.CustomerOid).HasColumnName("CustomerOID");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ManufacturerOid).HasColumnName("ManufacturerOID");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesRepOid).HasColumnName("SalesRepOID");

                entity.Property(e => e.TaxStampOid)
                    .HasColumnName("TaxStampOID")
                    .HasDefaultValueSql("((2))");
            });

            modelBuilder.Entity<MonthlySalesRepSales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxMonthlySalesRepSalesOjID")
                    .IsClustered(false);

                entity.ToTable("MonthlySalesRepSales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Month, e.SalesRepOid })
                    .HasName("IxMonthlySalesRepSales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesRepOid).HasColumnName("SalesRepOID");
            });

            modelBuilder.Entity<MonthlybrandSales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxMonthlybrandSalesOjID")
                    .IsClustered(false);

                entity.ToTable("MonthlybrandSales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Month, e.BrandOid })
                    .HasName("IxMonthlybrandSales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.BrandOid).HasColumnName("BrandOID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");
            });

            modelBuilder.Entity<MonthlymanufacturerSales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxMonthlymanufacturerSalesOjID")
                    .IsClustered(false);

                entity.ToTable("MonthlymanufacturerSales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Month, e.ManufacturerOid })
                    .HasName("IxMonthlymanufacturerSales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ManufacturerOid).HasColumnName("manufacturerOID");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");
            });

            modelBuilder.Entity<Msacusts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MSACusts", "dbo");

                entity.Property(e => e.Column10)
                    .HasColumnName("Column 10")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column11)
                    .HasColumnName("Column 11")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column12)
                    .HasColumnName("Column 12")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column13)
                    .HasColumnName("Column 13")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column14)
                    .HasColumnName("Column 14")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column15)
                    .HasColumnName("Column 15")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column16)
                    .HasColumnName("Column 16")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column17)
                    .HasColumnName("Column 17")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column18)
                    .HasColumnName("Column 18")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column19)
                    .HasColumnName("Column 19")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column2)
                    .HasColumnName("Column 2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column20)
                    .HasColumnName("Column 20")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column21)
                    .HasColumnName("Column 21")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column22)
                    .HasColumnName("Column 22")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column23)
                    .HasColumnName("Column 23")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column24)
                    .HasColumnName("Column 24")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column25)
                    .HasColumnName("Column 25")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column3)
                    .HasColumnName("Column 3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column4)
                    .HasColumnName("Column 4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column5)
                    .HasColumnName("Column 5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column6)
                    .HasColumnName("Column 6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column7)
                    .HasColumnName("Column 7")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column8)
                    .HasColumnName("Column 8")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column9)
                    .HasColumnName("Column 9")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustOid)
                    .HasColumnName("CustOID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Msaitems>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MSAItems", "dbo");

                entity.Property(e => e.Column0)
                    .HasColumnName("Column 0")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column1)
                    .HasColumnName("Column 1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column10)
                    .HasColumnName("Column 10")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column11)
                    .HasColumnName("Column 11")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column12)
                    .HasColumnName("Column 12")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column2)
                    .HasColumnName("Column 2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column3)
                    .HasColumnName("Column 3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column4)
                    .HasColumnName("Column 4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column5)
                    .HasColumnName("Column 5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column6)
                    .HasColumnName("Column 6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column7)
                    .HasColumnName("Column 7")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column8)
                    .HasColumnName("Column 8")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Column9)
                    .HasColumnName("Column 9")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Object>(entity =>
            {
                entity.HasKey(e => new { e.ClsId, e.ObjId })
                    .HasName("IxClsObjID")
                    .IsClustered(false);

                entity.ToTable("Object", "cdr");

                entity.HasIndex(e => new { e.ClsId, e.ObjId, e.ObjDeleted })
                    .HasName("IxObjectClsIDObjIDC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ClsId).HasColumnName("ClsID");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.ObjCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.ObjCreatedByOid).HasColumnName("ObjCreatedByOID");

                entity.Property(e => e.ObjInvalidMsg)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ObjModified).HasColumnType("smalldatetime");

                entity.Property(e => e.ObjModifiedByOid).HasColumnName("ObjModifiedByOID");
            });

            modelBuilder.Entity<PaymentTerm>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxPaymentTermObjID")
                    .IsClustered(false);

                entity.ToTable("PaymentTerm", "cdr");

                entity.HasIndex(e => e.Code)
                    .HasName("IxPaymentTermCode")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("IxPaymentTermDescr")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.Code })
                    .HasName("IxPaymentTermC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercent).HasColumnType("money");
            });

            modelBuilder.Entity<PoadjustmentReason>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxPOAdjustmentReasonObjID")
                    .IsClustered(false);

                entity.ToTable("POAdjustmentReason", "cdr");

                entity.HasIndex(e => e.Description)
                    .HasName("IxPOAdjustmentReasonDescr")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.RestockInventory).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Poexpense>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxObjID")
                    .IsClustered(false);

                entity.ToTable("POExpense", "cdr");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pospayments>(entity =>
            {
                entity.HasKey(e => new { e.SalesOrderOid, e.CustomerOid, e.Line })
                    .HasName("IxPOSPaymentsOrdCustLine")
                    .IsClustered(false);

                entity.ToTable("POSPayments", "cdr");

                entity.Property(e => e.SalesOrderOid).HasColumnName("SalesOrderOID");

                entity.Property(e => e.CustomerOid).HasColumnName("CustomerOID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.StrRef)
                    .HasColumnName("strRef")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PricingGroup>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxPricingGroupObjID")
                    .IsClustered(false);

                entity.ToTable("PricingGroup", "cdr");

                entity.HasIndex(e => e.Code)
                    .HasName("IxPricingGroupCode")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("IxPricingGroupName")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.Code })
                    .HasName("IxPricingGroupC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxPurchaseOrderObjID")
                    .IsClustered(false);

                entity.ToTable("PurchaseOrder", "cdr");

                entity.HasIndex(e => new { e.Status, e.ObjId })
                    .HasName("IxPurchaseOrderC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.AdjustedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BillToAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAttention)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToStateOid).HasColumnName("BillToStateOID");

                entity.Property(e => e.BillToZipCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerOid).HasColumnName("BuyerOID");

                entity.Property(e => e.DefaultPoreasonOid).HasColumnName("DefaultPOReasonOID");

                entity.Property(e => e.DefaultTaxStampOid).HasColumnName("DefaultTaxStampOID");

                entity.Property(e => e.ExpectedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FreightTerms)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceTotal).HasColumnType("money");

                entity.Property(e => e.InvoicedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastPricedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OrderedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PaidDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PostedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ReceivedBy)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ReferencedOrderOid).HasColumnName("ReferencedOrderOID");

                entity.Property(e => e.ShipToAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAttention)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToStateOid).HasColumnName("ShipToStateOID");

                entity.Property(e => e.ShipToZipCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.TaxJurisdictionOid).HasColumnName("TaxJurisdictionOID");

                entity.Property(e => e.TotalActualCost).HasColumnType("money");

                entity.Property(e => e.TotalCharges).HasColumnType("money");

                entity.Property(e => e.TotalDiscount).HasColumnType("money");

                entity.Property(e => e.TotalNetCost).HasColumnType("money");

                entity.Property(e => e.TotalOrder).HasColumnType("money");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.TotalPriceChanges).HasColumnType("money");

                entity.Property(e => e.TotalRebates).HasColumnType("money");

                entity.Property(e => e.TotalSalesTax).HasColumnType("money");

                entity.Property(e => e.TransferDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VendorBuyer)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.VendorOid).HasColumnName("VendorOID");

                entity.Property(e => e.VendorPaymentTermOid).HasColumnName("VendorPaymentTermOID");

                entity.Property(e => e.VendorPonumber)
                    .HasColumnName("VendorPONumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseOrderLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PurchaseOrderLine", "cdr");

                entity.Property(e => e.BuyingAllowanceOid).HasColumnName("BuyingAllowanceOID");

                entity.Property(e => e.CategoryOid).HasColumnName("CategoryOID");

                entity.Property(e => e.ClassOid).HasColumnName("ClassOID");

                entity.Property(e => e.Description)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ExtendedActualCost).HasColumnType("money");

                entity.Property(e => e.ExtendedDiscount).HasColumnType("money");

                entity.Property(e => e.ExtendedNetCost).HasColumnType("money");

                entity.Property(e => e.ExtendedPrice).HasColumnType("money");

                entity.Property(e => e.ExtendedPriceDiscount).HasColumnType("money");

                entity.Property(e => e.ExtendedSalesTax).HasColumnType("money");

                entity.Property(e => e.ExtendedStampTax).HasColumnType("money");

                entity.Property(e => e.FreeItemOid).HasColumnName("FreeItemOID");

                entity.Property(e => e.FreeOverrideUnitNetCost).HasColumnType("money");

                entity.Property(e => e.ItemInventoryTransOid).HasColumnName("ItemInventoryTransOID");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.LineTotal).HasColumnType("money");

                entity.Property(e => e.Message1)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Message2)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Message3)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Message4)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Message5)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OverrideUnitNetCost).HasColumnType("money");

                entity.Property(e => e.OverrideUnitPrice).HasColumnType("money");

                entity.Property(e => e.PoreasonOid).HasColumnName("POReasonOID");

                entity.Property(e => e.PurchaseOrderOid).HasColumnName("PurchaseOrderOID");

                entity.Property(e => e.TaxStampOid).HasColumnName("TaxStampOID");

                entity.Property(e => e.UnitDiscount).HasColumnType("money");

                entity.Property(e => e.UnitNetCost).HasColumnType("money");

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<PurchaseOrderSalesTax>(entity =>
            {
                entity.HasKey(e => new { e.PurchaseOrderOid, e.TaxAuthOid, e.RatePercentage })
                    .HasName("IxPurchaseOrderOIDAuth")
                    .IsClustered(false);

                entity.ToTable("PurchaseOrderSalesTax", "cdr");

                entity.Property(e => e.PurchaseOrderOid).HasColumnName("PurchaseOrderOID");

                entity.Property(e => e.TaxAuthOid).HasColumnName("TaxAuthOID");

                entity.Property(e => e.RatePercentage).HasColumnType("money");

                entity.Property(e => e.PercentageAmount).HasColumnType("money");

                entity.Property(e => e.RateAmount).HasColumnType("money");

                entity.Property(e => e.TaxCollected).HasColumnType("money");
            });

            modelBuilder.Entity<Qbcustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QBCustomer", "cdr");

                entity.Property(e => e.AltPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillTo4)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.BillTo5)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAttention)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToStateOid).HasColumnName("BillToStateOID");

                entity.Property(e => e.BillToZipCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipTo4)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ShipTo5)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAttention)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToStateOid).HasColumnName("ShipToStateOID");

                entity.Property(e => e.ShipToZipCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Qbitem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QBItem", "cdr");

                entity.Property(e => e.Category)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Class)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Item)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ListPrice).HasColumnType("money");

                entity.Property(e => e.NetCost).HasColumnType("money");

                entity.Property(e => e.Unit1Um)
                    .HasColumnName("Unit1UM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Unit2Um)
                    .HasColumnName("Unit2UM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Unit3Um)
                    .HasColumnName("Unit3UM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RemoteOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RemoteOrder", "cdr");

                entity.Property(e => e.Created)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CustNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(23)
                    .IsUnicode(false);

                entity.Property(e => e.ObjId)
                    .HasColumnName("ObjID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Po)
                    .IsRequired()
                    .HasColumnName("PO")
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrderOid).HasColumnName("SalesOrderOID");

                entity.Property(e => e.ShipTo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Srnum)
                    .IsRequired()
                    .HasColumnName("SRNum")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Zeros)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RemoteOrderLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RemoteOrderLine", "cdr");

                entity.Property(e => e.Cr)
                    .IsRequired()
                    .HasColumnName("CR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Qty)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RemoteOrderOid).HasColumnName("RemoteOrderOID");

                entity.Property(e => e.Sign)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Upc)
                    .IsRequired()
                    .HasColumnName("UPC")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Zeros)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportFormat>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxReportFormatOID")
                    .IsClustered(false);

                entity.ToTable("ReportFormat", "cdr");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DistributorSiteId)
                    .HasColumnName("DistributorSiteID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastEndDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ReportFormatAddIns>(entity =>
            {
                entity.HasKey(e => new { e.FormatOid, e.FormatSeq })
                    .HasName("IxReportFormatOIDSeq")
                    .IsClustered(false);

                entity.ToTable("ReportFormatAddIns", "cdr");

                entity.Property(e => e.FormatOid).HasColumnName("FormatOID");

                entity.Property(e => e.Udaoid).HasColumnName("UDAOID");
            });

            modelBuilder.Entity<ReportFormatCategory>(entity =>
            {
                entity.HasKey(e => new { e.FormatOid, e.CategoryOid })
                    .HasName("IxReportFormatOIDCat")
                    .IsClustered(false);

                entity.ToTable("ReportFormatCategory", "cdr");

                entity.Property(e => e.FormatOid).HasColumnName("FormatOID");

                entity.Property(e => e.CategoryOid).HasColumnName("CategoryOID");
            });

            modelBuilder.Entity<ReportFormatMnfr>(entity =>
            {
                entity.HasKey(e => new { e.FormatOid, e.Manufacturer })
                    .HasName("IxReportFormatOIDMnfr")
                    .IsClustered(false);

                entity.ToTable("ReportFormatMnfr", "cdr");

                entity.Property(e => e.FormatOid).HasColumnName("FormatOID");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesOrder>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxSalesOrderObjID")
                    .IsClustered(false);

                entity.ToTable("SalesOrder", "cdr");

                entity.HasIndex(e => new { e.Status, e.ObjId })
                    .HasName("IxSalesOrderC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.AdjustedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BillToAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAttention)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToStateOid).HasColumnName("BillToStateOID");

                entity.Property(e => e.BillToZipCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeAmount).HasColumnType("money");

                entity.Property(e => e.CustomerOid).HasColumnName("CustomerOID");

                entity.Property(e => e.CustomerPonumber)
                    .HasColumnName("CustomerPONumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultCreditReasonOid).HasColumnName("DefaultCreditReasonOID");

                entity.Property(e => e.DefaultTaxStampOid).HasColumnName("DefaultTaxStampOID");

                entity.Property(e => e.DeliveryRouteOid).HasColumnName("DeliveryRouteOID");

                entity.Property(e => e.Edidate)
                    .HasColumnName("EDIDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoicedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastPricedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OrderedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PaidDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PaymentTermOid).HasColumnName("PaymentTermOID");

                entity.Property(e => e.PickedBy)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PickedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PostedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PricingGroupOid).HasColumnName("PricingGroupOID");

                entity.Property(e => e.ReferencedOrderOid).HasColumnName("ReferencedOrderOID");

                entity.Property(e => e.RequestedDeliveryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SalesRepOid).HasColumnName("SalesRepOID");

                entity.Property(e => e.ShiftOid).HasColumnName("ShiftOID");

                entity.Property(e => e.ShipToAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAttention)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToStateOid).HasColumnName("ShipToStateOID");

                entity.Property(e => e.ShipToZipCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.TaxJurisdictionOid).HasColumnName("TaxJurisdictionOID");

                entity.Property(e => e.TenderAmount).HasColumnType("money");

                entity.Property(e => e.TenderCheckNum)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.TotalActualCost).HasColumnType("money");

                entity.Property(e => e.TotalCharges).HasColumnType("money");

                entity.Property(e => e.TotalDiscount).HasColumnType("money");

                entity.Property(e => e.TotalNetCost).HasColumnType("money");

                entity.Property(e => e.TotalOrder).HasColumnType("money");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.TotalPriceChanges).HasColumnType("money");

                entity.Property(e => e.TotalRebates).HasColumnType("money");

                entity.Property(e => e.TotalSalesTax).HasColumnType("money");
            });

            modelBuilder.Entity<SalesOrderLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SalesOrderLine", "cdr");

                entity.HasIndex(e => new { e.SalesOrderOid, e.LineNum })
                    .HasName("IxSalesOrderLineC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.CategoryOid).HasColumnName("CategoryOID");

                entity.Property(e => e.CityAuthOid).HasColumnName("CityAuthOID");

                entity.Property(e => e.CityAuthTax).HasColumnType("money");

                entity.Property(e => e.ClassOid).HasColumnName("ClassOID");

                entity.Property(e => e.CountyAuthOid).HasColumnName("CountyAuthOID");

                entity.Property(e => e.CountyAuthTax).HasColumnType("money");

                entity.Property(e => e.CreditReasonOid).HasColumnName("CreditReasonOID");

                entity.Property(e => e.Description)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ExtendedActualCost).HasColumnType("money");

                entity.Property(e => e.ExtendedDiscount).HasColumnType("money");

                entity.Property(e => e.ExtendedNetCost).HasColumnType("money");

                entity.Property(e => e.ExtendedPrice).HasColumnType("money");

                entity.Property(e => e.ExtendedPriceDiscount).HasColumnType("money");

                entity.Property(e => e.ExtendedSalesTax).HasColumnType("money");

                entity.Property(e => e.ExtendedStampTax).HasColumnType("money");

                entity.Property(e => e.FreeItemInventoryTransOid).HasColumnName("FreeItemInventoryTransOID");

                entity.Property(e => e.FreeItemOid).HasColumnName("FreeItemOID");

                entity.Property(e => e.FreeOverrideUnitNetCost).HasColumnType("money");

                entity.Property(e => e.ItemInventoryTransOid).HasColumnName("ItemInventoryTransOID");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.LineTotal).HasColumnType("money");

                entity.Property(e => e.Message1)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Message2)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Message3)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Message4)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Message5)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OtherAuthOid).HasColumnName("OtherAuthOID");

                entity.Property(e => e.OtherAuthTax).HasColumnType("money");

                entity.Property(e => e.OverrideUnitNetCost).HasColumnType("money");

                entity.Property(e => e.OverrideUnitPrice).HasColumnType("money");

                entity.Property(e => e.SalesOrderOid).HasColumnName("SalesOrderOID");

                entity.Property(e => e.SellingAllowanceOid).HasColumnName("SellingAllowanceOID");

                entity.Property(e => e.SellingContractOid).HasColumnName("SellingContractOID");

                entity.Property(e => e.StateAuthOid).HasColumnName("StateAuthOID");

                entity.Property(e => e.StateAuthTax).HasColumnType("money");

                entity.Property(e => e.SubstItemInventoryTransOid).HasColumnName("SubstItemInventoryTransOID");

                entity.Property(e => e.SubstituteItemOid).HasColumnName("SubstituteItemOID");

                entity.Property(e => e.SubstituteOverrideUnitNetCost).HasColumnType("money");

                entity.Property(e => e.SubstituteOverrideUnitPrice).HasColumnType("money");

                entity.Property(e => e.TaxStampOid).HasColumnName("TaxStampOID");

                entity.Property(e => e.TaxTypeOid).HasColumnName("TaxTypeOID");

                entity.Property(e => e.UnitDiscount).HasColumnType("money");

                entity.Property(e => e.UnitNetCost).HasColumnType("money");

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<SalesOrderLineTax>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxSalesOrderLineTaxObjID")
                    .IsClustered(false);

                entity.ToTable("SalesOrderLineTax", "cdr");

                entity.HasIndex(e => new { e.DateSold, e.TaxAuthorityOid, e.TaxTypeOid })
                    .HasName("IxSalesOrderLineTaxIndex");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.CustomerOid).HasColumnName("CustomerOID");

                entity.Property(e => e.DateSold).HasColumnType("datetime");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.SalesOrderOid).HasColumnName("SalesOrderOID");

                entity.Property(e => e.TaxAmount).HasColumnType("money");

                entity.Property(e => e.TaxAuthorityOid).HasColumnName("TaxAuthorityOID");

                entity.Property(e => e.TaxTypeOid).HasColumnName("TaxTypeOID");

                entity.Property(e => e.TaxableAmount).HasColumnType("money");
            });

            modelBuilder.Entity<SalesOrderMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SalesOrderMessage", "cdr");

                entity.Property(e => e.Message)
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrderOid).HasColumnName("SalesOrderOID");
            });

            modelBuilder.Entity<SalesOrderSalesTax>(entity =>
            {
                entity.HasKey(e => new { e.SalesOrderOid, e.TaxAuthOid, e.RatePercentage })
                    .HasName("IxSalesOrderOIDAuth")
                    .IsClustered(false);

                entity.ToTable("SalesOrderSalesTax", "cdr");

                entity.Property(e => e.SalesOrderOid).HasColumnName("SalesOrderOID");

                entity.Property(e => e.TaxAuthOid).HasColumnName("TaxAuthOID");

                entity.Property(e => e.RatePercentage).HasColumnType("money");

                entity.Property(e => e.PercentageAmount).HasColumnType("money");

                entity.Property(e => e.RateAmount).HasColumnType("money");

                entity.Property(e => e.TaxCollected).HasColumnType("money");
            });

            modelBuilder.Entity<SalesRep>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxSalesRepObjID")
                    .IsClustered(false);

                entity.ToTable("SalesRep", "cdr");

                entity.HasIndex(e => e.Code)
                    .HasName("IxSalesRepCode")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.Code })
                    .HasName("IxSalesRepC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateOid).HasColumnName("StateOID");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScanCode>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxSCObjID")
                    .IsClustered(false);

                entity.ToTable("ScanCode", "cdr");

                entity.HasIndex(e => e.ScanCode1)
                    .HasName("IxSCScanCode")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.ScanCode1)
                    .IsRequired()
                    .HasColumnName("ScanCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SellingAllowance>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxSellingAllowanceObjID")
                    .IsClustered(false);

                entity.ToTable("SellingAllowance", "cdr");

                entity.HasIndex(e => e.Description)
                    .HasName("IxSellingAllowanceDescr")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Amount1).HasColumnType("money");

                entity.Property(e => e.Amount2).HasColumnType("money");

                entity.Property(e => e.Amount3).HasColumnType("money");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FreeItemOid).HasColumnName("FreeItemOID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.WhatCid).HasColumnName("WhatCID");

                entity.Property(e => e.WhatOid).HasColumnName("WhatOID");

                entity.Property(e => e.WhoCid).HasColumnName("WhoCID");

                entity.Property(e => e.WhoOid).HasColumnName("WhoOID");
            });

            modelBuilder.Entity<SellingContract>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxSellingContractObjID")
                    .IsClustered(false);

                entity.ToTable("SellingContract", "cdr");

                entity.HasIndex(e => new { e.PricingGroupOid, e.WhatCid, e.WhatOid, e.RestrictToUnit })
                    .HasName("IxSellingContractWhoWhat");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CalculateAfterTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.PricingGroupOid).HasColumnName("PricingGroupOID");

                entity.Property(e => e.WhatCid).HasColumnName("WhatCID");

                entity.Property(e => e.WhatOid).HasColumnName("WhatOID");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxShiftObjID")
                    .IsClustered(false);

                entity.ToTable("Shift", "cdr");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.DateOfShift).HasColumnType("smalldatetime");

                entity.Property(e => e.EndingCash).HasColumnType("money");

                entity.Property(e => e.EndingCheckAmount).HasColumnType("money");

                entity.Property(e => e.EndingCreditCardAmount).HasColumnType("money");

                entity.Property(e => e.EndingDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.EndingOnAccountAmount).HasColumnType("money");

                entity.Property(e => e.StartingCash).HasColumnType("money");

                entity.Property(e => e.StartingDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.SystemUserOid).HasColumnName("SystemUserOID");

                entity.Property(e => e.UserEndingCash).HasColumnType("money");

                entity.Property(e => e.UserEndingCheckAmount).HasColumnType("money");

                entity.Property(e => e.UserEndingCreditCardAmount).HasColumnType("money");

                entity.Property(e => e.UserEndingOnAccountAmount).HasColumnType("money");
            });

            modelBuilder.Entity<Sldatabase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SLDatabase", "cdr");

                entity.Property(e => e.DatabaseName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dbversion)
                    .HasColumnName("DBVersion")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ObjId)
                    .HasColumnName("ObjID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Slupdate>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxSLUpdateOjID")
                    .IsClustered(false);

                entity.ToTable("SLUpdate", "cdr");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Completed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Finished).HasColumnType("datetime");

                entity.Property(e => e.Severity).HasDefaultValueSql("((1))");

                entity.Property(e => e.Started).HasColumnType("datetime");

                entity.Property(e => e.UpdateId).HasColumnName("UpdateID");

                entity.Property(e => e.UpdateName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Soexpense>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxSOExpObjID")
                    .IsClustered(false);

                entity.ToTable("SOExpense", "cdr");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxStateObjID")
                    .IsClustered(false);

                entity.ToTable("State", "cdr");

                entity.HasIndex(e => e.Code)
                    .HasName("IxStateCode")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("IxStateName")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.Code })
                    .HasName("IxStateC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemNotification>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxSysNotificationOjID")
                    .IsClustered(false);

                entity.ToTable("SystemNotification", "cdr");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.AcknowledgedByUserOid).HasColumnName("AcknowledgedByUserOID");

                entity.Property(e => e.AcknowledgedDate).HasColumnType("datetime");

                entity.Property(e => e.Command)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByAppFunction)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByApplication)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByProgramMethod)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBySystemName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUserOid).HasColumnName("CreatedByUserOID");

                entity.Property(e => e.CreatedByVersion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationSystemName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationUserOid).HasColumnName("DestinationUserOID");

                entity.Property(e => e.DetailedMessage)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ForcedClearDate).HasColumnType("datetime");

                entity.Property(e => e.IdForProgram)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReAcknowledgeDays).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.SentToCdr).HasColumnName("SentToCDR");

                entity.Property(e => e.Started).HasColumnType("datetime");

                entity.Property(e => e.StepsToTake)
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemOption>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SystemOption", "cdr");

                entity.HasIndex(e => e.OptionId)
                    .HasName("IxSystemOptionID")
                    .IsUnique();

                entity.Property(e => e.OptionId).HasColumnName("OptionID");

                entity.Property(e => e.Value)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemUser>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxSystemUserObjID")
                    .IsClustered(false);

                entity.ToTable("SystemUser", "cdr");

                entity.HasIndex(e => e.UserName)
                    .HasName("IxSystemUserName")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.UserName })
                    .HasName("IxSystemUserC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMailAddress")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaxAuthority>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxTaxAuthorityObjID")
                    .IsClustered(false);

                entity.ToTable("TaxAuthority", "cdr");

                entity.HasIndex(e => e.Name)
                    .HasName("IxTaxAuthorityName")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaxJurisdiction>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxTaxJurisdictionObjID")
                    .IsClustered(false);

                entity.ToTable("TaxJurisdiction", "cdr");

                entity.HasIndex(e => e.Description)
                    .HasName("IxTaxJurisdictionDescr")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.Description })
                    .HasName("IxTaxJurisdictionC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.CityTaxAuthOid).HasColumnName("CityTaxAuthOID");

                entity.Property(e => e.CountyTaxAuthOid).HasColumnName("CountyTaxAuthOID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.OtherTaxAuthOid).HasColumnName("OtherTaxAuthOID");

                entity.Property(e => e.StateTaxAuthOid).HasColumnName("StateTaxAuthOID");

                entity.Property(e => e.TaxStampOid).HasColumnName("TaxStampOID");
            });

            modelBuilder.Entity<TaxJurisdictionType>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxTaxJurisdictionTypeObjID")
                    .IsClustered(false);

                entity.ToTable("TaxJurisdictionType", "cdr");

                entity.HasIndex(e => new { e.TaxJurisdictionOid, e.TaxTypeOid })
                    .HasName("IxTaxJurisdictionTypeKey")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.TaxJurisdictionOid).HasColumnName("TaxJurisdictionOID");

                entity.Property(e => e.TaxTypeOid).HasColumnName("TaxTypeOID");
            });

            modelBuilder.Entity<TaxRate>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxTaxRateObjID")
                    .IsClustered(false);

                entity.ToTable("TaxRate", "cdr");

                entity.HasIndex(e => new { e.TaxAuthorityOid, e.GroupingCid, e.GroupingOid, e.TaxTypeOid })
                    .HasName("IxTaxRateKey")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.GroupingCid).HasColumnName("GroupingCID");

                entity.Property(e => e.GroupingOid).HasColumnName("GroupingOID");

                entity.Property(e => e.PercentageOf).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.TaxAuthorityOid).HasColumnName("TaxAuthorityOID");

                entity.Property(e => e.TaxTypeOid).HasColumnName("TaxTypeOID");
            });

            modelBuilder.Entity<TaxStamp>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxTaxStampObjID")
                    .IsClustered(false);

                entity.ToTable("TaxStamp", "cdr");

                entity.HasIndex(e => e.Description)
                    .HasName("IxTaxStampDescr")
                    .IsUnique();

                entity.HasIndex(e => e.ObjId)
                    .HasName("IxTaxStampC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.TaxStampItem1Oid).HasColumnName("TaxStampItem1OID");

                entity.Property(e => e.TaxStampItem2Oid).HasColumnName("TaxStampItem2OID");

                entity.Property(e => e.TaxStampItem3Oid).HasColumnName("TaxStampItem3OID");

                entity.Property(e => e.TaxStampItem4Oid).HasColumnName("TaxStampItem4OID");
            });

            modelBuilder.Entity<TaxStampDenom>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxTSDenomObjID")
                    .IsClustered(false);

                entity.ToTable("TaxStampDenom", "cdr");

                entity.HasIndex(e => e.Description)
                    .HasName("IxTSDenomDesc")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaxStampItem>(entity =>
            {
                entity.HasKey(e => new { e.TaxStampOid, e.TaxStampDenomOid })
                    .HasName("IxTSoidTSDoid")
                    .IsClustered(false);

                entity.ToTable("TaxStampItem", "cdr");

                entity.Property(e => e.TaxStampOid).HasColumnName("TaxStampOID");

                entity.Property(e => e.TaxStampDenomOid).HasColumnName("TaxStampDenomOID");

                entity.Property(e => e.Item1Oid).HasColumnName("Item1OID");

                entity.Property(e => e.Item2Oid).HasColumnName("Item2OID");

                entity.Property(e => e.Item3Oid).HasColumnName("Item3OID");

                entity.Property(e => e.Item4Oid).HasColumnName("Item4OID");
            });

            modelBuilder.Entity<TaxType>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxTaxTypeObjID")
                    .IsClustered(false);

                entity.ToTable("TaxType", "cdr");

                entity.HasIndex(e => e.Description)
                    .HasName("IxTaxTypeDescr")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Uda>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxUDAObjID")
                    .IsClustered(false);

                entity.ToTable("UDA", "cdr");

                entity.HasIndex(e => e.Name)
                    .HasName("IxUDAName")
                    .IsUnique();

                entity.HasIndex(e => new { e.TypeCid, e.Sequence })
                    .HasName("IxUDATypeSequence")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.MaxValue).HasColumnType("decimal(14, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCid).HasColumnName("TypeCID");
            });

            modelBuilder.Entity<UdaobjectValue>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxUDAOVObjID")
                    .IsClustered(false);

                entity.ToTable("UDAObjectValue", "cdr");

                entity.HasIndex(e => new { e.ObjectOid, e.Udaoid, e.TypeCid })
                    .HasName("IxUDAOVObjectOIDUDAOIDTypeCID")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.ObjectOid).HasColumnName("ObjectOID");

                entity.Property(e => e.TypeCid).HasColumnName("TypeCID");

                entity.Property(e => e.Udaoid).HasColumnName("UDAOID");

                entity.Property(e => e.Udavalue)
                    .HasColumnName("UDAValue")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UdavalueOid).HasColumnName("UDAValueOID");
            });

            modelBuilder.Entity<Udavalue>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxUDAVObjID")
                    .IsClustered(false);

                entity.ToTable("UDAValue", "cdr");

                entity.HasIndex(e => new { e.Udaoid, e.Name })
                    .HasName("IxUDAVUDAOIDName")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Udaoid).HasColumnName("UDAOID");
            });

            modelBuilder.Entity<UnitSurcharge>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxUnitSurchargeObjID")
                    .IsClustered(false);

                entity.ToTable("UnitSurcharge", "cdr");

                entity.HasIndex(e => new { e.PricingGroupOid, e.WhatCid, e.WhatOid })
                    .HasName("IxUnitSurchargeWhoWhat");

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Amount1).HasColumnType("money");

                entity.Property(e => e.Amount2).HasColumnType("money");

                entity.Property(e => e.Amount3).HasColumnType("money");

                entity.Property(e => e.Amount4).HasColumnType("money");

                entity.Property(e => e.PricingGroupOid).HasColumnName("PricingGroupOID");

                entity.Property(e => e.WhatCid).HasColumnName("WhatCID");

                entity.Property(e => e.WhatOid).HasColumnName("WhatOID");
            });

            modelBuilder.Entity<UpdateCustomerInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UpdateCustomerInfo", "cdr");

                entity.Property(e => e.CustomerNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FtpsiteAddress1)
                    .HasColumnName("FTPSiteAddress1")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.FtpsiteAddress2)
                    .HasColumnName("FTPSiteAddress2")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LicenseExpirationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateInstalled)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxVendorObjID")
                    .IsClustered(false);

                entity.ToTable("Vendor", "cdr");

                entity.HasIndex(e => e.Code)
                    .HasName("IxVendorCode")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("IxVendorName")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.Code })
                    .HasName("IxVendorC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.AccountNum)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Attention)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryFri).HasDefaultValueSql("((1))");

                entity.Property(e => e.DeliveryMon).HasDefaultValueSql("((1))");

                entity.Property(e => e.DeliverySat).HasDefaultValueSql("((1))");

                entity.Property(e => e.DeliverySun).HasDefaultValueSql("((1))");

                entity.Property(e => e.DeliveryThu).HasDefaultValueSql("((1))");

                entity.Property(e => e.DeliveryTue).HasDefaultValueSql("((1))");

                entity.Property(e => e.DeliveryWed).HasDefaultValueSql("((1))");

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FreightTerms)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LeadDays).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAttention)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToStateOid).HasColumnName("ShipToStateOID");

                entity.Property(e => e.ShipToZipCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.StateOid).HasColumnName("StateOID");

                entity.Property(e => e.UpdateFromPo)
                    .HasColumnName("UpdateFromPO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.VendorBuyer)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.VendorGroup)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.VendorPaymentTermOid).HasColumnName("VendorPaymentTermOID");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VendorPaymentTerm>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxVendorPaymentTermObjID")
                    .IsClustered(false);

                entity.ToTable("VendorPaymentTerm", "cdr");

                entity.HasIndex(e => e.Code)
                    .HasName("IxVendorPaymentTermCode")
                    .IsUnique();

                entity.HasIndex(e => e.Description)
                    .HasName("IxVendorPaymentTermDescr")
                    .IsUnique();

                entity.HasIndex(e => new { e.ObjId, e.Code })
                    .HasName("IxVendorPaymentTermC")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountPercent).HasColumnType("money");
            });

            modelBuilder.Entity<WeeklyCategorySales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxWeeklyCategorySalesOjID")
                    .IsClustered(false);

                entity.ToTable("WeeklyCategorySales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Week, e.CategoryOid })
                    .HasName("IxWeeklyCategorySales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.CategoryOid).HasColumnName("CategoryOID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");
            });

            modelBuilder.Entity<WeeklyClassSales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxWeeklyClassSalesOjID")
                    .IsClustered(false);

                entity.ToTable("WeeklyClassSales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Week, e.ClassOid })
                    .HasName("IxWeeklyClassSales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.ClassOid).HasColumnName("ClassOID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");
            });

            modelBuilder.Entity<WeeklyCustomerSales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxWeeklyCustomerSalesOjID")
                    .IsClustered(false);

                entity.ToTable("WeeklyCustomerSales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Week, e.CustomerOid })
                    .HasName("IxWeeklyCustomerSales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.CustomerOid).HasColumnName("CustomerOID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");
            });

            modelBuilder.Entity<WeeklyItemSales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxWeeklyItemSalesOjID")
                    .IsClustered(false);

                entity.ToTable("WeeklyItemSales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Week, e.ItemOid, e.TaxStampOid })
                    .HasName("IxWeeklyItemSales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.TaxStampOid)
                    .HasColumnName("TaxStampOID")
                    .HasDefaultValueSql("((2))");
            });

            modelBuilder.Entity<WeeklySales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxWeeklySalesOjID")
                    .IsClustered(false);

                entity.ToTable("WeeklySales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Week, e.CustomerOid, e.ItemOid, e.TaxStampOid, e.CategoryOid, e.ClassOid, e.ManufacturerOid, e.BrandOid, e.SalesRepOid })
                    .HasName("IxWeeklySales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.BrandOid).HasColumnName("BrandOID");

                entity.Property(e => e.CategoryOid).HasColumnName("CategoryOID");

                entity.Property(e => e.ClassOid).HasColumnName("ClassOID");

                entity.Property(e => e.CustomerOid).HasColumnName("CustomerOID");

                entity.Property(e => e.ItemOid).HasColumnName("ItemOID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ManufacturerOid).HasColumnName("ManufacturerOID");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesRepOid).HasColumnName("SalesRepOID");

                entity.Property(e => e.TaxStampOid)
                    .HasColumnName("TaxStampOID")
                    .HasDefaultValueSql("((2))");
            });

            modelBuilder.Entity<WeeklySalesRepSales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxWeeklySalesRepSalesOjID")
                    .IsClustered(false);

                entity.ToTable("WeeklySalesRepSales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Week, e.SalesRepOid })
                    .HasName("IxWeeklySalesRepSales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesRepOid).HasColumnName("SalesRepOID");
            });

            modelBuilder.Entity<WeeklybrandSales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxWeeklybrandSalesOjID")
                    .IsClustered(false);

                entity.ToTable("WeeklybrandSales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Week, e.BrandOid })
                    .HasName("IxWeeklybrandSales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.BrandOid).HasColumnName("brandOID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");
            });

            modelBuilder.Entity<WeeklymanufacturerSales>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("IxWeeklymanufacturerSalesOjID")
                    .IsClustered(false);

                entity.ToTable("WeeklymanufacturerSales", "cdr");

                entity.HasIndex(e => new { e.Year, e.Week, e.ManufacturerOid })
                    .HasName("IxWeeklymanufacturerSales")
                    .IsUnique();

                entity.Property(e => e.ObjId).HasColumnName("ObjID");

                entity.Property(e => e.LostSalesListPrice).HasColumnType("money");

                entity.Property(e => e.LostSalesNetCost).HasColumnType("money");

                entity.Property(e => e.LostSalesQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.ManufacturerOid).HasColumnName("manufacturerOID");

                entity.Property(e => e.ObjModified)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnsActualCost).HasColumnType("money");

                entity.Property(e => e.ReturnsNetCost).HasColumnType("money");

                entity.Property(e => e.ReturnsPrice).HasColumnType("money");

                entity.Property(e => e.ReturnsQty).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.SalesActualCost).HasColumnType("money");

                entity.Property(e => e.SalesNetCost).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesQty).HasColumnType("decimal(12, 4)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public List<WeeklySalesResult> GetWeklySales()
        {
            // grab the query from the database
            var query = WeeklyItemSales.Where(d => d.Week == 49 && d.Year == 2018).Join(
                Item,
                weekly => weekly.ItemOid,
                item => item.ObjId,
                (weekly, item) => new
                {
                    weekly.Week,
                    Qty = weekly.SalesQty,
                    item.Name
                }
                ).GroupBy(o => new { o.Name, o.Week, o.Qty })
                .Select(g => new
                {
                    g.Key.Name,
                    g.Key.Week,
                    Qty = g.Key,
                    Total = g.Sum(i => i.Qty)
                });
            // make temporary variable to store the transformed DB values
            List<WeeklySalesResult> _results = new List<WeeklySalesResult>();
            // loop thru the query results and transform them into salesResults
            foreach (var result in query)
            {
                WeeklySalesResult r = new WeeklySalesResult()
                {
                    Week = result.Week,
                    Name = result.Name,
                    Qty = (decimal)result.Total
                };
                _results.Add(r);
            }
            return _results;
        }
#nullable enable
        public WeeklySalesResult? GetWeeklyItemSales(int Id, int Week)
        {
            // make query using the wonderufl LINQ
            var _itemSalesQuery =
                from item in Item
                join weeklySales in WeeklyItemSales on item.ObjId equals weeklySales.ItemOid
                where weeklySales.Week == Week && weeklySales.Year == 2019 && item.Num == Id
                select new { Name = item.Name, Quantity = weeklySales.SalesQty, Week = weeklySales.Week, Year = weeklySales.Year };

            // make temporary variable to store the transformed DB values
            List<WeeklySalesResult> _results = new List<WeeklySalesResult>();
            WeeklySalesResult result = new WeeklySalesResult();

            //loop thru the query results and transform them into salesResults
            foreach (var res in _itemSalesQuery)
            {
                WeeklySalesResult r = new WeeklySalesResult()
                {
                    Week = res.Week,
                    Name = res.Name,
                    Qty = res.Quantity
                };
                _results.Add(r);
            }
            if (_results.Count != 0)
            {
                return _results.FirstOrDefault();

            }
            else
            {
                return null;
            }
        }
#nullable disable
        public static int GetPreviousWeek()
        {
            // Gets the Calendar instance associated with a CultureInfo.
            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;

            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

            int Week = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);
            Console.WriteLine("The current week is Week {0} of the current year.", myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW));

            return Week - 1;
        }

        public string GetRepName(int RepID)
        {
            var RepResult =
                from rep in SalesRep
                where rep.ObjId == RepID
                select new { rep.FirstName };

            return RepResult.FirstOrDefault().FirstName;
        }

        public int? GetOnHandQuantity(int Sku)
        {

            var QtyResult =
                    from item in Item
                    join onHand in ItemInventoryOnHand on item.ObjId equals onHand.ItemOid
                    where item.Num == Sku
                    select new { onHand.QuantityRemaining };
            var MultiplierResult =
                    from item in Item
                    where item.Num == Sku
                    select new { item.StdSellUnit };

            int QtyRemaining = QtyResult.Select(c => c.QuantityRemaining).Sum();
            byte? StdSellUnit = MultiplierResult.Select(c => c.StdSellUnit).FirstOrDefault();
            switch (StdSellUnit)
            {
                case 1:
                    var Unit1Result =
                        from item in Item
                        where item.Num == Sku
                        select new { item.Unit1Multiplier, item.ObjId };
                    return QtyRemaining / Unit1Result.FirstOrDefault().Unit1Multiplier - GetDailyItemSales(Unit1Result.FirstOrDefault().ObjId);
                case 2:
                    var Unit2Result =
                        from item in Item
                        where item.Num == Sku
                        select new { item.Unit2Multiplier, item.ObjId };
                    return QtyRemaining / Unit2Result.FirstOrDefault().Unit2Multiplier - GetDailyItemSales(Unit2Result.FirstOrDefault().ObjId);
                case 3:
                    var Unit3Result =
                        from item in Item
                        where item.Num == Sku
                        select new { item.Unit3Multiplier, item.ObjId };
                    return QtyRemaining / Unit3Result.FirstOrDefault().Unit3Multiplier - GetDailyItemSales(Unit3Result.FirstOrDefault().ObjId);
                case 4:
                    var Unit4Result =
                        from item in Item
                        where item.Num == Sku
                        select new { item.Unit4Multiplier, item.ObjId };
                    return QtyRemaining / Unit4Result.FirstOrDefault().Unit4Multiplier - GetDailyItemSales(Unit4Result.FirstOrDefault().ObjId);
                default:
                    return 0;
            }
        }

        public static int GetCurrentWeekNumber()
        {
            // Gets the Calendar instance associated with a CultureInfo.
            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;

            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

            int Week = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);
            Console.WriteLine("The current week is Week {0} of the current year.", myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW));

            return Week;

        }

        public bool CheckIfItemNeedsOrdering(int ItemId)
        {
#nullable enable
            // get the previous week
            int previousWeek = GetPreviousWeek();
            // pass the previous week into the function to check the weekly sales for the
            // previous week. Sometimes this returns null if no sales were made.
            WeeklySalesResult? previousWeekItemSales = GetWeeklyItemSales(ItemId, previousWeek);
            // get the current on-hand quantity for the item
            int? onHandQty = GetOnHandQuantity(ItemId);
#nullable disable

            // logic to determine if the item needs to be ordered.
            // first, we need to handle if the previous week had no sales and returned null
            if (previousWeekItemSales != null)
            {
                if (onHandQty < previousWeekItemSales.Qty) // if the onHand is less than what we sold last week, then:
                {
                    // item needs to be ordered
                    return true;
                }
                else
                {
                    // there is enough stock to keep going
                    return false;
                }
            }
            else // if there were no previous sales
            {
                return false;
            }

        }

        public List<LowStockResult> GetLowStockWarnings()
        {
            List<Item> _items = Item.ToList();
            List<LowStockResult> _lowStockResults = new List<LowStockResult>();
            // loop over each item and see if it needs to be ordered.
            foreach (Item i in _items)
            {
                bool _needsOrdering = CheckIfItemNeedsOrdering(i.Num);
                int? onHandQty = GetOnHandQuantity(i.Num);
                WeeklySalesResult prevWeekSales = GetWeeklyItemSales(i.Num, GetPreviousWeek());
                _lowStockResults.Add(new LowStockResult
                {
                    Name = i.Name,
                    needsOrdering = _needsOrdering,
                    prevWeekSalesQty = prevWeekSales,
                    onHandQty = onHandQty
                });
            }
            return _lowStockResults;
        }

        public List<VendorReportResult> GetVendorReport(int ItemObjID)
        {
            List<VendorReportResult> vendorReportResults = new List<VendorReportResult>();
            var QtyResult =
                    from _PoLine in PurchaseOrderLine
                    join _Po in PurchaseOrder on _PoLine.PurchaseOrderOid equals _Po.ObjId
                    join _Vend in Vendor on _Po.VendorOid equals _Vend.ObjId
                    where _PoLine.ItemOid == ItemObjID
                    select new { _PoLine.Description, _Po.ReceivedDate, _PoLine.UnitPrice, _Vend.Name };


            foreach (var _result in QtyResult)
            {
                var v = new VendorReportResult()
                {
                    Description = _result.Description,
                    RecievedDate = _result.ReceivedDate,
                    UnitPrice = _result.UnitPrice,
                    VendorName = _result.Name
                };
                vendorReportResults.Add(v);

            }

            return vendorReportResults;
        }

        public List<CustomerLocation> GetCustomerAddresses()
        {
            List<CustomerLocation> customerLocations = new List<CustomerLocation>();
            var _customerLocationQueryResult =
                from _cust in Customer
                select new { _cust.Name, _cust.ShipToAddressLine1, _cust.ShipToCity, _cust.ShipToZipCode, _cust.Num };
            foreach (var Customer in _customerLocationQueryResult)
            {
                CustomerLocation _location = new CustomerLocation()
                {
                    Name = Customer.Name,
                    Street = Customer.ShipToAddressLine1,
                    City = Customer.ShipToCity,
                    Zipcode = Customer.ShipToZipCode,
                    Number = Customer.Num
                };
                customerLocations.Add(_location);
            }

            return customerLocations;
        }

        public decimal? GetCustomerAccountTotal(int CustomerOid)
        {
            decimal? accountTotal = 0;

            var _results =
                from _invoice in SalesOrder
                where _invoice.CustomerOid == CustomerOid
                select new { _invoice.TotalPrice };

            foreach (var invoice in _results)
            {
                accountTotal += invoice.TotalPrice;
            }

            return accountTotal;
        }

        public int GetItemObjIDFromScancode(string scancode)
        {
            char[] charsToTrim = { '[', ']' };
            string pureScancode = scancode.Trim(charsToTrim);

            var _result =
                from _item in Item
                join _Scancode in ScanCode on _item.ObjId equals _Scancode.ItemOid
                where _Scancode.ScanCode1 == pureScancode
                select new { _item.ObjId };

            Debug.WriteLine("Scancode for the item is: " + pureScancode);

            return _result.FirstOrDefault().ObjId;
        }

        public int GetDailyItemSales(int OBJID)
        {
            List<int> todaysItemSales = new List<int>();
            var salesOrderQuery =
                from _salesOrders in SalesOrder
                where _salesOrders.Status == 4 | _salesOrders.Status == 1
                orderby _salesOrders.OrderedDate descending
                select new { _salesOrders.ObjId, _salesOrders.InvoicedDate };

            foreach (var salesOrder in salesOrderQuery.ToList())
            {
                var qtySalesQuery =
                from _salesOrderLines in SalesOrderLine
                where _salesOrderLines.SalesOrderOid == salesOrder.ObjId
                select new { _salesOrderLines.OrderedQty, _salesOrderLines.ItemOid };

                foreach (var orderLine in qtySalesQuery.ToList())
                {
                    if (orderLine.ItemOid == OBJID)
                    {
                        todaysItemSales.Add(orderLine.OrderedQty.Value);
                        Debug.WriteLine("Sold " + orderLine.OrderedQty + " of this item today. (diamond game)");
                    }
                }
            }

            int soldQuantity = 0;

            foreach (var qty in todaysItemSales)
            {
                soldQuantity += qty;
            }

            return soldQuantity;


        }


        public List<InvoiceReportLine> GetInvoiceDetails(int invoiceID)
        {
            List<InvoiceReportLine> Result = new List<InvoiceReportLine>();

            var _invoiceDetails =
                from _lines in SalesOrderLine
                where _lines.SalesOrderOid == invoiceID
                join _items in Item on _lines.ItemOid equals _items.ObjId
                join _cat in Category on _lines.CategoryOid equals _cat.ObjId
                select new { _items.Name, _lines.OrderedQty, _lines.LineTotal, _lines.UnitPrice, _lines.Unit, _lines.UnitNetCost, _lines.CategoryOid, _cat.TobCat, _items.Unit1Um, _items.Unit2Um, _items.Unit3Um, _items.NetCost };

            foreach (var result in _invoiceDetails)
            {
                var _result = new InvoiceReportLine()
                {
                    ItemName = result.Name,
                    OrderQty = result.OrderedQty,
                    LineTotal = result.LineTotal,
                    ItemCatOID = result.CategoryOid,
                    UnitPrice = result.UnitPrice,
                    Unit = result.Unit,
                    UnitNetCost = result.UnitNetCost,
                    NetCost = result.NetCost,
                    itemProfit = ((decimal)result.UnitPrice * (decimal)result.OrderedQty) - ((decimal)result.UnitNetCost * (decimal)result.OrderedQty),
                    isGeneralGoods = IsGeneralGoods(result.TobCat)
                };

                if (_result.Unit == 1)
                {
                    _result.UnitName = result.Unit1Um;
                }
                else if (_result.Unit == 2)
                {
                    _result.UnitName = result.Unit2Um;
                }
                else
                {
                    _result.UnitName = result.Unit3Um;
                }
                Result.Add(_result);
            }
            return Result;
        }

        public bool IsGeneralGoods(string? ItemCat)
        {
            if (ItemCat == "0-None")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<UnPostedInvoiceResult> GetOrdersForDate(DateTime selectedDate)
        {
            Debug.WriteLine(selectedDate);
            List<UnPostedInvoiceResult> results = new List<UnPostedInvoiceResult>();
            var _unPostedResultsList =
                from _custs in Customer
                join _sales in SalesOrder on _custs.ObjId equals _sales.CustomerOid
                where _sales.OrderedDate.Value.Day == selectedDate.Day &&
                      _sales.OrderedDate.Value.Month == selectedDate.Month &&
                      _sales.OrderedDate.Value.Year == selectedDate.Year
                join _reps in SalesRep on _custs.SalesRepOid equals _reps.ObjId
                orderby _sales.OrderedDate descending
                select new { _custs.Num, _custs.Name, _sales.InvoicedDate, _sales.TotalPrice, _sales.TotalActualCost, _sales.ObjId, _reps.FirstName, _reps.MiddleName, _reps.LastName };

            foreach (var result in _unPostedResultsList)
            {
                var _result = new UnPostedInvoiceResult()
                {
                    Name = result.Name,
                    Num = result.Num,
                    InvoicedDate = result.InvoicedDate,
                    TotalPrice = result.TotalPrice,
                    TotalCost = result.TotalActualCost,
                    InvoiceObjID = result.ObjId,
                    RepFirstName = result.FirstName,
                    RepMiddleName = result.MiddleName,
                    RepLastName = result.LastName
                };

                _result.CalculateProfit();
                results.Add(_result);
            }

            Debug.WriteLine(results.Count);
            return results;
        }


        public List<UnPostedInvoiceResult> GetUnPostedOrders()
        {
            List<UnPostedInvoiceResult> results = new List<UnPostedInvoiceResult>();
            var _unPostedResultsList =
                from _custs in Customer
                join _sales in SalesOrder on _custs.ObjId equals _sales.CustomerOid
                where _sales.Status == 4
                join _reps in SalesRep on _custs.SalesRepOid equals _reps.ObjId
                orderby _sales.OrderedDate descending
                select new { _custs.Num, _custs.Name, _sales.InvoicedDate, _sales.TotalPrice, _sales.TotalActualCost, _sales.ObjId, _reps.FirstName, _reps.MiddleName, _reps.LastName };

            foreach (var result in _unPostedResultsList)
            {
                var _result = new UnPostedInvoiceResult()
                {
                    Name = result.Name,
                    Num = result.Num,
                    InvoicedDate = result.InvoicedDate,
                    TotalPrice = result.TotalPrice,
                    TotalCost = result.TotalActualCost,
                    InvoiceObjID = result.ObjId,
                    RepFirstName = result.FirstName,
                    RepMiddleName = result.MiddleName,
                    RepLastName = result.LastName
                };

                _result.CalculateProfit();
                results.Add(_result);
            }

            return results;
        }

        public List<ArResult> GetTransactionType(int transType)
        {
            List<ArResult> results = new List<ArResult>();
            DateTime dateLimit = new DateTime(2021, 1, 1);
            var _transactions =
                from _trans in Artransaction
                where _trans.PaymentType == transType && _trans.Type == 3 && _trans.EntryDate > dateLimit
                join _custs in Customer on _trans.CustomerOid equals _custs.ObjId
                orderby _trans.TransDate descending
                select new
                {
                    _trans.ObjId,
                    _trans.CustomerOid,
                    _trans.TransNum,
                    _trans.Type,
                    _trans.EntryDate,
                    _trans.Status,
                    _trans.TransactionAmount,
                    _trans.SalesOrderOid,
                    _trans.InvoiceNum,
                    _trans.PaymentType,
                    _custs.Name,
                    _custs.Num
                };

            foreach (var result in _transactions)
            {
                var _result = new ArResult()
                {
                    ObjId = result.ObjId,
                    CustomerOid = result.CustomerOid,
                    TransNum = result.TransNum,
                    Type = result.Type,
                    EntryDate = result.EntryDate,
                    Status = result.Status,
                    TransactionAmount = result.TransactionAmount,
                    SalesOrderOid = result.SalesOrderOid,
                    InvoiceNum = result.InvoiceNum,
                    PaymentType = result.PaymentType,
                    CustomerName = result.Name,
                    CustomerNumber = result.Num
                };

                results.Add(_result);
            }

            return results;
        }

        public List<ArResult> GetTransactionsByDate(DateTime date)
        {
            List<ArResult> results = new List<ArResult>();
            var _transactions =
                from _trans in Artransaction
                where _trans.Type == 3 && _trans.EntryDate == date
                join _custs in Customer on _trans.CustomerOid equals _custs.ObjId
                orderby _trans.TransDate descending
                select new
                {
                    _trans.ObjId,
                    _trans.CustomerOid,
                    _trans.TransNum,
                    _trans.Type,
                    _trans.EntryDate,
                    _trans.Status,
                    _trans.TransactionAmount,
                    _trans.SalesOrderOid,
                    _trans.InvoiceNum,
                    _trans.PaymentType,
                    _custs.Name,
                    _custs.Num
                };

            foreach (var result in _transactions)
            {
                var _result = new ArResult()
                {
                    ObjId = result.ObjId,
                    CustomerOid = result.CustomerOid,
                    TransNum = result.TransNum,
                    Type = result.Type,
                    EntryDate = result.EntryDate,
                    Status = result.Status,
                    TransactionAmount = result.TransactionAmount,
                    SalesOrderOid = result.SalesOrderOid,
                    InvoiceNum = result.InvoiceNum,
                    PaymentType = result.PaymentType,
                    CustomerName = result.Name,
                    CustomerNumber = result.Num
                };

                results.Add(_result);
            }

            return results;
        }

        public List<UnPostedInvoiceResult> GetInvoicesByCustomer(int customerNumber)
        {
            List<UnPostedInvoiceResult> results = new List<UnPostedInvoiceResult>();
            var _unPostedResultsList =
                from _custs in Customer
                where _custs.Num == customerNumber
                join _sales in SalesOrder on _custs.ObjId equals _sales.CustomerOid
                join _reps in SalesRep on _custs.SalesRepOid equals _reps.ObjId
                orderby _sales.OrderedDate descending
                select new { _custs.Num, _custs.Name, _sales.InvoicedDate, _sales.TotalPrice, _sales.TotalActualCost, _sales.ObjId, _reps.FirstName, _reps.MiddleName, _reps.LastName };

            foreach (var result in _unPostedResultsList)
            {
                var _result = new UnPostedInvoiceResult()
                {
                    Name = result.Name,
                    Num = result.Num,
                    InvoicedDate = result.InvoicedDate,
                    TotalPrice = result.TotalPrice,
                    TotalCost = result.TotalActualCost,
                    InvoiceObjID = result.ObjId,
                    RepFirstName = result.FirstName,
                    RepMiddleName = result.MiddleName,
                    RepLastName = result.LastName
                };

                _result.CalculateProfit();
                results.Add(_result);
            }

            return results;
        }

        public List<DraftOrdersResult> GetDraftOrders()
        {
            List<DraftOrdersResult> results = new List<DraftOrdersResult>();

            var _draftInvoiceResults =
                from _custs in Customer
                join _sales in SalesOrder on _custs.ObjId equals _sales.CustomerOid
                where _sales.Status == 0
                join _reps in SalesRep on _sales.ObjId equals _reps.ObjId
                orderby _sales.OrderedDate descending
                select new { _custs.Num, _custs.Name, _sales.OrderedDate, _sales.TotalPrice, _sales.ObjId, _reps.FirstName, _reps.LastName, _reps.MiddleName };

            foreach (var result in _draftInvoiceResults)
            {
                var _result = new DraftOrdersResult()
                {
                    Name = result.Name,
                    Num = result.Num,
                    InvoicedDate = result.OrderedDate,
                    TotalPrice = result.TotalPrice,
                    InvoiceObjID = result.ObjId,
                    RepFirstName = result.FirstName,
                    RepMiddleName = result.MiddleName,
                    RepLastName = result.LastName
                };
                results.Add(_result);
            }

            return results;
        }

        public List<UnPostedInvoiceResult> GetPlacedOrders()
        {
            List<UnPostedInvoiceResult> results = new List<UnPostedInvoiceResult>();
            var _unPostedResultsList =
                from _custs in Customer
                join _sales in SalesOrder on _custs.ObjId equals _sales.CustomerOid
                where _sales.Status == 1
                orderby _sales.OrderedDate descending
                select new { _custs.Num, _custs.Name, _sales.OrderedDate, _sales.TotalPrice, _sales.ObjId };

            foreach (var result in _unPostedResultsList)
            {
                var _result = new UnPostedInvoiceResult()
                {
                    Name = result.Name,
                    Num = result.Num,
                    InvoicedDate = result.OrderedDate,
                    TotalPrice = result.TotalPrice,
                    InvoiceObjID = result.ObjId
                };
                results.Add(_result);
            }

            return results;
        }


        public List<CustomerRouteCustomer> GetGetSalesRepCustomers(int repObjId)
        {
            List<CustomerRouteCustomer> customers = new List<CustomerRouteCustomer>();
            var customerQuery =
                from _custs in Customer
                join _reps in SalesRep on _custs.SalesRepOid equals _reps.ObjId
                where _custs.SalesRepOid == repObjId
                orderby _custs.ShipToCity descending
                select new
                {
                    _custs.Num,
                    _custs.Name,
                    _custs.PhoneNumber,
                    _custs.BillToCity,
                    _reps.FirstName,
                    _reps.LastName,
                    _custs.ObjId
                };
            foreach (var cust in customerQuery)
            {
                var tempCustomer = new CustomerRouteCustomer()
                {
                    Num = cust.Num,
                    Name = cust.Name,
                    City = cust.BillToCity,
                    RepFirstName = cust.FirstName,
                    RepLastName = cust.LastName,
                    OID = cust.ObjId
                };
                tempCustomer.PhoneNumber = new List<PhoneNumber>();
                tempCustomer.PhoneNumber.Add(new PhoneNumber() { NumberTitle = "System Number", Number = cust.PhoneNumber });

                customers.Add(tempCustomer);
            }
            return customers;
        }

        public List<CustomerRouteCustomer> GetAllCustomers()
        {
            List<CustomerRouteCustomer> customers = new List<CustomerRouteCustomer>();
            var customerQuery =
                from _custs in Customer
                join _reps in SalesRep on _custs.SalesRepOid equals _reps.ObjId
                orderby _custs.ShipToCity descending
                select new
                {
                    _custs.Num,
                    _custs.Name,
                    _custs.ObjId,
                    _custs.PhoneNumber,
                    _custs.BillToCity,
                    _reps.FirstName,
                    _reps.LastName
                };
            foreach (var cust in customerQuery)
            {
                var tempCustomer = new CustomerRouteCustomer()
                {
                    Num = cust.Num,
                    Name = cust.Name,
                    City = cust.BillToCity,
                    RepFirstName = cust.FirstName,
                    RepLastName = cust.LastName,
                    OID = cust.ObjId
                };
                tempCustomer.PhoneNumber = new List<PhoneNumber>();
                tempCustomer.PhoneNumber.Add(new PhoneNumber() { NumberTitle = "System Number", Number = cust.PhoneNumber });

                customers.Add(tempCustomer);
            }
            return customers;
        }

        public List<SalesRep> GetAllSalesReps()
        {
            List<SalesRep> salesReps = new List<SalesRep>();
            var salesRepQuery =
                from _reps in SalesRep
                orderby _reps.FirstName descending
                select new
                {
                    _reps.FirstName,
                    _reps.LastName,
                    _reps.ObjId
                };
            foreach (var rep in salesRepQuery)
            {
                var tempRep = new SalesRep()
                {
                    ObjId = rep.ObjId,
                    FirstName = rep.FirstName,
                    LastName = rep.LastName
                };

                salesReps.Add(tempRep);
            }
            return salesReps;
        }
    }
}
