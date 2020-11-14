using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceSettings
{
    public string[] settings;
    public DeviceSettings(string[] _settings)
    {
        settings = new string[_settings.Length];
        for(int i =0;i<_settings.Length;i++)
        {
            settings[i] = _settings[i];
        }
    }

}
