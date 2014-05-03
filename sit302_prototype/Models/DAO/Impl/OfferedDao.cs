using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sit302_prototype.Models.Impl;

namespace sit302_prototype.Models.DAO.Impl {
    public class OfferedDao : IDAO<Offered> {
        public void addModel(Offered model) {
            DatabaseContext.getInstance().offeredContext.Add(model);
            DatabaseContext.getInstance().SaveChanges();
        }

        public void removeModel(Offered model) {
            DatabaseContext.getInstance().offeredContext.Remove(model);
            DatabaseContext.getInstance().SaveChanges();
        }

        public Offered getById(int Id) {
            return DatabaseContext.getInstance().offeredContext.Where(i => i.Id == Id).FirstOrDefault();
        }

        public Offered getByCode(string code) {
            throw new NotImplementedException();
        }

        public Offered getEntry(int year, int trimester) {
            return DatabaseContext.getInstance().offeredContext.Where(i => i.year == year && i.trimester == trimester).FirstOrDefault();
        }
    }
}