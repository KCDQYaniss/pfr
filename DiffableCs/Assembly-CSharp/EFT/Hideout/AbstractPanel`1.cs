namespace EFT.Hideout;

public abstract class AbstractPanel`1 : UIElement, IAreaRelatedPanel, IUIView, IDisposable
{
	[CompilerGenerated]
	private struct <Show>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public AbstractPanel <>4__this; //Field offset: 0x0
		public RelatedData relatedData; //Field offset: 0x0
		public Stage stage; //Field offset: 0x0
		public ELevelType levelType; //Field offset: 0x0
		public AreaData areaData; //Field offset: 0x0
		public InventoryController inventoryController; //Field offset: 0x0
		public IEftSession session; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private T <Info>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ELevelType <LevelType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Stage <Stage>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private RelatedData <RelatedData>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private AreaData <AreaData>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private InventoryController <InventoryController>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private IEftSession <Session>k__BackingField; //Field offset: 0x0

	protected private AreaData AreaData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private T Info
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	protected private InventoryController InventoryController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private ELevelType LevelType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	protected private RelatedData RelatedData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private IEftSession Session
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private Stage Stage
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected AbstractPanel`1() { }

	[CompilerGenerated]
	private void <Show>b__28_0(bool silent) { }

	[CompilerGenerated]
	protected AreaData get_AreaData() { }

	[CompilerGenerated]
	protected T get_Info() { }

	[CompilerGenerated]
	protected InventoryController get_InventoryController() { }

	[CompilerGenerated]
	protected ELevelType get_LevelType() { }

	[CompilerGenerated]
	protected RelatedData get_RelatedData() { }

	[CompilerGenerated]
	protected IEftSession get_Session() { }

	[CompilerGenerated]
	protected Stage get_Stage() { }

	[CompilerGenerated]
	private void set_AreaData(AreaData value) { }

	[CompilerGenerated]
	private void set_Info(T value) { }

	[CompilerGenerated]
	private void set_InventoryController(InventoryController value) { }

	[CompilerGenerated]
	private void set_LevelType(ELevelType value) { }

	[CompilerGenerated]
	private void set_RelatedData(RelatedData value) { }

	[CompilerGenerated]
	private void set_Session(IEftSession value) { }

	[CompilerGenerated]
	private void set_Stage(Stage value) { }

	public abstract void SetInfo() { }

	[AsyncStateMachine(typeof(<Show>d__28))]
	public override Task Show(RelatedData relatedData, Stage stage, ELevelType levelType, AreaData areaData, InventoryController inventoryController, IEftSession session) { }

	public abstract Task ShowContents() { }

}

