using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_spwan : MonoBehaviour
{
    [SerializeField] GameObject car;
    // [SerializeField] float delay = 4f;
    Vector3 positionOfSpawnedObject;  // span at the containing object position.
    Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
    [SerializeField] float min_delay = 1f;
    [SerializeField] float max_delay = 2.5f;


    
    // Start is called before the first frame update
    void Start()
    {
        positionOfSpawnedObject = transform.position;
        StartCoroutine(spwan_car());
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    private IEnumerator spwan_car(){
        while (true)
        {
            float delay = Random.Range(min_delay,max_delay);
            //Debug.Log(delay);
            yield return new WaitForSeconds(delay);
            //Debug.Log(positionOfSpawnedObject);
            Instantiate(car,positionOfSpawnedObject,rotationOfSpawnedObject);
        }

    }
}
