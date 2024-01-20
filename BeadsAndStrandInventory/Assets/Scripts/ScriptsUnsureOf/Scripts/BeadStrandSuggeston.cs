using UnityEngine;
using System.Collections.Generic;

public class BeadStrandSuggeston : MonoBehaviour
{
    #region BoolVariables
    public bool red;
    public bool orange;
    public bool yellow;
    public bool green;
    public bool blue;
    public bool violet;

    public bool head;
    public bool neck;
    public bool chest;
    public bool stomach;
    public bool groin;
    public bool everywhereChronic;

    public bool depression;
    public bool anger;
    public bool guilt;
    public bool loneliness;
    public bool stress;
    public bool noneRightNow;
    #endregion BoolVariables

    #region Variables

    //private GlobalVariables.BeadStrandStates beadStrandStates;

    public CustomerCart customerCart;

    #endregion Variables

    #region StartFunctions
    private void Start()
    {
        //beadStrandStates = GlobalVariables.BeadStrandStates.waitingForResponse;
        SettingBoolsFalse();
    }

    private void SettingBoolsFalse()
    {
        red = false;
        orange = false;
        yellow = false;
        green = false;
        blue = false;
        violet = false;
        head = false;
        neck = false;
        chest = false;
        stomach = false;
        groin = false;
        everywhereChronic = false;
        depression = false;
        anger = false;
        guilt = false;
        loneliness = false;
        stress = false;
        noneRightNow = false;
    }
    #endregion StartFunctions


    #region BoolFunctions
    public void PickedRed()
    {
        red = !red;
        if (red)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.garnet);
            //Debug.Log(customerCart.beadNames.garnet);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.garnet);
            Debug.Log(red);
        }
    }

    public void PickedOrange()
    {
        orange = !orange;
        if (orange)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.carnelian);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.carnelian);
        }
    }

    public void PickedYellow()
    {
        yellow = !yellow;
        if (yellow)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.tigersEye);
            //customerCart.beadSelections.Add(customerCart.beadNames.citrine);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.tigersEye);
            //customerCart.beadSelections.Remove(customerCart.beadNames.citrine);
        }
    }
    
    public void PickedGreen()
    {
        green = !green;
        if (green)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.aventurine);
            //customerCart.beadSelections.Add(customerCart.beadNames.roseQuartz);
            //customerCart.beadSelections.Add(customerCart.beadNames.unikite);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.aventurine);
            //customerCart.beadSelections.Remove(customerCart.beadNames.roseQuartz);
            //customerCart.beadSelections.Remove(customerCart.beadNames.unikite);
        }
    }

    public void PickedBlue()
    {
        blue = !blue;
        if (blue)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.lapisLazuli);
            //customerCart.beadSelections.Add(customerCart.beadNames.sodalite);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.lapisLazuli);
            //customerCart.beadSelections.Remove(customerCart.beadNames.sodalite);
        }
    }

    public void PickedViolet()
    {
        violet = !violet;
        if (violet)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.amethyst);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.amethyst);
        }
    }

    public void PickedHead()
    {
        head = !head;
        if (head)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.amethyst);
            //customerCart.beadSelections.Add(customerCart.beadNames.lapisLazuli);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.amethyst);
            //customerCart.beadSelections.Remove(customerCart.beadNames.lapisLazuli);
        }
    }

    public void PickedNeck()
    {
        neck = !neck;
        if (neck)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.sodalite);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.sodalite);
        }
    }

    public void PickedChest()
    {
        chest = !chest;
        if (chest)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.aventurine);
            //customerCart.beadSelections.Add(customerCart.beadNames.unikite);
            //customerCart.beadSelections.Add(customerCart.beadNames.roseQuartz);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.aventurine);
            //customerCart.beadSelections.Remove(customerCart.beadNames.unikite);
            //customerCart.beadSelections.Remove(customerCart.beadNames.roseQuartz);
        }
    }

    public void PickedStomach()
    {
        stomach = !stomach;
        if (stomach)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.tigersEye);
            //customerCart.beadSelections.Add(customerCart.beadNames.citrine);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.tigersEye);
            //customerCart.beadSelections.Remove(customerCart.beadNames.citrine);
        }
    }

    public void PickedGroin()
    {
        groin = !groin;
        if (groin)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.garnet);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.garnet);
        }
    }

    public void PickedEverywhereChronic()
    {
        everywhereChronic = !everywhereChronic;
        if (everywhereChronic)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.amethyst);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.amethyst);
        }
    }

    public void PickedDepression()
    {
        depression = !depression;
        if (depression)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.carnelian);
            //customerCart.beadSelections.Add(customerCart.beadNames.amethyst);
            //customerCart.beadSelections.Add(customerCart.beadNames.citrine);
            //customerCart.beadSelections.Add(customerCart.beadNames.tigersEye);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.carnelian);
            //customerCart.beadSelections.Remove(customerCart.beadNames.amethyst);
            //customerCart.beadSelections.Remove(customerCart.beadNames.citrine);
            //customerCart.beadSelections.Remove(customerCart.beadNames.tigersEye);
        }
    }

    public void PickedAnger()
    {
        anger = !anger;
        if (anger)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.amethyst);
            //customerCart.beadSelections.Add(customerCart.beadNames.roseQuartz);
            //customerCart.beadSelections.Add(customerCart.beadNames.lapisLazuli);
            //customerCart.beadSelections.Add(customerCart.beadNames.carnelian);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.amethyst);
            //customerCart.beadSelections.Remove(customerCart.beadNames.roseQuartz);
            //customerCart.beadSelections.Remove(customerCart.beadNames.lapisLazuli);
            //customerCart.beadSelections.Remove(customerCart.beadNames.carnelian);
        }
    }

    public void PickedGuilt()
    {
        guilt = !guilt;
        if (guilt)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.citrine);
            //customerCart.beadSelections.Add(customerCart.beadNames.obsidian);
            //customerCart.beadSelections.Add(customerCart.beadNames.roseQuartz);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.citrine);
            //customerCart.beadSelections.Remove(customerCart.beadNames.obsidian);
            //customerCart.beadSelections.Remove(customerCart.beadNames.roseQuartz);
        }
    }

    public void PickedLoneliness()
    {
        loneliness = !loneliness;
        if (loneliness)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.amethyst);
            //customerCart.beadSelections.Add(customerCart.beadNames.roseQuartz);
            //customerCart.beadSelections.Add(customerCart.beadNames.citrine);
            //customerCart.beadSelections.Add(customerCart.beadNames.carnelian);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.amethyst);
            //customerCart.beadSelections.Remove(customerCart.beadNames.roseQuartz);
            //customerCart.beadSelections.Remove(customerCart.beadNames.citrine);
            //customerCart.beadSelections.Remove(customerCart.beadNames.carnelian);
        }
    }
    
    public void PickedStress()
    {
        stress = !stress;
        if (stress)
        {
            //customerCart.beadSelections.Add(customerCart.beadNames.roseQuartz);
            //customerCart.beadSelections.Add(customerCart.beadNames.amethyst);
            //customerCart.beadSelections.Add(customerCart.beadNames.citrine);
            //customerCart.beadSelections.Add(customerCart.beadNames.sodalite);
        }
        else
        {
            //customerCart.beadSelections.Remove(customerCart.beadNames.roseQuartz);
            //customerCart.beadSelections.Remove(customerCart.beadNames.amethyst);
            //customerCart.beadSelections.Remove(customerCart.beadNames.citrine);
            //customerCart.beadSelections.Remove(customerCart.beadNames.sodalite);
        }
    }
    
    public void PickedNoneRightNow()
    {
        noneRightNow = !noneRightNow;
        if (noneRightNow)
        {
            Debug.Log("Picked None checkbox");
        }
    }
    #endregion BoolFunctions
}