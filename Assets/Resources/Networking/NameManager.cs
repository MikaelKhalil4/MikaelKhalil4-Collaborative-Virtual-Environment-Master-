using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

namespace RVC
{
    public class NameManager : MonoBehaviourPunCallbacks
    {
        public TMP_Text textComponent = null;

        void Start()
        {
            if (photonView.IsMine || !PhotonNetwork.IsConnected)
            {
                string myText = PlayerPrefs.GetString("PlayerName");
                textComponent.text = myText;
            }
            else
            {
                photonView.RPC("RequestText", RpcTarget.Others);
                PhotonNetwork.SendAllOutgoingCommands();
            }
        }

        [PunRPC]
        void RequestText(PhotonMessageInfo info)
        {
            if (photonView.IsMine || !PhotonNetwork.IsConnected)
            {
                string myText = textComponent.text;
                photonView.RPC("UpdateText", RpcTarget.All, myText);
                PhotonNetwork.SendAllOutgoingCommands();
            }
        }

        [PunRPC]
        void UpdateText(string myText, PhotonMessageInfo info)
        {
            textComponent.text = myText;
        }
    }
}