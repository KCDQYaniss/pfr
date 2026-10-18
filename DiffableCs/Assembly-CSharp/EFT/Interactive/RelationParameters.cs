namespace EFT.Interactive;

public struct RelationParameters
{
	public EVolumeRelationsMask RelationType; //Field offset: 0x0
	public float Audibility; //Field offset: 0x4
	public bool UseManualAudibilitySettings; //Field offset: 0x8

	public bool HasConnectedFlag
	{
		 get { } //Length: 7
	}

	public bool HasIsolatedFlag
	{
		 get { } //Length: 7
	}

	public bool HasNone
	{
		 get { } //Length: 7
	}

	public bool HasSelfFlag
	{
		 get { } //Length: 6
	}

	public bool HasStairsFlag
	{
		 get { } //Length: 7
	}

	public bool HasVerticalFlag
	{
		 get { } //Length: 7
	}

	public bool get_HasConnectedFlag() { }

	public bool get_HasIsolatedFlag() { }

	public bool get_HasNone() { }

	public bool get_HasSelfFlag() { }

	public bool get_HasStairsFlag() { }

	public bool get_HasVerticalFlag() { }

}

