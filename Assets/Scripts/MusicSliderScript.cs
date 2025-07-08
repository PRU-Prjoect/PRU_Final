using UnityEngine;
using UnityEngine.UI;

public class MusicSliderScript : MonoBehaviour
{
    public AudioSource bgm;

    private Slider slider;

    private const string VolumeKey = "Volume";

    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = PlayerPrefs.GetFloat(VolumeKey, 1f);
        bgm.volume = slider.value;

        slider.onValueChanged.AddListener(UpdateVolume);
    }

    void UpdateVolume(float value)
    {
        bgm.volume = value;
        PlayerPrefs.SetFloat(VolumeKey, value);
    }
}
