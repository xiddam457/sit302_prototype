using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sit302_prototype.Models.Impl;

namespace sit302_prototype.Models.DAO.Impl {
    public class GridEntryDao : IDAO<GridEntry> {
        public void addModel(GridEntry model) {
            DatabaseContext.getInstance().entryContext.Add(model);
            DatabaseContext.getInstance().SaveChanges();
        }

        public void removeModel(GridEntry model) {
            DatabaseContext.getInstance().entryContext.Remove(model);
            DatabaseContext.getInstance().SaveChanges();
        }

        public GridEntry getById(int Id) {
            return DatabaseContext.getInstance().entryContext.Where(i => i.Id == Id).FirstOrDefault();
        }

        public List<GridEntry> getEntriesMatchingYear(Year year) {
            return DatabaseContext.getInstance().entryContext.Where(i => i.year == year).ToList();
        }

        public GridEntry getByCode(string code) {
            throw new NotImplementedException();
        }
    }
}