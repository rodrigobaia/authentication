using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Repository.Context
{
    internal class DbConnection
    {
        public static string ConnectionString
        {
            get { return ConnectionStringImpl(); }
        }

        private static string ConnectionStringImpl()
        {
            var server = Environment.GetEnvironmentVariable("ENV_DATABASE_SERVER");
            var port = Environment.GetEnvironmentVariable("ENV_DATABASE_PORT");
            var db = Environment.GetEnvironmentVariable("ENV_DATABASE_NAME");
            var user = Environment.GetEnvironmentVariable("ENV_DATABASE_USER");
            var pwd = Environment.GetEnvironmentVariable("ENV_DATABASE_PWD");
            var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var sslMode = Environment.GetEnvironmentVariable("ENV_DATABASE_SSL_MODE");
            var maxpoolsize = Environment.GetEnvironmentVariable("ENV_DATABASE_MAXPOOLSIZE");
            sslMode = (string.IsNullOrEmpty(sslMode) ? "none" : sslMode);
            maxpoolsize = (string.IsNullOrEmpty(maxpoolsize) ? "20" : maxpoolsize);

#if DEBUG
            server = "192.168.0.12";
            port = "3306";
            db = "IdentityUserDB";
            user = "userIdentityAdmin";
            pwd = "102030";
            sslMode = "none";
            maxpoolsize = "75";
#endif

            var cnnstr = $"Server={server};Port={port};DataBase={db};Uid={user};Pwd={pwd};SslMode={sslMode};convert zero datetime=True;ConnectionReset=True;pooling=true;minpoolsize=1;maxpoolsize={maxpoolsize};ConnectionLifeTime=30";

            return cnnstr;
        }
    }
}
