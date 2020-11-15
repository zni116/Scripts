using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droplets : MonoBehaviour
{
    public int DropletsAtt;
    public int DropletsHp;
    public int DropletsCost;
    public void Update()
    {
        DropletsAtt = 10;
        DropletsHp = 50;
        DropletsCost = 2;
    }
}
