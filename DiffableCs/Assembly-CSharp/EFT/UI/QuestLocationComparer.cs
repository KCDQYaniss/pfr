namespace EFT.UI;

public sealed class QuestLocationComparer : IComparer
{
	private const string ANY_LOCATION_KEY = "any"; //Field offset: 0x0
	private readonly string _locationId; //Field offset: 0x10
	private readonly Dictionary _allLocations; //Field offset: 0x18
	private readonly bool _checkNull; //Field offset: 0x20

	public QuestLocationComparer(string locationId, Dictionary locations, bool checkNull = false) { }

	public override int Compare(Quest x, Quest y) { }

}

