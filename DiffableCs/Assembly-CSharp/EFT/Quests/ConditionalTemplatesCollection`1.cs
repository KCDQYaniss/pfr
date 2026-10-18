namespace EFT.Quests;

public abstract class ConditionalTemplatesCollection`1 : IReadOnlyCollection, IEnumerable, IEnumerable
{
	protected readonly List _templates; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 26
	}

	protected ConditionalTemplatesCollection`1() { }

	public bool Add(TTemplate template) { }

	public void AddRange(IEnumerable templates) { }

	public void Clear() { }

	public abstract bool Contains(TTemplate template) { }

	public override int get_Count() { }

	public override IEnumerator GetEnumerator() { }

	public abstract void Remove(TTemplate template) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

