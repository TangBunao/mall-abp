using Microsoft.EntityFrameworkCore;
using TangBunao.Mall.ProductBrands;
using TangBunao.Mall.ProductCategories;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace TangBunao.Mall.EntityFrameworkCore
{
    [ReplaceDbContext(typeof(IIdentityDbContext))]
    [ReplaceDbContext(typeof(ITenantManagementDbContext))]
    [ConnectionStringName("Default")]
    public class MallDbContext :
        AbpDbContext<MallDbContext>,
        IIdentityDbContext,
        ITenantManagementDbContext
    {
        /* Add DbSet properties for your Aggregate Roots / Entities here. */

        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductBrand> Brands { get; set; }

        #region Entities from the modules

        /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
         * and replaced them for this DbContext. This allows you to perform JOIN
         * queries for the entities of these modules over the repositories easily. You
         * typically don't need that for other modules. But, if you need, you can
         * implement the DbContext interface of the needed module and use ReplaceDbContext
         * attribute just like IIdentityDbContext and ITenantManagementDbContext.
         *
         * More info: Replacing a DbContext of a module ensures that the related module
         * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
         */

        //Identity
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityClaimType> ClaimTypes { get; set; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
        public DbSet<IdentityLinkUser> LinkUsers { get; set; }

        // Tenant Management
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

        #endregion

        public MallDbContext(DbContextOptions<MallDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureIdentityServer();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MallConsts.DbTablePrefix + "YourEntities", MallConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<ProductCategory>(b =>
            {
                b.ToTable(MallConsts.DbTablePrefixPms + nameof(ProductCategory), MallConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Name).IsRequired().HasMaxLength(64);
                b.Property(x => x.Level).IsRequired().HasMaxLength(1);
                b.Property(x => x.ProductUnit).IsRequired().HasMaxLength(64);
                b.Property(x => x.NavStatus).IsRequired().HasMaxLength(1);
                b.Property(x => x.ShowStatus).IsRequired().HasMaxLength(1);
                b.Property(x => x.Icon).IsRequired().HasMaxLength(255);
                b.Property(x => x.Keywords).IsRequired().HasMaxLength(255);
            });

            builder.Entity<ProductBrand>(b =>
            {
                b.ToTable(MallConsts.DbTablePrefixPms + nameof(ProductBrand), MallConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Name).IsRequired().HasMaxLength(64);
                b.Property(x => x.FirstLetter).IsRequired().HasMaxLength(8);
                b.Property(x => x.FactoryStatus).IsRequired().HasMaxLength(1);
                b.Property(x => x.ShowStatus).IsRequired().HasMaxLength(1);
                b.Property(x => x.Logo).IsRequired().HasMaxLength(255);
                b.Property(x => x.BigPic).IsRequired().HasMaxLength(255);
                b.Property(x => x.BrandStory).IsRequired();
            });
        }
    }
}
