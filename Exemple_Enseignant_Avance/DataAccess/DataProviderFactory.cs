using Exemple_Enseignant_Avance.Business.Abstractions;
using Exemple_Enseignant_Avance.Business.Services;
using Exemple_Enseignant_Avance.DataAccess.MySql;
using Exemple_Enseignant_Avance.DataAccess.SqlServer;
using ExtraAdvancedMultiTier.Business.Domain;
using ExtraAdvancedMultiTier.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Enseignant_Avance.DataAccess;
public static class DataProviderFactory {

    private static IDataProvider? currentProvider;

#pragma warning disable IDE0060 // Remove unused parameter
    public static IDataProvider GetDataProvider(this DataProviderService service, AppConfigurations configurations) {
        switch (configurations.GetDbTypeConfig()) {
            case DbTypesEnum.SqlServer:
                if (currentProvider is null || currentProvider.GetType() != typeof(SqlServerDataProvider)) {
                    currentProvider = new SqlServerDataProvider();
                }
                break;
            case DbTypesEnum.MySql:
                if (currentProvider is null || currentProvider.GetType() != typeof(MySqlDataProvider)) {
                    currentProvider = new MySqlDataProvider();
                }
                break;
            case DbTypesEnum.Postgesql:
            default:
                throw new NotImplementedException($"Data provider for database type [{configurations.GetDbTypeConfig()}] not supported (yet).");
        }
        return currentProvider;
    }
#pragma warning restore IDE0060 // Remove unused parameter
}
