using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseIndividualPanels : MonoBehaviour
{
    public GameObject RespectivePanel;

    public void CloseRespectivePanel()
    {
        RespectivePanel.SetActive(false);
    }
}
