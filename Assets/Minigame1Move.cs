using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Minigame1Move : MonoBehaviour
{
    // Start is called before the first frame update
   public int sceneBuildIndex;

   private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player"))
        {
            LevelManager levelManager = FindObjectOfType<LevelManager>();
            if (this.CompareTag("Minigame1") && !levelManager.interact1)
            {
                SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
            }
            else if (this.CompareTag("Minigame2") && !levelManager.interact2)
            {
                SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
            }
            else if (this.CompareTag("Minigame3") && !levelManager.interact3)
            {
                SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
            }
        }
   }
}
