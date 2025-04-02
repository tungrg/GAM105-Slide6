using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Slider musicSlider;
    void Start()
    {
        if (PlayerPrefs.HasKey("volBucket"))
        {
            LoadVolume();
            musicSlider.value = PlayerPrefs.GetFloat("volBucket");
        }
        else
        {
            PlayerPrefs.SetFloat("volBucket", 0.5f);
            musicSlider.value = PlayerPrefs.GetFloat("volBucket");
            LoadVolume();
        }
    }
    public void SetVolume()
    {
        AudioListener.volume = musicSlider.value;
    }
    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("volBucket", musicSlider.value);
        PlayerPrefs.Save();
    }
    public void LoadVolume()
    {
        PlayerPrefs.SetFloat("volBucket", musicSlider.value);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
