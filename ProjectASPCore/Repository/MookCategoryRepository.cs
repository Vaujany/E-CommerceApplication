﻿using ProjectASPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectASPCore.Repository
{
    public class MookCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories()
        {
            return new List<Category>()
            {
                new Category{CategoryId=1,CategoryName="Big Data",Description="books of big data"},
                new Category{CategoryId=2,CategoryName="Database",Description="books of database"},
                new Category{CategoryId=3,CategoryName="Front-End",Description="books of Front-End"},
                new Category{CategoryId=4,CategoryName="Back-End",Description="books of back-End"}
            };
        }

        public Category GetCategoryById(int id)
        {
            return GetAllCategories().FirstOrDefault(c => c.CategoryId == id);
        }
    }
}
