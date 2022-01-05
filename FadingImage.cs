using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadingImage : MonoBehaviour
{
    //import an image to value type Image
    public Image image;
    //the time range for fade in
    public float TimeRangeFadeIn;
    //the time range for fade out
    public float TimeRangeFadeOut;
    //the waiting time in seconds for fade in
    public float WaitingTimeIn;

    //the waiting time in seconds for fade out
    public float WaitingTimeOut;

    IEnumerator Start()
    {
        //initialize the alpha value to 0
        image.canvasRenderer.SetAlpha(0.0f);
        //calling the method FadeIn 
        FadeIn();
        yield return new WaitForSeconds(WaitingTimeIn);
        //calling the method FadeOut 
        FadeOut();
        yield return new WaitForSeconds(WaitingTimeOut);
        //Calling the LoadScene method
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //The FadeIn function
    void FadeIn()
    {
        image.CrossFadeAlpha(1.0f, TimeRangeFadeIn, false);
    }
    //The FadeOut function
    void FadeOut()
    {
        image.CrossFadeAlpha(0.0f, TimeRangeFadeOut, false);
    }
}
