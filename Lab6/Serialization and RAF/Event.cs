using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Serialization_and_RAF
{
    [Serializable]
    public class Event
    {
        public int EventNumber { get; set; }
        public string Location { get; set; }

        public Event(int eventNumber, string location)
        {
            EventNumber = eventNumber;
            Location = location;
        }

        public override string ToString()
        {
            return $"Event Number: {EventNumber} \nLocation: {Location}";
        }
    }
}
