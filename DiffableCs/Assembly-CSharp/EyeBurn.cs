//Type is in global namespace

public class EyeBurn : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <TimeDisable>d__35 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public EyeBurn <>4__this; //Field offset: 0x20
		public float t; //Field offset: 0x28
		private float <normalizedTime>5__2; //Field offset: 0x2C

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <TimeDisable>d__35(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private class EyeBurnSpot
	{
		public Vector3 ScreenPosition; //Field offset: 0x10
		public Material Material; //Field offset: 0x20
		public float Rotation; //Field offset: 0x28
		public Vector3 Scale; //Field offset: 0x2C
		public float StartTime; //Field offset: 0x38
		public float MaxTime; //Field offset: 0x3C

		public EyeBurnSpot(Vector3 screenPosition, Material material, float rotation, Vector3 scale, float startTime, float maxTime) { }

	}

	private static readonly int _eyeBurnTex; //Field offset: 0x0
	private const string COEF = "_Coef"; //Field offset: 0x0
	private const string ROTATION = "_Rotation"; //Field offset: 0x0
	public Material EyeBurnScreenEffect; //Field offset: 0x20
	[SerializeField]
	private Material[] _eyeBurnEffectMaterial; //Field offset: 0x28
	[SerializeField]
	private Material[] _eyeBurnTrailMaterial; //Field offset: 0x30
	[SerializeField]
	private Vector2 _scaleMinMax; //Field offset: 0x38
	[SerializeField]
	private float _eyeBurnMaxTime; //Field offset: 0x40
	[SerializeField]
	private float TrailSpotEvery; //Field offset: 0x44
	[SerializeField]
	private float TrailSpotShift; //Field offset: 0x48
	[SerializeField]
	private AnimationCurve trailDecreaseCurve; //Field offset: 0x50
	[SerializeField]
	private int MaxTrailLength; //Field offset: 0x58
	[SerializeField]
	private AnimationCurve _scaleCoefCurve; //Field offset: 0x60
	[CompilerGenerated]
	private bool <EyesBurn>k__BackingField; //Field offset: 0x68
	public bool IsPaused; //Field offset: 0x69
	private RenderTexture _eyeBurnRT; //Field offset: 0x70
	private Coroutine _disableCoroutine; //Field offset: 0x78
	private List _flashes; //Field offset: 0x80
	private int _currentTexture; //Field offset: 0x88
	private Vector3 _initialBurnPosition; //Field offset: 0x8C
	protected SSAAPropagator _ssaaPropagator; //Field offset: 0x98

	public bool EyesBurn
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static EyeBurn() { }

	public EyeBurn() { }

	private void AddEyeBurn(Vector3 screenPosition, Vector3 scale, float eyeBurnTime, float elapsedTime) { }

	private void AddEyeBurn(Vector3 screenPosition, Vector3 scale, float eyeBurnTime) { }

	private void AddMainSpot(Vector3 screenPosition, float strength, float time, float elapsedTime) { }

	private void AddTrailEyeburn(Vector3 direction, Vector3 scale, float eyeBurnTime) { }

	private void Awake() { }

	public bool Burn(Vector3 position, float stregnth, Vector2 deltaRotation, out Vector2 viewportUv) { }

	public void BurnMainSpot(Vector3 position, float strength, float elapsedTime) { }

	public void BurnMainSpotAtViewport(Vector2 viewportUv, float strength, float elapsedTime) { }

	public void Clear() { }

	public void ClearEyeBurnRT() { }

	public void Draw(Vector3 position, Vector3 scale, float rotation, Material material, float coef, float scaleCoef) { }

	[CompilerGenerated]
	public bool get_EyesBurn() { }

	private RenderTexture GetOrCreateEyeBurnRenderTexture() { }

	private bool IsScreenPositionCorrect(Vector3 screenPosition) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private Vector3 ScreenPositionToUV(Vector3 screenPosition) { }

	[CompilerGenerated]
	public void set_EyesBurn(bool value) { }

	[IteratorStateMachine(typeof(<TimeDisable>d__35))]
	private IEnumerator TimeDisable(float t) { }

	private void Update() { }

}

