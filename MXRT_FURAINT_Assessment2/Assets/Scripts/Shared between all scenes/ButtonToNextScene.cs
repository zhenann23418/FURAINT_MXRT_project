using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonToNextScene : MonoBehaviour
{
    //methods to assign to buttons in order to move to a specific scene
    public void ToSignUpScene()
    {
        SceneManager.LoadScene("2SignUpScene");
    }
}
