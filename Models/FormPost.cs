using ProjectEweis.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestApiJWT.Models;


namespace ProjectEweis.Models
{
    public interface IGeneralPost
    {
      
        public Guid ID { get; set; }
   
        public ApplicationUser Owner { get; set; }
       
        public int partner_type { get; set; }
       
        public int city_id { get; set; }
       
        public int investment_cost { get; set; }
        public string description { get; set; }
    
        public int partners_count { get; set; }
    }

    public interface Icommercial
    {
        public int project_status { get; set; }
        public int user_contribution { get; set; }
        public int other_contribution { get; set; }
    }

    public interface Ireal_estate
    {
        public int    purpose { get; set; }
        public int    property_type { get; set; }
        public int    property_area { get; set; }
        public string directions { get; set; }
        public int    street_width { get; set; }
        public int    negotiable { get; set; }
        public string partnerNeighborhoods { get; set; }
        public int    needs_money { get; set; }
    }





    public class commercial : IGeneralPost, Icommercial
    {
        [Key]
        public Guid ID { get; set; }
         
        public ApplicationUser Owner { get ; set ; }
         
        public int partner_type { get ; set ; }
         
        public int city_id { get ; set ; }
         
        public int investment_cost { get ; set ; }  
        public string description { get ; set ; }
         
        public int partners_count { get ; set ; }
         
        public int project_status { get ; set ; }
         
        public int user_contribution { get ; set ; }
         
        public int other_contribution { get ; set ; }
         
        public DateTime DateCreated { get; set; } = DateTime.Now;

         
        public int Deleted { get; set; } = 0;

        public List<UserRequest> requests { get; set; }
    }
    public class real_estate_yes : IGeneralPost, Ireal_estate
    {
        [Key]
        public Guid ID { get; set; }
         
        public int purpose { get ; set ; }
         
        public int property_type { get ; set ; }
         
        public int property_area { get ; set ; }
         
        public string? directions { get ; set ; }
         
        public int street_width { get ; set ; }
         
        public int negotiable { get ; set ; }
         
        public string? partnerNeighborhoods { get ; set ; }
         
        public int needs_money { get ; set ; }

         
        public ApplicationUser Owner { get ; set ; }
         
        public int partner_type { get ; set ; }
         
        public int city_id { get ; set ; }
         
        public int investment_cost { get ; set ; }
        public string? description { get ; set ; }
         
        public int partners_count { get ; set ; }
         
        public string? images { get ; set ; }
         
        public string? plan_number { get ; set ;}
         
        public string? property_number { get ; set ; }
         
        public int property_age{get; set;}
         
        public DateTime DateCreated { get; set; } = DateTime.Now;
         
        public int Deleted { get; set; } = 0;

        public List<UserRequest> requests { get; set; }

    }
    public class real_estate_no : IGeneralPost, Ireal_estate
    {
        [Key]
        public Guid ID { get; set; }
         
        public ApplicationUser Owner { get; set; }
         
        public int purpose { get ; set ; }
         
        public int property_type { get ; set ; }
         
        public int property_area { get ; set ; }
         
        public string? directions { get ; set ; }
         
        public int street_width { get ; set ; }
         
        public int negotiable { get ; set ; }
         
        public string? Neighborhood { get ; set ; }
         
        public int needs_money { get ; set ; }
        
         
        public int partner_type { get ; set ; }
         
        public int city_id { get ; set ; }
         
        public int investment_cost { get ; set ; }

        public string? description { get ; set ; }

         
        public int partners_count { get ; set ; }
        public string? partnerNeighborhoods { get ; set; }
         
        public DateTime DateCreated { get; set; } = DateTime.Now;
        
         
        public int Deleted { get; set; }=0;

        public List<UserRequest> requests { get; set; }
    }

    public class Partnership_proposal
    {
        public int Id { get; set; }
        public bool Islocation_suitable { get; set; }
        public bool Ispartnership_amount_appropriate { get; set; }
        public double? Amount { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}