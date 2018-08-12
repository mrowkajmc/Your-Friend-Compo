using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreeSpaceController : MonoBehaviour {
    public DataController dataController;
    public RoundData roundData;
    public int roundNumber;
    public float gb;
    public float mb;
    public float b;
    public static float bBis;
    public float actualSize;
    public float actualSizeStart;
    public bool isGb;
    public bool isMb;
    public bool isB;
    public GameObject sizePlace;
    public GameObject formatPlace;
    public GameObject portraitPlace;
    public string sizeText;
    public string formatText;
    public Sprite portrait;
	// Use this for initialization
	void Start () {
        dataController = FindObjectOfType<DataController>();
        roundNumber = DataController.roundNumber;
        roundData = dataController.GetAllRoundData(roundNumber);
        portraitPlace.GetComponent<Image>().sprite = roundData.playerSprite;
        sizePlace.GetComponent<Text>().text = roundData.freeSpace.ToString();
        if (roundData.gb ==true)
        {
            formatPlace.GetComponent<Text>().text = "GB";
            b = (roundData.freeSpace) * 1048576;
        }
        if (roundData.mb == true)
        {
            formatPlace.GetComponent<Text>().text = "MB";
            b = (roundData.freeSpace) * 1024;
        }
        if (roundData.b == true)
        {
            formatPlace.GetComponent<Text>().text = "KB";
            b = (roundData.freeSpace);
        }
        actualSizeStart = b;
        Invoke("ComponentsSet", 0.3f);
        // obliczy bajty zey byly potem do updatow
    }
	
    public void ComponentsSet()
    {
        Invoke("ComponentsSet", 0.3f);
        if (b >= 1048576)
        {
            sizePlace.GetComponent<Text>().text = ((Mathf.Round(actualSize * 100)) / 100.0).ToString();
            formatPlace.GetComponent<Text>().text = "GB";
        }
        if (b >= 1024 && b < 1048576)
        {
            sizePlace.GetComponent<Text>().text = ((Mathf.Round(actualSize * 100)) / 100.0).ToString();
            formatPlace.GetComponent<Text>().text = "MB";
        }
        if (b < 1024 && b > 0)
        {
            sizePlace.GetComponent<Text>().text = ((Mathf.Round(actualSize * 100)) / 100.0).ToString();
            formatPlace.GetComponent<Text>().text = "KB";
        }
        if (b <= 0)
        {
            sizePlace.GetComponent<Text>().text = "0";
            formatPlace.GetComponent<Text>().text = "KB";
        }
    }
	// Update is called once per frame
	void Update () {
        if (b >= 1048576)
        {
            actualSize = ((b - 1048576) / 1048576) + 1;
        }
        if (b >= 1024 && b < 1048576)
        {
            actualSize = ((b - 1024) / 1024) + 1;
        }
        if (b < 1024 && b > 0)
        {
            actualSize = b;
        }
        if (b <= 0)
        {
            actualSize = b;
        }
        bBis = b;
    }
}
