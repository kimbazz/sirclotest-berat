using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqToDB;
using Berat.Web.Models;
using DataTables.AspNet.AspNetCore;
using DataTables.AspNet.Core;
using Berat.Web.ViewModel;

namespace Berat.Web.Repository
{
    public class HomeRepository
    {
        private SircloBeratDB _db;

        public HomeRepository()
        {
            _db = new SircloBeratDB();
        }

        //To Be Implemented
        public DataTablesJsonResult GetAllBerat(IDataTablesRequest request)
        {
            DataTablesResponse response = null;            
            
            var lBerat = _db.Berats.Where(x => x.IsDelete == false).OrderByDescending(x => x.Tanggal)
                        .Select(x => new  BeratViewModel {
                            Id = x.Id,
                            BeratMax = x.BeratMax.Value,
                            BeratMin = x.BeratMin.Value,
                            Tanggal = x.Tanggal.Value.ToString("yyyy-MM-dd"),                            
                        })
                        .ToList();
            
            response = DataTablesResponse.Create(request, lBerat.Count, lBerat.Count, lBerat);

            return new DataTablesJsonResult(response, true);
        }

        public Models.Berat GetBeratById(string id)
        {
            Models.Berat o = _db.Berats.Where(x => x.Id == id && x.IsDelete == false).FirstOrDefault();
            return o;
        }

        public void SaveBerat(Models.Berat param)
        {
            param.Id = Guid.NewGuid().ToString();
            _db.InsertWithIdentity(param);
        }

        public void UpdateBerat(Models.Berat param)
        {
            _db.Update(param);
        }

    }
}
