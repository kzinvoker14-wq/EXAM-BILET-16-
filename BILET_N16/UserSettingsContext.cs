using System.Collections.Generic;

public sealed class UserSettingsContext
{
    private static UserSettingsContext _instance;
    private static readonly object _lock = new object();

    private Dictionary<string, object> _settings;
    private ISettingsStorage _storage;

    private UserSettingsContext(ISettingsStorage storage)
    {
        _storage = storage;
        _settings = _storage.Load();
    }

    public static UserSettingsContext GetInstance(ISettingsStorage storage)
    {
        lock (_lock)
        {
            if (_instance == null)
                _instance = new UserSettingsContext(storage);

            return _instance;
        }
    }

    public T GetValue<T>(string key)
    {
        return (T)_settings[key];
    }

    public void SetValue(string key, object value)
    {
        _settings[key] = value;
    }

    public void Persist()
    {
        _storage.Save(_settings);
    }
}