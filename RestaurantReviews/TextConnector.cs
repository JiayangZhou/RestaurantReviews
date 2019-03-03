using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews
{
    public class TextConnector
    {
        private const string ReviewsFile = "Reviews.csv";

        public Review CreateReviews(Review model)
        {
            List<Review> reviews = ReviewsFile.FullFilePath().LoadFile().ConvertToReview();

            int currentId = 1;

            if (reviews.Count > 0)
            {
                currentId = reviews.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            reviews.Add(model);
            reviews.SaveToReviewsFile(ReviewsFile);
            return model;
        }

        public List<Review> GetAllReviews()
        {
            List<Review> reviews = new List<Review>();
            return reviews = ReviewsFile.FullFilePath().LoadFile().ConvertToReview();
        }
    }
}
