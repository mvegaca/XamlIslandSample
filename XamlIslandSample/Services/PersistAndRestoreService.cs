using System;
using System.Collections;
using System.IO;

using Microsoft.Extensions.Options;

using XamlIslandSample.Contracts.Services;
using XamlIslandSample.Core.Contracts.Services;
using XamlIslandSample.Models;

namespace XamlIslandSample.Services
{
    public class PersistAndRestoreService : IPersistAndRestoreService
    {
        private readonly IFileService _fileService;
        private readonly AppConfig _config;
        private readonly string _localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public PersistAndRestoreService(IFileService fileService, IOptions<AppConfig> config)
        {
            _fileService = fileService;
            _config = config.Value;
        }

        public void PersistData()
        {
            if (App.Current.Properties != null)
            {
                var folderPath = Path.Combine(_localAppData, _config.ConfigurationsFolder);
                var fileName = _config.AppPropertiesFileName;
                _fileService.Save(folderPath, fileName, App.Current.Properties);
            }
        }

        public void RestoreData()
        {
            var folderPath = Path.Combine(_localAppData, _config.ConfigurationsFolder);
            var fileName = _config.AppPropertiesFileName;
            var properties = _fileService.Read<IDictionary>(folderPath, fileName);
            if (properties != null)
            {
                foreach (DictionaryEntry property in properties)
                {
                    App.Current.Properties.Add(property.Key, property.Value);
                }
            }
        }
    }
}
