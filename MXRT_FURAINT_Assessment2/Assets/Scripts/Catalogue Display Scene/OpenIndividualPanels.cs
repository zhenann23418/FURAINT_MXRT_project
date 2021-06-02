using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenIndividualPanels : MonoBehaviour
{
    public GameObject RespectivePanel;

    public void OpenRespectivePanel()
    {
        RespectivePanel.SetActive(true);
    }
}
