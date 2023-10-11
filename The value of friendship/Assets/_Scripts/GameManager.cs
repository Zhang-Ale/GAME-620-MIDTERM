using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Vector3 vector;
    public GameObject lifeXP;
    public GameObject objects;
    public const int numObjects = 2000;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numObjects; ++i)
        {
            vector = new Vector3(Random.Range(-100f, 100f), Random.Range(-100f, 100f), 0);
            objects = Instantiate(lifeXP, vector, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
