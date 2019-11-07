using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GC : MonoBehaviour
{

    public AudioMixer mixer;

    public Text loadingText;
    public Slider loading;

    public void SetVSFX(float value)
    {
        mixer.SetFloat("VSFX", value);
    }


}
