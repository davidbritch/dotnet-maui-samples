#nullable enable
#if ANDROID || IOS
using LegacySecureStorage;

namespace MigrateProperties;

// IMPORTANT - Make sure you have an Entitlements.plist with the following:
//    <key>keychain-access-groups</key>
//    <string>$(AppIdentifierPrefix)$(CFBundleIdentifier)</string>
// and that the Entitlements.plist is set in the Custom Entitlements field for Bundle Signing
public class LegacySecureStorage
{
    internal static readonly string Alias = $"{AppInfo.PackageName}.xamarinessentials";

    public static Task<string> GetAsync(string key)
    {
        if (string.IsNullOrWhiteSpace(key))
            throw new ArgumentNullException(nameof(key));

        string result = string.Empty;

#if ANDROID
        object locker = new object();
        string? encVal = Preferences.Get(key, null, Alias);

        if (!string.IsNullOrEmpty(encVal))
        {
            byte[] encData = Convert.FromBase64String(encVal);
            lock (locker)
            {
                AndroidKeyStore keyStore = new AndroidKeyStore(Platform.AppContext, Alias, false);
                result = keyStore.Decrypt(encData);
            }
        }
#elif IOS
        KeyChain keyChain = new KeyChain();
        result = keyChain.ValueForKey(key, Alias);
#endif

        return Task.FromResult(result);
    }

    public static bool Remove(string key)
    {
        bool result = false;

#if ANDROID
        Preferences.Clear(Alias);
        result = true;
#elif IOS
        KeyChain keyChain = new KeyChain();
        result = keyChain.Remove(key, Alias);
#endif

        return result;
    }

    public static void RemoveAll()
    {
#if ANDROID
        Preferences.Clear(Alias);
#elif IOS
        KeyChain keyChain = new KeyChain();
        keyChain.RemoveAll(Alias);
#endif
    }
}
#endif