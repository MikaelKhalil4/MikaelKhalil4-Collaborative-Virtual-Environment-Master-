using System.Collections;
using System.Collections.Generic;
using RVC;
using UnityEngine;

public class GrabableHandle : Grabable
{
    public override void Update () {

        if (!caught)
        {
            transform.localPosition = new Vector3 (0, 0, 0) ;
        
            transform.localRotation = Quaternion.identity ;
        }
    }
    
    public override void LocalRelease () {

        if (caught) {
        
            base.LocalRelease () ;
        
            transform.localPosition = new Vector3 (0, 0, 0) ;
        
            transform.localRotation = Quaternion.identity ;
        
        }

    }
}
    