using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Allocation_Management
{
    [Table("tbl_project")]
    public class Project
    {
        public Int64 Id { get; set; }

        [Required]
        [StringLength(35)]
        public String Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime PlannedTerm { get; set; }

        public DateTime Termination { get; set; }
        [NotMapped]
        public List<Allocation> Allocations { get; set; }

        public Project()
        {
        }

        public Project(string name, DateTime start, DateTime plannedTerm, DateTime termination)
        {
            Name = name;
            Start = start;
            PlannedTerm = plannedTerm;
            Termination = termination;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
