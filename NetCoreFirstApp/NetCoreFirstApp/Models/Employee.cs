using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreFirstApp.Models
{
    public class Employee
    {
        /// <summary>
        /// Unique identity
        /// </summary>
        [Required]
        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RecordId { get; set; }

        /// <summary>
        /// Employee Name
        /// </summary>
        [Column(Order = 2), MaxLength(50)]
        [Display (Name ="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Employee Surname
        /// </summary>
        [Column(Order = 3), MaxLength(50)]
        public string Surname { get; set; }

        /// <summary>
        /// Employee's Age
        /// </summary>
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Age must be a natural number")]
        [Column(Order = 4)]
        public int Age { get; set; }

        /// <summary>
        /// Employee's Department Record Id
        /// </summary>
        [Column(Order = 5)]
        public long DepartmentRecordId { get; set; }

        /// <summary>
        /// Employee's Title Record Id
        /// </summary>
        [Column(Order = 6)]
        public long TittleRecordId { get; set; }

        /// <summary>
        /// Employee's Salary $$
        /// </summary>
        [Column(Order = 7)]
        public decimal Salary { get; set; }
    }
}
