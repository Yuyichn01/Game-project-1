using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    //Set the speed for the game object
    public float speed = 1f;

    //Set the acceleration of the game object
    public float acceleration;

    //The maximum height the player can fly
    public float MaximumHeight;

    //The minimum height the player can fly
    public float MinimumHeight;
    //Set the maximum speed for the game object
    public float MaximumSpeed;

    //object's rigidbody component
    private Rigidbody2D rigidbody2d;
    //Set whether the game object will move automatically
    public bool autoFly;

    public Slider slider;
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        //if autofly is on the gameobject will fly automatically
        if (autoFly == true)
        {
            //The gameobject will do continuous movement with specific acceleration
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            speed += acceleration;
            //If the current speed exceed the maximum speed then it will be equal to maximum speed
            if (speed > MaximumSpeed)
                speed = MaximumSpeed;
        }
        //when press W the player move up
        if (Input.GetKey(KeyCode.W) && transform.position.y <= MaximumHeight)
        {
            GoingUp();
        }
        //when press S the player move down
        if (Input.GetKey(KeyCode.S) && transform.position.y >= MinimumHeight)
        {
            GoingDown();
        }
        //when esc is pressed load the previous scene
        if (Input.GetKey(KeyCode.Escape))
        {
            ExitGame();
        }

        if (slider.value < 0.4 && transform.position.y <= MaximumHeight)
        {
            GoingUp();
        }

        if (slider.value > 0.6 && transform.position.y >= MinimumHeight)
        {
            GoingDown();
        }





    }

    //The going up function
    public void GoingUp()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
    }

    //The going down function
    public void GoingDown()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed, Space.World);
    }

    //The exit game function
    public void ExitGame()
    {
        SceneManager.LoadScene(1);
    }
}
