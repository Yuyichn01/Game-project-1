using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{

    public bool CheckPoint;
    //which button to click
    public Button ButtonToClick;
    public AudioSource m_MyAudioSource;
    public AudioClip m_ClickSound;

    //When button is clicked, action is executed
    void start()
    {
        Button btn = ButtonToClick.GetComponent<Button>();
        btn.GetComponent<Button>().onClick.AddListener(PlaySound);
        CheckPoint = true;
        if (CheckPoint == true)
            LoadScene();
    }

    public void PlaySound()
    {
        m_MyAudioSource.PlayOneShot(m_ClickSound);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
