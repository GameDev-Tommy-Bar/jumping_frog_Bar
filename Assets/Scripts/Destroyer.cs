using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] float min_lim = -20f;
    [SerializeField] float max_lim = 20f;
    // Start is called before the first frame update
    void Update()
    {
        if (transform.position.x < min_lim || transform.position.x > max_lim){
            Destroy(gameObject);
            //Debug.Log("DESTROYED!"+gameObject);
        }
    }
}
