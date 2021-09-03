using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPos : MonoBehaviour
{
    public CameraPos camerapos;
    public static Vector3 TargetPos;
    public static Quaternion TargetRot;
    public static bool CameraMoveCheck=false;
    public GameObject StatusUpgradeUI;
    void Start()
    {
        
    }

    void Update()
    {
      
    }

    void OnMouseDown()
    {
        if (!CameraMoveCheck)
        {
            TargetPos = new Vector3(camerapos.Posx, camerapos.Posy, camerapos.Posz);
            TargetRot = Quaternion.Euler(camerapos.Rotx, camerapos.Roty, camerapos.Rotz);
            Debug.Log(TargetPos);
            CameraMoveCheck = true;
            StatusUpgradeUI.SetActive(true);
        }
        
    }
}
