using ProjectEweis.Models;
using ProjectEweis.ModelView.POSTVM;
using System.ComponentModel.DataAnnotations;
using TestApiJWT.Models;

namespace ProjectEweis.ModelView.RequestVM
{
    public class UserRequesVM
    {
         
        public string Requester { get; set; }
        public int ISpecificationsOK { get; set; }
        public int ISAmountofMoneyOK { get; set; }
        public int SuggestedAmount { get; set; }
        public string commercial { get; set; }
        public string real_estate_yes { get; set; }
        public string real_estate_no { get; set; }
    }

    public partial class maper
    {
        public UserRequest MapUserReques(UserRequesVM VM)
        {
            var map = new UserRequest
            {
                ISpecificationsOK = VM.ISpecificationsOK,
                ISAmountofMoneyOK = VM.ISAmountofMoneyOK,
                SuggestedAmount = VM.SuggestedAmount,
            };
            return map;
        }
    }
}
