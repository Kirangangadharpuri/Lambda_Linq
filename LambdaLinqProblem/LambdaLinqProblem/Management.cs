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
            var records= from product in products where (product.ProductId==1 || product.ProductId==4 || product.ProductId==9) && product.Rating>3 select product;
            Display(result);
            foreach (var rec in records)
            {
                Console.WriteLine(rec.ProductId + " " + rec.UserId + " " + rec.Rating + " " + rec.Review + " " + rec.IsLike);
            }
        }
        public void Count_GroupBy(List<ProductReview> products)
        {
            var result = products.GroupBy(x => x.ProductId);
            foreach(var rec in result)
            {
                Console.WriteLine(rec.Key+ " "+ rec.Count());

            }
            Console.WriteLine("********Linq*********");
            var records = products.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            foreach (var record in records)
            {
                Console.WriteLine(record.ProductId + " " + record.Count);

            }

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
