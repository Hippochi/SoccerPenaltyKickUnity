using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayController : MonoBehaviour
{
    //creates changable at runtime variables to be modified with sliders
    [SerializeField] Slider Xforce;
    [SerializeField] Slider Yforce;
    [SerializeField] Slider Zforce;

    private void Update()
    {
        //reads keyboard inputs to activate the two controls
        if (Input.GetKeyDown("space"))
        {

            kick(Xforce.value, Yforce.value, Zforce.value);
        }

        if (Input.GetKeyDown("r"))
        {
            //uses original variables for the soccer ball to "restart" the sim
            gameObject.transform.position = new Vector3(0.0f, 11.3f, 7.6f);
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }

    private void kick(float x, float y, float z)
    {
       //adds the vector created with sliders to the ball's rigidbody and moves it
        gameObject.GetComponent<Rigidbody>().AddForce(x, y, z);
    }
}
