using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TownlyService.DataContracts;

namespace TownlyService.Controllers
{
    public class EventController : ApiController
    {
        #region defaultElements
        List<string> eventNames = new List<string>() { "TestEvent1", "TestEvent2", "TestEvent3", "TestEvent4", "TestEvent5" };
        List<Event> events = new List<Event>()
        {
            new Event()
            {
                EventId = Guid.NewGuid(),
                CreatedBy = "ADMIN",
                Description = "This is a description",
                From = DateTimeOffset.UtcNow.AddDays(1),
                To = DateTimeOffset.UtcNow.AddDays(7),
                Moderated = false,
                Name = "TestEvent1",
                Public = true
            },
            new Event()
            {
                EventId = Guid.NewGuid(),
                CreatedBy = "ADMIN",
                Description = "This is a description",
                From = DateTimeOffset.UtcNow.AddDays(2),
                To = DateTimeOffset.UtcNow.AddDays(8),
                Moderated = false,
                Name = "TestEvent2",
                Public = true
            },
            new Event()
            {
                EventId = Guid.NewGuid(),
                CreatedBy = "ADMIN",
                Description = "This is a description",
                From = DateTimeOffset.UtcNow.AddDays(3),
                To = DateTimeOffset.UtcNow.AddDays(9),
                Moderated = false,
                Name = "TestEvent3",
                Public = true
            },
            new Event()
            {
                EventId = Guid.NewGuid(),
                CreatedBy = "ADMIN",
                Description = "This is a description",
                From = DateTimeOffset.UtcNow.AddDays(4),
                To = DateTimeOffset.UtcNow.AddDays(10),
                Moderated = false,
                Name = "TestEvent4",
                Public = true
            }
        };
        #endregion

        [HttpGet]
        public List<Event> Events()
        {
            return events;
        }

        [HttpGet]
        public List<string> EventNames(string eventName)
        {
            if (String.IsNullOrWhiteSpace(eventName))
            {
                return new List<string>();
            }

            return eventNames.Where(name => name.Contains(eventName)).ToList();
        }
    }
}
