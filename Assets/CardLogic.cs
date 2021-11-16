using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardLogic : MonoBehaviour
{
    public TMP_Text tmp;
    public bool IsMouseOver = false;
    private void OnMouseOver()
    {
        IsMouseOver = true;
    }

    private void OnMouseExit()
    {
        IsMouseOver = false;
    }

    public void InduceRight()
    {
        tmp.text = "Swiped Right";
    }

    public void InduceLeft()
    {
        tmp.text = "Swiped Left";
    }

    public void InduceNeutral()
    {
        tmp.text = "Nothing";
    }
}
