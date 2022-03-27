namespace Authentication.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// 
        /// </summary>
        public AppSettings()
        {
            Secret = Environment.GetEnvironmentVariable("ENV_TOKEN_SECRECT");
            ExpiracaoHoras =Convert.ToInt32( Environment.GetEnvironmentVariable("ENV_TOKEN_EXPIRACAOHORAS"));
            Emissor = Environment.GetEnvironmentVariable("ENV_TOKEN_EMISSOR");
            ValidoEm = Environment.GetEnvironmentVariable("ENV_TOKEN_VALIDOEM");
        }

        /// <summary>
        /// 
        /// </summary>
        public string Secret { get; set; } 

        /// <summary>
        /// 
        /// </summary>
        public int ExpiracaoHoras { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Emissor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ValidoEm { get; set; }
    }
}
