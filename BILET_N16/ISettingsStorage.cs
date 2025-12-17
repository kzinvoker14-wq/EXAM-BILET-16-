using System.Collections.Generic;

public interface ISettingsStorage
{
    Dictionary<string, object> Load();
    void Save(Dictionary<string, object> settings);
}