using UnityEngine;
using UnityEngine.UI;

public class MusicToggleScript : MonoBehaviour
{
    public AudioSource bgm;

    private Toggle toggle;

    private const string MusicKey = "MusicEnabled";

    void Start()
    {
        toggle = GetComponent<Toggle>();

        bool isOn = PlayerPrefs.GetInt(MusicKey, 1) == 1;
        toggle.isOn = isOn;
        bgm.mute = !isOn;

        toggle.onValueChanged.AddListener(OnToggleChanged);
    }

    void OnToggleChanged(bool value)
    {
        bgm.mute = !value;
        PlayerPrefs.SetInt(MusicKey, value ? 1 : 0);
    }
}
