using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faith.Models.Dtos
{
    public class PostDTO
    {
        public int Id { get; set; }
        public int JongereId { get; set; }
        public int ReactieId { get; set; }
        public string ReactieContent { get; set; }
        public DateTime TimeStamp { get; set; }
        public string ImageURL { get; set; }
    }
}
