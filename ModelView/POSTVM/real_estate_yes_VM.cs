using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjectEweis.Models;
using System.ComponentModel.DataAnnotations;
using TestApiJWT.Models;

namespace ProjectEweis.ModelView.POSTVM
{
    public class real_estate_yes_VM
    {

         
        public int purpose { get; set; }
         
        public int property_type { get; set; }
         
        public int property_area { get; set; }
         
        public string? directions { get; set; }
         
        public int street_width { get; set; }
         
        public int negotiable { get; set; }
         
        public string? partnerNeighborhoods { get; set; }
         
        public int needs_money { get; set; }
         
        public string? UserID { get; set; }
         
        public int partner_type { get; set; }
         
        public int city_id { get; set; }
         
        public int investment_cost { get; set; }
        public string? description { get; set; }
         
        public int partners_count {get; set; }

         
        public string? plan_number {get; set; }
         
        public string? property_number {get; set; }
         
        public int property_age {get; set;}

         
        public List<IFormFile>? images { get; set;}
    }

    public partial class maper
    {


       
            public static string SavePhoto (string ID,IFormFile Photo)
            {

                try
                {
                    if (Photo != null)
                    {
                        var filePath = Directory.GetCurrentDirectory() + @"\wwwroot\Photos\" + ID + Photo.FileName;
                        using (var stream = System.IO.File.Create(filePath))
                        {
                            Photo.CopyTo(stream);
                        }
                    }
                    return ID + Photo.FileName;
                }
                catch (Exception e) 
                {
                    return e.Message;
                }
            }
        


        public real_estate_yes Mapreal_estate_yes(real_estate_yes_VM VM)
        {

            var x= new real_estate_yes
               {
                        purpose = VM.purpose,
                        property_type = VM.property_type,
                        directions = VM.directions,
                        property_age = VM.property_age,
                        property_number = VM.property_number,
                        plan_number = VM.plan_number,
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
            
            x.images = "";

            foreach (var item in  VM.images)
            {
               x.images += "|||" + SavePhoto(Guid.NewGuid().ToString(), item);
            }

            return x;
        }

    }
}

