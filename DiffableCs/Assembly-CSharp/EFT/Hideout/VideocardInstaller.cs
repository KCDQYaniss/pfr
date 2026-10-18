namespace EFT.Hideout;

public sealed class VideocardInstaller : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public TaskCompletionSource source; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal void <Init>b__0() { }

	}

	[CompilerGenerated]
	private struct <AttachCard>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int count; //Field offset: 0x20
		public VideocardInstaller <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static bool <IsInited>k__BackingField; //Field offset: 0x0
	private static Item _itemTemplate; //Field offset: 0x8
	private static Token _videocardBundle; //Field offset: 0x10
	[SerializeField]
	private Transform[] _points; //Field offset: 0x20
	private readonly List _installedCards; //Field offset: 0x28

	private ObjectsFactory Factory
	{
		private get { } //Length: 46
	}

	private int InstalledCardsCount
	{
		private get { } //Length: 65
	}

	public private static bool IsInited
	{
		[CompilerGenerated]
		 get { } //Length: 59
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public VideocardInstaller() { }

	[AsyncStateMachine(typeof(<AttachCard>d__13))]
	public Task AttachCard(int count = 1) { }

	public void DetachCard() { }

	public void Dispose() { }

	private ObjectsFactory get_Factory() { }

	private int get_InstalledCardsCount() { }

	[CompilerGenerated]
	public static bool get_IsInited() { }

	public void GetFromOther(VideocardInstaller oldInstaller) { }

	public static Task Init(MongoID templateId) { }

	public static void ReleaseBundles() { }

	[CompilerGenerated]
	private static void set_IsInited(bool value) { }

}

