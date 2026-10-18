namespace PlayerIcons;

[CreateAssetMenu(fileName = "PlayerIconCreatorSettings", menuName = "Scriptable objects/PlayerIconCreatorSettings")]
public class PlayerIconCreatorSettings : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__33_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <CheckForcePause>b__33_0(GameObject o) { }

	}

	[CompilerGenerated]
	private struct <CheckForcePause>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerIconCreatorSettings <>4__this; //Field offset: 0x20
		public GameObject[] objects; //Field offset: 0x28
		private object <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string PlayerIconCreatorSettingsName = "PlayerIconCreatorSettings"; //Field offset: 0x0
	public const float GRAPHIC_SETTINGS_PREPARE = 0.1; //Field offset: 0x0
	public const float MODEL_VIEW_PREPARE = 0.2; //Field offset: 0x0
	public const float BUNDLES_LOADED = 0.6; //Field offset: 0x0
	public const float PLAYER_BODY_INITED = 0.7; //Field offset: 0x0
	public const float MODEL_CREATED = 0.8; //Field offset: 0x0
	public const float SPRITE_RENDER_PREPARE = 0.9; //Field offset: 0x0
	[Space]
	public Vector3 orthographicLocalPosition; //Field offset: 0x18
	public Vector3 orthographicRotation; //Field offset: 0x24
	public RenderingPath orthographicRenderingPath; //Field offset: 0x30
	public float orthographicSize; //Field offset: 0x34
	[Space]
	public Vector3 perspectiveLocalPosition; //Field offset: 0x38
	public Vector3 perspectiveRotation; //Field offset: 0x44
	public RenderingPath perspectiveRenderingPath; //Field offset: 0x50
	[Space]
	public bool isOrthographic; //Field offset: 0x54
	[Range(0.01, 179)]
	[Space]
	public float fieldOfView; //Field offset: 0x58
	public float nearClipPlane; //Field offset: 0x5C
	public float farClipPlane; //Field offset: 0x60
	[Space]
	public bool isForceRenderActive; //Field offset: 0x64
	[Space]
	public bool isForceSetHelmetState; //Field offset: 0x65
	public bool isHelmetOn; //Field offset: 0x66
	[Space]
	public Vector2 textureSize; //Field offset: 0x68
	[Space]
	public List meshMaterialSettings; //Field offset: 0x70
	[Space]
	public bool isEnablePreview; //Field offset: 0x78
	public bool isEditInProgress; //Field offset: 0x79
	private PlayerIconRequest _lastRequest; //Field offset: 0x80

	public Vector3 LocalPosition
	{
		 get { } //Length: 44
	}

	public RenderingPath RenderingPath
	{
		 get { } //Length: 14
	}

	public Quaternion Rotation
	{
		 get { } //Length: 185
	}

	public PlayerIconCreatorSettings() { }

	[AsyncStateMachine(typeof(<CheckForcePause>d__33))]
	public Task CheckForcePause(GameObject[] objects) { }

	public Vector3 get_LocalPosition() { }

	public RenderingPath get_RenderingPath() { }

	public Quaternion get_Rotation() { }

	public void SaveLastRequest(PlayerIconRequest lastRequest) { }

	public bool TryForceRenderLastIco(out ItemIcon icon) { }

}

