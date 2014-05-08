using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace sit302_prototype.Models.Impl {
    public class Unit : AbstractModelImpl {
        public string unitCode { get; set; }
        public string unitName { get; set; }
        public int worthCP { get; set; }
        public bool isCoreUnit { get; set; }
        public int level { get; set; }

        public virtual ICollection<Requisite> requisites { get; set; }

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

        public void addOfferedTime(Offered offered) {
            this.offered.Add(offered);
        }

        public void removeOfferedTime(Offered offered) {
            this.offered.Remove(offered);
        }
    }
}
