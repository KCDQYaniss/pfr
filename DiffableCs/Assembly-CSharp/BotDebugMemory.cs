//Type is in global namespace

public class BotDebugMemory
{
	public DebugCoversChecker DebugCoversChecker; //Field offset: 0x10
	public EditorsCoverPointDebugData EditorsCoverPointDebugData; //Field offset: 0x18
	private LastCoversSearchData _lastCoversSearchData; //Field offset: 0x20
	private readonly BotOwner _owner; //Field offset: 0x28
	private readonly HashSet _searchBeforeHide; //Field offset: 0x30

	public BotDebugMemory(BotOwner owner) { }

	public void Dispose() { }

	public string GetLastNode() { }

	public void Init() { }

	public void SetLastSearch(HashSet nearGroups, Vector3 CenterPos, CustomNavigationPoint betterPoint) { }

	public void SetLastSearchBeforeHide(HashSet nearGroups) { }

	public void Stuck(Vector3 position) { }

	public void TryDrawLastSearchData() { }

}

