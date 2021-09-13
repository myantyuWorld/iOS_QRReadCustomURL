using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KubotaTestApi.Controllers
{
    public class AbstractController : Controller
    {
        public static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

    }
}
