using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AustinOfficerInvolvedShootings.Models;
using AustinOfficerInvolvedShootings.Models.AccountViewModels;

namespace AustinOfficerInvolvedShootings.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<AustinOfficerInvolvedShootings.Models.ShootingIncident> ShootingIncident { get; set; }
        public DbSet<AustinOfficerInvolvedShootings.Models.CallType> CallType { get; set; }
        public DbSet<AustinOfficerInvolvedShootings.Models.CaseNumber> CaseNumber { get; set; }
        public DbSet<AustinOfficerInvolvedShootings.Models.SubjectInjuries> SubjectInjuries { get; set; }
        public DbSet<AustinOfficerInvolvedShootings.Models.DrugsAlcohol> DrugsAlcohol { get; set; }
        public DbSet<AustinOfficerInvolvedShootings.Models.OfficerEthnicity> OfficerEthnicity { get; set; }
        public DbSet<AustinOfficerInvolvedShootings.Models.OfficerName> OfficerName { get; set; }
        public DbSet<AustinOfficerInvolvedShootings.Models.OfficerWeaponCaliber> OfficerWeaponCaliber { get; set; }
        public DbSet<AustinOfficerInvolvedShootings.Models.Rank> Rank { get; set; }
        public DbSet<AustinOfficerInvolvedShootings.Models.SubjectEthnicity> SubjectEthnicity { get; set; }
        public DbSet<AustinOfficerInvolvedShootings.Models.SubjectWeapon> SubjectWeapon { get; set; }
        public DbSet<AustinOfficerInvolvedShootings.Models.WeekDay> WeekDay { get; set; }
        public DbSet<AustinOfficerInvolvedShootings.Models.YearsExperience> YearsExperience { get; set; }
        public DbSet<AustinOfficerInvolvedShootings.Models.AccountViewModels.EditUserViewModel> EditUserViewModel { get; set; }
        public DbSet<AustinOfficerInvolvedShootings.Models.Donation> Donation { get; set; }
        public DbSet<AustinOfficerInvolvedShootings.Models.Cart> Cart { get; set; }
    }
}
