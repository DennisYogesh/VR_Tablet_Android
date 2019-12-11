using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackerTransform : Photon.MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {
        if (photonView.isMine)
        {
            //transform.position = ViveManager.Instance.tracker.transform.position;
            //transform.rotation = ViveManager.Instance.tracker.transform.rotation;
        }
    }
}
