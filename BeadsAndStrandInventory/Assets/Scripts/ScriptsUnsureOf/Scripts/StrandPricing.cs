using UnityEngine;
using TMPro;

public class StrandPricing : MonoBehaviour
{
    public BoolHolder[] boolsToggled;
    public InputFieldTextHolder[] inputFieldTexts;

    public bool isBeadOne;
    public bool isBeadTwo;
    public bool isBeadThree;
    public bool isBeadFour;
    public bool didItTakeTimeToMake;
    public bool wasThereCopperWire;
    
    public string beadNameOne;
    public float numberOfBeadsOne;
    public float priceOfBeadOne;
    public float totalPriceOfBeadOne;

    public string beadNameTwo;
    public float numberOfBeadsTwo;
    public float priceOfBeadTwo;
    public float totalPriceOfBeadTwo;

    public string beadNameThree;
    public float numberOfBeadsThree;
    public float priceOfBeadThree;
    public float totalPriceOfBeadThree;

    public string beadNameFour;
    public float numberOfBeadsFour;
    public float priceOfBeadFour;
    public float totalPriceOfBeadFour;

    public float timeToMakeStrand;
    public float hourlyWage;
    public float totalLabor;

    public float copperWireCost;
    public float strandCost;
    public float totalCostOfStrand;
    public float markupCostOfStrand;

    public TMP_Text totalPriceOfBeadOneText;
    public TMP_Text totalPriceOfBeadTwoText;
    public TMP_Text totalPriceOfBeadThreeText;
    public TMP_Text totalPriceOfBeadFourText;
    public TMP_Text strandCostText;
    public TMP_Text totalCostOfStrandText;
    public TMP_Text markUpCostOfStrandText;
    public TMP_InputField timeToMakeStrandText;
    public TMP_InputField hourlyWageText;
    public TMP_InputField copperWireCostText;

    private void Update()
    {
        TotalPriceOfBeads();
        StrandCost();
        LaborCost();
        CostOfStrand();
        TotalCostOfStrand();
    }

    private void StrandCost()
    {
        if (boolsToggled[4].boolHolder)
        {
            didItTakeTimeToMake = true;
            strandCost = totalPriceOfBeadOne + totalPriceOfBeadTwo + totalPriceOfBeadThree + totalPriceOfBeadFour;
            strandCostText.text = strandCost.ToString();
        }
        else
        {
            didItTakeTimeToMake = false;
            strandCost = 0;
        }
    }
    private void TotalCostOfStrand()
    {
        markupCostOfStrand = totalCostOfStrand * 2;
        markUpCostOfStrandText.text = markupCostOfStrand.ToString();
    }

    private void CostOfStrand()
    {
        if (boolsToggled[5].boolHolder)
        {
            wasThereCopperWire = true;
            copperWireCost = inputFieldTexts[10].floatText;
            totalCostOfStrand = totalLabor + copperWireCost + strandCost;
            totalCostOfStrandText.text = totalCostOfStrand.ToString();
        }
        else
        {
            wasThereCopperWire = false;
            totalCostOfStrand = 0;
        }
    }

    private void LaborCost()
    {
        if (boolsToggled[4].boolHolder)
        {
            didItTakeTimeToMake = true;
            timeToMakeStrand = inputFieldTexts[8].floatText;
            hourlyWage = inputFieldTexts[9].floatText;
            totalLabor = (timeToMakeStrand / 60) * hourlyWage;
        }
        else
        {
            didItTakeTimeToMake = false;
        }
    }
    private void TotalPriceOfBeads()
    {
        if (boolsToggled[0].boolHolder)
        {
            isBeadOne = true;
            totalPriceOfBeadOne = numberOfBeadsOne * priceOfBeadOne;
            numberOfBeadsOne = inputFieldTexts[0].floatText;
            priceOfBeadOne = inputFieldTexts[1].floatText;
            inputFieldTexts[1].floatText = priceOfBeadOne;
            totalPriceOfBeadOneText.text = totalPriceOfBeadOne.ToString();
        }
        else
        {
            isBeadOne = false;
            numberOfBeadsOne = inputFieldTexts[0].floatText;
            numberOfBeadsOne = 0;
            priceOfBeadOne = inputFieldTexts[1].floatText;
            priceOfBeadOne = 0;
            totalPriceOfBeadOne = 0;
        }

        if (boolsToggled[1].boolHolder)
        {
            isBeadTwo = true;
            totalPriceOfBeadTwo = numberOfBeadsTwo * priceOfBeadTwo;
            numberOfBeadsTwo = inputFieldTexts[2].floatText;
            priceOfBeadTwo = inputFieldTexts[3].floatText;
            inputFieldTexts[3].floatText = totalPriceOfBeadTwo;
            totalPriceOfBeadTwoText.text = totalPriceOfBeadTwo.ToString();
        }
        else
        {
            isBeadTwo = false;
            numberOfBeadsTwo = 0;
            numberOfBeadsTwo = inputFieldTexts[2].floatText;
            priceOfBeadTwo = 0;
            priceOfBeadTwo = inputFieldTexts[3].floatText;
            totalPriceOfBeadTwo = 0;
        }
        if (boolsToggled[2].boolHolder)
        {
            isBeadThree = true;
            totalPriceOfBeadThree = numberOfBeadsThree * priceOfBeadThree;
            numberOfBeadsThree = inputFieldTexts[4].floatText;
            priceOfBeadThree = inputFieldTexts[5].floatText;
            inputFieldTexts[5].floatText = totalPriceOfBeadThree;
            totalPriceOfBeadThreeText.text = totalPriceOfBeadThree.ToString();
        }
        else
        {
            isBeadThree = false;
            numberOfBeadsThree = 0;
            numberOfBeadsThree = inputFieldTexts[4].floatText;
            priceOfBeadThree = 0;
            priceOfBeadThree = inputFieldTexts[5].floatText;
            totalPriceOfBeadThree = 0;
        }
        if (boolsToggled[3].boolHolder)
        {
            isBeadFour = true;
            totalPriceOfBeadFour = numberOfBeadsFour * priceOfBeadFour;
            numberOfBeadsFour = inputFieldTexts[6].floatText;
            priceOfBeadFour = inputFieldTexts[7].floatText;
            inputFieldTexts[7].floatText = totalPriceOfBeadFour;
            totalPriceOfBeadFourText.text = totalPriceOfBeadFour.ToString();
        }
        else
        {
            isBeadFour = false;
            numberOfBeadsFour = 0;
            numberOfBeadsFour = inputFieldTexts[6].floatText;
            priceOfBeadFour = 0;
            priceOfBeadFour = inputFieldTexts[7].floatText;
            totalPriceOfBeadFour = 0;
        }
    }
}