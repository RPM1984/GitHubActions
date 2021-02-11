using System;
using System.Reflection;
using Microsoft.AspNetCore.Hosting;

namespace API
{
    public class AppDetails
    {
        private readonly IWebHostEnvironment _env;
        private readonly DateTime _startedOn;
        private readonly Assembly _assembly;

        public AppDetails(Assembly assembly, IWebHostEnvironment env)
        {
            _assembly = assembly;
            _env = env;
            _startedOn = DateTime.UtcNow;
        }

        public override string ToString()
            => $"Name: {_assembly.GetName().Name}{Environment.NewLine}" +
               $"Version: {_assembly.GetName().Version}{Environment.NewLine}" +
               $"Build Date : {System.IO.File.GetLastWriteTime(_assembly.Location).ToString("U")}{Environment.NewLine}" +
               $"Application Started: {_startedOn:U}{Environment.NewLine}" +
               $"Server name: {Environment.MachineName}{Environment.NewLine}" +
               $"Environment: {_env.EnvironmentName}";
    }
}
