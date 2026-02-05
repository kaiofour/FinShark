using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api
{
    public class Comment
    {
        /**
        * public = access modifier
        * int = data type
        * Id = name of the property
        * { get; set; } = accessors / auto-implemented property
        **/
        
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        // Navigational Property to Stock (creating relationships)
        public int? StockId { get; set; } 
        public Stock? Stock { get; set; }
    }
}