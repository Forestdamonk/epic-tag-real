using UnityEngine;

public class SynchedMusicController : MonoBehaviour
{
	public int mySeed;
	public long minimumWait;
	public int randomInterval;
	public long[] songStartTimes;
	public AudioSource audioSource;
	public int lastPlayIndex;
	public long currentTime;
	public bool isMuted;
	public long totalLoopTime;
	public GorillaPressableButton muteButton;
	public bool isPlayingCurrently;
	public bool testPlay;
}
