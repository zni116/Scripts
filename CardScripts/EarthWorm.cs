using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthWorm : MonoBehaviour
{
    public int EarthWormAtt;
    public int EarthWormHp;
    public int EarthWormCost;
    public void Update()
    {
        EarthWormAtt = 100;
        EarthWormHp = 100;
        EarthWormCost = 1;
    }
}
