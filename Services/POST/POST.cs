using DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using ProjectEweis.Models;
using ProjectEweis.ModelView.POSTVM;

namespace ProjectEweis.Services.POST
{
    public class POST : IPOST
    {
        maper maper = new maper();
        private readonly ApplicationDbContext _db;
        public POST(ApplicationDbContext db)
        {
            _db = db;
        }

        public string AddCommercialPost(CommercialVM commercialVM)
        {
            try
            {
                var commercial = maper.MapCommercial(commercialVM);
                commercial.Owner = _db.Users.FirstOrDefault(u => u.Id == commercialVM.UserId);
                _db.Add(commercial);
                _db.SaveChanges();
                return "save ok";
            }
            catch (Exception ex)
            {
                return ex.InnerException.Message;
            }
        }

        public string Addreal_estate_yes(real_estate_yes_VM VM)
        {
            try
            {
                var real_estate_yes = maper.Mapreal_estate_yes(VM);
                real_estate_yes.Owner = _db.Users.FirstOrDefault(u => u.Id == VM.UserID);
                _db.Add(real_estate_yes);
                _db.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.InnerException.Message;
            }

        }
        public string Addreal_estate_no(real_estate_no_VM VM)
        {
            try
            {
                var real_estate_no = maper.Mapreal_estate_no(VM);
                real_estate_no.Owner= _db.Users.FirstOrDefault(u => u.Id == VM.UserID);
                _db.Add(real_estate_no);
                _db.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.InnerException.Message;
            }
        }

        public AllPosts GetAllPosts()
        {
            return new AllPosts()
            {
              commercials     = _db.commercials.Include(m => m.Owner).Where(m=> m.Deleted == 0).ToList(),
              real_Estate_No  = _db.real_estate_nos.Include(m => m.Owner).Where(m => m.Deleted == 0).ToList(),
              real_Estate_Yes = _db.real_estate_yess.Include(m => m.Owner).Where(m => m.Deleted == 0).ToList(),
             };
        }

        public AllPosts GetmyPosts(string Iduser)
        {
            return new AllPosts()
            {
                commercials     = _db.commercials.Include(m=>m.Owner).Where(m=> m.Owner.Id == Iduser && m.Deleted==0).ToList(),
                real_Estate_No  = _db.real_estate_nos.Include(m => m.Owner).Where(m => m.Owner.Id == Iduser && m.Deleted == 0).ToList(),
                real_Estate_Yes = _db.real_estate_yess.Include(m => m.Owner).Where(m => m.Owner.Id == Iduser && m.Deleted == 0).ToList(),
            };
        }
    }
}