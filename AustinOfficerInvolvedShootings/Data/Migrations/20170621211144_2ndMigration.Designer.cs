using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AustinOfficerInvolvedShootings.Data;

namespace AustinOfficerInvolvedShootings.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170621211144_2ndMigration")]
    partial class _2ndMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.AccountViewModels.EditUserViewModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Role");

                    b.Property<string>("fName");

                    b.Property<string>("lName");

                    b.HasKey("Id");

                    b.ToTable("EditUserViewModel");
                });

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("fName");

                    b.Property<string>("lName");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.CallType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("CallType");
                });

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.CaseNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("CaseNumber");
                });

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.DrugsAlcohol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("DrugsAlcohol");
                });

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.OfficerEthnicity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("OfficerEthnicity");
                });

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.OfficerName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("OfficerName");
                });

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.OfficerWeaponCaliber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("OfficerWeaponCaliber");
                });

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.Rank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("Rank");
                });

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.ShootingIncident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CallTypeId");

                    b.Property<int>("CaseNumberId");

                    b.Property<string>("Date");

                    b.Property<string>("DayPart");

                    b.Property<int>("DrugsAlcoholId");

                    b.Property<string>("HowCleared");

                    b.Property<string>("InsideOutisde");

                    b.Property<string>("Jurisdiction");

                    b.Property<string>("Location");

                    b.Property<int>("NumberHits");

                    b.Property<int>("NumberOfficerPresent");

                    b.Property<int>("NumberOfficerShooters");

                    b.Property<int>("NumberShotsFired");

                    b.Property<int>("OfficerAge");

                    b.Property<int>("OfficerEthnicityId");

                    b.Property<string>("OfficerGender");

                    b.Property<int>("OfficerNameId");

                    b.Property<int>("OfficerWeaponCaliberId");

                    b.Property<string>("OfficerWeaponType");

                    b.Property<string>("Premise");

                    b.Property<string>("PreviousOIS");

                    b.Property<int>("RankId");

                    b.Property<int>("SubjectAge");

                    b.Property<int>("SubjectEthnicityId");

                    b.Property<string>("SubjectGender");

                    b.Property<int>("SubjectInjuriesId");

                    b.Property<int>("SubjectWeaponId");

                    b.Property<int>("WeekDayId");

                    b.Property<int>("YearsExperienceId");

                    b.HasKey("Id");

                    b.HasIndex("CallTypeId");

                    b.HasIndex("CaseNumberId");

                    b.HasIndex("DrugsAlcoholId");

                    b.HasIndex("OfficerEthnicityId");

                    b.HasIndex("OfficerNameId");

                    b.HasIndex("OfficerWeaponCaliberId");

                    b.HasIndex("RankId");

                    b.HasIndex("SubjectEthnicityId");

                    b.HasIndex("SubjectInjuriesId");

                    b.HasIndex("SubjectWeaponId");

                    b.HasIndex("WeekDayId");

                    b.HasIndex("YearsExperienceId");

                    b.ToTable("ShootingIncident");
                });

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.SubjectEthnicity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("SubjectEthnicity");
                });

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.SubjectInjuries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("SubjectInjuries");
                });

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.SubjectWeapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("SubjectWeapon");
                });

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.WeekDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("WeekDay");
                });

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.YearsExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("YearsExperience");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AustinOfficerInvolvedShootings.Models.ShootingIncident", b =>
                {
                    b.HasOne("AustinOfficerInvolvedShootings.Models.CallType", "CallType")
                        .WithMany("ShootingIncident")
                        .HasForeignKey("CallTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AustinOfficerInvolvedShootings.Models.CaseNumber", "CaseNumber")
                        .WithMany("ShootingIncident")
                        .HasForeignKey("CaseNumberId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AustinOfficerInvolvedShootings.Models.DrugsAlcohol", "DrugsAlcohol")
                        .WithMany("ShootingIncident")
                        .HasForeignKey("DrugsAlcoholId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AustinOfficerInvolvedShootings.Models.OfficerEthnicity", "OfficerEthnicity")
                        .WithMany("ShootingIncident")
                        .HasForeignKey("OfficerEthnicityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AustinOfficerInvolvedShootings.Models.OfficerName", "OfficerName")
                        .WithMany("ShootingIncident")
                        .HasForeignKey("OfficerNameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AustinOfficerInvolvedShootings.Models.OfficerWeaponCaliber", "OfficerWeaponCaliber")
                        .WithMany("ShootingIncident")
                        .HasForeignKey("OfficerWeaponCaliberId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AustinOfficerInvolvedShootings.Models.Rank", "Rank")
                        .WithMany("ShootingIncident")
                        .HasForeignKey("RankId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AustinOfficerInvolvedShootings.Models.SubjectEthnicity", "SubjectEthnicity")
                        .WithMany("ShootingIncident")
                        .HasForeignKey("SubjectEthnicityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AustinOfficerInvolvedShootings.Models.SubjectInjuries", "SubjectInjuries")
                        .WithMany("ShootingIncident")
                        .HasForeignKey("SubjectInjuriesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AustinOfficerInvolvedShootings.Models.SubjectWeapon", "SubjectWeapon")
                        .WithMany("ShootingIncident")
                        .HasForeignKey("SubjectWeaponId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AustinOfficerInvolvedShootings.Models.WeekDay", "WeekDay")
                        .WithMany("ShootingIncident")
                        .HasForeignKey("WeekDayId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AustinOfficerInvolvedShootings.Models.YearsExperience", "YearsExperience")
                        .WithMany("ShootingIncident")
                        .HasForeignKey("YearsExperienceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AustinOfficerInvolvedShootings.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AustinOfficerInvolvedShootings.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AustinOfficerInvolvedShootings.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
