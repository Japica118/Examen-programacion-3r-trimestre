using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    
    public ScriptableItem[] guns;
    public ScriptableItem[] armors;
    public Text[] gunsNames;
    public Image[] gunsSprites;
    public Text[] gunsPrize;
    public Text[] armorsNames;
    public Image[] armorsSprites;
    public Text[] armorsPrize;

    void Awake()
    {
        instance = this;
    }

    public void AddItem(ScriptableItem item)
    {
        for (int i = 0; i < guns.Length; i++)
        {
            if(item.itemId == 0)
            {
                if(guns[i] == null)
            {
                guns [i] = item;

                gunsNames[i].text = item.itemName;

                gunsSprites[i].sprite = item.itemSprite;

                gunsPrize[i].text = item.itemPrize;

                return;
            }

            }

            if(item.itemId == 1)
            {
                if(armors[i] == null)
            {
                armors [i] = item;

                armorsNames[i].text = item.itemName;

                armorsSprites[i].sprite = item.itemSprite;

                armorsPrize[i].text = item.itemPrize;

                return;
            }

            }
           
        }
    }
}
