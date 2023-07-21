using System;
using System.Collections.Generic;
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
            foreach (var item in result)
            {
             
                Console.WriteLine(item.ProductId+" "+item.UserId+" "+item.Rating+" "+item.Review+" "+item.IsLike);
            }
        }
    }
}
