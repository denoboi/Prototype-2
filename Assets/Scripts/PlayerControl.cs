using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalinput = 10.0f;
    public float speed = 30.0f;

    public GameObject projectilePrefab;

    //Instantiate projectile after a certain amount of time
    private float cooldownStart;
    private float cooldownTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        //Character Move
        if (transform.position.x < -20)
        {
            transform.position = new Vector3(-20, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 20)
        {
            transform.position = new Vector3(20, transform.position.y, transform.position.z);
        }
        horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);

        //projectile instantiation
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - cooldownStart > cooldownTime)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            cooldownStart = Time.time;
        }
           

    }
    
   
}
