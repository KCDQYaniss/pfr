namespace Cutscene;

public class ULipSyncCurvesPlayer : MonoBehaviour
{
	[SerializeField]
	private uLipSyncBakedDataPlayer _player; //Field offset: 0x20
	[SerializeField]
	private uLipSyncBlendShape _blendShape; //Field offset: 0x28
	[SerializeField]
	private Animator _animator; //Field offset: 0x30
	[SerializeField]
	private float _minCurvesDuration; //Field offset: 0x38
	private SkinnedMeshRenderer _skinnedMeshRenderer; //Field offset: 0x40
	private BakedData _lastBakedData; //Field offset: 0x48
	private CurveData[] _curves; //Field offset: 0x50
	private readonly Dictionary _paramHashes; //Field offset: 0x58
	private bool _isPlaying; //Field offset: 0x60

	public float Volume
	{
		 get { } //Length: 28
		 set { } //Length: 28
	}

	public ULipSyncCurvesPlayer() { }

	private void ApplyCurves(float normalizedTime, float duration) { }

	private void Awake() { }

	private void CacheCurves(BakedData bakedData) { }

	public float get_Volume() { }

	private int GetHash(string param) { }

	private void OnDisable() { }

	public void Play(BakedData bakedData) { }

	private void ResetCurves() { }

	public void set_Volume(float value) { }

	public void Stop() { }

	private void Update() { }

}

