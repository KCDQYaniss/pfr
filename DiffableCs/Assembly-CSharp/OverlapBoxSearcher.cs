//Type is in global namespace

public class OverlapBoxSearcher : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public int id; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal bool <SyncCollider>b__0(OBBTrigger t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public BoxCollider collider; //Field offset: 0x10
		public int id; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal bool <RemoveCollider>b__0(KeyValuePair kv) { }

		internal bool <RemoveCollider>b__1(OBBTrigger el) { }

	}

	internal struct ScheduledExecute : IDisposable
	{
		public OverlapBoxSearcher Searcher; //Field offset: 0x0
		public int CommandsCount; //Field offset: 0x8
		public OverlapBoxJob Job; //Field offset: 0xC
		public JobHandle Handle; //Field offset: 0x10

		public override void Dispose() { }

	}

	public static int PARAMS_INDEX_COUNTER; //Field offset: 0x0
	private const int MAX_COLLIDERS_CAPACITY = 2048; //Field offset: 0x0
	private const int COLLIDER_CAPACITY = 32; //Field offset: 0x0
	private const int MAX_COMMANDS_TO_EXECUTE = 128; //Field offset: 0x0
	private readonly HashSet _colliders; //Field offset: 0x10
	private readonly Dictionary _links; //Field offset: 0x18
	private readonly List _triggers; //Field offset: 0x20
	private readonly BoxOverlapCommandResult[] _commandsResultStage0; //Field offset: 0x28
	private readonly BoxOverlapCommandResult[] _commandsResultStage1; //Field offset: 0x30
	private BoxOverlapCommand[] _commandsStage0; //Field offset: 0x38
	private BoxOverlapCommand[] _commandsStage1; //Field offset: 0x40
	private int _commandsCount; //Field offset: 0x48
	private readonly int _paramsIndex; //Field offset: 0x4C
	private int _triggersIdCounter; //Field offset: 0x50
	private bool _needRebuildTriggers; //Field offset: 0x54
	private int _stage; //Field offset: 0x58
	[CompilerGenerated]
	private bool <HaveCriticalTriggersCount>k__BackingField; //Field offset: 0x5C

	private BoxOverlapCommandResult[] CommandsResultPrev
	{
		private get { } //Length: 16
	}

	public private bool HaveCriticalTriggersCount
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private OverlapBoxJobParameters JobParams
	{
		private get { } //Length: 119
	}

	public int RegisteredTriggersCount
	{
		 get { } //Length: 65
	}

	public OverlapBoxSearcher() { }

	public void BoxOverlap(int index, Vector3 center, Vector3 halfExtents, Quaternion orientation, Collider[] result, int mask, QueryTriggerInteraction queryTriggerInteraction, AwaitMultiWorldsOverlapBoxAsyncData asyncData) { }

	private void CheckTriggersCorrect() { }

	public void Clear() { }

	private OBBTrigger CreateTrigger(int id, BoxCollider collider) { }

	public override void Dispose() { }

	private BoxOverlapCommandResult[] get_CommandsResultPrev() { }

	[CompilerGenerated]
	public bool get_HaveCriticalTriggersCount() { }

	private OverlapBoxJobParameters get_JobParams() { }

	public int get_RegisteredTriggersCount() { }

	private BoxCollider GetColliderById(int id) { }

	private void NextStage() { }

	public Nullable RegisterCollider(BoxCollider collider) { }

	public void RemoveCollider(BoxCollider collider) { }

	public ScheduledExecute Schedule() { }

	[CompilerGenerated]
	private void set_HaveCriticalTriggersCount(bool value) { }

	public void SyncCollider(int id, BoxCollider collider) { }

	public void WaitScheduleComplete(ScheduledExecute scheduled) { }

}

