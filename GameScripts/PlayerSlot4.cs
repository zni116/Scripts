using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class PlayerSlot4 : MonoBehaviour
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
    public GameObject playerSlot4;
    public PlayerSlot1 playerSlot1;
    public GameObject enemySlot1;
    public GameObject enemySlot2;
    public GameObject enemySlot3;
    public GameObject enemySlot4;
    public GameObject enemySlot5;
    public UIManager UIManager;
    Color HighlightColor = new Color32(255, 255, 102, 255);
    Color blueColor = new Color32(17, 216, 238, 255);
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
        playerSlot1 = GameObject.Find("PlayerSlot1").GetComponent<PlayerSlot1>();
        playerSlot4 = GameObject.Find("PlayerSlot4");
        enemySlot1 = GameObject.Find("EnemySlot1");
        enemySlot2 = GameObject.Find("EnemySlot2");
        enemySlot3 = GameObject.Find("EnemySlot3");
        enemySlot4 = GameObject.Find("EnemySlot4");
        enemySlot5 = GameObject.Find("EnemySlot5");
    }
    void Update()
    {
        playerSlot1.battle(playerSlot4, KeyCode.V);
    }
}