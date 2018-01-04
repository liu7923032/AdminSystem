using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AdminSystem.Migrations
{
    public partial class changetablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoleClaims_Sys_Roles_RoleId",
                table: "AbpRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpSettings_Sys_Users_UserId",
                table: "AbpSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserTokens_Sys_Users_UserId",
                table: "AbpUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserTokens",
                table: "AbpUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserOrganizationUnits",
                table: "AbpUserOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserNotifications",
                table: "AbpUserNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserLoginAttempts",
                table: "AbpUserLoginAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpSettings",
                table: "AbpSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpRoleClaims",
                table: "AbpRoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpOrganizationUnits",
                table: "AbpOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpNotificationSubscriptions",
                table: "AbpNotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpBackgroundJobs",
                table: "AbpBackgroundJobs");

            migrationBuilder.RenameTable(
                name: "AbpUserTokens",
                newName: "Sys_UserTokens");

            migrationBuilder.RenameTable(
                name: "AbpUserOrganizationUnits",
                newName: "Sys_UserOrganizations");

            migrationBuilder.RenameTable(
                name: "AbpUserNotifications",
                newName: "Sys_UserNotificationInfos");

            migrationBuilder.RenameTable(
                name: "AbpUserLoginAttempts",
                newName: "Sys_UserLoginAttempts");

            migrationBuilder.RenameTable(
                name: "AbpSettings",
                newName: "Sys_Settings");

            migrationBuilder.RenameTable(
                name: "AbpRoleClaims",
                newName: "Sys_RoleClaims");

            migrationBuilder.RenameTable(
                name: "AbpOrganizationUnits",
                newName: "Sys_OrganizationUnits");

            migrationBuilder.RenameTable(
                name: "AbpNotificationSubscriptions",
                newName: "Sys_NotificationSubscriptionInfos");

            migrationBuilder.RenameTable(
                name: "AbpBackgroundJobs",
                newName: "Sys_BackgroundJobInfos");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserTokens_UserId",
                table: "Sys_UserTokens",
                newName: "IX_Sys_UserTokens_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSettings_UserId",
                table: "Sys_Settings",
                newName: "IX_Sys_Settings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoleClaims_RoleId",
                table: "Sys_RoleClaims",
                newName: "IX_Sys_RoleClaims_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnits_ParentId",
                table: "Sys_OrganizationUnits",
                newName: "IX_Sys_OrganizationUnits_ParentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_UserTokens",
                table: "Sys_UserTokens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_UserOrganizations",
                table: "Sys_UserOrganizations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_UserNotificationInfos",
                table: "Sys_UserNotificationInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_UserLoginAttempts",
                table: "Sys_UserLoginAttempts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_Settings",
                table: "Sys_Settings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_RoleClaims",
                table: "Sys_RoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_OrganizationUnits",
                table: "Sys_OrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_NotificationSubscriptionInfos",
                table: "Sys_NotificationSubscriptionInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_BackgroundJobInfos",
                table: "Sys_BackgroundJobInfos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_OrganizationUnits_Sys_OrganizationUnits_ParentId",
                table: "Sys_OrganizationUnits",
                column: "ParentId",
                principalTable: "Sys_OrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_RoleClaims_Sys_Roles_RoleId",
                table: "Sys_RoleClaims",
                column: "RoleId",
                principalTable: "Sys_Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_Settings_Sys_Users_UserId",
                table: "Sys_Settings",
                column: "UserId",
                principalTable: "Sys_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_UserTokens_Sys_Users_UserId",
                table: "Sys_UserTokens",
                column: "UserId",
                principalTable: "Sys_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sys_OrganizationUnits_Sys_OrganizationUnits_ParentId",
                table: "Sys_OrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Sys_RoleClaims_Sys_Roles_RoleId",
                table: "Sys_RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Sys_Settings_Sys_Users_UserId",
                table: "Sys_Settings");

            migrationBuilder.DropForeignKey(
                name: "FK_Sys_UserTokens_Sys_Users_UserId",
                table: "Sys_UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_UserTokens",
                table: "Sys_UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_UserOrganizations",
                table: "Sys_UserOrganizations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_UserNotificationInfos",
                table: "Sys_UserNotificationInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_UserLoginAttempts",
                table: "Sys_UserLoginAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_Settings",
                table: "Sys_Settings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_RoleClaims",
                table: "Sys_RoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_OrganizationUnits",
                table: "Sys_OrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_NotificationSubscriptionInfos",
                table: "Sys_NotificationSubscriptionInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_BackgroundJobInfos",
                table: "Sys_BackgroundJobInfos");

            migrationBuilder.RenameTable(
                name: "Sys_UserTokens",
                newName: "AbpUserTokens");

            migrationBuilder.RenameTable(
                name: "Sys_UserOrganizations",
                newName: "AbpUserOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "Sys_UserNotificationInfos",
                newName: "AbpUserNotifications");

            migrationBuilder.RenameTable(
                name: "Sys_UserLoginAttempts",
                newName: "AbpUserLoginAttempts");

            migrationBuilder.RenameTable(
                name: "Sys_Settings",
                newName: "AbpSettings");

            migrationBuilder.RenameTable(
                name: "Sys_RoleClaims",
                newName: "AbpRoleClaims");

            migrationBuilder.RenameTable(
                name: "Sys_OrganizationUnits",
                newName: "AbpOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "Sys_NotificationSubscriptionInfos",
                newName: "AbpNotificationSubscriptions");

            migrationBuilder.RenameTable(
                name: "Sys_BackgroundJobInfos",
                newName: "AbpBackgroundJobs");

            migrationBuilder.RenameIndex(
                name: "IX_Sys_UserTokens_UserId",
                table: "AbpUserTokens",
                newName: "IX_AbpUserTokens_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Sys_Settings_UserId",
                table: "AbpSettings",
                newName: "IX_AbpSettings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Sys_RoleClaims_RoleId",
                table: "AbpRoleClaims",
                newName: "IX_AbpRoleClaims_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Sys_OrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                newName: "IX_AbpOrganizationUnits_ParentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserTokens",
                table: "AbpUserTokens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserOrganizationUnits",
                table: "AbpUserOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserNotifications",
                table: "AbpUserNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserLoginAttempts",
                table: "AbpUserLoginAttempts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpSettings",
                table: "AbpSettings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpRoleClaims",
                table: "AbpRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpOrganizationUnits",
                table: "AbpOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpNotificationSubscriptions",
                table: "AbpNotificationSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpBackgroundJobs",
                table: "AbpBackgroundJobs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                column: "ParentId",
                principalTable: "AbpOrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoleClaims_Sys_Roles_RoleId",
                table: "AbpRoleClaims",
                column: "RoleId",
                principalTable: "Sys_Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpSettings_Sys_Users_UserId",
                table: "AbpSettings",
                column: "UserId",
                principalTable: "Sys_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserTokens_Sys_Users_UserId",
                table: "AbpUserTokens",
                column: "UserId",
                principalTable: "Sys_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
