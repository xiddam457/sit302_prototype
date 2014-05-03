using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sit302_prototype.Models.Impl;

namespace sit302_prototype.Models.Manager {
    //this is where our business logic will live
    public class PlanningManager {
        private Plan plan;
        private PlanUnitGrid grid;

        public PlanningManager(Plan plan) {
            if (plan.selectedUnits == null) {
                plan.selectedUnits = new PlanUnitGrid();
            }

            this.plan = plan;
            this.grid = this.plan.selectedUnits;
        }

        private GridEntry selectEntry(Year year, Trimester trimester) {
            GridEntry entry = grid.entries.Where(i => i.year == year && i.trimester == trimester).FirstOrDefault();
            if (entry == default(GridEntry)) {
                throw new Exception("Invalid grid entry specified");
            } else {
                return entry;
            }
        }

        public bool unitAlreadyAdded(Unit unit) {
            var years = Enum.GetValues(typeof(Year)).Cast<Year>();
            var trimesters = Enum.GetValues(typeof(Trimester)).Cast<Trimester>();

            foreach(var year in years) {
                foreach (var trimester in trimesters) {
                    if(entryContains(year, trimester, unit))
                        return true;
                }
            }

            return false;
        }

        private bool entryContains(Year year, Trimester trimester, Unit unit) {
            return selectEntry(year, trimester).units.Contains(unit);
        }

        public Plan generateGrid(List<Unit> coreUnits, List<Unit> majorUnits) {
            //type-bucket sort?
            Dictionary<Year, Dictionary<Trimester, Unit>> typeBucket = new Dictionary<Year, Dictionary<Trimester, Unit>>();
            
            //place core units
            foreach (Unit unit in coreUnits) {
                
            }

            //place major units

            return null;
        }
    }
}