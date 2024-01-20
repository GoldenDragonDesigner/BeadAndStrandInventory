using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CustomerCart : MonoBehaviour
{
    public BeadNames beadNames;

    public List<string> beadSelections = new List<string>();

    private void Start()
    {
        beadSelections.Clear();
    }
}
