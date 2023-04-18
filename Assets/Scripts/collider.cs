using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collider : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "top_grass"  && enabled){
            Debug.Log("yessssssssss");
        }
        if(other.tag == "car" && enabled){
            Destroy(this.gameObject);
           Debug.Log("game over!");
        }
        
    }
}
