using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenColorPanel : MonoBehaviour
{
    public GameObject ColorPanel;
    
    public void OpenPanel()
    {
        ColorPanel.SetActive(true);
    }
}
