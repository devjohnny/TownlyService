using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TownlyService.DataContracts
{
    public class Question
    {
        
        public int QuestionId { get; set; }

        public string QuestionText { get; set; }

        public bool Moderated { get; set; }

        //[Required]
        public string CreatedBy { get; set; }

        public DateTimeOffset CreatedAtUtc { get; set; }

        public DateTimeOffset ModifiedAtUtc { get; set; }

        public int EventId { get; set; }
    }
}