using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Minigame1Move : MonoBehaviour
{
    // Start is called before the first frame update
   public int sceneBuildIndex;

   private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Jarvis_Normal_1"){
            
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
   }
}
