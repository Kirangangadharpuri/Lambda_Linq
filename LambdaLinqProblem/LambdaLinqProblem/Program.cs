using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Management management = new Management();

            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview(){ ProductId=1,UserId=101, Rating=5, Review="Very Good",IsLike=true },
                new ProductReview(){ ProductId=2,UserId=102, Rating=4, Review="Good",IsLike=true },
                new ProductReview(){ ProductId=3,UserId=103, Rating=4, Review="Good",IsLike=true },
                new ProductReview(){ ProductId=4,UserId=104, Rating=3, Review="Very Good",IsLike=true },
                new ProductReview(){ ProductId=5,UserId=105, Rating=2, Review="Poor",IsLike=false },
                new ProductReview(){ ProductId=6,UserId=106, Rating=3, Review="Very Good",IsLike=false },
                new ProductReview(){ ProductId=7,UserId=107, Rating=4, Review="Good",IsLike=true },
                new ProductReview(){ ProductId=8,UserId=108, Rating=5, Review="Very Good",IsLike=true },
                new ProductReview(){ ProductId=9,UserId=109, Rating=2, Review="Poor",IsLike=true },
                new ProductReview(){ ProductId=10,UserId=110, Rating=4, Review="Good",IsLike=true },
                new ProductReview(){ ProductId=11,UserId=111, Rating=3, Review="Average",IsLike=false },
                new ProductReview(){ ProductId=12,UserId=112, Rating=2, Review="Poor",IsLike=false },
                new ProductReview(){ ProductId=13,UserId=113, Rating=1, Review=" Bad",IsLike=false },
                new ProductReview(){ ProductId=14,UserId=114, Rating=1, Review=" Bad",IsLike=false },
                new ProductReview(){ ProductId=15,UserId=115, Rating=2, Review="Poor",IsLike=false },
                new ProductReview(){ ProductId=16,UserId=116, Rating=3, Review="Average",IsLike=false },
                new ProductReview(){ ProductId=17,UserId=117, Rating=3, Review="Average",IsLike=false },
                new ProductReview(){ ProductId=5,UserId=118, Rating=2, Review="Poor",IsLike=false },
                new ProductReview(){ ProductId=5,UserId=119, Rating=5, Review="Very Good",IsLike=true },
                new ProductReview(){ ProductId=2,UserId=120, Rating=4, Review="Good",   IsLike=true },
                new ProductReview(){ ProductId=10,UserId=121, Rating=4, Review="Good",IsLike=true },
                new ProductReview(){ ProductId=2,UserId=122, Rating=5, Review="Very Good",IsLike=true },
                new ProductReview(){ ProductId=3,UserId=123, Rating=5, Review="Very Good",IsLike=true },
                new ProductReview(){ ProductId=4,UserId=124, Rating=5, Review="Very Good",IsLike=true },
                new ProductReview(){ ProductId=5,UserId=125, Rating=4, Review="Good",IsLike=true },

            };
            while(true)
            {

                Console.WriteLine("1-Top three ratings");
                Console.WriteLine("2- take ProductId 1, 4, 9 greater than 3");
                Console.WriteLine("3- total count group by product Id");
                Console.WriteLine("4- Retrive only ProductId and Review");
                Console.WriteLine("5- Skip top 5 Records");
                Console.WriteLine("Choose obove oprion");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1 :
                        management.TopThreeRecord(list);
                        management.Display(list);
                        break; 
                    case 2 :    
                        management.ProductRating(list);
                        break;
                    case 3 :
                        management.Count_GroupBy(list);
                        break;
                    case 4:
                        management.ProductId_Review(list);
                        break;
                    case 5:
                        management.SkipTopFive(list);
                        break;
                }
            }
        }
    }
}
