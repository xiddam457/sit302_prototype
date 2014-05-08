using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sit302_prototype.Models.Impl {
    public enum RequisiteType {
        PREREQUISITE,
        COREQUISITE
    }

    public class Requisite : AbstractModelImpl {
        public Unit requisite { get; set; }
        public RequisiteType type { get; set; }
    }
}