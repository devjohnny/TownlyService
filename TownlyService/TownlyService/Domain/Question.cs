using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TownlyService.Domain
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }

        public string QuestionText { get; set; }

        public bool Moderated { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        public DateTimeOffset CreatedAtUtc { get; set; }

        public DateTimeOffset ModifiedAtUtc { get; set; }

        public int EventId { get; set; }

        public virtual Event Event { get; set; }
    }
}