using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventObserver : MonoBehaviour
{
    public GameManager gm;

    void Start()
    {
        CollectionNotifier.OnXPCollected += XPCollected;
    }

    private void XPCollected()
    {
        if (gm.timer > 0)
        {
            gm.XP += 1.0f * 1.0f;//friend value;
        }
    }
}