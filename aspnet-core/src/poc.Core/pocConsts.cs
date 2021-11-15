using poc.Debugging;

namespace poc
{
    public class pocConsts
    {
        public const string LocalizationSourceName = "poc";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "d4f10b26ecb7408598a5fa2ec38d9272";
    }
}
