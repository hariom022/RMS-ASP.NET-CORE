using Microsoft.EntityFrameworkCore;
using RMS.Models;

namespace RMS.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<InventoryUpdateOverview> InventoryUpdateOverviews { get; set; }
        public DbSet<GoodsReceiptOverview> GoodsReceiptOverview { get;set;}
        public DbSet<OpenRequestReport> OpenRequestReports { get; set;}
        public DbSet<OpenInvoiceConfirmation> OpenInvoiceConfirmations { get; set;}
        //public DbSet<LastConsumptionReport> LastConsumptionReports { get; set;}
        public DbSet<InventoryStatusReport> InventoryStatusReports { get; set;}
        public DbSet<SalesOrderDetails> SalesOrderDetailsReports { get;set;}
        public DbSet<CompletedRequestsReport> CompletedRequestsReports { get; set;}
        public DbSet<QuotationApproval> QuotationApprovals { get; set; }

        public DbSet<Role_Authentication> Role_Authentications { get; set; } 

        public DbSet<MaterialMasterOverview> MaterialMasterOverviews { get; set; }

        public DbSet<Inquiry> Inquiries { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<ConsumptionEntry> ConsumptionEntries { get; set; }

        public DbSet<UserAccount> UserAccounts { get; set; }

        public DbSet<GoodReceiptConfirmation> GoodsReceiptConfirmations { get; set;}

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<InvoiceConfirmation> InvoicesConfirmations { get; set; }

        public DbSet<SalesInquiryRequestDTO> salesInquiryRequestDTOs { get; set; }
    }
}
