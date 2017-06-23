using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AustinOfficerInvolvedShootings.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "CallType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaseNumber",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseNumber", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DrugsAlcohol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugsAlcohol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficerEthnicity",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficerEthnicity", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OfficerName",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficerName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficerWeaponCaliber",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficerWeaponCaliber", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubjectEthnicity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectEthnicity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubjectInjuries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectInjuries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubjectWeapon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectWeapon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeekDay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YearsExperience",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearsExperience", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShootingIncident",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CallTypeId = table.Column<int>(nullable: false),
                    CaseNumberId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    DayPart = table.Column<string>(nullable: true),
                    DrugsAlcoholId = table.Column<int>(nullable: false),
                    HowCleared = table.Column<string>(nullable: true),
                    InsideOutisde = table.Column<string>(nullable: true),
                    Jurisdiction = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    NumberHits = table.Column<int>(nullable: false),
                    NumberOfficerPresent = table.Column<int>(nullable: false),
                    NumberOfficerShooters = table.Column<int>(nullable: false),
                    NumberShotsFired = table.Column<int>(nullable: false),
                    OfficerAge = table.Column<int>(nullable: false),
                    OfficerEthnicityId = table.Column<int>(nullable: false),
                    OfficerGender = table.Column<string>(nullable: true),
                    OfficerNameId = table.Column<int>(nullable: false),
                    OfficerWeaponCaliberId = table.Column<int>(nullable: false),
                    OfficerWeaponType = table.Column<string>(nullable: true),
                    Premise = table.Column<string>(nullable: true),
                    PreviousOIS = table.Column<string>(nullable: true),
                    RankId = table.Column<int>(nullable: false),
                    SubjectAge = table.Column<int>(nullable: false),
                    SubjectEthnicityId = table.Column<int>(nullable: false),
                    SubjectGender = table.Column<string>(nullable: true),
                    SubjectInjuriesId = table.Column<int>(nullable: false),
                    SubjectWeaponId = table.Column<int>(nullable: false),
                    WeekDayId = table.Column<int>(nullable: false),
                    YearsExperienceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShootingIncident", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShootingIncident_CallType_CallTypeId",
                        column: x => x.CallTypeId,
                        principalTable: "CallType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShootingIncident_CaseNumber_CaseNumberId",
                        column: x => x.CaseNumberId,
                        principalTable: "CaseNumber",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShootingIncident_DrugsAlcohol_DrugsAlcoholId",
                        column: x => x.DrugsAlcoholId,
                        principalTable: "DrugsAlcohol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShootingIncident_OfficerEthnicity_OfficerEthnicityId",
                        column: x => x.OfficerEthnicityId,
                        principalTable: "OfficerEthnicity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShootingIncident_OfficerName_OfficerNameId",
                        column: x => x.OfficerNameId,
                        principalTable: "OfficerName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShootingIncident_OfficerWeaponCaliber_OfficerWeaponCaliberId",
                        column: x => x.OfficerWeaponCaliberId,
                        principalTable: "OfficerWeaponCaliber",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShootingIncident_Rank_RankId",
                        column: x => x.RankId,
                        principalTable: "Rank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShootingIncident_SubjectEthnicity_SubjectEthnicityId",
                        column: x => x.SubjectEthnicityId,
                        principalTable: "SubjectEthnicity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShootingIncident_SubjectInjuries_SubjectInjuriesId",
                        column: x => x.SubjectInjuriesId,
                        principalTable: "SubjectInjuries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShootingIncident_SubjectWeapon_SubjectWeaponId",
                        column: x => x.SubjectWeaponId,
                        principalTable: "SubjectWeapon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShootingIncident_WeekDay_WeekDayId",
                        column: x => x.WeekDayId,
                        principalTable: "WeekDay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShootingIncident_YearsExperience_YearsExperienceId",
                        column: x => x.YearsExperienceId,
                        principalTable: "YearsExperience",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShootingIncident_CallTypeId",
                table: "ShootingIncident",
                column: "CallTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShootingIncident_CaseNumberId",
                table: "ShootingIncident",
                column: "CaseNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_ShootingIncident_DrugsAlcoholId",
                table: "ShootingIncident",
                column: "DrugsAlcoholId");

            migrationBuilder.CreateIndex(
                name: "IX_ShootingIncident_OfficerEthnicityId",
                table: "ShootingIncident",
                column: "OfficerEthnicityId");

            migrationBuilder.CreateIndex(
                name: "IX_ShootingIncident_OfficerNameId",
                table: "ShootingIncident",
                column: "OfficerNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ShootingIncident_OfficerWeaponCaliberId",
                table: "ShootingIncident",
                column: "OfficerWeaponCaliberId");

            migrationBuilder.CreateIndex(
                name: "IX_ShootingIncident_RankId",
                table: "ShootingIncident",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_ShootingIncident_SubjectEthnicityId",
                table: "ShootingIncident",
                column: "SubjectEthnicityId");

            migrationBuilder.CreateIndex(
                name: "IX_ShootingIncident_SubjectInjuriesId",
                table: "ShootingIncident",
                column: "SubjectInjuriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ShootingIncident_SubjectWeaponId",
                table: "ShootingIncident",
                column: "SubjectWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_ShootingIncident_WeekDayId",
                table: "ShootingIncident",
                column: "WeekDayId");

            migrationBuilder.CreateIndex(
                name: "IX_ShootingIncident_YearsExperienceId",
                table: "ShootingIncident",
                column: "YearsExperienceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShootingIncident");

            migrationBuilder.DropTable(
                name: "CallType");

            migrationBuilder.DropTable(
                name: "CaseNumber");

            migrationBuilder.DropTable(
                name: "DrugsAlcohol");

            migrationBuilder.DropTable(
                name: "OfficerEthnicity");

            migrationBuilder.DropTable(
                name: "OfficerName");

            migrationBuilder.DropTable(
                name: "OfficerWeaponCaliber");

            migrationBuilder.DropTable(
                name: "Rank");

            migrationBuilder.DropTable(
                name: "SubjectEthnicity");

            migrationBuilder.DropTable(
                name: "SubjectInjuries");

            migrationBuilder.DropTable(
                name: "SubjectWeapon");

            migrationBuilder.DropTable(
                name: "WeekDay");

            migrationBuilder.DropTable(
                name: "YearsExperience");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
