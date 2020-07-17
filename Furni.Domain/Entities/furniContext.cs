using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Furni.Domain.Entities
{
    public partial class furniContext : DbContext
    {
        public furniContext()
        {
        }

        public furniContext(DbContextOptions<furniContext> options)
            : base(options)
        {
        }

        public override int SaveChanges()
        {
            var entities = from e in ChangeTracker.Entries()
                           where e.State == EntityState.Added
                               || e.State == EntityState.Modified
                           select e.Entity;
            foreach (var entity in entities)
            {
                var validationContext = new ValidationContext(entity);
                Validator.ValidateObject(
                    entity,
                    validationContext,
                    validateAllProperties: true);
            }

            return base.SaveChanges();
        }



        public virtual DbSet<Models.AdminComCountTbl> AdminComCountTbl { get; set; }
        public virtual DbSet<Models.AdminTransactionTransferDetail> AdminTransactionTransferDetail { get; set; }
        public virtual DbSet<Models.BannerTbl> BannerTbl { get; set; }
        public virtual DbSet<Models.CancelLang> CancelLang { get; set; }
        public virtual DbSet<Models.Cancelreason> Cancelreason { get; set; }
        public virtual DbSet<Models.CartCalculation> CartCalculation { get; set; }
        public virtual DbSet<Models.Carts> Carts { get; set; }
        public virtual DbSet<Models.CategoryLang> CategoryLang { get; set; }
        public virtual DbSet<Models.CategoryTbl> CategoryTbl { get; set; }
        public virtual DbSet<Models.City> City { get; set; }
        public virtual DbSet<Models.CmspageBlockDescLangTbl> CmspageBlockDescLangTbl { get; set; }
        public virtual DbSet<Models.CmspageBlockDescTbl> CmspageBlockDescTbl { get; set; }
        public virtual DbSet<Models.CmspageLangTbl> CmspageLangTbl { get; set; }
        public virtual DbSet<Models.CmspageTbl> CmspageTbl { get; set; }
        public virtual DbSet<Models.CodtransferDetails> CodtransferDetails { get; set; }
        public virtual DbSet<Models.Contact> Contact { get; set; }
        public virtual DbSet<Models.ContactUs> ContactUs { get; set; }
        public virtual DbSet<Models.Country> Country { get; set; }
        public virtual DbSet<Models.CuisineLang> CuisineLang { get; set; }
        public virtual DbSet<Models.CuisineTbl> CuisineTbl { get; set; }
        public virtual DbSet<Models.Currancy> Currancy { get; set; }
        public virtual DbSet<Models.Customer> Customer { get; set; }
        public virtual DbSet<Models.CustomerAddress> CustomerAddress { get; set; }
        public virtual DbSet<Models.CustomerOffer> CustomerOffer { get; set; }
        public virtual DbSet<Models.CustomerRating> CustomerRating { get; set; }
        public virtual DbSet<Models.CustomerWhishListtbl> CustomerWhishListtbl { get; set; }
        public virtual DbSet<Models.CustomizableItemOnCarts> CustomizableItemOnCarts { get; set; }
        public virtual DbSet<Models.CustomizeOrdertbl> CustomizeOrdertbl { get; set; }
        public virtual DbSet<Models.DbErrors> DbErrors { get; set; }
        public virtual DbSet<Models.DeliveryCharge> DeliveryCharge { get; set; }
        public virtual DbSet<Models.DeliveryCompany> DeliveryCompany { get; set; }
        public virtual DbSet<Models.DetailsTbl> DetailsTbl { get; set; }
        public virtual DbSet<Models.DeviceTokenTbl> DeviceTokenTbl { get; set; }
        public virtual DbSet<Models.DocumentFor> DocumentFor { get; set; }
        public virtual DbSet<Models.DriverAddress> DriverAddress { get; set; }
        public virtual DbSet<Models.DriverBankDetails> DriverBankDetails { get; set; }
        public virtual DbSet<Models.DriverCurrentLatLongtbl> DriverCurrentLatLongtbl { get; set; }
        public virtual DbSet<Models.DriverDocument> DriverDocument { get; set; }
        public virtual DbSet<Models.DriverLogTbl> DriverLogTbl { get; set; }
        public virtual DbSet<Models.DriverRating> DriverRating { get; set; }
        public virtual DbSet<Models.DriverReg> DriverReg { get; set; }
        public virtual DbSet<Models.DriverTimeSlot> DriverTimeSlot { get; set; }
        public virtual DbSet<Models.DriverWithdrawal> DriverWithdrawal { get; set; }
        public virtual DbSet<Models.EmailLang> EmailLang { get; set; }
        public virtual DbSet<Models.EmailTemplate> EmailTemplate { get; set; }
        public virtual DbSet<Models.ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<Models.Faq> Faq { get; set; }
        public virtual DbSet<Models.FaqCategory> FaqCategory { get; set; }
        public virtual DbSet<Models.FaqCategoryLang> FaqCategoryLang { get; set; }
        public virtual DbSet<Models.FaqLang> FaqLang { get; set; }
        public virtual DbSet<Models.FeedbackTbl> FeedbackTbl { get; set; }
        public virtual DbSet<Models.GeoLocation> GeoLocation { get; set; }
        public virtual DbSet<Models.GeoLocationAddress> GeoLocationAddress { get; set; }
        public virtual DbSet<Models.ItemAddOn> ItemAddOn { get; set; }
        public virtual DbSet<Models.ItemOption> ItemOption { get; set; }
        public virtual DbSet<Models.ItemTag> ItemTag { get; set; }
        public virtual DbSet<Models.ItemTagLang> ItemTagLang { get; set; }
        public virtual DbSet<Models.ItemType> ItemType { get; set; }
        public virtual DbSet<Models.ItemTypeLang> ItemTypeLang { get; set; }
        public virtual DbSet<Models.LanguageLable> LanguageLable { get; set; }
        public virtual DbSet<Models.Languages> Languages { get; set; }
        public virtual DbSet<Models.LoginLog> LoginLog { get; set; }
        public virtual DbSet<Models.ManageDocLang> ManageDocLang { get; set; }
        public virtual DbSet<Models.ManageDocument> ManageDocument { get; set; }
        public virtual DbSet<Models.MobileWizardSteps> MobileWizardSteps { get; set; }
        public virtual DbSet<Models.Notificationtbl> Notificationtbl { get; set; }
        public virtual DbSet<Models.OrderBaseDetails> OrderBaseDetails { get; set; }
        public virtual DbSet<Models.OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Models.OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<Models.OrderSubDetails> OrderSubDetails { get; set; }
        public virtual DbSet<Models.Orders> Orders { get; set; }
        public virtual DbSet<Models.PageLang> PageLang { get; set; }
        public virtual DbSet<Models.Pages> Pages { get; set; }
        public virtual DbSet<Models.PayToStoreFromDriver> PayToStoreFromDriver { get; set; }
        public virtual DbSet<Models.PaymentResponse> PaymentResponse { get; set; }
        public virtual DbSet<Models.Paymenttbl> Paymenttbl { get; set; }
        public virtual DbSet<Models.PermissionRole> PermissionRole { get; set; }
        public virtual DbSet<Models.ProductAddon> ProductAddon { get; set; }
        public virtual DbSet<Models.ProductItemAddOnView> ProductItemAddOnView { get; set; }
        public virtual DbSet<Models.ProductItemOptionView> ProductItemOptionView { get; set; }
        public virtual DbSet<Models.ProductLang> ProductLang { get; set; }
        public virtual DbSet<Models.ProductNew> ProductNew { get; set; }
        public virtual DbSet<Models.ProductOption> ProductOption { get; set; }
        public virtual DbSet<Models.ProductOtherImages> ProductOtherImages { get; set; }
        public virtual DbSet<Models.ProductQtytbl> ProductQtytbl { get; set; }
        public virtual DbSet<Models.Promocode> Promocode { get; set; }
        public virtual DbSet<Models.PromocodeLang> PromocodeLang { get; set; }
        public virtual DbSet<Models.RestrictedArea> RestrictedArea { get; set; }
        public virtual DbSet<Models.ReviewsTbl> ReviewsTbl { get; set; }
        public virtual DbSet<Models.Role> Role { get; set; }
        public virtual DbSet<Models.RoleManagement> RoleManagement { get; set; }
        public virtual DbSet<Models.RoleUser> RoleUser { get; set; }
        public virtual DbSet<Models.ServiceTypetbl> ServiceTypetbl { get; set; }
        public virtual DbSet<Models.Settingtbl> Settingtbl { get; set; }
        public virtual DbSet<Models.State> State { get; set; }
        public virtual DbSet<Models.StatusLang> StatusLang { get; set; }
        public virtual DbSet<Models.StatusLogtbl> StatusLogtbl { get; set; }
        public virtual DbSet<Models.Store> Store { get; set; }
        public virtual DbSet<Models.StoreAddress> StoreAddress { get; set; }
        public virtual DbSet<Models.StoreAvailableCuisineTbl> StoreAvailableCuisineTbl { get; set; }
        public virtual DbSet<Models.StoreBankDetails> StoreBankDetails { get; set; }
        public virtual DbSet<Models.StoreDocument> StoreDocument { get; set; }
        public virtual DbSet<Models.StoreOffer> StoreOffer { get; set; }
        public virtual DbSet<Models.StoreOrder> StoreOrder { get; set; }
        public virtual DbSet<Models.StorePreferableDriverMapping> StorePreferableDriverMapping { get; set; }
        public virtual DbSet<Models.StoreRating> StoreRating { get; set; }
        public virtual DbSet<Models.StoreSetting> StoreSetting { get; set; }
        public virtual DbSet<Models.StoreTimeSlot> StoreTimeSlot { get; set; }
        public virtual DbSet<Models.Table> Table { get; set; }
        public virtual DbSet<Models.TblEmployees> TblEmployees { get; set; }
        public virtual DbSet<Models.User> User { get; set; }
        public virtual DbSet<Models.UserTypeTbl> UserTypeTbl { get; set; }
        public virtual DbSet<Models.Vehicle> Vehicle { get; set; }
        public virtual DbSet<Models.VehicleDocument> VehicleDocument { get; set; }
        public virtual DbSet<Models.VehicleLang> VehicleLang { get; set; }
        public virtual DbSet<Models.VehicleMakeTbl> VehicleMakeTbl { get; set; }
        public virtual DbSet<Models.VehicleModelTbl> VehicleModelTbl { get; set; }
        public virtual DbSet<Models.VehicleType> VehicleType { get; set; }
        public virtual DbSet<Models.View2> View2 { get; set; }
        public virtual DbSet<Models.View3> View3 { get; set; }
        public virtual DbSet<Models.VwGetDriverList> VwGetDriverList { get; set; }
        public virtual DbSet<Models.VwGetFullStoreDetails> VwGetFullStoreDetails { get; set; }
        public virtual DbSet<Models.WalletSettlement> WalletSettlement { get; set; }
        public virtual DbSet<Models.WalletTbl> WalletTbl { get; set; }
        public virtual DbSet<Models.Weektbl> Weektbl { get; set; }
      
    }
}
