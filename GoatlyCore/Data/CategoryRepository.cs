﻿using System.Collections.Generic;
using System.Linq;
using GoatlyCore.Models;

namespace GoatlyCore.Data
{
    public class CategoryRepository
    {
        private readonly NorthwindContext _context;

        public CategoryRepository(NorthwindContext context)
        {
            _context = context;
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.OrderBy(c => c.CategoryId).ToList();
        }

        public Category? GetById(int id)
        {
            return _context.Categories.Find(id);
        }
    }
}
