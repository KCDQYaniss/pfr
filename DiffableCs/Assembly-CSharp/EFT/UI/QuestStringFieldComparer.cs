namespace EFT.UI;

public sealed class QuestStringFieldComparer : IComparer
{
	private readonly EQuestsSortType _sortType; //Field offset: 0x10
	private string _xField; //Field offset: 0x18
	private string _yField; //Field offset: 0x20
	private readonly bool _checkNull; //Field offset: 0x28

	public QuestStringFieldComparer(EQuestsSortType sortType, bool checkNull = false) { }

	public override int Compare(Quest x, Quest y) { }

}

