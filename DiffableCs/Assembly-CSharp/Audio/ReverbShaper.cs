namespace Audio;

[RequireComponent(typeof(BetterSource))]
public class ReverbShaper : MonoBehaviour, IManualUpdated
{
	[SerializeField]
	private AnimationCurve _envelope; //Field offset: 0x20
	[SerializeField]
	private float _minReverbDB; //Field offset: 0x28
	private BetterSource _controlledSource; //Field offset: 0x30
	private float _maxReverbDB; //Field offset: 0x38
	private float _timer; //Field offset: 0x3C
	private float _curveDuration; //Field offset: 0x40
	private bool _isPlaying; //Field offset: 0x44

	public ReverbShaper() { }

	private void Awake() { }

	public override void ManualUpdate() { }

	private void OnDestroy() { }

	public override void SetActive(bool active) { }

	private void StateChangedHandler(BetterSource betterSource, EPlayBackState playBackState) { }

}

