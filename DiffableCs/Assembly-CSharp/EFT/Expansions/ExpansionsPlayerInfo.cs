namespace EFT.Expansions;

public sealed class ExpansionsPlayerInfo
{
	[CompilerGenerated]
	private struct <Init>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ExpansionsPlayerInfo <>4__this; //Field offset: 0x20
		private ExpansionsPlayerData <shopData>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshExpansionsPlayerDataAsync>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ExpansionsPlayerInfo <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IEftSession _session; //Field offset: 0x10
	private Action _unsubscribeExpansionsBrowserPageOpened; //Field offset: 0x18
	private Action _unsubscribeNotificationReceived; //Field offset: 0x20
	[CompilerGenerated]
	private Action dataUpdated; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsExpansionsEnabled>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <IsExpansionsAvailable>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	private int <TarcoinsCount>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private int <NewOffersCount>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <FreeOffersCount>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private int <SaleOffersCount>k__BackingField; //Field offset: 0x40

	public event Action dataUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private int FreeOffersCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsExpansionsAvailable
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsExpansionsEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int NewOffersCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int SaleOffersCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int TarcoinsCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ExpansionsPlayerInfo(IEftSession session) { }

	[CompilerGenerated]
	private void <Init>b__31_0(ExpansionsBrowserPageOpenedEvent _) { }

	[CompilerGenerated]
	private void <Init>b__31_1() { }

	[CompilerGenerated]
	public void add_dataUpdated(Action value) { }

	private void ApplyExpansionsNotification(NotificationExpansions notification) { }

	public void Dispose() { }

	[CompilerGenerated]
	public int get_FreeOffersCount() { }

	[CompilerGenerated]
	public bool get_IsExpansionsAvailable() { }

	[CompilerGenerated]
	public bool get_IsExpansionsEnabled() { }

	[CompilerGenerated]
	public int get_NewOffersCount() { }

	[CompilerGenerated]
	public int get_SaleOffersCount() { }

	[CompilerGenerated]
	public int get_TarcoinsCount() { }

	[AsyncStateMachine(typeof(<Init>d__31))]
	public Task Init() { }

	private void NotificationReceivedHandler(Notification notification) { }

	public void OnDataUpdated(ExpansionsPlayerData data) { }

	private void OnExpansionsBrowserPageOpened() { }

	private void OnOffersUpdated(int newOffersCount, int freeOffersCount, int saleOffersCount) { }

	[AsyncStateMachine(typeof(<RefreshExpansionsPlayerDataAsync>d__33))]
	private Task RefreshExpansionsPlayerDataAsync() { }

	[CompilerGenerated]
	public void remove_dataUpdated(Action value) { }

	[CompilerGenerated]
	private void set_FreeOffersCount(int value) { }

	[CompilerGenerated]
	private void set_IsExpansionsAvailable(bool value) { }

	[CompilerGenerated]
	private void set_IsExpansionsEnabled(bool value) { }

	[CompilerGenerated]
	private void set_NewOffersCount(int value) { }

	[CompilerGenerated]
	private void set_SaleOffersCount(int value) { }

	[CompilerGenerated]
	private void set_TarcoinsCount(int value) { }

	private void SetTarcoinsCount(int tarcoinsCount) { }

	private void SetUniversalDocumentsCount(int count) { }

}

