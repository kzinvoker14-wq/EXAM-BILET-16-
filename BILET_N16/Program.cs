using System;

class Program
{
    static void Main()
    {
        ISettingsStorage storage = new JsonSettingsStorage();
        var settings = UserSettingsContext.GetInstance(storage);

        settings.SetValue("Language", "en");
        settings.Persist();

        Console.WriteLine("Программа успешно выполнена");
    }
}

