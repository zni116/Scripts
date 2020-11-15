using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class GameManager : NetworkBehaviour
{
    public UIManager UIManager;
    public PlayerSlot1 PlayerSlot1;
    public string GameState = "Draw card";
    public int PlayerBP = 0;
    public int OpponentBP = 0;
    public int PlayerVariables = 0;
    public int OpponentVariables = 0;

    public int ReadyClicks = 0;

    void Start()
    {
        UIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        UIManager.UpdatePlayerText();
        UIManager.UpdateButtonText(GameState);
        PlayerSlot1 = GameObject.Find("PlayerSlot1").GetComponent<PlayerSlot1>();
    }

    public void ChangeGameState(string stateRequest)
    {
        if (stateRequest == "Draw card")
        {
            PlayerSlot1.ButtonText1 = 1;
            ReadyClicks = 0;
            GameState = "Draw card";
        }
        else if (stateRequest == "Play card")
        {
            PlayerSlot1.ButtonText1 = 2;
            if (ReadyClicks == 1)
            {
                GameState = "Play card";
                UIManager.HighlightTurn();
            }
            if (isClientOnly)
            {
                PlayerManager pm = NetworkClient.connection.identity.GetComponent<PlayerManager>();
                pm.IsMyTurn = true;
                UIManager.PlayerPlay = 1;
            }
            else
            {
                PlayerManager pm = NetworkClient.connection.identity.GetComponent<PlayerManager>();
                pm.IsMyTurn = false;
                UIManager.PlayerPlay = 2;
            }
        }
        else if (stateRequest == "End turn")
        {
            PlayerSlot1.ButtonText1 = 3;
            GameState = "End turn";
        }
        UIManager.UpdateButtonText(GameState);
    }

    public void ChangeReadyClicks()
    {
        ReadyClicks++;
    }

    public void CardPlayed()
    {
        UIManager.HighlightTurn();
    }

    public void ChangeBP(int playerBP, int opponentBP, bool hasAuthority)
    {
        if (hasAuthority)
        {
            PlayerBP += playerBP;
            OpponentBP -= opponentBP;
        }
        else
        {
            PlayerBP -= opponentBP;
            OpponentBP += playerBP;
        }
        UIManager.UpdatePlayerText();
    }

    public void ChangeVariables(int variables, bool hasAuthority)
    {
        if (hasAuthority)
        {
            PlayerVariables += variables;
        }
        else
        {
            OpponentVariables += variables;
        }
        UIManager.UpdatePlayerText();
    }
}
