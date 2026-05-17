using Unity.Mathematics;
using UnityEngine;

public class animalsmovement : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed* Time.deltaTime*5);

        if (transform.position.z > 32)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > 25)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -25)
        { 
            Destroy(gameObject);
        }

    }

}
