using System.Collections.Generic;

public class JsonSettingsStorage : ISettingsStorage
{
    public Dictionary<string, object> Load()
    {
        return new Dictionary<string, object>
        {
            { "Language", "ru" },
            { "Theme", "Dark" },
            { "Notifications", true }
        };
    }

    public void Save(Dictionary<string, object> settings)
    {
        
    }
}
