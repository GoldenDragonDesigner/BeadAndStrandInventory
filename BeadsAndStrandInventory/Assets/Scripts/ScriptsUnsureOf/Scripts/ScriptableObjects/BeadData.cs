using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu]
public class BeadData : ScriptableObject
{
    [Tooltip("This is where the Bead Name will be")]
    public List<string> beadName = new List<string>();
    [Tooltip("This is where the bead Picture will go")]
    public List<Sprite> beadSprite = new List<Sprite>();
    [Tooltip("What kind of bead is it? Round? Flat? rough?")]
    public List<string> beadType = new List<string>();
    [Tooltip("This is the number of beads On hand")]
    public List<float> numberOfBeadsOnHand = new List<float>();
    [Tooltip("How Much did the Strand Cost?")]
    public List<float> amountOfStrand = new List<float>();
    [Tooltip("How Much does each bead cost?")]
    public List<float> individualBeadDollarAmount = new List<float>();
}