using IReporterLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KubotaTestApi.Service
{
    public class IReporterService : AbstractBaseService
    {
        static IReporterService()
        {
        }

        /// <summary>
        /// 自動帳票作成処理
        /// </summary>
        /// <param name="defTopId">帳票定義ID</param>
        /// <param name="actionNameCode">基準書番号</param>
        /// <param name="actionName">対策名称</param>
        /// <param name="actionDescription">対策内容</param>
        /// <param name="developmentModel">派生開発コード</param>
        /// <param name="actionId">対策ID</param>
        /// <param name="defSheetCount">シート数</param>
        /// <returns>処理結果</returns>
        public ApiResult AutoReportCreation(string defTopId = "", Dictionary<string, string> _dicClustarData = null)
        {
            logger.Info("iReporterService#AutoReportCreation 【自動帳票作成処理　開始】");
            logger.Info($"defTopId : {defTopId}");

            ApiResult apiResult = new ApiResult();
            var csvSimple = new CsvSimple
            {
                writePath = $"{Directory.GetCurrentDirectory()}\\conmas.csv",
                defTopId = defTopId == "" ? DEF_TOP_ID : defTopId.ToString(),
            };
            
            csvSimple.dicClusterData = _dicClustarData != null ? _dicClustarData : new Dictionary<string, string>();

            using (var iReporterApiWrapper = new IReporterApiWrapper(CONMAS_USER_ID, CONMAS_PASSWORD, CONMAS_URL))
            {
                apiResult = (ApiResult)iReporterApiWrapper.CreateAutoReportSimple(csvSimple);
                // 自動帳票作成に失敗した帳票がある場合、以降の処理を中断する
                logger.Info($"apiResult : {apiResult.Code} : {apiResult.ErrMsg}");
                if (apiResult.Code != 0)
                {
                    return apiResult;
                }
            }
            logger.Info("iReporterService#AutoReportCreation 【自動帳票作成処理　終了】");
            return apiResult;
        }
    }
}
