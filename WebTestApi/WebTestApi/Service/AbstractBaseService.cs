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

        static AbstractBaseService ()
        {
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
