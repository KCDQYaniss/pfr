//Type is in global namespace

public class GroupPointPath : IComparable
{
	public float Dist; //Field offset: 0x10
	public int IdPath; //Field offset: 0x14
	public int IdB; //Field offset: 0x18
	public int IdA; //Field offset: 0x1C
	public GroupPointWay WayA; //Field offset: 0x20
	public GroupPointWay WayB; //Field offset: 0x28

	public GroupPointPath(float dist, int idPath, GroupPointWay wayA, GroupPointWay wayB) { }

	public override int CompareTo(GroupPointPath other) { }

}

