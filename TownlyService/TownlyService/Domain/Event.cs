using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TownlyService.Domain
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTimeOffset From { get; set; }

        public DateTimeOffset To { get; set; }

        public bool Public { get; set; }

        public bool Moderated { get; set; }

        public string Barcode { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        public DateTimeOffset CreatedAtUtc { get; set; }

        public DateTimeOffset ModifiedAtUtc { get; set; }

        public string PublicEventId { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}