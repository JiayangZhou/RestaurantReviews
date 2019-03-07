using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews
{
    public static class TextProcessor
    {

        public static string FullFilePath(this string fileName) 
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<Review> ConvertToReview(this List<string> lines)
        {
            List<Review> output = new List<Review>();
            foreach (string line in lines)
            {
                if (line != "")
                {
                    string[] cols = line.Split('|');
                    Review p = new Review();
                    p.Id = int.Parse(cols[0]);
                    p.Nickname = cols[1];
                    p.ReviewContext = cols[2];
                    output.Add(p);
                }
            }
            return output;
        }

        
        public static void SaveToReviewsFile(this List<Review> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (Review p in models)
            {
                lines.Add($"{p.Id}|{p.Nickname}|{p.ReviewContext}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
