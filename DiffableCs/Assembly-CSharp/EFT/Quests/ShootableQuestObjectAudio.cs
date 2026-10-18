namespace EFT.Quests;

public sealed class ShootableQuestObjectAudio : MonoBehaviour
{
	private const float CHECK_INTERVAL = 0.1; //Field offset: 0x0
	[SerializeField]
	[Tooltip("loop sound is optional, if not set - not playing")]
	private AudioSingleClipContainer _loopSound; //Field offset: 0x20
	[SerializeField]
	private AudioMultipleClipContainer _breakSound; //Field offset: 0x28
	[SerializeField]
	private EOcclusionTest OcclusionTest; //Field offset: 0x30
	[SerializeField]
	private ShootableQuestLocationObject _shootableQuestObject; //Field offset: 0x38
	[SerializeField]
	private AnimationCurve _rolloffCurve; //Field offset: 0x40
	private BetterSource _source; //Field offset: 0x48
	private bool _isBroken; //Field offset: 0x50
	private bool _isPlaying; //Field offset: 0x51
	private Transform _transform; //Field offset: 0x58
	private float _nextCheckTime; //Field offset: 0x60

	public ShootableQuestObjectAudio() { }

	private void Awake() { }

	private void CheckPlayback() { }

	private void Clear() { }

	private void Init() { }

	private void OnBroken() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void PlayBreakSound() { }

	private void PlayLoopSound() { }

	private void StopAndReleaseLoop() { }

	private void Update() { }

}

