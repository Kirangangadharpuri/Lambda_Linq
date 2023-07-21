using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProblem
{
    public class Management
    {
        public void TopThreeRecord(List<ProductReview> products)
        {
            var result = products.OrderByDescending(x => x.Rating).Take(3);
            
            var record = (from product in products orderby product.Review descending select product).Take(3);
            //firstly sort data in descending order and then print top 3 records.
            Display(result);

        }
        public void ProductRating(List<ProductReview> products)
        {
            var result = products.Where(x => x.Rating > 3 && (x.ProductId == 1 || x.ProductId == 4 || x.ProductId == 9));
            Display(result);
        }
        public void Display(IEnumerable<ProductReview> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductId + " " + item.UserId + " " + item.Rating + " " + item.Review + " " + item.IsLike);
            }
        }
    }
}
