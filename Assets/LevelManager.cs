using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private static LevelManager _instance;

    public bool interact1 = false;
    public bool interact2 = false;
    public bool interact3 = false;



    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (interact1 && interact2 && interact3)
        {
            SceneManager.LoadScene(5);
            Destroy(gameObject);
        }
    }
}
