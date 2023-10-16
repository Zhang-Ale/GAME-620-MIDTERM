using UnityEngine;

public class EasyGoingPerson : People
{
    //Should pass in stranger's location when creating new friend
    EasyGoingPerson(Vector3 strangerLocation)
    {
        this.location = strangerLocation;
        this.stayTimeValue = Random.Range(10f, 30f);
    }

    EasyGoingPerson()
    {
        this.location = new Vector3();
        this.stayTimeValue = Random.Range(10f, 30f);
    }
}
