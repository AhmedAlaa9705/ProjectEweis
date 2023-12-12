using ProjectEweis.Models;

namespace ProjectEweis.ModelView.POSTVM
{
    public class AllPosts
    {
        public List<commercial> commercials {  get; set; } 
        public List<real_estate_yes> real_Estate_Yes { get; set; }
        public List <real_estate_no> real_Estate_No { get; set; }
    }
}
