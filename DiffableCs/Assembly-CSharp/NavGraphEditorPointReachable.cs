//Type is in global namespace

public class NavGraphEditorPointReachable
{
	public HashSet Points; //Field offset: 0x10
	public int Id; //Field offset: 0x18
	[CompilerGenerated]
	private bool <Deprecate>k__BackingField; //Field offset: 0x1C

	public int Count
	{
		 get { } //Length: 65
	}

	public private bool Deprecate
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public NavGraphEditorPointReachable(int id, BaseReachablEditor baseReachablEditor) { }

	public void Add(NavGraphEditorPoint p) { }

	public int get_Count() { }

	[CompilerGenerated]
	public bool get_Deprecate() { }

	public bool IsReach(NavGraphEditorPoint finalPoint) { }

	[CompilerGenerated]
	private void set_Deprecate(bool value) { }

	public void SetDeprecated() { }

}

