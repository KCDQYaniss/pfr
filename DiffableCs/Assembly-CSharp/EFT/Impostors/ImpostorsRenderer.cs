namespace EFT.Impostors;

[ExecuteInEditMode]
[ScriptOrder(20002)]
public sealed class ImpostorsRenderer : MonoBehaviourSingleton
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__24_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal uint <UpdateDrawInstance>b__24_0(ImpostorsGroup group) { }

	}

	private Action _textureQualitySubscription; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	private AmplifyImpostorsArray _impostorsArray; //Field offset: 0x28
	[HideInInspector]
	[SerializeField]
	private EImpostorsShadowMode _shadowMode; //Field offset: 0x30
	[SerializeField]
	private int MaxImpostorsCount; //Field offset: 0x34
	[SerializeField]
	private bool _drawGizmos; //Field offset: 0x38
	private readonly Dictionary _groups; //Field offset: 0x40
	private int _impostorsCount; //Field offset: 0x48
	private bool _dirty; //Field offset: 0x4C
	private bool _dirtyOnLoad; //Field offset: 0x4D
	private ImpostorsDrawInstance _drawInstance; //Field offset: 0x50

	public AmplifyImpostorsArray ImpostorsArray
	{
		 get { } //Length: 5
		 set { } //Length: 848
	}

	public int ImpostorsToRenderCount
	{
		 get { } //Length: 74
	}

	public EImpostorsShadowMode ShadowMode
	{
		 get { } //Length: 4
		 set { } //Length: 10
	}

	public ImpostorsRenderer() { }

	private void Add(AmplifyImpostorsArrayElement impostor) { }

	private void AddEarlyImpostors() { }

	public virtual void Awake() { }

	private void CameraRender(Camera currentCamera) { }

	private void Clear() { }

	internal void DrawDistantShadow(Camera currentCamera, CommandBuffer renderObjectsCmdBuf, uint impostorsPerFrame, out int impostorsRest) { }

	public AmplifyImpostorsArray get_ImpostorsArray() { }

	public int get_ImpostorsToRenderCount() { }

	public EImpostorsShadowMode get_ShadowMode() { }

	private static bool IsCorrect(Component camera) { }

	private void LateUpdate() { }

	private void OnChangedActiveScene(Scene scene, Scene next) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnEnableChanged(AmplifyImpostorsArrayElement impostor, bool enable) { }

	private void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode) { }

	private void OnTextureQualityChanged(int textureQuality) { }

	public void Refresh() { }

	private void RegisterEvent() { }

	private void Remove(AmplifyImpostorsArrayElement impostor) { }

	public void set_ImpostorsArray(AmplifyImpostorsArray value) { }

	public void set_ShadowMode(EImpostorsShadowMode value) { }

	private void Subscribe() { }

	private void UnregisterEvent() { }

	private void Unsubscribe() { }

	private void UpdateDrawInstance() { }

}

