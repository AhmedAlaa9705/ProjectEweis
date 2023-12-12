using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectEweis.Healper;
using ProjectEweis.Models;
using ProjectEweis.ModelView.POSTVM;
using ProjectEweis.ModelView.RequestVM;
using ProjectEweis.Services.POST;
using ProjectEweis.Services.Request;

namespace ProjectEweis.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IPOST _POST;
        private readonly IRequest _Request;

        public HomeController(IPOST POST , IRequest Request)
        {
            _POST = POST;
            _Request = Request;
        }

        [HttpPost]
        public string AddCommercialPost([FromBody] CommercialVM commercialVM)
        {
            return _POST.AddCommercialPost(commercialVM);
        }


        [HttpPost]
        public string Addreal_estate_yesPost([FromForm] real_estate_yes_VM VM )
        {
            return _POST.Addreal_estate_yes(VM);
        }
        

        [HttpPost]
        public string Addreal_estate_noPost([FromBody] real_estate_no_VM VM)
        {
            return _POST.Addreal_estate_no(VM);
        }

        [HttpGet]
        public AllPosts GetAllPost()
        {
            return _POST.GetAllPosts();
        }


        [HttpGet]
        public AllPosts GetmyPosts(string Iduser)
        {
            return _POST.GetmyPosts(Iduser); 
        }

        [HttpPost]
        public string AddRequest_Commercial(UserRequesVM Reques)
        {
            return _Request.AddrequestForCommercial(Reques);
        }


        [HttpPost]
        public string AddRequest_Real_Estate_Yes(UserRequesVM Reques)
        {
            return _Request.AddrequestForRealEstateYes(Reques);
        }


        [HttpPost]
        public string AddRequest_Real_Estate_No(UserRequesVM Reques)
        {
            return _Request.AddrequestForRealEstateNo(Reques);
        }


        [HttpGet]
        public List<UserRequest> GetMyRequest(string IDrquest)
        {
            return _Request.GetMyRequests(IDrquest);
        }


        [HttpGet]
        public List<UserRequest> GetRequestsOnPost(string IDrquest)
        {
            return _Request.GetRequestsOnPost(IDrquest);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetCities()
        {
            List<cities> cities = new List<cities>();
            var filePath = Directory.GetCurrentDirectory() + @"\cities.json";
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                cities=JsonConvert.DeserializeObject<List<cities>>(json);
            }
            return Ok(cities);
        }

        [HttpGet]
        [AllowAnonymous]

        public IActionResult GetRegions()
        {
            List<regions> regions = new List<regions>();
            var filePath = Directory.GetCurrentDirectory() + @"\regions.json";
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                regions = JsonConvert.DeserializeObject<List<regions>>(json);
            }
            return Ok(regions);
        }

    }
}
