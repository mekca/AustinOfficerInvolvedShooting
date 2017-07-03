using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using AustinOfficerInvolvedShootings.Infrastructure;






namespace AustinOfficerInvolvedShootings.Models
{
    public class SessionCart : CartList
    {
        public static CartList GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionCart cartList = session?.GetJson<SessionCart>("CartList") ?? new SessionCart();
            cartList.Session = session;
            return cartList;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(CaseNumber caseNumber)
        {
            base.AddItem(caseNumber);
            Session.SetJson("CartList", this);
        }

        public override void RemoveItem(CaseNumber caseNumber)
        {
            base.RemoveItem(caseNumber);
            Session.SetJson("CartList", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.Remove("CartList");
        }
    }
}
