using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StrandPrice : MonoBehaviour
{
    #region
    public BeadPricing_BeadInfo beadPrice;
    public StrandInfo strandInfo;
    public string strandName;
    public string bead1Name;
    public float numberOfBead1Used;
    public double amountOfEachBead1;
    public double totalPriceOfBead1;
    public string bead2Name;
    public float numberOfBead2Used;
    public double amountOfEachBead2;
    public double totalPriceOfBead2;
    public string bead3Name;
    public float numberOfBead3Used;
    public double amountOfEachBead3;
    public double totalPriceOfBead3;
    public string bead4Name;
    public float numberOfBead4Used;
    public double amountOfEachBead4;
    public double totalPriceOfBead4;
    public float howLongToMakeStrand;
    public double hourlyWage;
    public double totalLaborCost;
    public double copperWireCost;
    public double strandCost;
    public double strandCostWithWireAndLabor;
    public double markupCostOfStrand;
    public float markUpAmount;
    public TMP_Text strandNameText;
    public TMP_Text bead1NameText;
    public TMP_Text totalPriceOfBead1Text;
    public TMP_Text bead2NameText;
    public TMP_Text totalPriceOfBead2Text;
    public TMP_Text bead3NameText;
    public TMP_Text totalPriceOfBead3Text;
    public TMP_Text bead4NameText;
    public TMP_Text totalPriceOfBead4Text;
    public Image strandSprite;
    public TMP_Text strandCostText;
    #endregion

    #region StartAndUpdate
    private void Start()
    {
        strandInfo = GetComponent<StrandInfo>();
    }

    private void Update()
    {
        CalculateStrandPrice();
    }
    #endregion StartAndUpdate

    private void CalculateStrandPrice()
    {
        if(strandInfo != null)
        {
            strandName = strandInfo.name;
            strandNameText.text = strandName;
            CalCulateTotalBeadPrice(bead1Name, strandInfo.BeadNumber1NameUsed, numberOfBead1Used, strandInfo.NumberOfBeads1Used, amountOfEachBead1, beadPrice.Amount_Of_Each_Bead, totalPriceOfBead1, bead1NameText, totalPriceOfBead1Text);
            CalculateStrandCost();
            CalculateLaborCost();
            TotalStrandCost();
            MarkUpCostOfStrand();
        }
    }

    private void MarkUpCostOfStrand()
    {
        markupCostOfStrand = strandCostWithWireAndLabor * markUpAmount;
    }

    private void TotalStrandCost()
    {
        strandCostWithWireAndLabor = totalLaborCost + strandCost + copperWireCost;
    }
    private void CalculateStrandCost()
    {
        strandCost = totalPriceOfBead1 + totalPriceOfBead2 + totalPriceOfBead3 + totalPriceOfBead4;       
    }

    private void CalculateLaborCost()
    {
        totalLaborCost = howLongToMakeStrand / 60 * hourlyWage;
    }
    private void CalCulateTotalBeadPrice(string beadName, string beadNameInfo, float numberOfBeadUsed, float numberOfBeadsUsedInfo, double amountOfEachBead, double amountOfEachBeadInfo, double totalPriceOfBead, TMP_Text beadNameText, TMP_Text totalPriceOfBeadText)
    {
        if(beadPrice != null)
        {
            beadName = beadNameInfo;
            beadNameText.text = beadName;
            numberOfBeadUsed = numberOfBeadsUsedInfo;
            amountOfEachBead = amountOfEachBeadInfo;
            totalPriceOfBead = amountOfEachBead * numberOfBeadUsed;
            totalPriceOfBeadText.text = totalPriceOfBead.ToString();
        }
    }
}