using XamlIslandSample.Services;

namespace XamlIslandSample.Contracts.Services
{
    public interface IXamlHostService
    {
        void Configure(WindowsXamlHostConfiguration configuration);
    }
}
