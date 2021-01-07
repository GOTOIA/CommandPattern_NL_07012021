using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTurnOnCommand : CCommand
{
    public override void Execute()
    {
        m_Reveiver.TurnOn();
    }

   public CTurnOnCommand(CRemoteControlDevice receiver):base(receiver)
    {

    }
}
