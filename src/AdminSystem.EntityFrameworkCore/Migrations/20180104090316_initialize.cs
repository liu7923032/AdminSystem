using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AdminSystem.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpPermissions_AbpRoles_RoleId",
                table: "AbpPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpPermissions_AbpUsers_UserId",
                table: "AbpPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                table: "AbpRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoles_AbpUsers_CreatorUserId",
                table: "AbpRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoles_AbpUsers_DeleterUserId",
                table: "AbpRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoles_AbpUsers_LastModifierUserId",
                table: "AbpRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpSettings_AbpUsers_UserId",
                table: "AbpSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpUsers_CreatorUserId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpUsers_DeleterUserId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpUsers_LastModifierUserId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserClaims_AbpUsers_UserId",
                table: "AbpUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserLogins_AbpUsers_UserId",
                table: "AbpUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserRoles_AbpUsers_UserId",
                table: "AbpUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AbpUsers_CreatorUserId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AbpUsers_DeleterUserId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AbpUsers_LastModifierUserId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_UserId",
                table: "AbpUserTokens");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserTokens_TenantId_UserId",
                table: "AbpUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUsers",
                table: "AbpUsers");

            migrationBuilder.DropIndex(
                name: "IX_AbpUsers_CreatorUserId",
                table: "AbpUsers");

            migrationBuilder.DropIndex(
                name: "IX_AbpUsers_DeleterUserId",
                table: "AbpUsers");

            migrationBuilder.DropIndex(
                name: "IX_AbpUsers_LastModifierUserId",
                table: "AbpUsers");

            migrationBuilder.DropIndex(
                name: "IX_AbpUsers_TenantId_NormalizedEmailAddress",
                table: "AbpUsers");

            migrationBuilder.DropIndex(
                name: "IX_AbpUsers_TenantId_NormalizedUserName",
                table: "AbpUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserRoles",
                table: "AbpUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserRoles_TenantId_RoleId",
                table: "AbpUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserRoles_TenantId_UserId",
                table: "AbpUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId",
                table: "AbpUserOrganizationUnits");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserOrganizationUnits_TenantId_UserId",
                table: "AbpUserOrganizationUnits");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserNotifications_UserId_State_CreationTime",
                table: "AbpUserNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserLogins",
                table: "AbpUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserLogins_TenantId_UserId",
                table: "AbpUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey",
                table: "AbpUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserLoginAttempts_UserId_TenantId",
                table: "AbpUserLoginAttempts");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
                table: "AbpUserLoginAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserClaims",
                table: "AbpUserClaims");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserClaims_TenantId_ClaimType",
                table: "AbpUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserAccounts",
                table: "AbpUserAccounts");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserAccounts_EmailAddress",
                table: "AbpUserAccounts");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserAccounts_UserName",
                table: "AbpUserAccounts");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserAccounts_TenantId_EmailAddress",
                table: "AbpUserAccounts");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserAccounts_TenantId_UserId",
                table: "AbpUserAccounts");

            migrationBuilder.DropIndex(
                name: "IX_AbpUserAccounts_TenantId_UserName",
                table: "AbpUserAccounts");

            migrationBuilder.DropIndex(
                name: "IX_AbpTenants_CreatorUserId",
                table: "AbpTenants");

            migrationBuilder.DropIndex(
                name: "IX_AbpTenants_DeleterUserId",
                table: "AbpTenants");

            migrationBuilder.DropIndex(
                name: "IX_AbpTenants_LastModifierUserId",
                table: "AbpTenants");

            migrationBuilder.DropIndex(
                name: "IX_AbpTenants_TenancyName",
                table: "AbpTenants");

            migrationBuilder.DropIndex(
                name: "IX_AbpTenantNotifications_TenantId",
                table: "AbpTenantNotifications");

            migrationBuilder.DropIndex(
                name: "IX_AbpSettings_TenantId_Name",
                table: "AbpSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpRoles",
                table: "AbpRoles");

            migrationBuilder.DropIndex(
                name: "IX_AbpRoles_TenantId_NormalizedName",
                table: "AbpRoles");

            migrationBuilder.DropIndex(
                name: "IX_AbpRoleClaims_TenantId_ClaimType",
                table: "AbpRoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpPermissions",
                table: "AbpPermissions");

            migrationBuilder.DropIndex(
                name: "IX_AbpPermissions_TenantId_Name",
                table: "AbpPermissions");

            migrationBuilder.DropIndex(
                name: "IX_AbpOrganizationUnits_TenantId_Code",
                table: "AbpOrganizationUnits");

            migrationBuilder.DropIndex(
                name: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key",
                table: "AbpLanguageTexts");

            migrationBuilder.DropIndex(
                name: "IX_AbpLanguages_TenantId_Name",
                table: "AbpLanguages");

            migrationBuilder.DropIndex(
                name: "IX_AbpFeatures_EditionId_Name",
                table: "AbpFeatures");

            migrationBuilder.DropIndex(
                name: "IX_AbpFeatures_TenantId_Name",
                table: "AbpFeatures");

            migrationBuilder.DropIndex(
                name: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime",
                table: "AbpBackgroundJobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpAuditLogs",
                table: "AbpAuditLogs");

            migrationBuilder.DropIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionDuration",
                table: "AbpAuditLogs");

            migrationBuilder.DropIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionTime",
                table: "AbpAuditLogs");

            migrationBuilder.DropIndex(
                name: "IX_AbpAuditLogs_TenantId_UserId",
                table: "AbpAuditLogs");

            migrationBuilder.RenameTable(
                name: "AbpUsers",
                newName: "Sys_Users");

            migrationBuilder.RenameTable(
                name: "AbpUserRoles",
                newName: "Sys_UserRoles");

            migrationBuilder.RenameTable(
                name: "AbpUserLogins",
                newName: "Sys_UserLogins");

            migrationBuilder.RenameTable(
                name: "AbpUserClaims",
                newName: "Sys_UserClaims");

            migrationBuilder.RenameTable(
                name: "AbpUserAccounts",
                newName: "Sys_UserAccounts");

            migrationBuilder.RenameTable(
                name: "AbpRoles",
                newName: "Sys_Roles");

            migrationBuilder.RenameTable(
                name: "AbpPermissions",
                newName: "Sys_Permissions");

            migrationBuilder.RenameTable(
                name: "AbpAuditLogs",
                newName: "Sys_AuditLogs");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserRoles_UserId",
                table: "Sys_UserRoles",
                newName: "IX_Sys_UserRoles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLogins_UserId",
                table: "Sys_UserLogins",
                newName: "IX_Sys_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserClaims_UserId",
                table: "Sys_UserClaims",
                newName: "IX_Sys_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_LastModifierUserId",
                table: "Sys_Roles",
                newName: "IX_Sys_Roles_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_DeleterUserId",
                table: "Sys_Roles",
                newName: "IX_Sys_Roles_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_CreatorUserId",
                table: "Sys_Roles",
                newName: "IX_Sys_Roles_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_UserId",
                table: "Sys_Permissions",
                newName: "IX_Sys_Permissions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_RoleId",
                table: "Sys_Permissions",
                newName: "IX_Sys_Permissions_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "ClaimType",
                table: "Sys_UserClaims",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Sys_UserAccounts",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Sys_UserAccounts",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId1",
                table: "AbpTenants",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId1",
                table: "AbpTenants",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId1",
                table: "AbpTenants",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClaimType",
                table: "AbpRoleClaims",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ServiceName",
                table: "Sys_AuditLogs",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Parameters",
                table: "Sys_AuditLogs",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MethodName",
                table: "Sys_AuditLogs",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Exception",
                table: "Sys_AuditLogs",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomData",
                table: "Sys_AuditLogs",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientName",
                table: "Sys_AuditLogs",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientIpAddress",
                table: "Sys_AuditLogs",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrowserInfo",
                table: "Sys_AuditLogs",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_Users",
                table: "Sys_Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_UserRoles",
                table: "Sys_UserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_UserLogins",
                table: "Sys_UserLogins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_UserClaims",
                table: "Sys_UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_UserAccounts",
                table: "Sys_UserAccounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_Roles",
                table: "Sys_Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_Permissions",
                table: "Sys_Permissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sys_AuditLogs",
                table: "Sys_AuditLogs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_CreatorUserId1",
                table: "AbpTenants",
                column: "CreatorUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_DeleterUserId1",
                table: "AbpTenants",
                column: "DeleterUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_LastModifierUserId1",
                table: "AbpTenants",
                column: "LastModifierUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AbpFeatures_EditionId",
                table: "AbpFeatures",
                column: "EditionId");

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
                name: "FK_AbpTenants_Sys_Users_CreatorUserId1",
                table: "AbpTenants",
                column: "CreatorUserId1",
                principalTable: "Sys_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_Sys_Users_DeleterUserId1",
                table: "AbpTenants",
                column: "DeleterUserId1",
                principalTable: "Sys_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_Sys_Users_LastModifierUserId1",
                table: "AbpTenants",
                column: "LastModifierUserId1",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_Permissions_Sys_Roles_RoleId",
                table: "Sys_Permissions",
                column: "RoleId",
                principalTable: "Sys_Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_Permissions_Sys_Users_UserId",
                table: "Sys_Permissions",
                column: "UserId",
                principalTable: "Sys_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_Roles_Sys_Users_CreatorUserId",
                table: "Sys_Roles",
                column: "CreatorUserId",
                principalTable: "Sys_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_Roles_Sys_Users_DeleterUserId",
                table: "Sys_Roles",
                column: "DeleterUserId",
                principalTable: "Sys_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_Roles_Sys_Users_LastModifierUserId",
                table: "Sys_Roles",
                column: "LastModifierUserId",
                principalTable: "Sys_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_UserClaims_Sys_Users_UserId",
                table: "Sys_UserClaims",
                column: "UserId",
                principalTable: "Sys_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_UserLogins_Sys_Users_UserId",
                table: "Sys_UserLogins",
                column: "UserId",
                principalTable: "Sys_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sys_UserRoles_Sys_Users_UserId",
                table: "Sys_UserRoles",
                column: "UserId",
                principalTable: "Sys_Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoleClaims_Sys_Roles_RoleId",
                table: "AbpRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpSettings_Sys_Users_UserId",
                table: "AbpSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_Sys_Users_CreatorUserId1",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_Sys_Users_DeleterUserId1",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_Sys_Users_LastModifierUserId1",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserTokens_Sys_Users_UserId",
                table: "AbpUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Sys_Permissions_Sys_Roles_RoleId",
                table: "Sys_Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sys_Permissions_Sys_Users_UserId",
                table: "Sys_Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Sys_Roles_Sys_Users_CreatorUserId",
                table: "Sys_Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Sys_Roles_Sys_Users_DeleterUserId",
                table: "Sys_Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Sys_Roles_Sys_Users_LastModifierUserId",
                table: "Sys_Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Sys_UserClaims_Sys_Users_UserId",
                table: "Sys_UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Sys_UserLogins_Sys_Users_UserId",
                table: "Sys_UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_Sys_UserRoles_Sys_Users_UserId",
                table: "Sys_UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_Users",
                table: "Sys_Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_UserRoles",
                table: "Sys_UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_UserLogins",
                table: "Sys_UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_UserClaims",
                table: "Sys_UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_UserAccounts",
                table: "Sys_UserAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_Roles",
                table: "Sys_Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_Permissions",
                table: "Sys_Permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sys_AuditLogs",
                table: "Sys_AuditLogs");

            migrationBuilder.DropIndex(
                name: "IX_AbpTenants_CreatorUserId1",
                table: "AbpTenants");

            migrationBuilder.DropIndex(
                name: "IX_AbpTenants_DeleterUserId1",
                table: "AbpTenants");

            migrationBuilder.DropIndex(
                name: "IX_AbpTenants_LastModifierUserId1",
                table: "AbpTenants");

            migrationBuilder.DropIndex(
                name: "IX_AbpFeatures_EditionId",
                table: "AbpFeatures");

            migrationBuilder.DropColumn(
                name: "CreatorUserId1",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "DeleterUserId1",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId1",
                table: "AbpTenants");

            migrationBuilder.RenameTable(
                name: "Sys_Users",
                newName: "AbpUsers");

            migrationBuilder.RenameTable(
                name: "Sys_UserRoles",
                newName: "AbpUserRoles");

            migrationBuilder.RenameTable(
                name: "Sys_UserLogins",
                newName: "AbpUserLogins");

            migrationBuilder.RenameTable(
                name: "Sys_UserClaims",
                newName: "AbpUserClaims");

            migrationBuilder.RenameTable(
                name: "Sys_UserAccounts",
                newName: "AbpUserAccounts");

            migrationBuilder.RenameTable(
                name: "Sys_Roles",
                newName: "AbpRoles");

            migrationBuilder.RenameTable(
                name: "Sys_Permissions",
                newName: "AbpPermissions");

            migrationBuilder.RenameTable(
                name: "Sys_AuditLogs",
                newName: "AbpAuditLogs");

            migrationBuilder.RenameIndex(
                name: "IX_Sys_UserRoles_UserId",
                table: "AbpUserRoles",
                newName: "IX_AbpUserRoles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Sys_UserLogins_UserId",
                table: "AbpUserLogins",
                newName: "IX_AbpUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Sys_UserClaims_UserId",
                table: "AbpUserClaims",
                newName: "IX_AbpUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Sys_Roles_LastModifierUserId",
                table: "AbpRoles",
                newName: "IX_AbpRoles_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Sys_Roles_DeleterUserId",
                table: "AbpRoles",
                newName: "IX_AbpRoles_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Sys_Roles_CreatorUserId",
                table: "AbpRoles",
                newName: "IX_AbpRoles_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Sys_Permissions_UserId",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Sys_Permissions_RoleId",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "ClaimType",
                table: "AbpUserClaims",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AbpUserAccounts",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "AbpUserAccounts",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ServiceName",
                table: "AbpAuditLogs",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Parameters",
                table: "AbpAuditLogs",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MethodName",
                table: "AbpAuditLogs",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Exception",
                table: "AbpAuditLogs",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomData",
                table: "AbpAuditLogs",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientName",
                table: "AbpAuditLogs",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientIpAddress",
                table: "AbpAuditLogs",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrowserInfo",
                table: "AbpAuditLogs",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClaimType",
                table: "AbpRoleClaims",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUsers",
                table: "AbpUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserRoles",
                table: "AbpUserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserLogins",
                table: "AbpUserLogins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserClaims",
                table: "AbpUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserAccounts",
                table: "AbpUserAccounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpRoles",
                table: "AbpRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpPermissions",
                table: "AbpPermissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpAuditLogs",
                table: "AbpAuditLogs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_CreatorUserId",
                table: "AbpUsers",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_DeleterUserId",
                table: "AbpUsers",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_LastModifierUserId",
                table: "AbpUsers",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_TenantId_NormalizedEmailAddress",
                table: "AbpUsers",
                columns: new[] { "TenantId", "NormalizedEmailAddress" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_TenantId_NormalizedUserName",
                table: "AbpUsers",
                columns: new[] { "TenantId", "NormalizedUserName" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserRoles_TenantId_RoleId",
                table: "AbpUserRoles",
                columns: new[] { "TenantId", "RoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserRoles_TenantId_UserId",
                table: "AbpUserRoles",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserLogins_TenantId_UserId",
                table: "AbpUserLogins",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey",
                table: "AbpUserLogins",
                columns: new[] { "TenantId", "LoginProvider", "ProviderKey" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserClaims_TenantId_ClaimType",
                table: "AbpUserClaims",
                columns: new[] { "TenantId", "ClaimType" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserAccounts_EmailAddress",
                table: "AbpUserAccounts",
                column: "EmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserAccounts_UserName",
                table: "AbpUserAccounts",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserAccounts_TenantId_EmailAddress",
                table: "AbpUserAccounts",
                columns: new[] { "TenantId", "EmailAddress" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserAccounts_TenantId_UserId",
                table: "AbpUserAccounts",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserAccounts_TenantId_UserName",
                table: "AbpUserAccounts",
                columns: new[] { "TenantId", "UserName" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoles_TenantId_NormalizedName",
                table: "AbpRoles",
                columns: new[] { "TenantId", "NormalizedName" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpPermissions_TenantId_Name",
                table: "AbpPermissions",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionDuration",
                table: "AbpAuditLogs",
                columns: new[] { "TenantId", "ExecutionDuration" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionTime",
                table: "AbpAuditLogs",
                columns: new[] { "TenantId", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogs_TenantId_UserId",
                table: "AbpAuditLogs",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserTokens_TenantId_UserId",
                table: "AbpUserTokens",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId",
                table: "AbpUserOrganizationUnits",
                columns: new[] { "TenantId", "OrganizationUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserOrganizationUnits_TenantId_UserId",
                table: "AbpUserOrganizationUnits",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserNotifications_UserId_State_CreationTime",
                table: "AbpUserNotifications",
                columns: new[] { "UserId", "State", "CreationTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserLoginAttempts_UserId_TenantId",
                table: "AbpUserLoginAttempts",
                columns: new[] { "UserId", "TenantId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
                table: "AbpUserLoginAttempts",
                columns: new[] { "TenancyName", "UserNameOrEmailAddress", "Result" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_CreatorUserId",
                table: "AbpTenants",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_DeleterUserId",
                table: "AbpTenants",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_LastModifierUserId",
                table: "AbpTenants",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_TenancyName",
                table: "AbpTenants",
                column: "TenancyName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenantNotifications_TenantId",
                table: "AbpTenantNotifications",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpSettings_TenantId_Name",
                table: "AbpSettings",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoleClaims_TenantId_ClaimType",
                table: "AbpRoleClaims",
                columns: new[] { "TenantId", "ClaimType" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpOrganizationUnits_TenantId_Code",
                table: "AbpOrganizationUnits",
                columns: new[] { "TenantId", "Code" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                columns: new[] { "NotificationName", "EntityTypeName", "EntityId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                columns: new[] { "TenantId", "NotificationName", "EntityTypeName", "EntityId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key",
                table: "AbpLanguageTexts",
                columns: new[] { "TenantId", "Source", "LanguageName", "Key" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpLanguages_TenantId_Name",
                table: "AbpLanguages",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpFeatures_EditionId_Name",
                table: "AbpFeatures",
                columns: new[] { "EditionId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpFeatures_TenantId_Name",
                table: "AbpFeatures",
                columns: new[] { "TenantId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime",
                table: "AbpBackgroundJobs",
                columns: new[] { "IsAbandoned", "NextTryTime" });

            migrationBuilder.AddForeignKey(
                name: "FK_AbpPermissions_AbpRoles_RoleId",
                table: "AbpPermissions",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpPermissions_AbpUsers_UserId",
                table: "AbpPermissions",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                table: "AbpRoleClaims",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoles_AbpUsers_CreatorUserId",
                table: "AbpRoles",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoles_AbpUsers_DeleterUserId",
                table: "AbpRoles",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoles_AbpUsers_LastModifierUserId",
                table: "AbpRoles",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpSettings_AbpUsers_UserId",
                table: "AbpSettings",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpUsers_CreatorUserId",
                table: "AbpTenants",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpUsers_DeleterUserId",
                table: "AbpTenants",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpUsers_LastModifierUserId",
                table: "AbpTenants",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserClaims_AbpUsers_UserId",
                table: "AbpUserClaims",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserLogins_AbpUsers_UserId",
                table: "AbpUserLogins",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserRoles_AbpUsers_UserId",
                table: "AbpUserRoles",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AbpUsers_CreatorUserId",
                table: "AbpUsers",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AbpUsers_DeleterUserId",
                table: "AbpUsers",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AbpUsers_LastModifierUserId",
                table: "AbpUsers",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_UserId",
                table: "AbpUserTokens",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
