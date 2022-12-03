using Photon.Pun;
using UnityEngine;

public class GorillaHatButtonParent : MonoBehaviourPunCallbacks
{
	public GorillaHatButton[] hatButtons;
	public GameObject[] adminObjects;
	public string hat;
	public string face;
	public string badge;
	public bool initialized;
	public GorillaLevelScreen screen;
}
