using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardLogic : MonoBehaviour
{
    public TMP_Text tmp;
    public bool IsMouseOver = false;
    public GameObject Card;
    private Vector3 Offset;

    private void Start()
    {

    }

    public void Update()
    {
        Vector3 MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            Collider2D Target = Physics2D.OverlapPoint(MousePosition);

            if (Target)
            {
                Card = Target.transform.gameObject;
                Offset = Card.transform.position - MousePosition;
            }
        }

        if (Card)
        {
            Card.transform.position = MousePosition + Offset;
        }

        if (Input.GetMouseButtonUp(0) && Card)
        {
            Card = null;
        }

        print(MousePosition);
    }


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
