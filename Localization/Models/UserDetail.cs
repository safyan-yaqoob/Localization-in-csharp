using Localization.Resources;
using System.ComponentModel.DataAnnotations;

namespace MvcLocalization.Models
{
    public class UserDetail
    {
        [Display(Name ="First Name",ResourceType =typeof(Resource))]
        public string FirstName { get; set; }

        [Display(Name = "Last Name", ResourceType = typeof(Resource))]
        public string LastName { get; set; }
    }
}