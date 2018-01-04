using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AdminSystem.Authorization.Roles;
using AdminSystem.Authorization.Users;
using AdminSystem.MultiTenancy;
using Abp.Authorization.Users;
using Abp.Authorization;
using Abp.Auditing;
using Abp.BackgroundJobs;
using Abp.Authorization.Roles;
using Abp.Notifications;
using Abp.Configuration;
using Abp.Organizations;
using Abp.Application.Features;

namespace AdminSystem.EntityFrameworkCore
{
    public class AdminSystemDbContext : AbpZeroDbContext<Tenant, Role, User, AdminSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public new virtual DbSet<FeatureSetting> FeatureSettings { get; set; }

        public AdminSystemDbContext(DbContextOptions<AdminSystemDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(b =>
            {
                b.ToTable("Sys_Users");
            });


            modelBuilder.Entity<Role>(b =>
            {
                b.ToTable("Sys_Roles");
            });

            modelBuilder.Entity<UserClaim>(b =>
            {
                b.ToTable("Sys_UserClaims");
            });

            modelBuilder.Entity<UserLogin>(b =>
            {
                b.ToTable("Sys_UserLogins");
            });


            modelBuilder.Entity<PermissionSetting>(b =>
            {
                b.ToTable("Sys_Permissions");
            });

            modelBuilder.Entity<UserClaim>(b =>
            {
                b.ToTable("Sys_UserClaims");
            });

            modelBuilder.Entity<UserRole>(b =>
            {
                b.ToTable("Sys_UserRoles");
            });



            modelBuilder.Entity<UserAccount>(b =>
            {
                b.ToTable("Sys_UserAccounts");
            });

            modelBuilder.Entity<AuditLog>(b =>
            {
                b.ToTable("Sys_AuditLogs");
            });

            modelBuilder.Entity<RoleClaim>(b =>
            {
                b.ToTable("Sys_RoleClaims");
            });

            modelBuilder.Entity<UserToken>(b =>
            {
                b.ToTable("Sys_UserTokens");
            });


            modelBuilder.Entity<UserOrganizationUnit>(b =>
            {
                b.ToTable("Sys_UserOrganizations");
            });

            modelBuilder.Entity<OrganizationUnit>(b =>
            {
                b.ToTable("Sys_OrganizationUnits");
            });

            modelBuilder.Entity<UserNotificationInfo>(b =>
            {
                b.ToTable("Sys_UserNotificationInfos");
            });

            modelBuilder.Entity<NotificationSubscriptionInfo>(b =>
            {
                b.ToTable("Sys_NotificationSubscriptionInfos");
            });

            modelBuilder.Entity<UserLoginAttempt>(b =>
            {
                b.ToTable("Sys_UserLoginAttempts");
            });


            modelBuilder.Entity<Setting>(b =>
            {
                b.ToTable("Sys_Settings");
            });

            modelBuilder.Entity<BackgroundJobInfo>(b =>
            {
                b.ToTable("Sys_BackgroundJobInfos");
            });

        }
    }
}
