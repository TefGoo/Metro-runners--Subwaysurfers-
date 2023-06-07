using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkinInShop : MonoBehaviour
{
    public SSkinInfo skinInfo;
    public GameObject skinModel;
    public bool isSkinUnlocked;
    public TextMeshProUGUI buttonText;

    private void Awake()
    {
        skinModel = Instantiate(skinInfo.skinModel, transform);
        skinModel.transform.localPosition = Vector3.zero;
        skinModel.transform.localRotation = Quaternion.identity;
        IsSkinUnlocked();
    }

    private void IsSkinUnlocked()
    {
        if (PlayerPrefs.GetInt(skinInfo.skinID.ToString()) == 1)
        {
            isSkinUnlocked = true;
            buttonText.text = "Equip";
        }
    }

    public void OnButtonpress()
    {
        if (isSkinUnlocked)
        {
            // Equip
            FindObjectOfType<SkinManager>().EquipSkin(skinInfo);
        }
        else
        {
            // Buy
            if (FindObjectOfType<Score>().TryRemoveScore(skinInfo.skinPrice))
            {
                PlayerPrefs.SetInt(skinInfo.skinID.ToString(), 1);
                IsSkinUnlocked();
            }
        }
    }
}
