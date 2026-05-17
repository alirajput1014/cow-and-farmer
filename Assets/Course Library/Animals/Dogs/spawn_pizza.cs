using UnityEngine;

public class spawn_pizza : MonoBehaviour
{
    public float speed;
    public GameObject prefabspawnpizza;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject pizza = Instantiate(prefabspawnpizza, transform.position ,transform.rotation);
            Rigidbody rb = pizza.GetComponent<Rigidbody>();
            rb.linearVelocity = transform.forward * speed;

           
        }
       
    }
}



