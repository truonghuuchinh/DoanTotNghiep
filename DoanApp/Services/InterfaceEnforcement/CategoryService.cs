﻿using DoanApp.Commons;
using DoanApp.Models;
using DoanData.DoanContext;
using DoanData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoanApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DpContext _context;
        public CategoryService(DpContext context)
        {
            _context = context;
        }
        public async Task<int> CreateAsync(CategoryRequest categoryRequest)
        {
            var category = new Category();
            category.Name = categoryRequest.Name;
            category.CreateDate = new GetDateNow().DateNow;
            _context.Category.Add(category);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            var category = _context.Category.FirstOrDefault(x => x.Id == id);
            if (category != null)
            {
                _context.Remove(category);
                return await _context.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<Category> FinByIdAsync(int id)
        {
            return await _context.Category.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Category>> GetAll()
        {
            var list = await _context.Category.Where(x=>x.Status).ToListAsync();
            return list;
        }

        public async Task<int> UpdateAsync(CategoryRequest categoryRequest)
        {
            var caegory = _context.Category.FirstOrDefault(x => x.Id == categoryRequest.Id);
            if (caegory != null)
            {
                caegory.Name = categoryRequest.Name;
                caegory.Status = categoryRequest.Status;
                _context.Update(caegory);
                return await _context.SaveChangesAsync();
            }
            return -1;
        }

    }
}
