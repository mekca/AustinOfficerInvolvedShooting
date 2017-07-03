using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AustinOfficerInvolvedShootings.Models
{
    public class CartList
    {
        private List<Cart> cartCollection = new List<Cart>();

        public virtual void AddItem(CaseNumber caseNumber)
        {
            Cart cart = cartCollection.Where(f => f.CaseNumber.Id == caseNumber.Id).FirstOrDefault();

            if (cart == null)
            {
                cartCollection.Add(new Cart
                {
                    CaseNumber = caseNumber
                });
            }
        }

        public virtual void RemoveItem(CaseNumber caseNumber) => cartCollection.RemoveAll(l => l.CaseNumber.Id == caseNumber.Id);

        public virtual decimal ComputeTotalValue() => cartCollection.Sum(e => e.Amount);

        public virtual void Clear() => cartCollection.Clear();

        public virtual IEnumerable<Cart> Carts => cartCollection;
    }

    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Fund")]
        public int CaseNumberId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "Donation")]
        public decimal Amount { get; set; }

        public virtual CaseNumber CaseNumber { get; set; }

    }
}
