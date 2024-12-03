using Photon.Pun;
using UnityEngine;

namespace RVC
{
    public class InteractiveCubeWithHandles : MonoBehaviourPun
    {
        public GameObject topHandle ;

        public GameObject bottomHandle ;

        public GameObject leftHandle ;

        public GameObject rightHandle ;

        public GameObject frontHandle ;

        public GameObject backHandle ;
        
        void Update () {
        
            if (photonView.IsMine) {
            
                ComputePosition () ;
            
            }
        
        }
        
        void ComputePosition () {

            transform.position = (topHandle.transform.position +

                                  bottomHandle.transform.position +

                                  leftHandle.transform.position +

                                  rightHandle.transform.position +

                                  frontHandle.transform.position +

                                  backHandle.transform.position) / 6 ;

        }
    }
}