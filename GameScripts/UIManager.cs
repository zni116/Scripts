
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class UIManager : NetworkBehaviour
{
    public GameObject PlayerSlot1;
    public GameObject PlayerSlot2;
    public GameObject PlayerSlot3;
    public GameObject PlayerSlot4;
    public GameObject PlayerSlot5;
    public GameObject EnemySlot1;
    public GameObject EnemySlot2;
    public GameObject EnemySlot3;
    public GameObject EnemySlot4;
    public GameObject EnemySlot5;
    public PlayerManager PlayerManager;
    public GameManager GameManager;
    public GameObject Button;
    public GameObject PlayerText;
    public GameObject OpponentText;
    public int PlayerPlay;

    Color blueColor = new Color32(17, 216, 238, 255);

    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        PlayerSlot1 = GameObject.Find("PlayerSlot1");
        PlayerSlot2 = GameObject.Find("PlayerSlot2");
        PlayerSlot3 = GameObject.Find("PlayerSlot3");
        PlayerSlot4 = GameObject.Find("PlayerSlot4");
        PlayerSlot5 = GameObject.Find("PlayerSlot5");
        EnemySlot1 = GameObject.Find("EnemySlot1");
        EnemySlot2 = GameObject.Find("EnemySlot2");
        EnemySlot3 = GameObject.Find("EnemySlot3");
        EnemySlot4 = GameObject.Find("EnemySlot4");
        EnemySlot5 = GameObject.Find("EnemySlot5");
    }

    public void UpdatePlayerText()
    {
        PlayerText.GetComponent<Text>().text = "Player BP: " + GameManager.PlayerBP + "\nPlayer Variables: " + GameManager.PlayerVariables;
        OpponentText.GetComponent<Text>().text = "Opponent BP: " + GameManager.OpponentBP + "\nOpponent Variables: " + GameManager.OpponentVariables;
    }

    public void UpdateButtonText(string gameState)
    {
        Button = GameObject.Find("Button");
        Button.GetComponentInChildren<Text>().text = gameState;
    }
    public void Clear()
    {
        PlayerSlot1.GetComponent<Outline>().effectColor = blueColor;
        PlayerSlot2.GetComponent<Outline>().effectColor = blueColor;
        PlayerSlot3.GetComponent<Outline>().effectColor = blueColor;
        PlayerSlot4.GetComponent<Outline>().effectColor = blueColor;
        PlayerSlot5.GetComponent<Outline>().effectColor = blueColor;
        EnemySlot1.GetComponent<Outline>().effectColor = blueColor;
        EnemySlot2.GetComponent<Outline>().effectColor = blueColor;
        EnemySlot3.GetComponent<Outline>().effectColor = blueColor;
        EnemySlot4.GetComponent<Outline>().effectColor = blueColor;
        EnemySlot5.GetComponent<Outline>().effectColor = blueColor;
    }

    public void HighlightTurn()
    {
        if (PlayerPlay == 1)
        {
            if (PlayerSlot1.transform.childCount == 0)
            {
                Clear();
                PlayerSlot1.GetComponent<Outline>().effectColor = Color.magenta;
                return;

            }
            if (PlayerSlot2.transform.childCount == 0)
            {
                Clear();
                PlayerSlot2.GetComponent<Outline>().effectColor = Color.magenta;
                return;
            }
            if (PlayerSlot3.transform.childCount == 0)
            {
                Clear();
                PlayerSlot3.GetComponent<Outline>().effectColor = Color.magenta;
                return;
            }
            if (PlayerSlot4.transform.childCount == 0)
            {
                Clear();
                PlayerSlot4.GetComponent<Outline>().effectColor = Color.magenta;
                return;
            }
            if (PlayerSlot5.transform.childCount == 0)
            {
                Clear();
                PlayerSlot5.GetComponent<Outline>().effectColor = Color.magenta;
                return;
            }
        }
        else if (PlayerPlay >= 2)
        {
            if (EnemySlot1.transform.childCount == 0)
            {
                Clear();
                EnemySlot1.GetComponent<Outline>().effectColor = Color.magenta;
                return;
            }
            if (EnemySlot2.transform.childCount == 0)
            {
                Clear();
                EnemySlot2.GetComponent<Outline>().effectColor = Color.magenta;
                return;
            }
            if (EnemySlot3.transform.childCount == 0)
            {
                Clear();
                EnemySlot3.GetComponent<Outline>().effectColor = Color.magenta;
                return;
            }
            if (EnemySlot4.transform.childCount == 0)
            {
                Clear();
                EnemySlot4.GetComponent<Outline>().effectColor = Color.magenta;
                return;
            }
            if (EnemySlot5.transform.childCount == 0)
            {
                Clear();
                EnemySlot5.GetComponent<Outline>().effectColor = Color.magenta;
                return;
            }
        }
        else
        {
            Clear();
        }
    }
}

