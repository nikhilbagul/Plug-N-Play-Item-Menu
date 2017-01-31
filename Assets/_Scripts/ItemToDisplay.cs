using UnityEngine;
using System.Collections;

public class ItemToDisplay
{
    public GameObject prefabToInstantiate;
    public string itemType;

    public ItemToDisplay(GameObject editorPrefabToAssign)
    {
        prefabToInstantiate = editorPrefabToAssign;
        itemType = editorPrefabToAssign.name;



    }	
}
