using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceReflector : MonoBehaviour
{
    //assign the text to change the distance
    public Text TextToChange;
    //the player object to trace
    public Transform player;

    void Update()
    {
        //Let the distance displayed equal to the transform x of player object
        Vector3 direction = player.position;
        int Integer = (int)direction.x;
        float DistanceToDisplay = Integer / 1000;
        TextToChange.text = (DistanceToDisplay + "KM");
    }
}
