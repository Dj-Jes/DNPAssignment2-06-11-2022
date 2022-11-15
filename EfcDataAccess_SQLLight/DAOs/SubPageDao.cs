﻿using Application.DaoInterfaces;
using Domain.Models;
using FileData;
using shortid;
using shortid.Configuration;

namespace EfcDataAccess_SQLLight.DAOs {
    public class SubPageDao : ISubPageDao {

        private readonly FileContext _context;

        public SubPageDao(FileContext context)
        {
            _context = context;
        }

        public Task<SubPage> CreateAsync(SubPage subPage) {
            string newId = ShortId.Generate(new GenerationOptions(true, true, 12));
            subPage.SubPageId = newId;
            subPage.Posts = new List<Post>();

            _context.SubPages.Add(subPage);

            return Task.FromResult(subPage);
        }

        public Task<IEnumerable<SubPage>> GetAsync() {
            IEnumerable<SubPage>  result = _context.SubPages.AsEnumerable();
            return Task.FromResult(result);
        }

        public Task<SubPage?> GetByIdAsync(string id) {
            SubPage? subPage = _context.SubPages.FirstOrDefault(t => t.SubPageId == id);
            return Task.FromResult(subPage);
        }

        public Task<SubPage?> GetByNameAsync(string name) {
            SubPage? subPage = _context.SubPages.FirstOrDefault(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            return Task.FromResult(subPage);
        }

        public Task<IEnumerable<Post>?> GetPostsAsync(string subPageId) {
            IEnumerable<Post>? posts = _context.SubPages.FirstOrDefault(t => t.SubPageId.Equals(subPageId))?.Posts.AsEnumerable();
            return Task.FromResult(posts);
        }
    }
}