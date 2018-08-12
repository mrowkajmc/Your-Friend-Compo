using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour {
    public RoundData[] allRoundsData;
    public static int roundNumber = 0;

    void Start()
    {

        DontDestroyOnLoad(gameObject);
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            SceneManager.LoadScene("mainMenu");
        }
    }
	
    public RoundData GetAllRoundData (int roundNumber)
    {
        return allRoundsData[roundNumber];
    }

}
