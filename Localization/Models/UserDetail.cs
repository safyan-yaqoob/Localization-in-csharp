using Localization.Resources;
using System.ComponentModel.DataAnnotations;

namespace MvcLocalization.Models
{
    public class UserDetail
    {
        [Display(Name = "FirstName", ResourceType = typeof(Resource))]
        public string FirstName { get; set; }

        [Display(Name = "LastName", ResourceType = typeof(Resource))]
        public string LastName { get; set; }
    }
}