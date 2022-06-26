using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Rating
    {
        public int ID { get; set; }
        public int RatingBlogID { get; set; }
        public int RatingTotalScore { get; set; }
        public int RatingCount { get; set; }
        public double RatingAverage { get; set; }   
    }
}
