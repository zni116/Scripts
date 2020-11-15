using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEgg : MonoBehaviour
{
    public int WaterEggAtt;
    public int WaterEggHp;
    public int WaterEggCost;
    public void Update()
    {
        WaterEggAtt = 0;
        WaterEggHp = 0;
        WaterEggCost = 1;
    }
}

