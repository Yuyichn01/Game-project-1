using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class SkyManager : MonoBehaviour
{

    public Material[] Skybox = new Material[6];



    // Update is called once per frame
    void Update()
    {

        System.DateTime moment = new System.DateTime();
        if (moment.Hour <= 10)
        {
            RenderSettings.skybox = Skybox[0];
        }
        else
        {
            if (moment.Hour <= 20)
            {
                RenderSettings.skybox = Skybox[1];
            }
            else
            {
                if (moment.Hour <= 30)
                {
                    RenderSettings.skybox = Skybox[2];
                }
                else
                {
                    if (moment.Hour <= 40)
                    {
                        RenderSettings.skybox = Skybox[3];
                    }
                    else
                    {
                        if (moment.Hour <= 50)
                        {
                            RenderSettings.skybox = Skybox[4];
                        }
                        else
                        {
                            RenderSettings.skybox = Skybox[5];
                        }
                    }
                }
            }


        }
    }
}
