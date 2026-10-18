namespace EFT.Quests;

public sealed class CompletedConditionsCollection
{
	private readonly HashSet _backendData; //Field offset: 0x10
	private readonly HashSet _localChanges; //Field offset: 0x18

	public IEnumerable LocalChanges
	{
		 get { } //Length: 5
	}

	public CompletedConditionsCollection(in HashSet backendData = null) { }

	public bool Add(Condition condition) { }

	public void Clear() { }

	public bool Contains(Condition condition) { }

	public IEnumerable get_LocalChanges() { }

	public bool Remove(Condition condition) { }

}

