using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public GameObject[] Cards;
    public GameObject Card;
    public CardLogic CL;
    float FMovingSpeed = 1f;
    public float BreadCrumbs = 0f;
    private Transform CardSwipe;

    SpriteRenderer SR;

    void Start()
    {
        Cards = GameObject.FindGameObjectsWithTag("Cards");
        SR = Card.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetMouseButton(0) && CL.IsMouseOver)
            {
                Vector2 Pos = (Camera.main.ScreenToWorldPoint(Input.mousePosition));
                Card.transform.position = Pos;
            }
            else
            {
                Card.transform.position = Vector2.MoveTowards(Card.transform.position, new Vector2(0, 0), FMovingSpeed);
            }
            //Right Swipe
            if (Card.transform.position.x > 2)
            {
                SR.color = Color.green;
                if (Input.GetMouseButtonUp(0))
                {
                    CL.InduceRight();
                    print("Press Right");
                }
            }
            //Left Swipe
            else if (Card.transform.position.x < -2)
            {
                SR.color = Color.red;
                if (Input.GetMouseButtonUp(0))
                {
                    CL.InduceLeft();
                    print("Press Left");
                }
            }
            //Neutral
            //else
            //{
            //    SR.color = Color.white;
            //    CL.InduceNeutral();
            //}
    }
}
