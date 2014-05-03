using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sit302_prototype.Models.Impl;

namespace sit302_prototype.Models.DAO.Impl {
    public class UnitDao : IDAO<Unit> {
        public void addModel(Unit model) {
            DatabaseContext.getInstance().unitContext.Add(model);
            DatabaseContext.getInstance().SaveChanges();
        }

        public void removeModel(Unit model) {
            DatabaseContext.getInstance().unitContext.Remove(model);
            DatabaseContext.getInstance().SaveChanges();
        }

        public Unit getById(int Id) {
            return DatabaseContext.getInstance().unitContext.Where(i => i.Id == Id).FirstOrDefault();
        }

        public Unit getByCode(string code) {
            return DatabaseContext.getInstance().unitContext.Where(i => i.unitCode.Equals(code)).FirstOrDefault();
        }

        public List<Unit> getAllUnitsForMajor(Major major) {
            return DatabaseContext.getInstance().unitContext.Where(i => major.units.Contains(i)).ToList();
        }

        public List<Unit> getAllCoreUnits() {
            return DatabaseContext.getInstance().unitContext.Where(i => i.isCoreUnit).ToList();
        }

        public List<Unit> getAllUnitsOfferedDuringTrimester(int trimester) {
            return DatabaseContext.getInstance().unitContext.Where(i => i.offered.Count(j => j.trimester == trimester) > 0).ToList();
        }

        public List<Unit> getAllUnitsOfferedDuringYear(int year) {
            return DatabaseContext.getInstance().unitContext.Where(i => i.offered.Count(j => j.year == year) > 0).ToList();
        }
    }
}