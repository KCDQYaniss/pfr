namespace EFT.GameTriggers;

public abstract class TriggersEmitter : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Action onTriggerEvent; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal void <Subscribe>b__0(TriggerEvent _) { }

	}

	protected List _unsub; //Field offset: 0x10
	private readonly Dictionary _actionsMap; //Field offset: 0x18
	private readonly List _allTimeSubscribers; //Field offset: 0x20
	protected HashSet _ignoreTriggers; //Field offset: 0x28

	public static TriggersEmitter Instance
	{
		 get { } //Length: 64
	}

	protected TriggersEmitter() { }

	public override void Dispose() { }

	public abstract void Emit(string triggerId, int originPlayerRaidId) { }

	public static TriggersEmitter get_Instance() { }

	private void OnTriggerEvent(TriggerEvent triggerEvent) { }

	public void SetTriggerState(string triggerId, bool state) { }

	public void Subscribe(string triggerId, Action onTriggerEvent) { }

	public void Subscribe(string triggerId, Action onTriggerEvent) { }

	public void Subscribe(Action onTriggerEvent) { }

	public void Subscribe(IEnumerable triggerIds, Action onTriggerEvent) { }

}

