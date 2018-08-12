using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderIrritate : MonoBehaviour {
    private GameController gameController;
    public DataController dataController;
    public RoundData roundData;
    public int roundNumber;

    // Use this for initialization
    void Start () {
        gameController = FindObjectOfType<GameController>();
        dataController = FindObjectOfType<DataController>();
        roundNumber = DataController.roundNumber;
        roundData = dataController.GetAllRoundData(roundNumber);
        GetComponent<Slider>().maxValue = roundData.irritateMax;
        GetComponent<Slider>().value = 0f;
    }

    public void IrritateHim( float val)
    {
        print("value is " + val);
        GetComponent<Slider>().value += val;
    }
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<Slider>().value>= roundData.irritateMax)
        {
            gameController.Death();
        }
	}
}
