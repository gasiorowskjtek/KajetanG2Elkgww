using UnityEngine;
using System.Collections;

public class MoveLeft : MonoBehaviour
{

    [SerializeField]
    private float _speed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if (transform.position.x < -15)
        {
            transform.position = new Vector3(15, 0, 0);
        }
    }
}