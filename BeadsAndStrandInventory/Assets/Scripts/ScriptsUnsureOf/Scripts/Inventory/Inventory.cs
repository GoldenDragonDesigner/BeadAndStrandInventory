using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System;
using System.IO;

public class Inventory : MonoBehaviour
{
    //public List<string> individualBeadName;
    //public List<double> individualBeadPrices;

    //public Dictionary<string, double> beadPrices = new Dictionary<string, double>();

    //private void Update()
    //{
    //    foreach(KeyValuePair<string, double> beadPricePair in beadPrices)
    //    {
    //        beadPrices.Add(individualBeadName, individualBeadPrices);
    //        Console.WriteLine("{0} and {1}", beadPrices.Keys, beadPrices.Values);
    //    }
    //}
    //public double garnetBeadPrice;
    public string clearQuartzName;
    public double clearQuartBeadPrice;
    //public double abaloneShellBeadPrice;
    //public double citrineBeadPrice;
    //public double bronziteBeadPrice;
    //public double aquamarineBeadPrice;
    //public double unikiteBeadPrice;
    //public double round5mmAmethystBeadPrice;
    //public double azuriteMalachiteBeadPrice;
    //public double rough10mmAmethystBeadPrice;
    //public double obsidianBeadPrice;
    //public double shungiteBeadPrice;
    //public double round10mmAmethystBeadPrice;
    //public double tearDropSodaliteBeadPrice;
    //public double OvalyellowTigersEyesBeadPrice;
    //public double roughPinkPearlBeadPrice;
    //public double tearDropOceanJasperBeadPrice;
    //public double round5mmJadeBeadPrice;
    //public double round10mmRoseQuartzBeadPrice;
    //public double round6mmCarnelianBeadPrice;
    //public double oval6mmLapisLazuliBeadPrice;
    //public double roughRound5mmHematiteBeadPrice;
    //public double round8mmPeachMoonStoneBeadPrice;
    //public double round6mmRoseQuartzBeadPrice;
    //public double flatSquare10mmGreenTigersEyeBeadPrice;
    //public double round6mmGreenAventrineBeadPrice;
    //public double round8mmCitrineBeadPrice;
    //public double chips4mmAmazoniteBeadPrice;
    //public double chips4mmSodaliteBeadPrice;
    //public double round4mmMoonstoneBeadPrice;

    //public List<BeadData> beadData;
    //    public InputFieldTextHolder inputBeadAmount;

    //    public BeadNames beadNames;
    //    public BeadPictures beadPictures;
    //    public BeadTypes beadTypes;
    //    public BeadAmounts beadDollarAmounts;
    //    public BeadSizes beadSizes;
    //    public BeadQuantity beadQuantity;

    //    public WireTypes wireName;
    //    public WirePictures wirePictures;
    //    public WireSizes wireSizes;
    //    public WireAmounts wireDollarAmounts;

    //    public GameObject beadNamePanel;
    //    public TextMeshProUGUI beadName;
    //    public Image beadImage;
    //    public TMP_Text beadType;
    //    public TMP_Text beadDollarAmount;
    //    public TMP_Text beadSize;
    //    public TMP_Text currentBeadQuantityText;

    //    public int roughAmethystBeadCount;
    //    public int lapisLazuliBeadCount;
    //    public int sodaliteBeadCount;
    //    public int aventurineBeadCount;
    //    public int citrineBeadCount;
    //    public int tigersEyeBeadCount;
    //    public int carnelianBeadCount;
    //    public int garnetBeadCount;
    //    public int abaloneShellBeadCount;
    //    public int clearQuartzBeadCount;
    //    public int copperWire24GuageCount;

    //    //public int currentBeadQty;
    //    public int numberToBeAddedToInventory;
    //    public int newBeadNumber;

    //    private void Start()
    //    {
    //        beadNamePanel.SetActive(true);
    //        //CreatingList();
    //    }

    //    private void Update()
    //    {
    //        //BeadNumberUpdateCount(roughAmethystBeadCount, beadQuantity);
    //        //BeadNumberUpdateCount(lapisLazuliBeadCount, beadQuantity);
    //    }

    //    private void CreatingList()
    //    {
    //        //beadQuantity.beadQuantities.Add(beadQuantity.amethystRoughQuantity);
    //        //beadQuantity.beadQuantities.Add(beadQuantity.lapisLazuliQuantity);
    //        //beadQuantity.beadQuantities.Add(beadQuantity.sodaliteQuantity);
    //        //beadQuantity.beadQuantities.Add(beadQuantity.aventurineQuantity);
    //        //beadQuantity.beadQuantities.Add(beadQuantity.citrineQuantity);
    //        //beadQuantity.beadQuantities.Add(beadQuantity.tigersEyeQuantity);
    //        //beadQuantity.beadQuantities.Add(beadQuantity.carnelianQuantity);
    //        //beadQuantity.beadQuantities.Add(beadQuantity.garnetQuantity);
    //        //beadQuantity.beadQuantities.Add(beadQuantity.abaloneShellQuantity);
    //        //beadQuantity.beadQuantities.Add(beadQuantity.clearQuartzQuantity);
    //    }

    //    private void BeadNumberUpdateCount(int beadType, BeadQuantity beadQuantity)
    //    {
    //        if (beadType >= 0)
    //        {
    //            beadType = beadType + numberToBeAddedToInventory;
    //            currentBeadQuantityText.text = beadType.ToString();
    //            for(int i = 0; i < beadQuantity.beadQuantities.Count; i++)
    //            {
    //                currentBeadQuantityText.text = beadQuantity.beadQuantities[i].ToString();
    //                beadType += beadQuantity.beadQuantities[i];
    //            }
    //        }
    //        else
    //        {
    //            beadType = numberToBeAddedToInventory;
    //            currentBeadQuantityText.text = beadType.ToString();
    //            for(int i = 0; i < beadQuantity.beadQuantities.Count; i++)
    //            {
    //                currentBeadQuantityText.text = beadQuantity.beadQuantities[i].ToString();
    //            }
    //        }
    //    }

    //    public void BeadNumberUpdate()
    //    {
    //        //bool beadNumberSuccess = int.TryParse(inputBeadAmount.text, out numberToBeAddedToInventory);
    //        //if (beadNumberSuccess)
    //        //{
    //        //    //BeadNumberUpdateCount(roughAmethystBeadCount, beadQuantity);

    //        //}
    //        //else
    //        //{
    //        //    Debug.Log("Invalid input");
    //        //}
    //    }
    //    private void BeadPress(string name, Sprite picture, string type, int size, float dollarAmount, int quantity)
    //    {
    //        beadName.text = name;
    //        beadImage.sprite = picture;
    //        beadType.text = type.ToString();
    //        beadSize.text = size.ToString();
    //        beadDollarAmount.text = dollarAmount.ToString();
    //        currentBeadQuantityText.text = quantity.ToString();       
    //        beadNamePanel.SetActive(false);
    //    }
    //    public void AmethystButtonPress()
    //    {
    //        //BeadPress(beadNames.beadNames[0], beadPictures.amethsytImage, beadTypes.roughTypeBead, beadSizes.tenMm, beadDollarAmounts.amethystAmoun10Mm, beadQuantity.amethystRoughQuantity);
    //    }

    //    public void LapisButtonPress()
    //    {
    //        //BeadPress(beadNames.lapisLazuli, beadPictures.lapisLazuliImage, beadTypes.roundTypeBead, beadSizes.sixMm, beadDollarAmounts.lapisAmount6Mm, beadQuantity.lapisLazuliQuantity);
    //    }

    //    public void SodaliteButtonPress()
    //    {
    //        //beadName.text = beadNames.sodalite;
    //        //beadImage.sprite = beadPictures.sodaliteImage;
    //        //beadType.text = beadTypes.tearDroppedShapped;
    //        //beadSize.text = beadSizes.eightMm.ToString();
    //        //beadDollarAmount.text = beadDollarAmounts.sodalite8Mm.ToString();
    //        //currentBeadQuantityText.text = sodaliteBeadCount.ToString();
    //        //beadNamePanel.SetActive(false);
    //    }

    //    public void AventurineButtonPress()
    //    {
    //        //beadName.text = beadNames.aventurine;
    //        //beadImage.sprite = beadPictures.aventurineImage;
    //        //beadType.text = beadTypes.roundTypeBead;
    //        //beadSize.text = beadSizes.eightMm.ToString();
    //        //beadDollarAmount.text = beadDollarAmounts.aventurine8Mm.ToString();
    //        //currentBeadQuantityText.text = aventurineBeadCount.ToString();
    //        //beadNamePanel.SetActive(false);
    //    }

    //    public void CitrineButtonPress()
    //    {
    //        //beadName.text = beadNames.citrine;
    //        //beadImage.sprite = beadPictures.citrineImage;
    //        //beadType.text = beadTypes.roundTypeBead;
    //        //beadSize.text = beadSizes.eightMm.ToString();
    //        //beadDollarAmount.text = beadDollarAmounts.citrineAmount8Mm.ToString();
    //        //currentBeadQuantityText.text = citrineBeadCount.ToString();
    //        //beadNamePanel.SetActive(false);
    //    }

    //    public void TigersEyeButtonPress()
    //    {
    //        //beadName.text = beadNames.tigersEye;
    //        //beadImage.sprite = beadPictures.tigersEyeImage;
    //        //beadType.text = beadTypes.ovalShapped;
    //        //beadSize.text = beadSizes.eightMm.ToString();
    //        //beadDollarAmount.text = beadDollarAmounts.tigersEyeAmount8Mn.ToString();
    //        //currentBeadQuantityText.text = tigersEyeBeadCount.ToString();
    //        //beadNamePanel.SetActive(false);
    //    }

    //    public void CarnelianButtonPress()
    //    {
    //        //beadName.text = beadNames.carnelian;
    //        //beadImage.sprite = beadPictures.carnelianImage;
    //        //beadType.text = beadTypes.roundTypeBead;
    //        //beadSize.text = beadSizes.eightMm.ToString();
    //        //beadDollarAmount.text = beadDollarAmounts.carnelianAmount8Mm.ToString();
    //        //currentBeadQuantityText.text = carnelianBeadCount.ToString();
    //        //beadNamePanel.SetActive(false);
    //    }

    //    public void GarnetButtonPress()
    //    {
    //        //beadName.text = beadNames.garnet;
    //        //beadImage.sprite = beadPictures.garnetImage;
    //        //beadType.text = beadTypes.roundTypeBead;
    //        //beadSize.text = beadSizes.fourMm.ToString();
    //        //beadDollarAmount.text = beadDollarAmounts.garnetAmount4Mm.ToString();
    //        //currentBeadQuantityText.text = garnetBeadCount.ToString();
    //        //beadNamePanel.SetActive(false);
    //    }

    //    public void ClearQuartzButtonPress()
    //    {
    //        //beadName.text = beadNames.clearQuartz;
    //        //beadImage.sprite = beadPictures.clearQuartzImage;
    //        //beadType.text = beadTypes.ovalShapped;
    //        //beadSize.text = beadSizes.eightMm.ToString();
    //        //beadDollarAmount.text = beadDollarAmounts.clearQuartzAmount8Mm.ToString();
    //        //currentBeadQuantityText.text = clearQuartzBeadCount.ToString();
    //        //beadNamePanel.SetActive(false);
    //    }

    //    public void AbaloneShellButtonPress()
    //    {
    //        ///beadName.text = beadNames.abaloneShell;
    //        //beadImage.sprite = beadPictures.abaloneShellImage;
    //        //beadType.text = beadTypes.flatAndHexagonalTypeBead;
    //        //beadSize.text = beadSizes.twentyMm.ToString();
    //        //beadDollarAmount.text = beadDollarAmounts.abaloneShellAmount20MmFlat.ToString();
    //        //currentBeadQuantityText.text = abaloneShellBeadCount.ToString();
    //        //beadNamePanel.SetActive(false);
    //    }

    //    public void CopperWireButtonPress()
    //    {
    //        //beadName.text = wireName.copperWire;
    //        //beadImage.sprite = wirePictures.copperWire24Guage;
    //        //beadType.text = wireName.copperWire;
    //        //beadSize.text = wireSizes.twentFourGuage.ToString();
    //        //beadDollarAmount.text = wireDollarAmounts.wireAmountCopper24Guage.ToString();
    //        //currentBeadQuantityText.text = copperWire24GuageCount.ToString();
    //        //beadNamePanel.SetActive(false);
    //    }

    //    //public void ObsidianButtonPress()
    //    //{
    //    //    beadName.text = beadNames.;
    //    //    beadImage.sprite = beadPictures.;
    //    //    beadType.text = beadTypes.roundTypeBead;
    //    //    beadSize.text = beadSizes..ToString();
    //    //    beadDollarAmount.text = beadDollarAmounts..ToString();
    //    //    currentBeadQuantityText.text = .ToString();
    //    //    beadNamePanel.SetActive(false);
    //    //}

    //    //public void RoseQuartzButtonPress()
    //    //{
    //    //    beadName.text = beadNames.;
    //    //    beadImage.sprite = beadPictures.;
    //    //    beadType.text = beadTypes.roundTypeBead;
    //    //    beadSize.text = beadSizes..ToString();
    //    //    beadDollarAmount.text = beadDollarAmounts..ToString();
    //    //    currentBeadQuantityText.text = .ToString();
    //    //    beadNamePanel.SetActive(false);
    //    //}
}