using System.Configuration;

namespace Project_Utilities.Services;
public class AppConfigurationsService {
    private const string appDevModeKeyName = "DevMode";
    private const string dbTypeKeyName = "DB_Type";
    private const string dbServerAddressKeyName = "DB_Server_Address";
    private const string dbDatabaseNameKeyName = "DB_Database_Name";
    private const string dbUsernameKeyName = "DB_User_Id";
    private const string dbUserPasswordKeyName = "DB_Password";


    public static string? GetConfig(string configKey) {
        return ConfigurationManager.AppSettings.Get(configKey);
    }

    public static string? GetDbTypeConfig() {
        return ConfigurationManager.AppSettings.Get(dbTypeKeyName);
    }

    public static string? GetDbServerConfig() {
        return ConfigurationManager.AppSettings.Get(dbServerAddressKeyName);
    }

    public static string? GetDbDatabaseConfig() {
        return ConfigurationManager.AppSettings.Get(dbDatabaseNameKeyName);
    }

    public static string? GetDbUsernameConfig() {
        return ConfigurationManager.AppSettings.Get(dbUsernameKeyName);
    }

    public static string? GetDbPasswordConfig() {
        return ConfigurationManager.AppSettings.Get(dbUserPasswordKeyName);
    }

}
