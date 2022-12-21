using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    public int maxHealth;
    public int currentHealth;
    public int gold;
    public Text health;
    public Text goldTxt;
    public bool action;
    public bool bonusAction;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        currentHealth = 100;
        gold = 100;
        action = true;
        bonusAction = true;
    }

    // Update is called once per frame
    void Update()
    {
        health.text = currentHealth.ToString() + " / 100 HP";
        goldTxt.text = gold.ToString();

    }
}
