using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardSystem : MonoBehaviour
{
    [SerializeField]
    public GameObject popUp;
    private string Tag;
    public Text pop;

    public void OnMouseDown()
    {
        if(gameObject.tag == "StrikeCard")
        {
            // Show popup
            GameObject.Find("popUp").transform.localScale = new Vector3(1, 1, 1);
            GameObject.Find("popUp").GetComponent<Text>();
            pop.text = "Your hand is full!";

        }
        else
        {
            // Show popup
            GameObject.Find("popUp").transform.localScale = new Vector3(1, 1, 1);
            string pop = GameObject.Find("popUp").GetComponent<Text>().ToString();
            pop = "Not strike clicked";
        }
    }
}
