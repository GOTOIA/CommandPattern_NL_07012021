using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRadioReceiver : CRemoteControlDevice
{
    public override void TurnOff()
    {
        Debug.Log("Radio turned off");
    }

    public override void TurnOn()
    {
        Debug.Log("Radio turned On");
    }
}
