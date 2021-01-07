using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CCommand
{

    protected CRemoteControlDevice m_Reveiver;

    public CCommand(CRemoteControlDevice receiver)
    {
        m_Reveiver = receiver;
    }

    public abstract void Execute();
}
