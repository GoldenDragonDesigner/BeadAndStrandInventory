using UnityEngine;

public class GemstonePanelsActiveBase : MonoBehaviour
{
    #region Variables

    private Gemstones gemstones;
    public GemkraUIManager gemkraUIManager;
    [SerializeField]
    protected int gemstoneNumber;
    public bool gemstoneActive;

    #endregion Variables

    protected virtual void Start()
    {
        gemstones = GetComponent<Gemstones>();
        gemstoneActive = false;
    }

    protected virtual void Update()
    {
        SettingTheTriggerForGemPanelBool();
    }

    #region Function

    protected virtual void SettingTheTriggerForGemPanelBool()
    {
        if (!gemstones.gemIsActive) { return; }
        switch (gemstones.gemIsActive)
        {
            case true:
                gemstoneActive = true;
                gemkraUIManager.isGemstonePanelActive[gemstoneNumber] = true;
                break;
            case false:
                gemstoneActive = false;
                gemkraUIManager.isGemstonePanelActive[gemstoneNumber] = false;
                break;
        }
    }

    #endregion Function
}