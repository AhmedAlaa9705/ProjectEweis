using ProjectEweis.Migrations;
using ProjectEweis.Models;
using ProjectEweis.ModelView.RequestVM;

namespace ProjectEweis.Services.Request
{
    public interface IRequest
    {
        public string AddrequestForRealEstateYes(UserRequesVM userReques);
        public string AddrequestForRealEstateNo(UserRequesVM userReques);
        public string AddrequestForCommercial(UserRequesVM userReques);
        public List<UserRequest> GetMyRequests(string IDuser);
        public List<UserRequest> GetRequestsOnPost(string IDRequest);

    }
}
