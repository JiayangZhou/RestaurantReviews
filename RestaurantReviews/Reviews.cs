using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews
{
    public class Review
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string ReviewContext { get; set; }

        public Review()
        {

        }

        public Review(string nickName, string reviewContext)
        {
            Nickname = nickName;
            ReviewContext = reviewContext;
        }

        public string FullInfo
        {
            get
            {
                return $"Nickname:{Nickname} Review:{ReviewContext}";
            }
        }
    }
}
