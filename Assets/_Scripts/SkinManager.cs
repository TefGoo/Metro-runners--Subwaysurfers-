using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public static GameObject equippedSkin;

    public void EquipSkin(SSkinInfo skinInfo)
    {
        equippedSkin = skinInfo.skinModel;
    }
}
