using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    public GameManager gm;
    public EventObserver eo;
    public TMP_Text timerDisplay;
    public TMP_Text XPDisplay;
    public TMP_Text winDisplay;
    private int intTimer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        intTimer = (int)gm.timer;
        timerDisplay.text = (intTimer/60).ToString("0") + ':' + (intTimer%60).ToString("0");
        XPDisplay.text = "XP: " + gm.XP.ToString("0");

        //if (gm.timer <= 0)
        {
            //The game is over, maybe display something on winDisplay
        }
    }
}
