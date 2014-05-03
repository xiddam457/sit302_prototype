using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sit302_prototype.Models.Impl;

namespace sit302_prototype.Models.DAO.Impl {
    public class CourseDao : IDAO<Course> {

        public void addModel(Course model) {
            DatabaseContext.getInstance().courseContext.Add(model);
            DatabaseContext.getInstance().SaveChanges();
        }

        public void removeModel(Course model) {
            DatabaseContext.getInstance().courseContext.Remove(model);
            DatabaseContext.getInstance().SaveChanges();
        }

        public Course getById(int Id) {
            return DatabaseContext.getInstance().courseContext.Where(i => i.Id == Id).FirstOrDefault();
        }


        public Course getByCode(string code) {
            return DatabaseContext.getInstance().courseContext.Where(i => i.courseCode.Equals(code)).FirstOrDefault();
        }

        public List<Course> getAllCourses() {
            return (from i in DatabaseContext.getInstance().courseContext select i).ToList();
        }
    }
}