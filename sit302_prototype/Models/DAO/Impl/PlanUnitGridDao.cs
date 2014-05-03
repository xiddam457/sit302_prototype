using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sit302_prototype.Models.Impl;

namespace sit302_prototype.Models.DAO.Impl {
    public class PlanUnitGridDao : IDAO<PlanUnitGrid> {
        public void addModel(PlanUnitGrid model) {
            DatabaseContext.getInstance().gridContext.Add(model);
        }

        public void removeModel(PlanUnitGrid model) {
            DatabaseContext.getInstance().gridContext.Remove(model);
        }

        public PlanUnitGrid getById(int Id) {
            return DatabaseContext.getInstance().gridContext.Where(i => i.Id == Id).FirstOrDefault();
        }

        public PlanUnitGrid getByCode(string code) {
            throw new NotImplementedException();
        }
    }
}