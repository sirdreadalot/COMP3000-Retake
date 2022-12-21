using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardSystem : MonoBehaviour
{
    [SerializeField]

    private PlayerManager playermanager;

    public void OnMouseDown()
    {
        if (gameObject.tag == "StrikeCard")
        {
            //if(playermanager.action == true)
            //{
            //    Debug.Log("Strike Used");
            //}
            //else
            //{
            //    Debug.Log("Strike Not used");
            //}
            Debug.Log("Strike Clicked");


        }


        if (gameObject.tag == "DefendCard")
        {
            Debug.Log("Defend Clicked");


        }

        if (gameObject.tag == "LightningBoltCard")
        {
            Debug.Log("Lightning Bolt Clicked");


        }
    }
}
