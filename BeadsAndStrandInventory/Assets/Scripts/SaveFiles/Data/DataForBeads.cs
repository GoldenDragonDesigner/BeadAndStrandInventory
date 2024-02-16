using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
//Same as GameData
public class DataForBeads
{

    public string garnetName;
    public string garnetType;
    public float numberOfGarnetBeadsOnStrand;
    //public float numberOfGarnetBeadsOnHand;
    //public double priceOfGarnetBeadStrand;
    //public double garnetBeadPrice;
    //public string garnetBeadSize;


    //public Dictionary<string, double> beadsPriced;

    //the values defined in this constructor will be the default values
    //the game starts with when there's no data to load
    public DataForBeads()
    {
        //this.beadName = "";
        //this.garnetName = "";
        //this.garnetType = "";
        //this.numberOfGarnetBeadsOnHand = 0.0f;
        //this.numberOfGarnetBeadsOnStrand = 0.0f;
        //this.priceOfGarnetBeadStrand = 0.0d;
        //this.garnetBeadPrice = 0.0f;
        this.garnetName = "";       
    }
}