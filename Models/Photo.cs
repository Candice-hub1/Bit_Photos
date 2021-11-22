using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bit_Photos.Models
{
    public class Photo
    {
        
        public int photoId { get; set; }
        public string Album_Title { get; set; }
        public byte[] picture { get; set; }
        public string PhotoName { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }

        public Photo()
        {

        }
    }
}
