using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace FishingStore.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid> 
    {
        public ApplicationUser()
        { 
            this.Id = Guid.NewGuid();
        }

        public virtual ICollection<FullSet> FullSets { get; set; } = new HashSet<FullSet>();
    }
}
