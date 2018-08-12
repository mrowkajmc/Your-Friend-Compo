using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseController : MonoBehaviour {
    private DataController roundData;
    public GameObject roundPlace;
    public GameObject dataControllerPrefab;
    public AudioClip soundLose;
    // Use this for initialization
    void Start () {
        AudioSource.PlayClipAtPoint(soundLose, Camera.main.transform.position);
        roundData = FindObjectOfType<DataController>();
        Destroy(roundData.gameObject);
        Instantiate(dataControllerPrefab, transform.position, transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
        roundPlace.GetComponent<Text>().text = (DataController.roundNumber+1).ToString();

    }
}
