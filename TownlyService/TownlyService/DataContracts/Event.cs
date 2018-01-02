using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TownlyService.DataContracts
{
    public class Event
    {
        public Guid EventId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTimeOffset From { get; set; }

        //[Required]
        public DateTimeOffset To { get; set; }

        //[Required]
        public bool Public { get; set; }

        //[Required]
        public bool Moderated { get; set; }

        public string Barcode { get; set; }

        public string CreatedBy { get; set; }

    }
}