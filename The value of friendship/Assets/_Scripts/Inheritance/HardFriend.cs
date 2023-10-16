using UnityEngine;

public class HardFriend : People
{
    //Should pass in stranger's location when creating new friend
    HardFriend(Vector3 strangerLocation)
    {
        this.location = strangerLocation;
        this.stayTimeValue = Random.Range(25f, 40f);
        this.multiplier = 3.0f;
    }

    HardFriend()
    {
        this.location = new Vector3();
        this.stayTimeValue = Random.Range(25f, 40f);
        this.multiplier = 1.2f;
    }
}