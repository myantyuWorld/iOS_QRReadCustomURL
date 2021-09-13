using KubotaTestApi.Model;
using KubotaTestApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KubotaTestApi.Controllers.api.ireporter
{
    [Route("api/irepo/[controller]")]
    [ApiController]
    public class Report2Controller : AbstractController
    {
        // GET: ReportController
        public ActionResult Index(int value)
        {
            logger.Debug("[start]call ReportContorller#index");
            logger.Debug("[end]call ReportContorller#index");
            return Ok("Hello Report Controller!");
        }

        // POST: ReportController/Create
        [HttpPost]
        public ActionResult Create()
        {
            logger.Debug("[start]call ReportContorller#Post");
            try
            {
                // テストコード
                return Ok(new RepTop("99999", ""));
            }
            catch (Exception e)
            {
                logger.Fatal($"{e.Message} : {e.StackTrace}");
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
            finally
            {
                logger.Debug("[end]call ReportContorller#Post");
            }
        }
    }
}
