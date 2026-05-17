using UnityEngine;

public class animals_spawn : MonoBehaviour
{
    public GameObject[] prefabanimals;
    public float delay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Animalspawn", 2, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Animalspawn()
    {
        int randomindex1=Random.Range(0, prefabanimals.Length);
        float spawnposX = Random.Range(-22.0f,22.0f);
        Vector3 pos = new Vector3(spawnposX, 0, -10.0f);
        Instantiate(prefabanimals[randomindex1], pos, prefabanimals[randomindex1].transform.rotation);

        int randomindex2 = Random.Range(0, prefabanimals.Length);
        float spawnposz1 = Random.Range(-12.0f, 20.0f);
        Vector3 posz = new Vector3(-19.0f, 0, spawnposz1);
        Instantiate(prefabanimals[randomindex2], posz, Quaternion.Euler(0,90,0));

        int randomindex3 = Random.Range(0, prefabanimals.Length);
        float spawnposz2 = Random.Range(-12.0f, 20.0f);
        Vector3 posz2 = new Vector3(25, 0, spawnposz2);
        Instantiate(prefabanimals[randomindex3], posz2, Quaternion.Euler(0, -90, 0));
    }
}
