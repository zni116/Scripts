using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarefShark : MonoBehaviour
{
    public int BarefSharkAtt;
    public int BarefSharkHp;
    public int BarefSharkCost;
    public void Update()
    {
        BarefSharkAtt = 0;
        BarefSharkHp = 400;
        BarefSharkCost = 4;
    }
}
