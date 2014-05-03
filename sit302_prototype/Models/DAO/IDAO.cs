using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sit302_prototype.Models.DAO {
    interface IDAO<T> {
        void addModel(T model);

        void removeModel(T model);

        T getById(int Id);

        T getByCode(string code);
    }
}
