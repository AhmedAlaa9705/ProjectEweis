using ProjectEweis.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjectEweis.ModelView.POSTVM
{
    public class CommercialVM
    {
        public int partner_type { get; set; }
        public int city_id { get; set; }
        public int investment_cost { get; set; }
        public string description { get; set; }
        public int partners_count { get; set; }
        public string title { get; set; }
        public int domain_id  { get; set; }
        public int project_status { get; set; }
        public int user_contribution { get; set; }
        public int other_contribution { get; set; }
        public string UserId { get; set; }
    }

    public partial class maper
    {
        public commercial MapCommercial(CommercialVM VM)
        {
            var map = new commercial
            {
                partner_type = VM.partner_type,
                city_id = VM.city_id,
                investment_cost = VM.investment_cost,
                description = VM.description,
                partners_count = VM.partners_count,
                project_status = VM.project_status,
                user_contribution = VM.user_contribution,
                other_contribution = VM.other_contribution,
            };
            return map;
        }
    }
}
