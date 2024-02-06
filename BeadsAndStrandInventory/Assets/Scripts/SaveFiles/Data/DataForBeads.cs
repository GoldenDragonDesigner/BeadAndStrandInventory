using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
//Same as GameData
public class DataForBeads
{
    public double garnetBeadPrice;

    public Dictionary<string, double> beadsPriced;

    //the values defined in this constructor will be the default values
    //the game starts with when there's no data to load
    public DataForBeads()
    {
        this.garnetBeadPrice = 0.00f;
        beadsPriced = new Dictionary<string, double>();
    }
}