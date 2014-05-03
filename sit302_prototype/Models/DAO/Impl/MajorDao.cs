using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sit302_prototype.Models.Impl;

namespace sit302_prototype.Models.DAO.Impl {
    public class MajorDao : IDAO<Major> {
        public void addModel(Major model) {
            DatabaseContext.getInstance().majorContext.Add(model);
            DatabaseContext.getInstance().SaveChanges();
        }

        public void removeModel(Major model) {
            DatabaseContext.getInstance().majorContext.Remove(model);
            DatabaseContext.getInstance().SaveChanges();
        }

        public Major getById(int Id) {
            return DatabaseContext.getInstance().majorContext.Where(i => i.Id == Id).FirstOrDefault();
        }

        public Major getByCode(string code) {
            return DatabaseContext.getInstance().majorContext.Where(i => i.majorCode.Equals(code)).FirstOrDefault();
        }
    }
}