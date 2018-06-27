using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace RIMIKS.Localization
{
    public static class RIMIKSLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(RIMIKSConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(RIMIKSLocalizationConfigurer).GetAssembly(),
                        "RIMIKS.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
