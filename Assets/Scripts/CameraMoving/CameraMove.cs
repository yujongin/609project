using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Vector3 OriginalPos;
    public Quaternion OriginalRot;
    void Start()
    {
        OriginalPos = this.transform.position;
        OriginalRot = this.transform.rotation;
    }

    void Update()
    {
        if (BuildingPos.CameraMoveCheck)
        {
            transform.position = Vector3.Lerp(transform.position, BuildingPos.TargetPos, Time.deltaTime * 2f);
            transform.rotation = Quaternion.Slerp(transform.rotation, BuildingPos.TargetRot, Time.deltaTime * 2f);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, OriginalPos, Time.deltaTime * 2f);
            transform.rotation = Quaternion.Slerp(transform.rotation, OriginalRot, Time.deltaTime * 2f);
        }

    }


}
