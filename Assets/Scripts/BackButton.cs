using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour {
    private GameController gameController;
    public AudioClip clickSound;
	// Use this for initialization
	void Start () {
        gameController = FindObjectOfType<GameController>();
	}
	
	// Update is called once per frame
	public void BackToPreviousFolder () {
        AudioSource.PlayClipAtPoint(clickSound, Camera.main.transform.position);
        if (gameController.branchNumber != 0)
        {
            gameController.PreviousFolder();
            gameController.NewSetOfFolders();
        }

    }
}
