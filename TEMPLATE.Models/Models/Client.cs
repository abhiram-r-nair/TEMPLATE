using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEMPLATE.Models.Models
{
    public class Client
    {
        public required long Id { get; set; }
        public required string Name { get; set; }
        public required bool IsActive { get; set; }
        public required DateTime CreatedOn { get; set; }
        public required DateTime LastUpdatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool IsDataActive { get; set; }
    }
}
