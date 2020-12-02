using System;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARPlaneChanger : MonoBehaviour
{
    public Material[] mats;
    private int pos = 0;
    public MeshRenderer Plane;

    //public void NextPlane()
    //{
    //    pos = pos + 1;
    //    if (pos>=mats.Length)
    //    {
    //        pos = 0;
    //    }
    //    SetPosTo(pos);
    //}
    public void SetPosTo(int newPos)
    {
        pos = newPos;
        MeshRenderer[] rends = transform.GetComponentsInChildren<MeshRenderer>();
        for (int i = 0; i < rends.Length; i++)
        {
            rends[i].material = mats[pos];
        }
        Plane.material = mats[pos];
    }
    void Update()
    {
        var planeManager = GetComponent<ARPlaneManager>();
        foreach (ARPlane plane in planeManager.trackables)
        {
            //horizontal
            if (plane.normal == new Vector3(0, 1, 0) || plane.normal == new Vector3(0, -1, 0))
            {
                //do x
                SetPosTo(1);
            }
            //vertical
            else
            {
                //do y
                SetPosTo(2);
            }
        }
    }

    
}
