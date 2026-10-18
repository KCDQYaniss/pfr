//Type is in global namespace

public class GroupPointWay : IComparable
{
	public GroupPoint Target; //Field offset: 0x10
	public float Dist; //Field offset: 0x18
	public int IdTarget; //Field offset: 0x1C
	public int Id; //Field offset: 0x20

	public GroupPointWay(int id, GroupPoint target, float dist) { }

	public override int CompareTo(GroupPointWay other) { }

	public void Restore(GroupPoint target) { }

}

