using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseColorPanel : MonoBehaviour
{
    public GameObject ColorPanel;

    public void ColorPanelClose()
    {
        ColorPanel.SetActive(false);
    }
}
