using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Vote
    {
        public int ID { get; set; }
        public int VoteOfBlogID { get; set; }
        public int Score { get; set; }
    }
}
