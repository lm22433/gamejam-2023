using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Texture2D levelComplete;
    public Texture2D levelNotComplete;
    public LogicOutput input;
    
    public void Update()
    {
        CheckWin();
    }

    void CheckWin()
    {
        if (input.GetOutput())
        {
            spriteRenderer.sprite = Sprite.Create(levelComplete, new Rect(0, 0, levelComplete.width, levelComplete.height), Vector2.one * 0.5f);
            Invoke(nameof(Win), 3f);
        }
        else
        {
            spriteRenderer.sprite = Sprite.Create(levelNotComplete, new Rect(0, 0, levelNotComplete.width, levelNotComplete.height), Vector2.one * 0.5f);
        }
    }

    void Win()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
