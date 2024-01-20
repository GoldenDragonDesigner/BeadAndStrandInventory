using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AddingBeadQuantity : MonoBehaviour
{
    public BeadNames beadNames;
    public BeadPictures beadPictures;
    public BeadTypes beadTypes;
    public BeadAmounts beadDollarAmounts;
    public BeadSizes beadSizes;
    //public BeadQuantity currentBeadQuantity;
    public GameObject beadNamePanel;
    public TextMeshProUGUI beadName;
    public Image beadImage;
    public TMP_Text beadType;
    public TMP_Text beadDollarAmount;
    public TMP_Text beadSize;
    public TMP_Text currentBeadQuantityText;
    public TMP_InputField numberToBeAddedToInventory;

    public int currentBeadQTY;

    //public Inventory inventory;

    private void Start()
    {
        //beadNamePanel.SetActive(true);
        //inventory = GetComponent<Inventory>();
    }

    public void AmethsytUpdate()
    {
        if(currentBeadQTY >= 0)
        {
           //currentBeadQTY = currentBeadQTY + currentBeadQuantity.amethystRoughQuantity;
           //currentBeadQuantityText.text = currentBeadQuantity.amethystRoughQuantity.ToString();
        }
        else
        {
            //currentBeadQTY = currentBeadQuantity.amethystRoughQuantity;
            //currentBeadQuantityText.text = currentBeadQuantity.amethystRoughQuantity.ToString();
        }
    }
}