using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sit302_prototype.Models.Impl {
    public class PlanUnitGrid : AbstractModelImpl {
        public virtual ICollection<GridEntry> entries { get; set; }

        public PlanUnitGrid() {
        }
    }
}