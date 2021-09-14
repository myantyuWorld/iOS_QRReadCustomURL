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
        public ApiResult Create(int value)
        {
            // 今後、追加検証で業務ロジックを書く必要がある場合は本サービスクラスに記載、iReporterServiceに渡す
            var _dicClustarData = new Dictionary<string, string>();
            _dicClustarData.Add(TARGET_CLUSUTER_ID, value.ToString());

            var irepo = new IReporterService();
            return irepo.AutoReportCreation(DEF_TOP_ID,_dicClustarData);
        }
    }
}
