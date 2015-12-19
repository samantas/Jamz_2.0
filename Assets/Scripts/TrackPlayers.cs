using UnityEngine;
using System.Collections;

public class TrackPlayers : Photon.MonoBehaviour {

	public TextMesh playersCon;


	public void OnJoinedRoom() {
		photonView.RPC ("trackPlayer", PhotonTargets.All, null);
	}

	public void OnPhotonPlayerConnected() {
		photonView.RPC ("trackPlayer", PhotonTargets.All, null);
	}

	[PunRPC]
	public void trackPlayer() {
		playersCon.text = PhotonNetwork.countOfPlayers + " connected player(s)";

	}

}
