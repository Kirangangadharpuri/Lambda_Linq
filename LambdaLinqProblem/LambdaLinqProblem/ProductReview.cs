using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProblem
{
    //Lambda expression is used to create anonymous function, expression and body member
    // Its a short block of code that accepts and return a value
    // Use (=>) - is a lambda operator which is used for all the lambda expression 

    public class ProductReview
    {
        //ProductId, UserId, Rating, Review and isLike Fields
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set;}
        public string Review { get; set; }
        public bool IsLike { get; set; }
    }
}
