namespace EFT.UI;

public sealed class QuestSpecificOrderComparer : IComparer
{
	private readonly Dictionary _order; //Field offset: 0x10
	private readonly bool _checkNull; //Field offset: 0x18

	public QuestSpecificOrderComparer(Dictionary order, bool checkNull = false) { }

	public override int Compare(Quest x, Quest y) { }

}

