using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FolderObject : MonoBehaviour {
    public GameObject openButton;
    private FreeSpaceController freeSpaceController;
    public GameObject deleteButton;
    public GameObject imageObject;
    public GameObject nameObject;
    public GameObject sizeObject;
    public GameObject formatObject;
    public GameObject highlight;
    public AudioClip clickSound;
    public AudioClip destroySound;

    public GameController gameController;

    public string name;
    public Sprite image;
    public float size;
    public string format;
    public float irritate;
    public bool gb = false;
    public bool mb = false;
    public bool b = false;
    public Sprite[] imageForFolder;
    public bool isFolder = false;
    public bool isRar = false;
    public bool isImage = false;
    public bool isMovie = false;
    public bool isDoc = false;
    public int folderNumber;
    private int clickCount = 0;
    private FolderObject[] folderObjects;

    public void OpenFolder()
    {
        AudioSource.PlayClipAtPoint(clickSound, Camera.main.transform.position);
        folderObjects = FindObjectsOfType<FolderObject>();
        clickCount += 1;
        if (clickCount >=3)
        { clickCount = 0; }
        if (clickCount==1)
        {
            foreach (FolderObject obj in folderObjects)
            {
                obj.clickCount = 0;
                obj.highlight.SetActive(false);
            }
            clickCount = 1;
            highlight.SetActive(true);
            if (highlight.activeSelf)
            {
                sizeObject = GameObject.Find("SizeText");
                sizeObject.GetComponent<Text>().text = size.ToString();
                formatObject = GameObject.Find("MemoryTypeText");
                if (gb)
                {
                    formatObject.GetComponent<Text>().text = "GB";
                }
                else if (mb)
                {
                    formatObject.GetComponent<Text>().text = "MB";
                }
                else if (b)
                {
                    formatObject.GetComponent<Text>().text = "KB";
                }
            }
        }
        if (clickCount == 2)
        {
            if (isFolder)
            {
                gameController.NextFolder(folderNumber);
                gameController.NewSetOfFolders();
            }
        }
    }
    public void DeleteFolder()
    {
        AudioSource.PlayClipAtPoint(destroySound, Camera.main.transform.position);
        gameController.distractIrritate = 0;
        gameController.iri = 0;
        gameController.iri2 = 0;
        gameController.iri3 = 0;
        gameController.iri4 = 0;
        gameController.iri5 = 0;
        gameController.iri6 = 0;
        gameController.iri7 = 0;
        gameController.iri8 = 0;
        gameController.iri9 = 0;
        gameController.iri10 = 0;
        gameController.iri11 = 0;
        gameController.iri12 = 0;
        gameController.iri13 = 0;
        gameController.iri14 = 0;
        gameController.iri15 = 0;
        gameController.iri16 = 0;
        gameController.iri17 = 0;
        gameController.iri18 = 0;
        gameController.iri19 = 0;
        //nie zapomnij ze trzeba zliczyc wszystkie irritate od dzieci !!!!!
        if (gb)
        {
            freeSpaceController.b += ((size) * 1048576);
        }
        else if (mb)
        {
            freeSpaceController.b += ((size) * 1024);
        }
        else if (b)
        {
            freeSpaceController.b += (size);
        }

        gameController.CountIrritate(folderNumber);
        gameController.ClearArray(folderNumber);

        //Destroy(gameObject);

    }
    // Use this for initialization
    public void InvokeAfterStart()
    {
        if (highlight.activeSelf)
        {
            sizeObject = GameObject.Find("SizeText");
            sizeObject.GetComponent<Text>().text = size.ToString();
            formatObject = GameObject.Find("MemoryTypeText");
            if (gb)
            {
                formatObject.GetComponent<Text>().text = "GB";
            }
            if (mb)
            {
                formatObject.GetComponent<Text>().text = "MB";
            }
            if (b)
            {
                formatObject.GetComponent<Text>().text = "KB";
            }
        }
    }
    void Start () {

        freeSpaceController = FindObjectOfType<FreeSpaceController>();

        if (folderNumber ==0)
        {
            clickCount = 1;
            highlight.SetActive(true);
        }
        folderObjects = FindObjectsOfType<FolderObject>();
        gameController = FindObjectOfType<GameController>();
        nameObject.GetComponent<Text>().text = name;
        Invoke("InvokeAfterStart", 0.3f);
        if (isFolder)
        {
            imageObject.GetComponent<Image>().sprite = imageForFolder[0];
        }
        if (isRar)
        {
            imageObject.GetComponent<Image>().sprite = imageForFolder[1];
        }
        if (isImage)
        {
            imageObject.GetComponent<Image>().sprite = imageForFolder[2];
        }
        if (isMovie)
        {
            imageObject.GetComponent<Image>().sprite = imageForFolder[3];
        }
        if (isDoc)
        {
            imageObject.GetComponent<Image>().sprite = imageForFolder[4];
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
