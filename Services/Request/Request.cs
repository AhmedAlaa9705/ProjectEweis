using DAL.DBContext;
using ProjectEweis.Migrations;
using ProjectEweis.Models;
using ProjectEweis.ModelView.POSTVM;
using ProjectEweis.ModelView.RequestVM;

namespace ProjectEweis.Services.Request
{
    public class Request : IRequest
    {

        private readonly ModelView.POSTVM.maper maper = new ModelView.POSTVM.maper();
        private readonly ApplicationDbContext _db;
        public Request(ApplicationDbContext db)
        {
            _db = db;
        }

        public string AddrequestForCommercial(UserRequesVM userReques)
        {
            try{
                UserRequest request = maper.MapUserReques(userReques);
                request.Requester = _db.Users.FirstOrDefault(u => u.Id == userReques.Requester);
                request.commercial = _db.commercials.FirstOrDefault(u => u.ID.ToString() == userReques.commercial);
                _db.Add(request);
                _db.SaveChanges();
                return "it is ok";
            }
            catch (Exception ex)
            {
                return ex.InnerException.Message;
            }
        }

        public string AddrequestForRealEstateNo(UserRequesVM userReques)
        {
            try
            {
                UserRequest request = maper.MapUserReques(userReques);
                request.Requester = _db.Users.FirstOrDefault(u => u.Id == userReques.Requester);
                request.real_estate_no = _db.real_estate_nos.FirstOrDefault(u => u.ID.ToString() == userReques.commercial);
                _db.Add(request);
                _db.SaveChanges();
                return "it is ok";
            }
            catch (Exception ex)
            {
                return ex.InnerException.Message;
            }
        }

        public string AddrequestForRealEstateYes(UserRequesVM userReques)
        {
            try
            {
                UserRequest request = maper.MapUserReques(userReques);
                request.Requester = _db.Users.FirstOrDefault(u => u.Id == userReques.Requester);
                request.real_estate_yes = _db.real_estate_yess.FirstOrDefault(u => u.ID.ToString() == userReques.commercial);
                _db.Add(request);
                _db.SaveChanges();
                return "it is ok";
            }
            catch (Exception ex)
            {
                return ex.InnerException.Message;
            }
        }

        public List<UserRequest> GetMyRequests(string IDuser)
        {
            return _db.Requests.Where(m => m.Requester.Id == IDuser).ToList();
        }      

        public List<UserRequest> GetRequestsOnPost(string IDRequest)
        {
            return _db.Requests.Where(m => m.real_estate_no.ID.ToString() == IDRequest || m.real_estate_yes.ID.ToString() == IDRequest  || m.commercial.ID.ToString() == IDRequest).ToList();
        }
    }
}
