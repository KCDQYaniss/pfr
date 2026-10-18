//Type is in global namespace

public class GroupPointSearchData : IComparable
{
	public GroupPoint Point; //Field offset: 0x10
	public float Power; //Field offset: 0x18
	[CompilerGenerated]
	private bool <CanIShootToEnemy>k__BackingField; //Field offset: 0x1C
	public ECoverCheckCause Cause; //Field offset: 0x20

	public bool AlwaysGood
	{
		 get { } //Length: 27
	}

	public bool CanIShootToEnemy
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Vector3 FirePosition
	{
		 get { } //Length: 41
	}

	public bool IsSpotted
	{
		 get { } //Length: 29
	}

	public GroupPointSearchData(GroupPoint p, float power) { }

	public override int CompareTo(GroupPointSearchData other) { }

	public bool get_AlwaysGood() { }

	[CompilerGenerated]
	public bool get_CanIShootToEnemy() { }

	public Vector3 get_FirePosition() { }

	public bool get_IsSpotted() { }

	[CompilerGenerated]
	public void set_CanIShootToEnemy(bool value) { }

}

