using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTurnOffCommand : CCommand
{

    public CTurnOffCommand(CRemoteControlDevice receiver) : base(receiver)
    {

    }
    public override void Execute()
    {
        m_Reveiver.TurnOff();
    }


}
