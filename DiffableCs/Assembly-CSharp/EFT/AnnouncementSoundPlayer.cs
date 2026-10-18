namespace EFT;

public class AnnouncementSoundPlayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public AnnouncementSoundPlayer <>4__this; //Field offset: 0x10
		public AnnouncementTriggerConfig config; //Field offset: 0x18

		public <>c__DisplayClass26_0() { }

		internal void <TriggerAnnouncement>b__0() { }

	}

	private class AnnouncementTriggerConfig
	{
		public string announcementId; //Field offset: 0x10
		public bool playOnce; //Field offset: 0x18
		public bool needSubtitles; //Field offset: 0x19
		public string subtitlesId; //Field offset: 0x20

		public AnnouncementTriggerConfig() { }

	}

	[SerializeField]
	private float _maxPhysicalDelaySec; //Field offset: 0x20
	[SerializeField]
	private List _triggerConfigs; //Field offset: 0x28
	[SerializeField]
	private AudioMultipleClipContainer _clipPool; //Field offset: 0x30
	[SerializeField]
	private List _speakers; //Field offset: 0x38
	[SerializeField]
	private Vector2 _randomDelayRange; //Field offset: 0x40
	[SerializeField]
	private AudioSourceGroupType _groupType; //Field offset: 0x48
	[SerializeField]
	private bool _spatialize; //Field offset: 0x4C
	[SerializeField]
	private bool _enabledHighPassFilter; //Field offset: 0x4D
	[SerializeField]
	private bool _enabledReverb; //Field offset: 0x4E
	[SerializeField]
	private EOcclusionTest _occlusionTest; //Field offset: 0x50
	[SerializeField]
	private int _rolloff; //Field offset: 0x54
	[SerializeField]
	private AudioMixerGroup _audioMixerGroup; //Field offset: 0x58
	[SerializeField]
	private AnimationCurve _spreadCurve; //Field offset: 0x60
	private Dictionary _triggerConfigsDict; //Field offset: 0x68
	private HashSet _playedOnceIds; //Field offset: 0x70
	private bool _isInitialized; //Field offset: 0x78
	private Action _unsubscribeAction; //Field offset: 0x80
	private IEnumerator _subtitlesDelayCoroutine; //Field offset: 0x88

	public AnnouncementSoundPlayer() { }

	private void Awake() { }

	private void BuildTriggerConfigsDictionary() { }

	private void Initialize() { }

	private void OnAnnouncementTriggered(RaidAnnouncementTriggerEvent eventData) { }

	private void OnDestroy() { }

	private void OnValidate() { }

	private void PlaySubtitles(AnnouncementTriggerConfig config) { }

	private void TriggerAnnouncement(AnnouncementTriggerConfig config) { }

	private void ValidateSpeakers() { }

}

