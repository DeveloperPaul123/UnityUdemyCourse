using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null;

    private void Awake()
    {
        // only keep a single instance. 
        if (instance != null)
        {
            // instance exists so kill this object.
            Destroy(gameObject);
        }
        else
        {
            // claim the object. 
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
