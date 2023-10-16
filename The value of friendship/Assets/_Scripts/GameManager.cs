using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private Vector3 vector;
    public GameObject lifeXPObject;
    public GameObject objects;
    public GameObject wall1;
    public GameObject wall;
    public const int numObjects = 2000;
    public float timer = 0f;
    public float timerDuration = 360f;
    public int XP = 0;

    public PlayerController player;
    public UI ui;
    public EventObserver eo;

    public TMP_Text scoreText;
    public TMP_Text timerText;

    public GameObject mainMusicObject;
    public AudioSource mainMusic;

    // Start is called before the first frame update
    void Start()
    {
        timer = timerDuration;

        for (int i = 0; i < numObjects; ++i)
        {
            vector = new Vector3(Random.Range(-100f, 100f), Random.Range(-100f, 100f), 0);
            objects = Instantiate(lifeXPObject, vector, Quaternion.identity);
            wall = Instantiate(wall1, -vector, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
            timer -= Time.deltaTime;
    }
}