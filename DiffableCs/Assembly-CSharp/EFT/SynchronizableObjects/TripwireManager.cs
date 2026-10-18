namespace EFT.SynchronizableObjects;

public sealed class TripwireManager : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public int objectId; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <GetTripwireById>b__0(TripwireSynchronizableObject tripwire) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public int netId; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <TriggerTripwireByHit>b__0(TripwireSynchronizableObject foundTripwire) { }

	}

	private List _tripwires; //Field offset: 0x10
	private ISyncEnvironment _gameWorld; //Field offset: 0x18

	public TripwireManager(ISyncEnvironment gameWorld) { }

	public void AddTripwire(TripwireSynchronizableObject tripwire) { }

	public override void Dispose() { }

	public TripwireSynchronizableObject GetTripwireById(int objectId) { }

	public void RemoveTripwire(TripwireSynchronizableObject tripwire) { }

	public void TriggerTripwireByHit(int netId, IPlayer player) { }

}

