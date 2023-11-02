namespace Kesten.Server.Common.Settings
{
    /// <summary>
    /// Container of project identity parameters
    /// </summary>
    public class ProjectSettings
    {
        /// <summary>
        /// App name
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// App description
        /// </summary>
        public string Description { get; set; } = null!;

        /// <summary>
        /// App version
        /// </summary>
        public string Version { get; set; } = null!;
    }
}
