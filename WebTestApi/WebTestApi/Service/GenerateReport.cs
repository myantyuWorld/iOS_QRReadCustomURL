using IReporterLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KubotaTestApi.Service
{
    public class GenerateReport : AbstractBaseService
    {
        /// <summary>
        /// 自動帳票作成
        /// </summary>
        public ApiResult Create()
        {
            // 今後、追加での検証で業務ロジックはここで処理し、iReporterServiceに渡す

            var irepo = new IReporterService();
            return irepo.AutoReportCreation();
        }
    }
}
