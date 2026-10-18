namespace Cinemachine;

[DocumentationSorting(Level::Undoc (0))]
internal class UpdateTracker
{
	internal enum UpdateClock
	{
		Fixed = 0,
		Late = 1,
	}

	private class UpdateStatus
	{
		private const int kWindowSize = 30; //Field offset: 0x0
		private int windowStart; //Field offset: 0x10
		private int numWindowLateUpdateMoves; //Field offset: 0x14
		private int numWindowFixedUpdateMoves; //Field offset: 0x18
		private int numWindows; //Field offset: 0x1C
		private int lastFrameUpdated; //Field offset: 0x20
		private Matrix4x4 lastPos; //Field offset: 0x24
		[CompilerGenerated]
		private UpdateClock <PreferredUpdate>k__BackingField; //Field offset: 0x64

		public private UpdateClock PreferredUpdate
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public UpdateStatus(int currentFrame, Matrix4x4 pos) { }

		[CompilerGenerated]
		public UpdateClock get_PreferredUpdate() { }

		public void OnUpdate(int currentFrame, UpdateClock currentClock, Matrix4x4 pos) { }

		[CompilerGenerated]
		private void set_PreferredUpdate(UpdateClock value) { }

	}

	private static Dictionary mUpdateStatus; //Field offset: 0x0
	private static List sToDelete; //Field offset: 0x8
	private static float mLastUpdateTime; //Field offset: 0x10

	private static UpdateTracker() { }

	public UpdateTracker() { }

	public static UpdateClock GetPreferredUpdate(Transform target) { }

	[RuntimeInitializeOnLoadMethod]
	private static void InitializeModule() { }

	public static void OnUpdate(UpdateClock currentClock) { }

	private static void UpdateTargets(UpdateClock currentClock) { }

}

