namespace EFT.UI;

public sealed class QuestProgressComparer : IComparer
{
	private readonly Dictionary _progresses; //Field offset: 0x10
	private readonly bool _checkNull; //Field offset: 0x18

	public QuestProgressComparer(bool checkNull = false) { }

	public override int Compare(Quest x, Quest y) { }

}

