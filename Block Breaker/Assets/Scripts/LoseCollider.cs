using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

    public LevelManager levelManager;
    /**
     * Called when a trigger happens. 
     **/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        levelManager.LoadLevel("Win");
    }
}
