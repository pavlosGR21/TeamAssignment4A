﻿using Microsoft.EntityFrameworkCore;
using TeamAssignment4A.Models;

namespace TeamAssignment4A.Data.Repositories
{
    public class ExamRepository : IGenericRepository<Exam>
    {
        private readonly WebAppDbContext _db;
        public ExamRepository(WebAppDbContext context)
        {
            _db = context;
        }
        public async Task<Exam?> GetAsync(int id)
        {
            return await _db.Exams.Include(exam => exam.Certificate).FirstOrDefaultAsync(x => x.Id == id);
        }        

        public async Task<IEnumerable<Exam>?> GetAllAsync()
        {
            return await _db.Exams.Include(exam => exam.Certificate).ToListAsync<Exam>();            
        }

        public EntityState AddOrUpdate(Exam exam)
        {            
            _db.Exams.Update(exam);
            return _db.Entry(exam).State;
        }

        public void Delete(Exam exam)
        {
            _db.Exams.Remove(exam);
        }

        public async Task<bool> Exists(int id)
        {
            return await _db.Exams.AnyAsync(e => e.Id == id);
        }

        public async Task<bool> CodeExists(int id, string code)
        {
            return await _db.Exams.AnyAsync(e => e.AssessmentTestCode == code && e.Id != id);
        }
    }
}
