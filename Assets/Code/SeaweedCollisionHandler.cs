using UnityEngine;
using System.Collections;

public class SeaweedCollisionHandler : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Application.LoadLevel(0);
    }

}