using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("GameOver");
        Instantiate(particle, gameObject.transform.position + new Vector3(0,5,0), particle.transform.rotation);
        //Destroy(gameObject, 2f);
        


    }
}
