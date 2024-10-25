using ExtraAdvancedMultiTier.Business.Domain;
using System.Collections.Specialized;
using System.Configuration;

namespace ExtraAdvancedMultiTier.Business.Services;
public static class AppConfigurationsService {
    private static AppConfigurations? configurations;

    public static AppConfigurations GetConfigs() {
        configurations ??= new AppConfigurations();
        return configurations;
    }

}
