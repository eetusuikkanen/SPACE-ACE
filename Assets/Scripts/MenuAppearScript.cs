using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class MenuAppearScript : MonoBehaviour
{
    public Canvas CanvasObject; // Assign in inspector
    public EventSystem EventSystem; // Assign in inspector
    public StandaloneInputModule StandaloneInputModule;
    public QuitGame QuitGame;
    public ChangeScene ChangeScene;


    void Start()
    {
        CanvasObject = GetComponent<Canvas>();
        //QuitGame = GetComponent<QuitGame>();
        //ChangeScene = GetComponent<ChangeScene>();
        StandaloneInputModule = GetComponent<StandaloneInputModule>();
        EventSystem = GetComponent<EventSystem>();

    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            CanvasObject.enabled = !CanvasObject.enabled;
            Time.timeScale = CanvasObject.enabled ? 0 : 1;
            StandaloneInputModule.enabled = !StandaloneInputModule.enabled;
            EventSystem.enabled = !EventSystem.enabled;
            //QuitGame.enabled = !QuitGame.enabled;
            //ChangeScene.enabled = !ChangeScene.enabled;
           
        }
    }
}


