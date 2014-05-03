using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sit302_prototype.Models.Impl {
    public class Offered : AbstractModelImpl {
        public int year { get; set; }
        public int trimester { get; set; }

        public Offered() {

        }

        public Offered(int year, int trimester) {
            this.year = year;

            if (trimester > 3) {
                throw new FormatException("Error: trimester cannot be greater than 3");
            } else {
                this.year = year;
            }
        }
    }
}
