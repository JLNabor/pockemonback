using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTesting.Data;
using WebApiTesting.Interface;
using WebApiTesting.Model;

namespace WebApiTesting.Service
{
    public class PockemonService : IPockemonService
    {
        private readonly PockemonContext _pockemonContext;

        public PockemonService(PockemonContext pockemonContext) {
            this._pockemonContext = pockemonContext;
        }
        public void Add(Pockemo pockemo)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var pock = GetById(id);
            this._pockemonContext.Pockemos.Remove(pock);
            this.Save();
        }

        public IEnumerable<Pockemo> GetAll()
        {
            return this._pockemonContext.Pockemos.ToList();
        }

        public Pockemo GetById(int id)
        {
            return this._pockemonContext.Pockemos.FirstOrDefault(x=>x.Id.Equals(id));
        }

        public void Update(Pockemo pockemo)
        {
            this._pockemonContext.Entry<Pockemo>(pockemo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.Save();
        }

        public void Save() { 
        }
    }
}
