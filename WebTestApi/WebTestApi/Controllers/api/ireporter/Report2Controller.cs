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
               logger.Debug("[end]call ReportContorller#index");
            }
        }
    }
}
