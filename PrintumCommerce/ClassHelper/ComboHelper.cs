using PrintumCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrintumCommerce.ClassHelper
{
    public class ComboHelper :IDisposable
    {
        private static DBPrintumContext db = new DBPrintumContext();
        public static List<DepartmentModel> getDepartment()
        {
           
            var Departament = db.DepartmentModels.ToList();
            Departament.Add(new DepartmentModel
            {
                DepartmentId = 0,
                DepartmentName = "[Seleccione Departamento...]",
            });
            return Departament.OrderBy(b => b.DepartmentName).ToList();
        }
        public static List<City> getCities()
        {

            var Cities = db.Cities.ToList();
            Cities.Add(new City
            {
                CityId = 0,
                CitiesName = "[Seleccione Ciudad...]",
            });
            return Cities.OrderBy(c => c.CitiesName).ToList();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}