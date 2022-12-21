using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawCards : MonoBehaviour
{
    [SerializeField]
    public int enemyDmg;
    public GameObject strikeCard;
    public GameObject defendCard;
    public GameObject lightningBoltCard;
    public GameObject playerHand;
    public GameObject popUp;
    public Text pop;
    public Text enemyDmgTxt;
    private PlayerManager playermanager;
    public List<GameObject> deckList = new List<GameObject>();
    public List<GameObject> hand = new List<GameObject>();
    

    void Start()
    {


        // Create the enemies damage 
       // enemyDmg = Random.Range(1, 5);
       // enemyDmgTxt.text = "The enemy intends todo: " + enemyDmg.ToString() + " damage!";

        //These for loops create the player's starting decklist, adding five strikes and defends as well as two lightning bolts.
        for (var i = 0; i < 4; i++) 
        {
            deckList.Add(strikeCard);
        }

        for (var i = 0; i < 4; i++)
        {
            deckList.Add(defendCard);
        }

        for (var i = 0; i < 2; i++)
        {
            deckList.Add(lightningBoltCard);
        }

        // A loop to draw the player a random hand of five cards from thier deck list.
        for (var i = 0; i < 5; i++)
        {
            if (hand.Count == 5)
            {
                // Show popup
                GameObject.Find("popUp").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("popUp").GetComponent<Text>();
                pop.text = "Your hand is full!";
            }
            else
            {
                int ranNum = Random.Range(0, deckList.Count);
                GameObject playerCard = Instantiate(deckList[ranNum], new Vector3(0, 0, 0), Quaternion.identity);
                hand.Add(deckList[ranNum]);
                deckList.Remove(deckList[ranNum]);
                // Make sure that the cards that are spawned are visible by putting them in the player's hand.
                playerCard.transform.SetParent(playerHand.transform, false);
            }
        }
    }



    public void OnClick()
    {
        // For the end turn button, so you throw away your old cards and redraw a new five.

        enemyDmgTxt.text = "The enemy intends todo: " + enemyDmg.ToString() + " damage!";

        playermanager.currentHealth = playermanager.currentHealth - enemyDmg;

        playermanager.health.text = playermanager.currentHealth.ToString() + "/100";

        // A loop to draw the player a random hand of five cards from thier deck list.
        for (var i = 0; i < 5; i++)
        {
            if (hand.Count == 5)
            {
                // Show popup
                GameObject.Find("popUp").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("popUp").GetComponent<Text>();
                pop.text = "Your hand is full!";
            }
            else
            {
                int ranNum = Random.Range(0, deckList.Count);
                GameObject playerCard = Instantiate(deckList[ranNum], new Vector3(0, 0, 0), Quaternion.identity);
                hand.Add(deckList[ranNum]);
                deckList.Remove(deckList[ranNum]);
                // Make sure that the cards that are spawned are visible by putting them in the player's hand.
                playerCard.transform.SetParent(playerHand.transform, false);
            }
        }

        // Randomize the enemies damage at the end of the turn, ready for the next.
        enemyDmg = Random.Range(1, 5);

    }   
}
