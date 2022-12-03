using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

namespace GorillaNetworking
{
	public class GorillaComputer : MonoBehaviourPunCallbacks
	{
		public enum ComputerState
		{
			Startup = 0,
			Color = 1,
			Name = 2,
			Turn = 3,
			Mic = 4,
			Room = 5,
			Queue = 6,
			Group = 7,
			Voice = 8,
			Credits = 9,
			Visuals = 10,
		}

		public bool tryGetTimeAgain;
		public Material unpressedMaterial;
		public Material pressedMaterial;
		public string currentTextField;
		public float buttonFadeTime;
		public Text offlineScoreboard;
		public Text screenText;
		public Text functionSelectText;
		public Text wallScreenText;
		public Text tutorialWallScreenText;
		public Text offlineVRRigNametagText;
		public string versionText;
		public string versionMismatch;
		public string unableToConnect;
		public Material wrongVersionMaterial;
		public MeshRenderer wallScreenRenderer;
		public MeshRenderer tutorialWallScreenRenderer;
		public MeshRenderer computerScreenRenderer;
		public MeshRenderer scoreboardRenderer;
		public GorillaLevelScreen[] levelScreens;
		public long startupMillis;
		public Text currentGameModeText;
		public PhotonNetworkController networkController;
		public float updateCooldown;
		public float lastUpdateTime;
		public bool isConnectedToMaster;
		public ComputerState currentState;
		public Text motdText;
		public string savedName;
		public string currentName;
		[SerializeField]
		public TextAsset exactOneWeekFile;
		public TextAsset anywhereOneWeekFile;
		public TextAsset anywhereTwoWeekFile;
		public string roomToJoin;
		public bool roomFull;
		public string pttType;
		public string currentQueue;
		public string groupMapJoin;
		public GorillaFriendCollider friendJoinCollider;
		public GorillaNetworkJoinTrigger caveMapTrigger;
		public GorillaNetworkJoinTrigger forestMapTrigger;
		public GorillaNetworkJoinTrigger canyonMapTrigger;
		public GorillaNetworkJoinTrigger cityMapTrigger;
		public string voiceChatOn;
		public ModeSelectButton[] modeSelectButtons;
		public string currentGameMode;
		public bool disableParticles;
	}
}
