using UnityEngine;

public class DonotDestroy : MonoBehaviour
{
    void Start()
    {
        //finds the gameobject with the tag"gamemusic" - which is in my audio source
        GameObject[] buttonObjs = GameObject.FindGameObjectsWithTag("GameMusic");

 
        if (buttonObjs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}

