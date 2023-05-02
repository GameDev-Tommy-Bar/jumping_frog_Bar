using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class collider : MonoBehaviour
{
    public GameObject GameObjectToDisable1;
    public GameObject GameObjectToDisable2;
    public GameObject GameObjectToDisable3;
    public GameObject winner;



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
            Disable();
            Enable();
        }
        if(other.tag == "car" && enabled){
            Destroy(this.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
           Debug.Log("game over!");
        }
        
    }
    public void Disable()
    {
        Destroy(GameObjectToDisable1);
        Destroy(GameObjectToDisable2);
        Destroy(GameObjectToDisable3);
    }
    public void Enable(){
        winner.GetComponent<SpriteRenderer>().enabled = true;

    }
}
