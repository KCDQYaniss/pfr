namespace EFT.SynchronizableObjects;

public class SynchronizableObjectLogicProcessor : IDisposable
{
	[CompilerGenerated]
	private sealed class <GetSynchronizableObjects>d__12 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private SynchronizableObject <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public SynchronizableObjectLogicProcessor <>4__this; //Field offset: 0x28
		private Enumerator <>7__wrap1; //Field offset: 0x30

		private override SynchronizableObject System.Collections.Generic.IEnumerator<EFT.SynchronizableObjects.SynchronizableObject>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetSynchronizableObjects>d__12(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.SynchronizableObjects.SynchronizableObject>.GetEnumerator() { }

		[DebuggerHidden]
		private override SynchronizableObject System.Collections.Generic.IEnumerator<EFT.SynchronizableObjects.SynchronizableObject>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	protected List _activeSynchronizableObjects; //Field offset: 0x10
	protected List _staticSynchronizableObjects; //Field offset: 0x18
	private LevelPhysicsSettings _settings; //Field offset: 0x20
	private byte _nextSynchronizedObjectId; //Field offset: 0x28
	internal IAirdropDataSender AirdropDataSender; //Field offset: 0x30
	public AirdropManager AirdropManager; //Field offset: 0x38
	public TripwireManager TripwireManager; //Field offset: 0x40

	public LevelPhysicsSettings Settings
	{
		 get { } //Length: 305
	}

	public byte TakeSynchronizedObjectId
	{
		 get { } //Length: 121
	}

	public SynchronizableObjectLogicProcessor() { }

	public override void Dispose() { }

	public LevelPhysicsSettings get_Settings() { }

	public byte get_TakeSynchronizedObjectId() { }

	[IteratorStateMachine(typeof(<GetSynchronizableObjects>d__12))]
	public IEnumerable GetSynchronizableObjects() { }

	public static ISynchronizableLogic GetSyncObjectStrategyByType(SynchronizableObjectType type) { }

	internal void Init(AirdropManager airdropManager, IAirdropDataSender data = null) { }

	public void InitStaticObject(SynchronizableObject synchronizableObject) { }

	public void InitSyncObject(SynchronizableObject syncObject, Vector3 position, Vector3 rotation, int objectId = -1) { }

	public void ManualUpdate(float deltaTime) { }

	public void RemoveNonActiveAndStaticObjects() { }

	public void ReturnToPool(SynchronizableObject synchronizableObject) { }

	protected SynchronizableObject TakeFromPool(SynchronizableObjectPacket packet) { }

	public SynchronizableObject TakeFromPool(SynchronizableObjectType type) { }

	private void UpdateRequiredHandler(SynchronizableObject synchronizableObject) { }

	public void WriteSyncObjects(ref GameWorldPacket packet) { }

}

