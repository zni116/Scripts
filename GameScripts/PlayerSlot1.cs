using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class PlayerSlot1 : MonoBehaviour
{
    public Snorboar SnorboarAbilities;
    public WaterEgg WaterEggAbilities;
    public BarefShark BarefSharkAbilities;
    public Turkin TurkinAbilities;
    public Droplets DropletsAbilities;
    public AllSeeingSalamander AllSeeingSalamanderAbilities;
    public AncientSpirit AncientSpiritAbilities;
    public Snakon SnakonAbilities;
    public EarthWorm EarthWormAbilities;
    public bool Slot1 = false;
    public bool Slot11 = false;
    public int ButtonText1 = 1;
    public GameObject playerYard;
    public GameObject playerSlot1;
    public GameObject playerSlot2;
    public GameObject playerSlot3;
    public GameObject playerSlot4;
    public GameObject playerSlot5;
    public GameObject enemySlot1;
    public GameObject enemySlot2;
    public GameObject enemySlot3;
    public GameObject enemySlot4;
    public GameObject enemySlot5;
    public UIManager UIManager;
    Color HighlightColor = new Color32(255, 255, 102, 255);
    Color blueColor = new Color32(17, 216, 238, 255);
    public int att;
    public int hp;
    private void Start()
    {
        SnorboarAbilities = GameObject.Find("Snorboar").GetComponent<Snorboar>();
        WaterEggAbilities = GameObject.Find("WaterEgg").GetComponent<WaterEgg>();
        BarefSharkAbilities = GameObject.Find("BarefShark").GetComponent<BarefShark>();
        TurkinAbilities = GameObject.Find("Turkin").GetComponent<Turkin>();
        DropletsAbilities = GameObject.Find("Droplets").GetComponent<Droplets>();
        AllSeeingSalamanderAbilities = GameObject.Find("AllSeeingSalamander").GetComponent<AllSeeingSalamander>();
        AncientSpiritAbilities = GameObject.Find("AncientSpirit").GetComponent<AncientSpirit>();
        SnakonAbilities = GameObject.Find("Snakon").GetComponent<Snakon>();
        EarthWormAbilities = GameObject.Find("EarthWorm").GetComponent<EarthWorm>();
        UIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        playerYard = GameObject.Find("PlayerYard");
        playerSlot1 = GameObject.Find("PlayerSlot1");
        playerSlot2 = GameObject.Find("PlayerSlot2");
        playerSlot3 = GameObject.Find("PlayerSlot3");
        playerSlot4 = GameObject.Find("PlayerSlot4");
        playerSlot5 = GameObject.Find("PlayerSlot5");
        enemySlot1 = GameObject.Find("EnemySlot1");
        enemySlot2 = GameObject.Find("EnemySlot2");
        enemySlot3 = GameObject.Find("EnemySlot3");
        enemySlot4 = GameObject.Find("EnemySlot4");
        enemySlot5 = GameObject.Find("EnemySlot5");
    }
    public void battle(GameObject playerSlot1, KeyCode key)
    {
        if (Input.GetKeyDown(key) == true)
        {
            if (Slot1 == false)
            {
                playerSlot1.GetComponent<Outline>().effectColor = HighlightColor;
                Slot1 = true;
                Att(playerSlot1);
            }
            else if (Slot1 == true && playerSlot1.GetComponent<Outline>().effectColor == blueColor)
            {
                return;
            }
            else
            {
                playerSlot1.GetComponent<Outline>().effectColor = blueColor;
                Slot1 = false;
            }
        }
    }
    public void destroy(GameObject enemySlot)
    {
        enemySlot1.GetComponent<Outline>().effectColor = blueColor;
        enemySlot2.GetComponent<Outline>().effectColor = blueColor;
        enemySlot3.GetComponent<Outline>().effectColor = blueColor;
        enemySlot4.GetComponent<Outline>().effectColor = blueColor;
        enemySlot5.GetComponent<Outline>().effectColor = blueColor;
        if (att >= hp)
        {
            foreach (Transform child in enemySlot.transform)
            {
                child.SetParent(playerYard.transform, false);
            }
        }
        Slot11 = false;
    }
    public void Update()
    {
        battle(playerSlot1, KeyCode.Z);

        if (Input.GetKeyDown(KeyCode.Q) == true)
        {
            if (ButtonText1 == 3)
            {
                if (Slot11 == false)
                {
                    enemySlot1.GetComponent<Outline>().effectColor = HighlightColor;
                    Slot11 = true;
                    Hp(enemySlot1);
                    destroy(enemySlot1);
                }
                else if (Slot11 == true && enemySlot1.GetComponent<Outline>().effectColor == blueColor)
                {
                    return;
                }
                else
                {
                    enemySlot1.GetComponent<Outline>().effectColor = blueColor;
                    Slot11 = false;
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.W) == true)
        {
            if (ButtonText1 == 3)
            {
                if (Slot11 == false)
                {
                    enemySlot2.GetComponent<Outline>().effectColor = HighlightColor;
                    Slot11 = true;
                    Hp(enemySlot2);
                    destroy(enemySlot2);
                }
                else if (Slot11 == true && enemySlot2.GetComponent<Outline>().effectColor == blueColor)
                {
                    return;
                }
                else
                {
                    enemySlot2.GetComponent<Outline>().effectColor = blueColor;
                    Slot11 = false;
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.E) == true)
        {
            if (ButtonText1 == 3)
            {
                if (Slot11 == false)
                {
                    enemySlot3.GetComponent<Outline>().effectColor = HighlightColor;
                    Slot11 = true;
                    Hp(enemySlot3);
                    destroy(enemySlot3);
                }
                else if (Slot11 == true && enemySlot3.GetComponent<Outline>().effectColor == blueColor)
                {
                    return;
                }
                else
                {
                    enemySlot3.GetComponent<Outline>().effectColor = blueColor;
                    Slot11 = false;
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.R) == true)
        {
            if (ButtonText1 == 3)
            {
                if (Slot11 == false)
                {
                    enemySlot4.GetComponent<Outline>().effectColor = HighlightColor;
                    Slot11 = true;
                    Hp(enemySlot4);
                    destroy(enemySlot4);
                }
                else if (Slot11 == true && enemySlot4.GetComponent<Outline>().effectColor == blueColor)
                {
                    return;
                }
                else
                {
                    enemySlot4.GetComponent<Outline>().effectColor = blueColor;
                    Slot11 = false;
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.T) == true)
        {
            if (ButtonText1 == 3)
            {
                if (Slot11 == false)
                {
                    enemySlot5.GetComponent<Outline>().effectColor = HighlightColor;
                    Slot11 = true;
                    Hp(enemySlot5);
                    destroy(enemySlot5);
                }
                else if (Slot11 == true && enemySlot5.GetComponent<Outline>().effectColor == blueColor)
                {
                    return;
                }
                else
                {
                    enemySlot5.GetComponent<Outline>().effectColor = blueColor;
                    Slot11 = false;
                }
            }
        }
    }
    public void Att(GameObject playerSlot)
    {
        foreach (Transform child in playerSlot.transform)
        {
            if (child.name == "Snorboar(Clone)")
            {
                att = SnorboarAbilities.SnorboarAtt;
            }
            else if (child.name == "WaterEgg(Clone)")
            {
                att = WaterEggAbilities.WaterEggAtt;
            }
            else if (child.name == "BarefShark(Clone)")
            {
                att = BarefSharkAbilities.BarefSharkAtt;
            }
            else if (child.name == "Turkin(Clone)")
            {
                att = TurkinAbilities.TurkinAtt;
            }
            else if (child.name == "Droplets(Clone)")
            {
                att = DropletsAbilities.DropletsAtt;
            }
            else if (child.name == "AllSeeingSalamander(Clone)")
            {
                att = AllSeeingSalamanderAbilities.AllSeeingSalamanderAtt;
            }
            else if (child.name == "EarthWorm(Clone)")
            {
                att = EarthWormAbilities.EarthWormAtt;
            }
            else if (child.name == "AncientSpirit(Clone)")
            {
                att = AncientSpiritAbilities.AncientSpiritAtt;
            }
            else
            {
                att = SnakonAbilities.SnakonAtt;
            }
        }
    }
    public void Hp(GameObject playerSlot)
    {
        foreach (Transform child in playerSlot.transform)
        {
            if (child.name == "Snorboar(Clone)")
            {
                hp = SnorboarAbilities.SnorboarHp;
            }
            else if (child.name == "WaterEgg(Clone)")
            {
                hp = WaterEggAbilities.WaterEggHp;
            }
            else if (child.name == "BarefShark(Clone)")
            {
                hp = BarefSharkAbilities.BarefSharkHp;
            }
            else if (child.name == "Turkin(Clone)")
            {
                hp = TurkinAbilities.TurkinHp;
            }
            else if (child.name == "Droplets(Clone)")
            {
                hp = DropletsAbilities.DropletsHp;
            }
            else if (child.name == "AllSeeingSalamander(Clone)")
            {
                hp = AllSeeingSalamanderAbilities.AllSeeingSalamanderHp;
            }
            else if (child.name == "EarthWorm(Clone)")
            {
                hp = EarthWormAbilities.EarthWormHp;
            }
            else if (child.name == "AncientSpirit(Clone)")
            {
                hp = AncientSpiritAbilities.AncientSpiritHp;
            }
            else
            {
                hp = SnakonAbilities.SnakonHp;
            }
        }
    }
}