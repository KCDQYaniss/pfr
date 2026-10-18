namespace EFT.UI;

public static class CursorSwitcher
{
	[CompilerGenerated]
	private struct <Init>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private Enumerator <>7__wrap1; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class CursorData
	{
		[CompilerGenerated]
		private struct <Init>d__7 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public CursorData <>4__this; //Field offset: 0x20
			public ResourceRequest resource; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private Texture2D <Texture>k__BackingField; //Field offset: 0x10
		public readonly Vector2 HotSpot; //Field offset: 0x18
		public readonly Task LoadingTask; //Field offset: 0x20

		public private Texture2D Texture
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public CursorData(string path, Vector2 hotSpot) { }

		[CompilerGenerated]
		public Texture2D get_Texture() { }

		[AsyncStateMachine(typeof(<Init>d__7))]
		private Task Init(ResourceRequest resource) { }

		[CompilerGenerated]
		private void set_Texture(Texture2D value) { }

	}

	[CompilerGenerated]
	private static Action LockModeChanged; //Field offset: 0x0
	private static Dictionary _cursors; //Field offset: 0x8
	private static ECursorType _defaultCursor; //Field offset: 0x10
	private static ECursorType _currentCursor; //Field offset: 0x14
	[CompilerGenerated]
	private static ECursorType <PreviousType>k__BackingField; //Field offset: 0x18

	public static event Action LockModeChanged
	{
		[CompilerGenerated]
		 add { } //Length: 266
		[CompilerGenerated]
		 remove { } //Length: 266
	}

	public private static ECursorType PreviousType
	{
		[CompilerGenerated]
		 get { } //Length: 59
		[CompilerGenerated]
		private set { } //Length: 64
	}

	[CompilerGenerated]
	public static void add_LockModeChanged(Action value) { }

	[CompilerGenerated]
	public static ECursorType get_PreviousType() { }

	[AsyncStateMachine(typeof(<Init>d__11))]
	public static Task Init() { }

	public static bool IsLockedState(CursorLockMode lockMode) { }

	[CompilerGenerated]
	public static void remove_LockModeChanged(Action value) { }

	[CompilerGenerated]
	private static void set_PreviousType(ECursorType value) { }

	public static void SetCursor(ECursorType type) { }

	private static void SetCursor(CursorData cursor) { }

	public static void SetCursorLockMode(bool cursorVisible, FullScreenMode fullscreenMode) { }

	public static void SetDefaultCursor(ECursorType type) { }

}

