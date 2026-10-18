//Type is in global namespace

public class DigitalGlitch : MonoBehaviour
{
	private Material _material; //Field offset: 0x20
	private float _startTime; //Field offset: 0x28
	private bool _isPlaying; //Field offset: 0x2C
	private bool _completionSent; //Field offset: 0x2D
	private int _appliedBlurQuality; //Field offset: 0x30
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x38
	private DigitalGlitchProfile _runtimeProfile; //Field offset: 0x40
	[SerializeField]
	private DigitalGlitchProfile _profile; //Field offset: 0x48
	[SerializeField]
	private bool _useSourceProfile; //Field offset: 0x50
	[CompilerGenerated]
	private Action Started; //Field offset: 0x58
	[CompilerGenerated]
	private Action Completed; //Field offset: 0x60
	[CompilerGenerated]
	private Action Stopped; //Field offset: 0x68

	public event Action Completed
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action Started
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action Stopped
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public bool IsPlaying
	{
		 get { } //Length: 5
	}

	public float PlaybackDuration
	{
		 get { } //Length: 7
	}

	public float PlaybackTime
	{
		 get { } //Length: 105
	}

	public DigitalGlitchProfile Profile
	{
		 get { } //Length: 153
	}

	public DigitalGlitch() { }

	[CompilerGenerated]
	public void add_Completed(Action value) { }

	[CompilerGenerated]
	public void add_Started(Action value) { }

	[CompilerGenerated]
	public void add_Stopped(Action value) { }

	private void ApplyBlurQualityKeyword(int blurQuality) { }

	private void ApplyOverlayAtlasSettings(DigitalGlitchProfile profile, float elapsed, bool hasBlur, bool hasPixelation) { }

	private void ApplySettings(DigitalGlitchProfile profile, float elapsed, bool hasBlur, bool hasPixelation, float blurProgress, float pixelationProgress, float overlayProgress) { }

	private void Awake() { }

	private float CalculateOverlayAbsoluteStartTime(bool hasBlur, bool hasPixelation) { }

	private float CalculatePlaybackDuration() { }

	private float CalculateSequentialPlaybackDuration(bool hasBlur, bool hasPixelation, bool hasOverlay) { }

	private static float CalculateStageEndTime(float startTime, float duration, float speed) { }

	private void CompletePlayback() { }

	public void Dispose() { }

	private bool EnsureMaterial() { }

	private void EvaluateSequentialStageProgress(float elapsed, bool hasBlur, bool hasPixelation, bool hasOverlay, out float blurProgress, out float pixelationProgress, out float overlayProgress) { }

	private static float EvaluateStageProgress(float elapsed, float startTime, float duration, float fadeInTime, float speed) { }

	public bool get_IsPlaying() { }

	public float get_PlaybackDuration() { }

	public float get_PlaybackTime() { }

	public DigitalGlitchProfile get_Profile() { }

	private void GetActiveStages(out bool hasBlur, out bool hasPixelation, out bool hasOverlay) { }

	private static string GetBlurQualityKeyword(int blurQuality) { }

	private static int HashToAtlasCell(int frame, int seed) { }

	private void OnEnable() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void Play() { }

	private static int PositiveModulo(int value, int modulo) { }

	[CompilerGenerated]
	public void remove_Completed(Action value) { }

	[CompilerGenerated]
	public void remove_Started(Action value) { }

	[CompilerGenerated]
	public void remove_Stopped(Action value) { }

	private static float Smooth01(float value) { }

	private void StartPlayback(bool invokeStartedEvent) { }

	public void Stop(bool invokeStoppedEvent = true) { }

}

