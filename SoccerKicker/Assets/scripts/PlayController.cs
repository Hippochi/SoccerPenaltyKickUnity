using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayController : MonoBehaviour
{
    [SerializeField] Slider Xforce;
    [SerializeField] Slider Yforce;
    [SerializeField] Slider Zforce;

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {

            kick(Xforce.value, Yforce.value, Zforce.value);
        }

        if (Input.GetKeyDown("r"))
        {
            gameObject.transform.position = new Vector3(0.0f, 11.3f, 7.6f);
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }

    private void kick(float x, float y, float z)
    {
       
        gameObject.GetComponent<Rigidbody>().AddForce(x, y, z);
    }
}
