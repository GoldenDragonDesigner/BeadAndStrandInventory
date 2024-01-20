using UnityEngine;

public class GemkraUIManager : MonoBehaviour
{
    #region Variables

    public GameObject welcomeScreen;
    public GameObject infoScreen;
    public GameObject copperWireScreen;
    public GameObject abaloneShellScreenDiscription;
    public GameObject clearQuartzScreenDiscription;
    public GameObject fullStrandScreen;
    public GameObject chakraScreen;
    public GameObject ChakraBeadScreen;
    public GameObject questionPanelScreen;
    public GameObject preliminaryQuestionScreen;
    public GameObject quesion1;
    public GameObject question2;
    public GameObject question3;
    public GameObject addingInventoryPanel;

    public bool isAmethystPanelActive;
    public bool isGarnetPanelActive;
    public bool isAbaloneShellPanelActive;
    public bool isAddingBeadsToInventoryPanelActive;
    public bool isQuestion1Active;
    public bool isQuestion2Active;
    public bool isQuestion3Active;

    public GameObject garnetPanel;
    public GameObject amethystPanel;
    public GameObject abaloneShellPanel;

    public bool[] isGemstonePanelActive;

    private GemstonePanelsActiveBase[] panelScriptArray;
    private AmethystPanelIsActive amethystPanelIsActive;

    public GameObject[] gemstoneBeadPanels;

    #endregion Variables

    void Start()
    {
        //SettingPanelsInActive();
        //SettingPanelUp();
    }

    void Update()
    {
        
        SettingPanelsActive();
    }

    #region Functions

    private void SettingPanelsInActive()
    {
        //welcomeScreen.SetActive(true);
        infoScreen.SetActive(false);
        copperWireScreen.SetActive(false);
        abaloneShellScreenDiscription.SetActive(false);
        clearQuartzScreenDiscription.SetActive(false);
        chakraScreen.SetActive(false);
        garnetPanel.SetActive(false);
        amethystPanel.SetActive(false);
        abaloneShellPanel.SetActive(false);
        fullStrandScreen.SetActive(false);
        ChakraBeadScreen.SetActive(false);
        questionPanelScreen.SetActive(false);
        preliminaryQuestionScreen.SetActive(false);
        quesion1.SetActive(false);
        question2.SetActive(false);
        question3.SetActive(false);
        addingInventoryPanel.SetActive(false);
    }
    private void SettingPanelUp()
    {
        amethystPanelIsActive = gemstoneBeadPanels[0].GetComponent<AmethystPanelIsActive>();
        panelScriptArray = new GemstonePanelsActiveBase[]
        {
            amethystPanelIsActive
        };
    }
    private void SettingPanelsActive()
    {
        SettingGemstonePanelActive(garnetPanel, isGarnetPanelActive);
        SettingGemstonePanelActive(amethystPanel, isAmethystPanelActive);
        SettingGemstonePanelActive(abaloneShellPanel, isAbaloneShellPanelActive);
        SettingGemstonePanelActive(addingInventoryPanel, isAddingBeadsToInventoryPanelActive);
        SettingGemstonePanelActive(quesion1, isQuestion1Active);
        SettingGemstonePanelActive(question2, isQuestion2Active);
        SettingGemstonePanelActive(question3, isQuestion3Active);
    }

    private void SettingGemstonePanelActive(GameObject gemstoneName, bool isGemstoneActive)
    {
        if (isGemstoneActive)
        {
            gemstoneName.SetActive(true);
        }
        else
        {
            gemstoneName.SetActive(false);
        }
    }

    #endregion Functions

    #region ButtonFunctions

    public void ActivatingAmethystPanel()
    {
        isAmethystPanelActive = true;
    }

    #endregion ButtonFunctions
}