//Type is in global namespace

public class BotsConnections
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public BotsConnections <>4__this; //Field offset: 0x10
		public BotOwner bot; //Field offset: 0x18
		public Action <>9__2; //Field offset: 0x20

		public <>c__DisplayClass12_0() { }

		internal void <AddPerson>b__0(IBotOwner follower, FollowerStatusChange status) { }

		internal void <AddPerson>b__1(BotOwner owner) { }

		internal void <AddPerson>b__2(IBotOwner follower, FollowerStatusChange b) { }

	}

	private const float DELAY_TO_CHECK = 2; //Field offset: 0x0
	private Dictionary _bots; //Field offset: 0x10
	private ITimer _timer; //Field offset: 0x18
	private readonly Dictionary _data; //Field offset: 0x20
	private readonly List _allPairs; //Field offset: 0x28
	private readonly HashSet _toRemove; //Field offset: 0x30
	private bool _haveSmtToRemove; //Field offset: 0x38
	private bool _isActive; //Field offset: 0x39

	public BotsConnections() { }

	public void Activate() { }

	public void AddPerson(IPlayer gamePerson) { }

	private void CheckAllBossFollowers(BotOwner boss) { }

	[CanBeNull]
	public BotsPairData GetClosest(IPlayer gamePerson) { }

	public List GetClosest(IPlayer gamePerson, float dist) { }

	public void ManualUpdate() { }

	private void OnFollowerStatusChange(IBotOwner follower, BotOwner boss, FollowerStatusChange status) { }

	public void Remove(IPlayer gamePerson) { }

	private void RemoveBossAndFollowerInteraction(BotsPairData botsPairData, BotOwner boss) { }

	private void RemoveInner() { }

	public void Stop() { }

	private void UpdateData() { }

}

