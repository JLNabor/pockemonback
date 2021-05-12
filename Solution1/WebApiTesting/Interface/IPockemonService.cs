using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTesting.Model;

namespace WebApiTesting.Interface
{
    public interface IPockemonService
    {
        IEnumerable<Pockemo> GetAll();

        Pockemo GetById(int id);

        void Delete(int id);

        void Update(Pockemo pockemo);

        void Add(Pockemo pockemo);

        void Save();

    }
}
