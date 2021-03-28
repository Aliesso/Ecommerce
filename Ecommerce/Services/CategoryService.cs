﻿using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService
    {
        public ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Category> GetCategories()
        {
            return _context.Categories.Include(x=>x.Products).ToList();
        }
        public Category GetCategoryById(int? id)
        {
            return _context.Categories.FirstOrDefault(x=>x.ID==id);
        }
    }
}
