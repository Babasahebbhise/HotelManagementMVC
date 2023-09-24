namespace HOTELBHISEFAMILY.Models
{
    public class Customer
    {
        public int Customer_Id { get; set; }
        public string Customer_First_Name { get; set;}
        public string Customer_Middle_Name { get; set; }
        public string Customer_Last_Name { get; set; }
        public string Customer_Email { get; set;}
        public string Customer_MobileNumber { get; set;}
        public string Customer_City { get; set;}
        public string Customer_Password { get; set; }
        public IFormFile Customer_ProfilePhote { get; set; }

    }
}
