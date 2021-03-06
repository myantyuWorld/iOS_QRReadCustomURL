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
    public class ReportController : AbstractController
    {
        // GET: ReportController
        public ActionResult Index(int value)
        {
            logger.Debug("[start]call ReportContorller#index");
            try
            {
                var reportService = new GenerateReport();
                var apiResult = reportService.Create(value);
                if (apiResult.Code == 0)
                {
                    return Ok(new RepTop(apiResult.RepTopId, ""));
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "帳票作成に失敗しました");
                }
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
