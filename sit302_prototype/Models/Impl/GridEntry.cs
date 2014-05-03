using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sit302_prototype.Models.Impl {
    public enum Year {
        ONE,
        TWO,
        THREE,
        FOUR,
        FIVE
    }

    public enum Trimester {
        ONE,
        TWO,
        THREE
    }

    public class GridEntry : AbstractModelImpl {
        public Year year { get; set; }
        public Trimester trimester { get; set; }
        public virtual ICollection<Unit> units { get; set; }

        public GridEntry() {
        }

        public GridEntry(Year year, Trimester trimester) {
            this.year = year;
            this.trimester = trimester;
        }

        public void addUnit(Unit unit) {
            this.units.Add(unit);    
        }

        public void removeUnit(Unit unit) {
            this.units.Remove(unit);
        }
    }
}