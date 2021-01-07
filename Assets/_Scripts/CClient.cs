using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CClient : MonoBehaviour
{

    private CRemoteControlDevice m_RadioReceiver;
    private CRemoteControlDevice m_TelevisionReceiver;
    private CRemoteControlDevice []m_Devices=new CRemoteControlDevice[2];

    // Start is called before the first frame update
    void Start()
    {
        m_RadioReceiver = new CRadioReceiver();
        m_TelevisionReceiver = new CTelevisionReceiver();

        m_Devices[0] = m_RadioReceiver;
        m_Devices[1] = m_TelevisionReceiver;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            CCommand commandTv = new CTurnOnCommand(m_Devices[1]);
            CCommand commandRadio = new CTurnOnCommand(m_Devices[0]);

            CInvoker invoker = new CInvoker();

            invoker.setCommand(commandTv);
            invoker.ExecuteCommand();

            invoker.setCommand(commandRadio);
            invoker.ExecuteCommand();

        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            CCommand commandKill = new CKillSwitchCommand(m_Devices);
            CInvoker invoker = new CInvoker();

            invoker.setCommand(commandKill);
            invoker.ExecuteCommand();

        }


    }
}
