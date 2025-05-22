using UnityEngine;

[CreateAssetMenu(fileName = "GameSettings", menuName = "Scriptable Objects/GameSettings")]
public class GameSettings : ScriptableObject
{
    public float SensitivitySetting;
    public float MusicVolume;
    public float SFXVolume;
}
