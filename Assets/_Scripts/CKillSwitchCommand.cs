using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CKillSwitchCommand : CCommand
{

    private CRemoteControlDevice[] m_Devices;
    private static CRemoteControlDevice receiver;
    public CKillSwitchCommand (CRemoteControlDevice [] devices) : base(receiver)
    {
        m_Devices = devices;

    }

    public override void Execute()
    {
        foreach(CRemoteControlDevice device in m_Devices)
        {
            device.TurnOff();
        }
       
    }
}
