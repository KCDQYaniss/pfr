namespace EFT.Hideout;

public sealed class HideoutAudioBackground : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public HideoutAudioBackground <>4__this; //Field offset: 0x10
		public AreaData areaData; //Field offset: 0x18

		public <>c__DisplayClass14_0() { }

		internal void <InitArea>b__0(bool silent) { }

	}

	[SerializeField]
	private AudioSource _hollowAudioSource; //Field offset: 0x20
	[SerializeField]
	private List _inhabitedAudioSources; //Field offset: 0x28
	[SerializeField]
	private AudioClip _hollowAmbiance; //Field offset: 0x30
	[Range(0, 1)]
	[SerializeField]
	private float _masterVolume; //Field offset: 0x38
	private float _currentTotalValue; //Field offset: 0x3C
	private float _maxTotalValue; //Field offset: 0x40
	private float _minTotalValue; //Field offset: 0x44
	private float _previousMasterVolume; //Field offset: 0x48
	private readonly Dictionary _currentValuesIndex; //Field offset: 0x50
	private readonly List _unsubscribersCache; //Field offset: 0x58
	private bool _started; //Field offset: 0x60

	public HideoutAudioBackground() { }

	public void InitArea(AreaData areaData) { }

	private void OnDestroy() { }

	private void OnEnable() { }

	public void Play() { }

	private void Update() { }

	private void UpdateAreaLevel(AreaData areaData) { }

	private void UpdateSounds() { }

}

