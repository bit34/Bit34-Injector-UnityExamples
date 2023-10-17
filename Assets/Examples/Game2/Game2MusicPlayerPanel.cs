using UnityEngine;
using UnityEngine.UI;

public class Game2MusicPlayerPanel : MonoBehaviour
{
	//	MEMBERS
#pragma warning disable 0649
    [SerializeField] private Text _volumeValueText;
    [SerializeField] private Text _musicStateValueText;
#pragma warning restore 0649
    private IGame2Settings _settings;

    //  METHODS
    public void InjectValues(IGame2Settings settings)
    {
        _settings = settings;
    }

    private void Update ()
	{
        _volumeValueText.text = _settings.Volume.ToString("0.0");
        _musicStateValueText.text = _settings.IsMusicPlaying.ToString();
    }
}
