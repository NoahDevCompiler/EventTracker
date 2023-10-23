
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5.DataModells
{
    public class EventData
    {                 
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }
        public List<Event>? Events { get; set; }
    }

    public class Event{
        public string? Id { get; set; }
        public string? title { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }
        public string? closed { get; set; }
        public List<Category>? Categories { get; set; }
        public List<Source>? Sources { get; set; }
        public List<Geometry>? Geometry { get; set; }
    }
   
    public class Category
    {
        public string? id { get; set; }
        public string? title { get; set; }
    }

    public class Source
    {
        public string? id { get; set; }
        public string? url { get; set; }
    }

    public class Geometry
    {
        public float? magnitudeValue { get; set; }
        public string? magnitudeUnit { get; set; }
        public DateTime date { get; set; }
        public string? type { get; set; }
        public List<float>? Coordinates { get; set; }
    }

    

}
