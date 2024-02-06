using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using System.Collections;
public class BeadPrice : MonoBehaviour, IDataPersistence
{
    #region Variables
    private BeadInfo beadPrice;
    public Inventory beadInventory;
    public string beadName;
    public string typeOfBead;
    public float numberOfBeadsOnStrand;
    public float numberOfBeadsOnHand;
    public float priceOfBeadStrand;
    public double amountOfEachBead;
    public string beadSize;
    public TMP_Text beadNameText;
    public TMP_Text typeOfBeadText;
    public TMP_Text numberOfBeadsOnHandText;
    public TMP_Text priceOfBeadStrandText;
    public TMP_Text amountOfEachBeadText;
    public Image pictureOfBeadSprite;
    public TMP_Text beadSizeText;
    public Button nextBeadButton;
    public Button lastBeadButton;
    public float addingBeadTime;
    public bool beadAdded = false;

    public double garnetBeadPrice;
    #endregion Variables

    #region StartAndUpdate
    void Start()
    {
        beadAdded = false;
        beadPrice = GetComponent<BeadInfo>();
    }

    void Update()
    {
        CalculateBeadPrice();
    }
    #endregion StartAndUpdate

    private void CalculateBeadPrice()
    {
        if(beadPrice != null)
        {
            beadName = beadPrice.name;
            beadNameText.text = beadName;
            typeOfBead = beadPrice.Type_Of_Bead;
            typeOfBeadText.text = typeOfBead;
            numberOfBeadsOnStrand = beadPrice.Number_Of_Beads_On_Strand;
            numberOfBeadsOnHand = beadPrice.Number_Of_Beads_On_Hand;
            numberOfBeadsOnHandText.text = numberOfBeadsOnHand.ToString();
            beadSize = beadPrice.Bead_Size;
            beadSizeText.text = beadSize.ToString();
            priceOfBeadStrand = beadPrice.Price_Of_BeadStrand;
            priceOfBeadStrandText.text = priceOfBeadStrand.ToString();
            pictureOfBeadSprite.sprite = beadPrice.Picture_Of_Bead;
        }
        PriceOfEachBead();
    }

    public void PriceOfEachBead()
    {
        amountOfEachBead = priceOfBeadStrand / numberOfBeadsOnStrand;
        amountOfEachBead = Math.Round(amountOfEachBead, 2, MidpointRounding.AwayFromZero);
        amountOfEachBeadText.text = amountOfEachBead.ToString();
        //StartCoroutine(AddingBeadToList());
    }

    private void AddBeadToList()
    {
        StartCoroutine(AddingBeadToList());
        if(beadAdded == true)
        {
            //beadInventory.individualBeadPrices.Add(amountOfEachBead);
            beadAdded = false;
        }
    }

    private IEnumerator AddingBeadToList()
    {
        beadAdded = true;
        yield return new WaitForSeconds(addingBeadTime);
        AddBeadToList();
        StopCoroutine(AddingBeadToList());
    }

    public void LoadData(DataForBeads bead)
    {
        this.garnetBeadPrice = bead.garnetBeadPrice;
    }

    public void SaveData(ref DataForBeads bead)
    {
        bead.garnetBeadPrice = this.garnetBeadPrice;
    }

    //public void OnNewBeadClicked()
    //{
    //    DataPersistenceManager.instance.NewBead();
    //}

    //public void OnLoadBeadClicked()
    //{
    //    DataPersistenceManager.instance.LoadBead();
    //}

    //public void OnSaveBeadClicked()
    //{
    //    DataPersistenceManager.instance.SaveBead();
    //}
}