using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TownlyService.Domain
{
    public class Event
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid EventId { get; set; }

        [Key]
        [StringLength(256)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTimeOffset From { get; set; }

        [Required]
        public DateTimeOffset To { get; set; }

        [Required]
        public bool Public { get; set; }

        [Required]
        public bool Moderated { get; set; }

        public string Barcode { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        public DateTimeOffset CreatedAtUtc { get; set; }

        public DateTimeOffset ModifiedAtUtc { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}