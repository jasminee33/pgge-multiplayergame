using UnityEngine;

public class DonotDestroy : MonoBehaviour
{
    void Start()
    {
        //finds the gameobject with the tag "gamemusic" - which is in my audio source
        GameObject[] buttonObjs = GameObject.FindGameObjectsWithTag("GameMusic");

        //allow the sound to continue even when the scene changes
        DontDestroyOnLoad(this.gameObject);
    }
}

