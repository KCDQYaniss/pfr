//Type is in global namespace

[DisallowMultipleComponent]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class DeathFade : MonoBehaviour
{
	private static readonly int _value; //Field offset: 0x0
	private static readonly int _color1; //Field offset: 0x4
	[SerializeField]
	private Material _deathFade; //Field offset: 0x20
	[SerializeField]
	private Material _deathColorFade; //Field offset: 0x28
	[SerializeField]
	private Color _color; //Field offset: 0x30
	[SerializeField]
	private float _closeEyesTime; //Field offset: 0x40
	[SerializeField]
	private float _closeEyesDelay; //Field offset: 0x44
	[SerializeField]
	private float _disableTime; //Field offset: 0x48
	[SerializeField]
	private AnimationCurve _enableCurve; //Field offset: 0x50
	[SerializeField]
	private AnimationCurve _disableCurve; //Field offset: 0x58
	[SerializeField]
	private bool _debug; //Field offset: 0x60
	private float _time; //Field offset: 0x64
	[Range(0, 1)]
	[SerializeField]
	private float _closeEyesValue; //Field offset: 0x68
	[Range(0, 1)]
	[SerializeField]
	private float _fadeValue; //Field offset: 0x6C
	private bool _isDead; //Field offset: 0x70
	private float _closeEyesTimer; //Field offset: 0x74
	private float _fadeTimer; //Field offset: 0x78
	private AnimationCurve _currentCurve; //Field offset: 0x80
	private Material _deathFadeCopy; //Field offset: 0x88
	private Material _deathColorFadeCopy; //Field offset: 0x90
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x98
	private float _deathTimer; //Field offset: 0xA0

	private static DeathFade() { }

	public DeathFade() { }

	private void Awake() { }

	public void DisableEffect() { }

	public void DisableEffectInstant() { }

	public void EnableEffect() { }

	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void OnRenderImageInternal(RenderTexture source, RenderTexture destination) { }

	private void Update() { }

}

