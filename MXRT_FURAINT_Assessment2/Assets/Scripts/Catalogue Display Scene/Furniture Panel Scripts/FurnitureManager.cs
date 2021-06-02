using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//referenced tutorial: https://youtu.be/bARhGg31MIs 
public class FurnitureManager : MonoBehaviour
{
    //reference to our furniture images 
    //we will use an array to store our images
    public GameObject[] furnitureImages;
    //instead of assigning the int below to a number, we will save it to playerprefs
    public int currentFurnitureImageIndex;

    // Start is called before the first frame update
    void Start()
    {
        //we will store the previously selected furniture image to playerprefs
        currentFurnitureImageIndex = PlayerPrefs.GetInt("SelectedFurniture", 0);

        //then we enable the currentFurnitureImageIndex and disable the others in the start method 
        //loop through all the images by using foreach 
        foreach (GameObject furniture in furnitureImages)
            furniture.SetActive(false);

        //enables the current image
        furnitureImages[currentFurnitureImageIndex].SetActive(true);
    }

    //the next block of code is to be assigned to the next button in order to change the 
    //images based on what the user clicks on
    public void ChangeNext()
    {
        //firstly, we set the current furniture index to false
        furnitureImages[currentFurnitureImageIndex].SetActive(false);

        //then we increment the index to get the next one
        currentFurnitureImageIndex++;

        //next we need to check if the currentFurnitureIndex goes beyond the number of actual images 
        if (currentFurnitureImageIndex == furnitureImages.Length)
            currentFurnitureImageIndex = 0;

        //then we enable the next furniture image
        furnitureImages[currentFurnitureImageIndex].SetActive(true);

        //lastly we store the new selected image into playerPrefs
        PlayerPrefs.SetInt("SelectedFurniture", currentFurnitureImageIndex);
    }

    //the next block of code is to be assigned to the previous button 
    public void ChangePrevious()
    {
        //firstly, we set the current furniture index to false
        furnitureImages[currentFurnitureImageIndex].SetActive(false);

        //then we increment the index to get the next one
        currentFurnitureImageIndex--;

        //next we need to check if the currentFurnitureIndex goes beyond the number of actual images 
        if (currentFurnitureImageIndex == -1)
            currentFurnitureImageIndex = furnitureImages.Length -1;

        //then we enable the next furniture image
        furnitureImages[currentFurnitureImageIndex].SetActive(true);

        //lastly we store the new selected image into playerPrefs
        PlayerPrefs.SetInt("SelectedFurniture", currentFurnitureImageIndex);
    }



}
