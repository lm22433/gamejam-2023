using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Texture2D levelComplete;
    public Texture2D levelNotComplete;
    public LogicOutput input;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateSprite();
    }

    public void Update()
    {
        UpdateSprite();
    }

    void UpdateSprite()
    {
        spriteRenderer.sprite = input.GetOutput() ?
            Sprite.Create(levelComplete, new Rect(0, 0, levelComplete.width, levelComplete.height), Vector2.one * 0.5f) :
            Sprite.Create(levelNotComplete, new Rect(0, 0, levelNotComplete.width, levelNotComplete.height), Vector2.one * 0.5f);
    }
}
