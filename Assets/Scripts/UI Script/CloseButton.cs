using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public void closeUI()
    {
       BuildingPos.CameraMoveCheck = false;
    }
}
