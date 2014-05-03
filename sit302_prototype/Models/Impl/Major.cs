using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sit302_prototype.Models.Impl {
    public class Major : AbstractModelImpl {

        public string majorCode { get; set; }
        public string majorName { get; set; }

        public virtual ICollection<Unit> units { get; set; }

        public Major() {

        }

        public Major(string code, string name) {
            this.majorCode = code;
            this.majorName = name;
        }

        public void addUnit(Unit unit) {
            this.units.Add(unit);
        }

        public void removeUnit(Unit unit) {
            this.units.Remove(unit);
        }
    }
}
