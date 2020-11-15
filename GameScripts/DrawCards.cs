
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class DrawCards : NetworkBehaviour
{
    public PlayerManager PlayerManager;
    public GameManager GameManager;
    public UIManager UIManager;
    public int PlayCard;

    private void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void OnClick()
    {
        NetworkIdentity networkIdentity = NetworkClient.connection.identity;
        PlayerManager = networkIdentity.GetComponent<PlayerManager>();
        UIManager = GameObject.Find("UIManager").GetComponent<UIManager>();

        if (GameManager.GameState == "Draw card")
        {
            DrawCardClick();
        }
        else if (GameManager.GameState == "Play card" && UIManager.PlayerPlay == 1)
        {
            PlayCard += 1;
            UIManager.PlayerPlay += 1;
            PlayerManager.IsMyTurn = false;
            UIManager.HighlightTurn();
            CmdHighlight();
        }
        else if (GameManager.GameState == "Play card" && UIManager.PlayerPlay == 2)
        {
            PlayCard += 1;
            UIManager.PlayerPlay -= 1;
            PlayerManager.IsMyTurn = true;
            UIManager.HighlightTurn();
            CmdHighlight();
        }
        else if (GameManager.GameState == "Play card" && PlayCard == 3)
        {
            GameManager.ChangeGameState("End Turn");
        }
        else if (GameManager.GameState == "End turn")
        {
            EndTurnClick();
        }
    }

    void DrawCardClick()
    {
        PlayerManager.CmdDealCards();
        PlayerManager.CardsPlayed = 0;
    }

    void EndTurnClick()
    {
        PlayerManager.CmdExecute();
        PlayerManager.CmdGMChangeState("Draw card");
        // this is just a test 
    }
    [Command]
    public void CmdHighlight()
    {
        RpcHighlight();
        PlayCard += 1;
        UIManager.PlayerPlay += 1;
        PlayerManager.IsMyTurn = false;
        UIManager.HighlightTurn();
        // CmdHighlight();
        // This is test
    }

    [ClientRpc]
    public void RpcHighlight()
    {
        PlayCard += 1;
        UIManager.PlayerPlay -= 1;
        PlayerManager.IsMyTurn = true;
        UIManager.HighlightTurn();
        CmdHighlight();
    }
}