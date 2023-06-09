using UnityEngine;
using TMPro;

public class SkinPanel : MonoBehaviour
{
    public GameObject skinToEquip;
    public TextMeshProUGUI buttonText;
    public enum SkinsIDs { defaultSkin, goblin, knight, chef, golden, cowboy, dr, classy, wizard, zombie, pug, cow, bald, ninja, elf}
    public SkinsIDs skinID;
    public int skinCost = 1;
    private bool isSkinUnlocked;

    private void Awake()
    {
        if (PlayerPrefs.GetInt(skinID.ToString()) == 1)
        {
            isSkinUnlocked = true;
            buttonText.text = "Equip Skin";
        }
        else
        {
            buttonText.text = "Buy for " + skinCost;
        }
    }

    public void EquipSkin()
    {
        SkinLoader.skinToLoad = skinToEquip;
    }

    public void OnSkinButtonPress()
    {
        if (isSkinUnlocked)
        {
            EquipSkin();
        }
        else
        {
            // try to buy skin
            if (FindObjectOfType<Score>().TryRemoveScore(skinCost))
            {
                isSkinUnlocked = true;
                PlayerPrefs.SetInt(skinID.ToString(), 1);
                buttonText.text = "Equip Skin";
            }
        }
    }
}