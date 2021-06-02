using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SaveUserParticulars : MonoBehaviour
{
    //create references to our text box fields and use it to grab the text from
    //our text fields
    public TMP_InputField fullNameTextBox;
    public TMP_InputField usernameTextBox;
    public TMP_InputField emailTextBox;
    public TMP_InputField passwordTextBox;
    
    //assign this method to our button so that it saves the particulars into 
    //playerprefs
    public void ClickSaveUserParticulars()
    {
        //we set the strings of the input by the user such that it stores them
        //and displays it when we get the string in the next scene (catalogue scene)
        PlayerPrefs.SetString("fullname", fullNameTextBox.text);
        PlayerPrefs.SetString("username", usernameTextBox.text);
        PlayerPrefs.SetString("email", emailTextBox.text);
        PlayerPrefs.SetString("password", passwordTextBox.text);
    }

    //after it saves the users particulars, it proceeds to the next scene
    public void ToCatalogueDisplayScene()
    {
        SceneManager.LoadScene("3CatalogueDisplayScene");
    }
}
