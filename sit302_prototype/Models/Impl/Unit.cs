using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sit302_prototype.Models.Impl {
    public class Unit : AbstractModelImpl {
        public string unitCode { get; set; }
        public string unitName { get; set; }
        public int worthCP { get; set; }
        public bool isCoreUnit { get; set; }
        public int level { get; set; }

        public virtual ICollection<Unit> prerequisites { get; set; }

        public virtual ICollection<Unit> corequisites { get; set; }

        public virtual ICollection<Offered> offered { get; set; }

        public Unit() {
        }

        public Unit(string code, string name, int worthCP, bool isCore, int level) {
            this.unitCode = code;
            this.unitName = name;
            this.worthCP = worthCP;
            this.isCoreUnit = isCore;
            this.level = level;
        }

        public void addPrereq(Unit unit) {
            this.prerequisites.Add(unit);
        }

        public void removePrereq(Unit unit) {
            this.prerequisites.Remove(unit);
        }

        public void addCoreq(Unit unit) {
            this.corequisites.Add(unit);
        }

        public void removeCoreq(Unit unit) {
            this.corequisites.Remove(unit);
        }

        public void addOfferedTime(Offered offered) {
            this.offered.Add(offered);
        }

        public void removeOfferedTime(Offered offered) {
            this.offered.Remove(offered);
        }
    }
}
