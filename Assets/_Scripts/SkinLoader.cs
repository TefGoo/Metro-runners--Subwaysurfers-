using UnityEngine;

public class SkinLoader : MonoBehaviour
{
    public GameObject defaultSkin;
    public static GameObject skinToLoad;

    private GameObject loadedSkin;

    private void Awake()
    {
        if (skinToLoad != null)
        {
            defaultSkin.SetActive(false);
            loadedSkin = Instantiate(skinToLoad, transform);
        }
        else
        {
            loadedSkin = Instantiate(defaultSkin, transform);
        }
    }

    private void OnDestroy()
    {
        if (loadedSkin != null && loadedSkin != defaultSkin)
        {
            Destroy(loadedSkin);
            defaultSkin.SetActive(true);
        }
    }
}
