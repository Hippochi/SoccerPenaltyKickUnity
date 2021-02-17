using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayController : MonoBehaviour
{
    [SerializeField] Slider Xforce;
    [SerializeField] Slider Yforce;
    [SerializeField] Slider Zforce;

    

    private void kick()
    {
        RigidBody.AddForce(Xforce, Yforce, Zforce);
    }
}
