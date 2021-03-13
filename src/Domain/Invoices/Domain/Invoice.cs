using System;

namespace Invoices.Domain
{
    public class Invoice
    {
        public string Id { get; set; }
        public double PayRate { get; set; }
        public string DeveloperName { get; set; }
        public string DeveloperLastName { get; set; }
        public string ExperienceLevel { get; set; }
        public string CurrentRole { get; set; }
        public int Age { get; set; }
        public int TotalExperience { get; set; }
        public string[] RelevantExperience { get; set; }
        public string[] Skills { get; set; }
        public string CreateAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
