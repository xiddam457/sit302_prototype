using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sit302_prototype.Models.Impl {
    public class Plan : AbstractModelImpl {
        public Course selectedCourse { get; set; }
        public Major selectedMajor { get; set; }
        public int achievedCP { get; set; }
        public PlanUnitGrid selectedUnits { get; set; }

        public Plan() {

        }

        public Plan(Course course, Major major, int achievedCP, PlanUnitGrid grid) {
            this.selectedCourse = course;
            this.selectedMajor = major;
            this.achievedCP = achievedCP;
            this.selectedUnits = grid;
        }
    }
}