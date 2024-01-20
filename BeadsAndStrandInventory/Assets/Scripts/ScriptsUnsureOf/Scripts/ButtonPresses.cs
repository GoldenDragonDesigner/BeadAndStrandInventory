using UnityEngine;

public class ButtonPresses : MonoBehaviour
{
    #region Variables

    public GameObject currentScreen;
    public GameObject nextScreen;
    public GameObject lastScreen;

    public GameObject inventoryScreen;
    public GameObject questionScreen;

    #endregion Variables

    #region Functions

    public void ToInventoryScreen()
    {
        currentScreen.SetActive(false);
        inventoryScreen.SetActive(true);
    }

    public void ToQuestonScreen()
    {
        currentScreen.SetActive(false);
        questionScreen.SetActive(true);
    }

    public void ContinueButton()
    {
        currentScreen.SetActive(false);
        nextScreen.SetActive(true);
        lastScreen.SetActive(false);
    }

    public void BackButton()
    {
        currentScreen.SetActive(false);
        lastScreen.SetActive(true);
        nextScreen.SetActive(false);
    }

    #endregion Functions
}