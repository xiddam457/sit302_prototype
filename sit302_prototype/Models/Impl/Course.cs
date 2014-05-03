using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sit302_prototype.Models.Impl {
    public class Course : AbstractModelImpl {
        public string courseCode { get; set; }
        public string courseName { get; set; }
        public int requiredCP { get; set; }

        public virtual ICollection<Major> majors { get; set; }

        public Course() {

        }

        public Course(string code, string name, int requiredCP) {
            this.courseCode = code;
            this.courseName = name;
            this.requiredCP = requiredCP;
        }

        public void addMajor(Major major) {
            this.majors.Add(major);
        }

        public void removeMajor(Major major) {
            this.majors.Remove(major);
        }
    }
}