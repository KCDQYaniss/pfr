namespace EFT.UI;

public class PlayerProfilePreview : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__31_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Show>b__31_0() { }

	}

	[CompilerGenerated]
	private struct <ChangeCameraPosition>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public float duration; //Field offset: 0x20
		public PlayerProfilePreview <>4__this; //Field offset: 0x28
		public ECameraViewType viewType; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum ECameraViewType
	{
		FullBody = 0,
		Head = 1,
		HalfBody = 2,
	}

	internal class PlayerProfilePreviewPosition
	{
		public ECameraViewType CameraType; //Field offset: 0x10
		public Transform CameraPosition; //Field offset: 0x18
		public RectTransform ViewportPosition; //Field offset: 0x20

		public PlayerProfilePreviewPosition() { }

	}

	[SerializeField]
	private PlayerModelView _playerModelView; //Field offset: 0x70
	[SerializeField]
	private RectTransform _transform; //Field offset: 0x78
	[SerializeField]
	private XCoordRotation _rotator; //Field offset: 0x80
	[SerializeField]
	private DragTrigger _dragTrigger; //Field offset: 0x88
	[SerializeField]
	private SideSelectionToggle _hoverTrigger; //Field offset: 0x90
	[SerializeField]
	private EPlayerSide _side; //Field offset: 0x98
	[SerializeField]
	private Transform _cameraContainer; //Field offset: 0xA0
	[SerializeField]
	private Camera _camera; //Field offset: 0xA8
	[SerializeField]
	private CanvasGroup _godLight; //Field offset: 0xB0
	[SerializeField]
	private List _lights; //Field offset: 0xB8
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0xC0
	[SerializeField]
	private List _viewPorts; //Field offset: 0xC8
	[SerializeField]
	private GameObject[] _hoverLights; //Field offset: 0xD0
	[SerializeField]
	private bool _allowGodLight; //Field offset: 0xD8
	private bool _selected; //Field offset: 0xD9
	[CompilerGenerated]
	private Profile <Profile>k__BackingField; //Field offset: 0xE0

	public DragTrigger DragTrigger
	{
		 get { } //Length: 8
	}

	public SideSelectionToggle HoverTrigger
	{
		 get { } //Length: 8
	}

	public PlayerModelView PlayerModelView
	{
		 get { } //Length: 5
	}

	public private Profile Profile
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool RotationEnabled
	{
		 get { } //Length: 93
		 set { } //Length: 657
	}

	public XCoordRotation Rotator
	{
		 get { } //Length: 8
	}

	public bool Selectable
	{
		 get { } //Length: 299
		 set { } //Length: 624
	}

	public EPlayerSide Side
	{
		 get { } //Length: 7
	}

	public PlayerProfilePreview() { }

	public void ChangeCameraPosition(ECameraViewType viewType) { }

	[AsyncStateMachine(typeof(<ChangeCameraPosition>d__34))]
	public Task ChangeCameraPosition(ECameraViewType viewType, float duration) { }

	public virtual void Close() { }

	public DragTrigger get_DragTrigger() { }

	public SideSelectionToggle get_HoverTrigger() { }

	public PlayerModelView get_PlayerModelView() { }

	[CompilerGenerated]
	public Profile get_Profile() { }

	public bool get_RotationEnabled() { }

	public XCoordRotation get_Rotator() { }

	public bool get_Selectable() { }

	public EPlayerSide get_Side() { }

	private PlayerProfilePreviewPosition GetPositionNode(ECameraViewType viewType) { }

	private void HoverHandler(bool isUnderCursor) { }

	[CompilerGenerated]
	private void set_Profile(Profile value) { }

	public void set_RotationEnabled(bool value) { }

	public void set_Selectable(bool value) { }

	public void SetGodLightStatus(bool active, float duration = 0.5) { }

	public void SetLightStatus(bool isOn) { }

	public void SetSide(EPlayerSide side) { }

	public void SetVisibility(bool visible, float duration) { }

	public Task Show(Profile profile, float update = 0) { }

}

