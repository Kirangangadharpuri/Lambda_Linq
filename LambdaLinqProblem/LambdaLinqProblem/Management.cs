﻿using System;
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
        public void ProductId_Review(List<ProductReview> products)
        {
            var result = products.Select(x => new { x.ProductId, x.Review });
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductId + " " + item.Review);
            }
            Console.WriteLine("************* Linq ************");
            var record = from product in products select new {product.ProductId, product.Review };
            foreach (var product in record)
            {
                Console.WriteLine(product.ProductId + "  " + product.Review);
            }
        }
        public void SkipTopFive(List<ProductReview> products)
        {
            var result = products.OrderByDescending(x => x.Rating).Skip(5);
            Display(result);
            Console.WriteLine("*********** Linq *************");
            var record = (from product in products select product).Skip(5);
            foreach (var rec in record)
            {
                Console.WriteLine(rec.ProductId + " " + rec.UserId + " " + rec.Rating + " " + rec.Review + " " + rec.IsLike);
            }
        }
        public DataTable AddTwoTable(List<ProductReview> products)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductId", typeof(int));
            table.Columns.Add("UserId", typeof(int));
            table.Columns.Add("Rating", typeof(int));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("IsLike", typeof(bool));
            foreach(var data in products)
            {
                table.Rows.Add(data.ProductId, data.UserId, data.Rating, data.Review, data.IsLike);
            }
            return table;
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
