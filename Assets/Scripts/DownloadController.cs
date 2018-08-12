using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownloadController : MonoBehaviour {
    public DataController dataController;
    public RoundData roundData;
    private FreeSpaceController freeSpaceController;
    private SliderIrritate sliderIrritate;
    private GameController gameController;
    public int roundNumber;
    public float gb;
    public float mb;
    public float b;
    public float actualSize;
    private float actualSizeStart;
    private float currentSize = 0f;
    public static float timer;
    private float timerStart;
    public GameObject sizePlace;
    public GameObject formatPlace;
    public GameObject sliderPlace;
    public GameObject timePlace;
    public string sizeText;
    public string formatText;
    // Use this for initialization
    void Start () {
        gameController = FindObjectOfType<GameController>();
        freeSpaceController = FindObjectOfType<FreeSpaceController>();
        sliderIrritate = FindObjectOfType<SliderIrritate>();
        dataController = FindObjectOfType<DataController>();
        roundNumber = DataController.roundNumber;
        roundData = dataController.GetAllRoundData(roundNumber);
        timer = roundData.timePerRound;
        timerStart = roundData.timePerRound;
        if (timer < 60 )
        {
            timePlace.GetComponent<Text>().text = "0:" + Mathf.Round(timer).ToString();
        }
        if (timer >= 60 && timer < 120)
        {
            timePlace.GetComponent<Text>().text ="1:"+ Mathf.Round(timer-60).ToString();
        }
        if (timer >= 120 && timer < 180)
        {
            timePlace.GetComponent<Text>().text = "2:" + Mathf.Round(timer-120).ToString();
        }
        if (timer >= 180 && timer < 240)
        {
            timePlace.GetComponent<Text>().text = "3:" + Mathf.Round(timer - 180).ToString();
        }
        if (timer >= 240 && timer < 300)
        {
            timePlace.GetComponent<Text>().text = "4:" + Mathf.Round(timer - 240).ToString();
        }
        sizePlace.GetComponent<Text>().text = roundData.spaceNeeded.ToString();
        if (roundData.gbN == true)
        {
            formatPlace.GetComponent<Text>().text = "GB";
            b = (roundData.spaceNeeded) * 1048576;
        }
        if (roundData.mbN == true)
        {
            formatPlace.GetComponent<Text>().text = "MB";
            b = (roundData.spaceNeeded) * 1024;
        }
        if (roundData.bN == true)
        {
            formatPlace.GetComponent<Text>().text = "KB";
            b = (roundData.spaceNeeded);
        }
        actualSize = b;
        actualSizeStart = actualSize;
        print("b is " + b);
        print("actual size is " + actualSize);
        sliderPlace.GetComponent<Slider>().value = 0;
        sliderPlace.GetComponent<Slider>().maxValue = 100;
        Invoke("ComponentsSet", 0.3f);
    }
	
    public void ComponentsSet()
    {
        Invoke("ComponentsSet", 0.3f);
        if (b >= 1048576)
        {

            sizePlace.GetComponent<Text>().text = ((Mathf.Round((((b - 1048576) / 1048576) + 1) * 100)) / 100.0).ToString();
            formatPlace.GetComponent<Text>().text = "GB";
        }
        if (b >= 1024 && b < 1048576)
        {
            sizePlace.GetComponent<Text>().text = ((Mathf.Round((((b - 1024) / 1024) + 1) * 100)) / 100.0).ToString();
            formatPlace.GetComponent<Text>().text = "MB";
        }
        if (b < 1024 && b > 0)
        {
            sizePlace.GetComponent<Text>().text = ((Mathf.Round(b * 100)) / 100.0).ToString();
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
        if ( freeSpaceController.b>0)
        {
            timer -= 1 * Time.deltaTime;
            currentSize += (actualSizeStart/ timerStart) * Time.deltaTime;
            b -=  (actualSizeStart/ timerStart) *Time.deltaTime;
            freeSpaceController.b -= (actualSizeStart / timerStart) * Time.deltaTime;
            sliderPlace.GetComponent<Slider>().value += (100/timerStart) * Time.deltaTime;
        }
        else
        {
            //wzrost irytacji
            sliderIrritate.IrritateHim(timerStart/roundData.irritateMax * Time.deltaTime*3);
        }


        //time
        if (timer < 0)
        {
            timePlace.GetComponent<Text>().text = "0:00";
        }
        if (timer < 10 && timer >= 0)
        {
            timePlace.GetComponent<Text>().text = "0:0" + Mathf.Round(timer).ToString();
        }
        if (timer < 60 && timer >=10)
        {
            timePlace.GetComponent<Text>().text = "0:" + Mathf.Round(timer).ToString();
        }
        if (timer >= 60 && timer < 70)
        {
            timePlace.GetComponent<Text>().text = "1:0" + Mathf.Round(timer - 60).ToString();
        }
        if (timer >= 70 && timer < 120)
        {
            timePlace.GetComponent<Text>().text = "1:" + Mathf.Round(timer - 60).ToString();
        }
        if (timer >= 120 && timer < 130)
        {
            timePlace.GetComponent<Text>().text = "2:0" + Mathf.Round(timer - 120).ToString();
        }
        if (timer >= 130 && timer < 180)
        {
            timePlace.GetComponent<Text>().text = "2:" + Mathf.Round(timer - 120).ToString();
        }
        if (timer >= 180 && timer < 190)
        {
            timePlace.GetComponent<Text>().text = "3:0" + Mathf.Round(timer - 180).ToString();
        }
        if (timer >= 190 && timer < 240)
        {
            timePlace.GetComponent<Text>().text = "3:" + Mathf.Round(timer - 180).ToString();
        }
        if (timer >= 240 && timer < 250)
        {
            timePlace.GetComponent<Text>().text = "4:0" + Mathf.Round(timer - 240).ToString();
        }
        if (timer >= 250 && timer < 300)
        {
            timePlace.GetComponent<Text>().text = "4:" + Mathf.Round(timer - 240).ToString();
        }

        if (b <=0)
        {
            gameController.Victory();
        }
    }
}
