using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/New Item")]

public class ScriptableItem : ScriptableObject
{
    public string itemName;
    public string itemPrize;
    public Sprite itemSprite;
    public float itemId;
}
