using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CInvoker 
{
    private CCommand m_Command;

    public void setCommand(CCommand command)
    {
        m_Command = command;
    }

    public void ExecuteCommand()
    {
        m_Command.Execute();
    }

}
