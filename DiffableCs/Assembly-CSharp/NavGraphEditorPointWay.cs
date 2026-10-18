//Type is in global namespace

public class NavGraphEditorPointWay : IComparable
{
	public int TargetPointId; //Field offset: 0x10
	public int StartPointId; //Field offset: 0x14
	public int PathId; //Field offset: 0x18
	public int Id; //Field offset: 0x1C
	public int ReverseId; //Field offset: 0x20
	public NavGraphEditorPoint StartPoint; //Field offset: 0x28
	public NavGraphEditorPoint TargetPoint; //Field offset: 0x30
	public NavGraphEditorPath Path; //Field offset: 0x38
	public NavGraphEditorPointWay Reverse; //Field offset: 0x40

	public float Value
	{
		 get { } //Length: 33
	}

	public NavGraphEditorPointWay(NavGraphEditorPoint targetPoint, NavGraphEditorPoint startPoint, NavGraphEditorPath path, int id) { }

	public override int CompareTo(NavGraphEditorPointWay other) { }

	public float get_Value() { }

}

