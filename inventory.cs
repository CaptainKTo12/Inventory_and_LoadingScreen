using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iventory : MonoBehaviour
{
    bool isInventoryOpen = false;
    bool isObject1inThere= false;
    public GameObject Iventory;
    public GameObject IventorySprite1;
    public GameObject IventorySprite2;
    public GameObject Object1;
    public GameObject Object2;
    public GameObject hand;

    void Update()
    {
        if(Input.GetKey (KeyCode.E)){
            isObject1inThere = true;
        };
        if(Input.GetKey (KeyCode.I)){
            Iventory.active = true;
            isInventoryOpen = true;
            IventorySprite1.active = true;
            if(isObject1inThere == true){
                IventorySprite1.active = false;
                IventorySprite2.active = true;
            };
        }
        if(isInventoryOpen == true){
            if(isObject1inThere == true){
            if(Input.GetKey (KeyCode.E)){
                Object1.active = true;
                Object2.active = false;
                hand.active = true;
                Iventory.active = false;
                isInventoryOpen = false;
            }
            }
            if(Input.GetKey (KeyCode.P)){
                Object1.active = false;
                Object2.active = true;
                hand.active = false;
                Iventory.active = false;
                isInventoryOpen = false;
            }
        };
    }
}