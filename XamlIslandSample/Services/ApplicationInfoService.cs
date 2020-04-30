using System;
using System.Diagnostics;
using System.Reflection;

using OSVersionHelper;

using Windows.ApplicationModel;

using XamlIslandSample.Contracts.Services;

namespace XamlIslandSample.Services
{
    public class ApplicationInfoService : IApplicationInfoService
    {
        public ApplicationInfoService()
        {
        }

        public Version GetVersion()
        {
            if (WindowsVersionHelper.HasPackageIdentity)
            {
                //// MSIX distribuition
                //// Setup the App Version in XamlIslandSample.Packaging > Package.appxmanifest > Packaging > PackageVersion
                var packageVersion = Package.Current.Id.Version;
                return new Version(packageVersion.Major, packageVersion.Minor, packageVersion.Build, packageVersion.Revision);
            }

            //// Setup the App Version in XamlIslandSample > Properties > Package > PackageVersion
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            var version = FileVersionInfo.GetVersionInfo(assemblyLocation).FileVersion;
            return new Version(version);
        }
    }
}
