using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenProfilePanel : MonoBehaviour
{
    public GameObject ProfilePanel;
    
    //this block of code is to set the popup panel active when profile button is clicked
    //panel is set to NOT active at the start
    public void ClickProfileButton()
    {
        ProfilePanel.SetActive(true);
    }

    //this block of code is for the cancel button on the top of the panel
    //sets panel to inactive when clicked 
    public void ClickCancelButton()
    {
        ProfilePanel.SetActive(false);
    }
}
