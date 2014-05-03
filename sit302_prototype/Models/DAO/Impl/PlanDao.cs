using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sit302_prototype.Models.Impl;

namespace sit302_prototype.Models.DAO.Impl {
    public class PlanDao : IDAO<Plan> {
        public void addModel(Plan model) {
            DatabaseContext.getInstance().planContext.Add(model);
            DatabaseContext.getInstance().SaveChanges();
        }

        public void removeModel(Plan model) {
            DatabaseContext.getInstance().planContext.Remove(model);
            DatabaseContext.getInstance().SaveChanges();
        }

        public Plan getById(int Id) {
            return DatabaseContext.getInstance().planContext.Where(i => i.Id == Id).FirstOrDefault();
        }

        public Plan getByCode(string code) {
            throw new NotImplementedException();
        }
    }
}