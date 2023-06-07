using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName = "New Skin", menuName = "Create New Skin")]
public class SSkinInfo : ScriptableObject
{
    public enum SkinIDs { knight, cowboy, wizard, goblin }
    public int skinID;
    public GameObject skinModel;
    public int skinPrice;
}
