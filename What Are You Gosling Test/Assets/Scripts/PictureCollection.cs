using UnityEngine;

[CreateAssetMenu(fileName = "Collection", menuName = "Gameplay/New Collection")]
public class PictureCollection : ScriptableObject
{
    public GoslingCollection GoslingCollection;
}

[System.Serializable]
public sealed class GoslingCollection
{
    [field: SerializeField] public int id { get; private set; }
    [field: SerializeField] public string PictureName { get; private set; }
    [field: SerializeField] public Sprite Image { get; private set; }
}