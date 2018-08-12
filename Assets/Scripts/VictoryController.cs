using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryController : MonoBehaviour {
    private DataController roundData;
    private DownloadController downloadController;
    public GameObject roundPlace;
    public GameObject sizePlace;
    public GameObject formatPlace;
    public GameObject dataControllerPrefab;
    private float b;
    private float timer;
    public AudioClip soundLose;
    // Use this for initialization
    void Start()
    {
        AudioSource.PlayClipAtPoint(soundLose, Camera.main.transform.position);
        downloadController = FindObjectOfType<DownloadController>();
        timer = DownloadController.timer;
        roundPlace.GetComponent<Text>().text = (DataController.roundNumber + 1).ToString();

        b = FreeSpaceController.bBis;
        if (b >= 1048576)

        { 
            float actualSize = ((b - 1048576) / 1048576) + 1;
            sizePlace.GetComponent<Text>().text = ((Mathf.Round(actualSize * 100)) / 100.0).ToString();
            formatPlace.GetComponent<Text>().text = "GB";
        }
        if (b >= 1024 && b < 1048576)
        {
            float actualSize = ((b - 1024) / 1024) + 1;
            sizePlace.GetComponent<Text>().text = ((Mathf.Round(actualSize * 100)) / 100.0).ToString();
            formatPlace.GetComponent<Text>().text = "MB";
        }
        if (b < 1024 && b > 0)
        {
            float actualSize = b;
            sizePlace.GetComponent<Text>().text = ((Mathf.Round(actualSize * 100)) / 100.0).ToString();
            formatPlace.GetComponent<Text>().text = "KB";
        }
        if (b <= 0)
        {
            float actualSize = b;
            sizePlace.GetComponent<Text>().text = "0";
            formatPlace.GetComponent<Text>().text = "KB";
        }
    }

    // Update is called once per frame
    void Update()
    {



    }
}
