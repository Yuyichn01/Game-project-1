using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolusionManager : MonoBehaviour
{
    void Start()
    {
        // Switch to 1920 1080 ,windowed,120HZ
        Screen.SetResolution(1920, 1080, false, 120);
    }
}
