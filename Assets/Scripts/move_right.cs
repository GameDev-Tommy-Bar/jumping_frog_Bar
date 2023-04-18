using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_right : MonoBehaviour
{
    Vector3 pos_right_left;
    [SerializeField] float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        pos_right_left = new Vector3(0.01f,0,0);
   
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position += pos_right_left*speed;
    }
}
