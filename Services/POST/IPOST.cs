using ProjectEweis.ModelView.POSTVM;

namespace ProjectEweis.Services.POST
{
    public interface IPOST
    {
        public string AddCommercialPost(CommercialVM commercialVM);
        public string Addreal_estate_yes(real_estate_yes_VM VM);
        public string Addreal_estate_no(real_estate_no_VM VM);
        public AllPosts GetAllPosts ();
        public AllPosts GetmyPosts(string Iduser);
    }
}
