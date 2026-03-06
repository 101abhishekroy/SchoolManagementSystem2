namespace SchoolManagementSystem2.Models
{
    public class Report
    {
        public int ReportID { get; set; }
        public int? StudentID { get; set; }
       
        public string Summary { get; set; }
        public DateTime ReportDate { get; set; }
        public string Category {  get; set; }
    }
}
