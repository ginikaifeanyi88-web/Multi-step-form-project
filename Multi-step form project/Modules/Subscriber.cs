using System.Net.Mail;

namespace Multi_step_form_project.Modules
{
    public class Subscriber
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PlanSelected { get; set; }
        public string? MonthlyOrYearly { get; set; }
        public int OnlineService { get; set; }
        public int LargerStorage { get; set; }
        public int CustomizableProfile {  get; set; }
        public int TotalCost { get; set; }
        public int AddOnsCost { get; set;  }

    }
}
