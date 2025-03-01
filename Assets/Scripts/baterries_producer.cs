using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baterries_producer : MonoBehaviour
{
    public GameObject itemPrefab;
    public GameObject particles;
    // Limit range of battery spawner
    public float minX = -5f;
    public float maxX = 5f;
    public float minY = 1f;
    public float maxY = 2f;

    // Start is called before the first frame update
    void Start()
    {  
        // Limit the number of batteries to spawn to 3
        for(int i = 0; i < 4; i++)
        {
            spawObject(); 
        }
       
    }

    // Update is called once per frame
    void Update()
    {
       // if(Input.GetKeyDown(KeyCode.B))
       // {
         //   spawObject();
       // }
    }

    void spawObject()
    {

        // Generate random positions within the specified ranges
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector3 randomPos = new Vector3(randomX, randomY, -5f);

        Instantiate(itemPrefab,randomPos,Quaternion.identity);
    }
}
