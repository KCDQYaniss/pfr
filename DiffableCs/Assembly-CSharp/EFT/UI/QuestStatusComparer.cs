namespace EFT.UI;

public sealed class QuestStatusComparer : IComparer
{
	private readonly bool _checkNull; //Field offset: 0x10

	public QuestStatusComparer(bool checkNull = false) { }

	public override int Compare(Quest x, Quest y) { }

}

