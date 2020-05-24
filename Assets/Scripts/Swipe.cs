using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Resources 
//https://www.youtube.com/watch?v=Dn_BUIVdAPg&t=30s

public class Swipe : MonoBehaviour
{
    private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered
    public int selectedBar = 0;

    //[SerializeField]
    //private Transform[] barList;
    private GameObject[] barList;


    void Start()
    {
        
        dragDistance = Screen.height * 15 / 100; //dragDistance is 15% height of the screen
        barList = new GameObject[transform.childCount];
        for (int i = 0; i < barList.Length; i++)
        {
            barList[i] = transform.GetChild(i).gameObject;
            Debug.Log(barList[i].name);

        }
    }

    public void ChangeColor()
    {
        try
        {
            barList[selectedBar].gameObject.GetComponent<ApplyColor>().ChangeColor();
           
        }
        catch(System.Exception e)
        {
           
            Debug.Log(e);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            if (selectedBar <= 0)
            {
                barList[selectedBar].gameObject.SetActive(false);
                selectedBar = transform.childCount - 1;
                barList[selectedBar].gameObject.SetActive(true);
            }
            else
            {
                barList[selectedBar].gameObject.SetActive(false);
                selectedBar--;
                barList[selectedBar].gameObject.SetActive(true);
            }
        }

        if (Input.touchCount == 1) // user is touching the screen with a single touch
        {
            UnityEngine.Touch touch = Input.GetTouch(0); // get the touch
            if (touch.phase == TouchPhase.Began) //check for the first touch
            {
                fp = touch.position;
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved) // update the last position based on where they moved
            {
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended) //check if the finger is removed from the screen
            {
                lp = touch.position;  //last touch position. Ommitted if you use list

                //Check if drag distance is greater than 20% of the screen height
                if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
                {//It's a drag
                 //check if the drag is vertical or horizontal
                    if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))
                    {   //If the horizontal movement is greater than the vertical movement...
                        int previousSelectedBar = selectedBar;

                        if ((lp.x > fp.x))  //If the movement was to the right)
                        {   //Right swipe

                           
                            
                            if(selectedBar == 0)
                            {
                                barList[selectedBar].gameObject.SetActive(false);
                                selectedBar = barList.Length - 1;
                                barList[selectedBar].gameObject.SetActive(true);
                            }
                            else
                            {
                                barList[selectedBar].gameObject.SetActive(false);
                                selectedBar--;
                                barList[selectedBar].gameObject.SetActive(true);
                            }
                        }
                        else
                        {   //Left swipe
                           
                            if (selectedBar == barList.Length - 1)
                            {
                                barList[selectedBar].gameObject.SetActive(false);
                                selectedBar = 0;
                                barList[selectedBar].gameObject.SetActive(true);
                            }
                            else
                            {
                                barList[selectedBar].gameObject.SetActive(false);
                                selectedBar++;
                                barList[selectedBar].gameObject.SetActive(true);
                            }
                        }
                        //if(previousSelectedBar != selectedBar)
                        //{
                        //    SelectBar();
                        //}
                    }
                    else
                    {   //the vertical movement is greater than the horizontal movement
                        if (lp.y > fp.y)  //If the movement was up
                        {   //Up swipe
                            Debug.Log("Up Swipe");
                        }
                        else
                        {   //Down swipe
                            Debug.Log("Down Swipe");
                        }
                    }
                }
                else
                {   //It's a tap as the drag distance is less than 20% of the screen height
                    Debug.Log("Tap");
                }
            }
        }
    }

}
