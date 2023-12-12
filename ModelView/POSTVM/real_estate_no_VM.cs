using ProjectEweis.Models;
using ProjectEweis.ModelView.RequestVM;
using System.ComponentModel.DataAnnotations;
using TestApiJWT.Models;

namespace ProjectEweis.ModelView.POSTVM
{
    public class real_estate_no_VM
    {
        
        public int purpose { get; set; }
        public int property_type { get; set; }
        public int property_area { get; set; }
        public string? directions { get; set; }
        public int street_width { get; set; }
        public int negotiable { get; set; }
        public string? Neighborhood { get; set; }
        public int needs_money { get; set; }
        public string? UserID { get; set; }
        public int partner_type { get; set; }
        public int city_id { get; set; }
        public int investment_cost { get; set; }
        public string? description { get; set; }
        public int partners_count { get; set; }
        public string? partnerNeighborhoods { get; set; }
    }
    public partial class maper
    {

        public real_estate_no Mapreal_estate_no(real_estate_no_VM VM)
        {
        var x = new real_estate_no
            {
               purpose = VM.purpose,
               property_type = VM.property_type,
               property_area= VM.property_area,
               directions = VM.directions,
               Neighborhood=VM.Neighborhood,
               partners_count = VM.partners_count,
               description = VM.description,
               investment_cost = VM.investment_cost,
               city_id = VM.city_id,
               partner_type = VM.partner_type,
               needs_money = VM.needs_money,
               partnerNeighborhoods = VM.partnerNeighborhoods,
               negotiable = VM.negotiable,
               street_width = VM.street_width,
            };

            return x;
        }

        internal UserRequest MapUserReques(UserRequesVM userReques)
        {
            throw new NotImplementedException();
        }
    }
}
