using Microsoft.AspNetCore.Mvc;
using Models;
using ServiceLogic.Servicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildInfo.Controllers
{
    public class BuildInfoController : Controller
    {
        public List<BuildingDistrictModel> GetDistricts()
        {
            InfoService Inf = new InfoService();
            return null;
        }
    }
}
