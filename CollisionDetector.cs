using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionDetector : MonoBehaviour
{
    //assign the text to change the distance
    public Text TextToChange;
    private int coin;
    private AudioSource Audio;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coin += 1;
            TextToChange.text = (coin.ToString());
            Audio = GetComponent<AudioSource>();
            Audio.Play(0);
        }
        else
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
