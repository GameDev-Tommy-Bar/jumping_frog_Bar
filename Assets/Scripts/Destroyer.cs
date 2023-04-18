using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private float minLimit = -20f;
    [SerializeField] private float maxLimit = 20f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < minLimit || transform.position.x > maxLimit)
        {
            Destroy(gameObject);
            //Debug.Log("DESTROYED!"+gameObject);
        }
    }
}
