using System.ComponentModel.DataAnnotations;
namespace Tracking.models
{
    public class issue
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public priority priority { get; set; }
        public issuetype issuetype { get; set; }
        public DateTime created { get; set; }
        public DateTime? completed { get; set; }
    
    }

}
 public enum priority
{
    Low, Medium, High
}
public enum issuetype
{
    Feature,Bug,Documentation
}