using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public float delayTime = 5f;

    int notes = 0;

    private void OnTriggerEnter2D(Collider2D other){
        if (notes == 3){
            Invoke("btn_change_scene", delayTime);
            
        }
        
    }

    // Start is called before the first frame update
    public void btn_change_scene(string scene_name){
        
        Time.timeScale = 1;

        SceneManager.LoadScene(scene_name); 
}
    
}
