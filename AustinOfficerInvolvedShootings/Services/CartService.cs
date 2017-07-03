using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using AustinOfficerInvolvedShootings.Data;

namespace AustinOfficerInvolvedShootings.Services
{
    public class CartService
    {
        private readonly ApplicationDbContext _context;

        public CartService(ApplicationDbContext context)
        {
            _context = context;
        }

        public int GetCartCount(System.Security.Claims.Claim user)
        {
            var user_id = user.Value;

            var c_count = _context.Cart.Where(c => c.UserId == user_id).Select(c => c).Count();

            return c_count;
        }
    }
}
