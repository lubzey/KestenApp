namespace Kesten.Api.Settings
{
    public class AppSettings
    {
        public AppSettings()
        {
            Project = new ProjectSettings();
            DevMode = true;
        }

        /// <summary>
        /// Whether the app is intended to be in DEV mode
        /// </summary>
        public bool DevMode { get; set; }

        /// <summary>
        /// Project-specific settings: name and description
        /// </summary>
        public ProjectSettings Project { get; set; }

        /// <summary>
        /// Helper method to check running mode
        /// </summary>
        /// <returns></returns>
        public bool IsDevelopment()
        {
            return DevMode;
        }

        public static AppSettings Load(IWebHostEnvironment env)
        {
            var settingsFileName = env.IsDevelopment()
                ? "appsettings.Development.json"
                : "appsettings.json";

            var dom = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile(settingsFileName, optional: true)
                .AddEnvironmentVariables()
                .Build();

            var settings = new AppSettings();
            dom.Bind(settings);
            return settings;
        }
    }
}
