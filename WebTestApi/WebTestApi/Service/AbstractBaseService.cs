using IReporterLib;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KubotaTestApi.Service
{
    public class AbstractBaseService
    {
        public static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public static string TARGET_CLUSUTER_ID;
        public static string CONMAS_USER_ID;
        public static string CONMAS_PASSWORD;
        public static string CONMAS_URL;
        public static string DEF_TOP_ID;

        static AbstractBaseService ()
        {
            // 設定値の取得
            var config = GetConfiguration();
            CONMAS_USER_ID = config["AppSettings:ConmasApiUser"];
            CONMAS_PASSWORD = config["AppSettings:ConmasApiPassword"];
            CONMAS_URL = config["AppSettings:ConmasApiUrl"];
            DEF_TOP_ID = config["AppSettings:DefTopId"];
            TARGET_CLUSUTER_ID = config["AppSettings:TargetClusterId"];
        }

        public static IConfiguration GetConfiguration()
        {
            var configBuilder = new ConfigurationBuilder();

            // 設定ファイルのベースパスをカレントディレクトリ( 実行ファイルと同じディレクトリ )にします。
            configBuilder.SetBasePath(Directory.GetCurrentDirectory());

            // Json ファイルへのパスを設定します。SetBasePath() で設定したパスからの相対パスになります。
            configBuilder.AddJsonFile(@"appsettings.json");

            return configBuilder.Build();
        }

        
    }
}
