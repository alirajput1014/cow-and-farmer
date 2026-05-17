using UnityEngine;
using UnityEngine.Rendering;

public class playermovement : MonoBehaviour
{
    public float speed;
    private float horizontalinput;
    public float rotationspeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime* horizontalinput);
       

        Vector3 position = transform.position;
        position.x=Mathf.Clamp(position.x, -22f, 22f);
        transform.position = position;

        if (Input.GetKey(KeyCode.K))
        {
            transform.Rotate(Vector3.up* rotationspeed);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(Vector3.down*rotationspeed);
        }
    }
}
