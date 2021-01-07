using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTelevisionReceiver : CRemoteControlDevice
{
    public override void TurnOff()
    {
        Debug.Log("TV turned off");
    }

    public override void TurnOn()
    {
        Debug.Log("TV turned on");
    }
}
