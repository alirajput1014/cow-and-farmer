using System;
using UnityEngine;

public class pizza_destroy : MonoBehaviour
{
    public float destroyZ;
    static int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= destroyZ)
        {
            Destroy(gameObject);
        }
        
    }
     void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Animal"))
        {
           
            if (other.gameObject.activeSelf)
            {
                score = score + 10;
                Debug.Log("Score: " + score);
                other.gameObject.SetActive(false);
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
        }
        

    }
}


