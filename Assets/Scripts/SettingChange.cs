using UnityEngine;
using UnityEngine.UI;

public class SettingChange : MonoBehaviour
{
    [SerializeField] GameSettings gameSettings;
    Slider sensitivitySlider;
    Slider musicSlider;
    Slider SFXSlider;

    void Awake()
    {
        sensitivitySlider = GetComponentsInChildren<Slider>()[0];
        musicSlider = GetComponentsInChildren<Slider>()[1];
        SFXSlider = GetComponentsInChildren<Slider>()[2];
        sensitivitySlider.value = gameSettings.SensitivitySetting;
        musicSlider.value = gameSettings.MusicVolume;
        SFXSlider.value = gameSettings.SFXVolume;
    }

    public void SettingEdit(int setting)
    {
        switch (setting)
        {
            case 0:
                gameSettings.SensitivitySetting = sensitivitySlider.value;
                break;

            case 1:
                gameSettings.MusicVolume = musicSlider.value;
                break;

            case 2:
                gameSettings.SFXVolume = SFXSlider.value;
                break;
        }
    }
}
