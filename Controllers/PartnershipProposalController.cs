using DAL.DBContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectEweis.Models;
using ProjectEweis.ModelView.POSTVM;

namespace ProjectEweis.Controllers
{
   // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PartnershipProposalController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public PartnershipProposalController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        public IActionResult PostPartnershipProposal(PartnershipProposalModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (model.Ispartnership_amount_appropriate == false)
            {
                Partnership_proposal partnership_ = new Partnership_proposal
                {
                    Islocation_suitable = model.Islocation_suitable,
                    Ispartnership_amount_appropriate = model.Ispartnership_amount_appropriate,
                    Amount = model.Amount,
                    UserId=model.UserId
                };
                _db.Partnership_Proposals.Add(partnership_);
            }
            else
            {
                Partnership_proposal partnership_ = new Partnership_proposal
                {
                    Islocation_suitable = model.Islocation_suitable,
                    Ispartnership_amount_appropriate = model.Ispartnership_amount_appropriate,
                    UserId=model.UserId
                   
                };
                _db.Partnership_Proposals.Add(partnership_);

            }
            _db.SaveChanges();


            return Ok(new {message= "تم إضافة العرض بنجاح" });
        }
    }
}
