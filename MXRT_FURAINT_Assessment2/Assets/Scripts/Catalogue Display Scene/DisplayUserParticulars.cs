using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayUserParticulars : MonoBehaviour
{
    //we will reference our username box right at the top of the catalogue display page 
    public TMP_Text UsernameBox;
    public TMP_Text FullnameBox;
    public TMP_Text EmailBox;

    // Start is called before the first frame update
    void Start()
    {
        UsernameBox.text = PlayerPrefs.GetString("username");
        //the next two lines of code will be shown within the profile pop up panel
        FullnameBox.text = PlayerPrefs.GetString("fullname");
        EmailBox.text = PlayerPrefs.GetString("email");

    }
    

}
