using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 


public class MenuManager : MonoBehaviour {

    public List<GameObject> menuItemPrefabs = new List<GameObject>();
    public Text nameOfItemOnDisplay;
    public Camera cam;
    public static bool isRotatable;

    private List<ItemToDisplay> menuItems = new List<ItemToDisplay>();
    private int currentItemIndex;
    private GameObject currentObject;
    

    // Use this for initialization
    void Start ()
    {
        isRotatable = true;
        currentItemIndex = 0;
        for (int i = 0; i < menuItemPrefabs.Count; i++)
        {
            menuItems.Add( new ItemToDisplay(menuItemPrefabs[i]));
        }

	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    public void onNextClicked()
    {
        if (currentItemIndex >= 0 && currentItemIndex < menuItems.Count-1)
        {
            Destroy(GameObject.FindGameObjectWithTag("activeItem"));
            currentItemIndex = currentItemIndex + 1;
            currentObject  = (GameObject)Instantiate(menuItems[currentItemIndex].prefabToInstantiate, new Vector3(0, 0, 0), menuItemPrefabs[currentItemIndex].transform.rotation);
            currentObject.name = menuItems[currentItemIndex].itemType;
            nameOfItemOnDisplay.text = menuItems[currentItemIndex].itemType;
        }

        isRotatable = true;

        print("Right button clicked !");
        //print(menuItems.Count);        
    }

    public void onPreviousClicked()
    {
        if (currentItemIndex > 0 && currentItemIndex <= menuItems.Count-1)
        {
            Destroy(GameObject.FindGameObjectWithTag("activeItem"));
            currentItemIndex = currentItemIndex - 1;
            currentObject = (GameObject)Instantiate(menuItems[currentItemIndex].prefabToInstantiate, new Vector3(0, 0, 0), menuItemPrefabs[currentItemIndex].transform.rotation);
            currentObject.name = menuItems[currentItemIndex].itemType;
            nameOfItemOnDisplay.text = menuItems[currentItemIndex].itemType;
        }

        isRotatable = true;

        print("Left button clicked !");
        //print(menuItems.Count);
    }


    public void onDragClicked()
    {
        isRotatable = false;
    }

    public void onRotateClicked()
    {
        currentObject = GameObject.FindGameObjectWithTag("activeItem");
        currentObject.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        isRotatable = true;
    }

}
