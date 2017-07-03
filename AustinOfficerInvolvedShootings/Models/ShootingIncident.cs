using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AustinOfficerInvolvedShootings.Models
{
    public class ShootingIncident
    {
        public int Id { get; set; }
        public int CaseNumberId { get; set; }
        public string Date { get; set; }
        public int WeekDayId { get; set; }
        public string DayPart { get; set; }
        public string Premise { get; set; }
        public string InsideOutisde { get; set; }
        public int SubjectWeaponId { get; set; }
        public int NumberOfficerShooters { get; set; }
        public int CallTypeId { get; set; }
        public int NumberOfficerPresent { get; set; }
        public int NumberHits { get; set; }
        public int OfficerNameId { get; set; }
        public int RankId { get; set; }
        public int OfficerEthnicityId { get; set; }
        public string OfficerGender { get; set; }
        public int OfficerAge { get; set; }
        public string Jurisdiction { get; set; }
        public int YearsExperienceId { get; set; }
        public string PreviousOIS { get; set; }
        public int OfficerWeaponCaliberId { get; set; }
        public string OfficerWeaponType { get; set; }
        public int NumberShotsFired { get; set; }
        public string HowCleared { get; set; }
        public int SubjectEthnicityId { get; set; }
        public string SubjectGender { get; set; }
        public int SubjectAge { get; set; }
        public int SubjectInjuriesId { get; set; }
        public int DrugsAlcoholId { get; set; }
        public string Location { get; set; }

        public virtual CaseNumber CaseNumber { get; set; }
        public virtual WeekDay WeekDay { get; set; }
        public virtual SubjectWeapon SubjectWeapon { get; set; }
        public virtual CallType CallType { get; set; }
        public virtual OfficerName OfficerName { get; set; }
        public virtual Rank Rank { get; set; }
        public virtual OfficerEthnicity OfficerEthnicity { get; set; }
        public virtual YearsExperience YearsExperience { get; set; }
        public virtual OfficerWeaponCaliber OfficerWeaponCaliber { get; set; }
        public virtual SubjectEthnicity SubjectEthnicity { get; set; }
        public virtual SubjectInjuries SubjectInjuries { get; set; }
        public virtual DrugsAlcohol DrugsAlcohol { get; set; }


    }

    public class CaseNumber
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ShootingIncident> ShootingIncident { get; set; }
    }

    public class WeekDay
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ShootingIncident> ShootingIncident { get; set; }
    }

    public class SubjectWeapon
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ShootingIncident> ShootingIncident { get; set; }
    }

    public class CallType
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ShootingIncident> ShootingIncident { get; set; }
    }
    public class OfficerName
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ShootingIncident> ShootingIncident { get; set; }
    }

    public class Rank
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ShootingIncident> ShootingIncident { get; set; }
    }

    public class OfficerEthnicity
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ShootingIncident> ShootingIncident { get; set; }
    }

    public class YearsExperience
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ShootingIncident> ShootingIncident { get; set; }
    }

    public class OfficerWeaponCaliber
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ShootingIncident> ShootingIncident { get; set; }
    }

    public class SubjectEthnicity
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ShootingIncident> ShootingIncident { get; set; }
    }

    public class SubjectInjuries
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ShootingIncident> ShootingIncident { get; set; }
    }

    public class DrugsAlcohol
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public virtual ICollection<ShootingIncident> ShootingIncident { get; set; }
    }
}

    
