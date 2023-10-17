using UnityEngine;

public class Game1Controller : MonoBehaviour
{
    //  MEMBERS
    public Game1SettingsPanel SettingsPanel;

    //  METHODS
    void Awake()
    {
        //  Load settings
        SettingsPanel.Volume = 0.5f;
        SettingsPanel.IsMusicPlaying = true;
    }
}
