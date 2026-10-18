namespace MultiFlare;

public class FlareOverlapSettings : BatchSettings
{
	[SerializeField]
	private int _maxNeighborCount; //Field offset: 0x38
	[SerializeField]
	private float _searchRange; //Field offset: 0x3C
	[SerializeField]
	private float _maxScaleMultiplier; //Field offset: 0x40

	public int MaxNeighborCount
	{
		 get { } //Length: 4
	}

	public float MaxScaleMultiplier
	{
		 get { } //Length: 6
	}

	public float SearchRange
	{
		 get { } //Length: 6
	}

	public FlareOverlapSettings() { }

	public int get_MaxNeighborCount() { }

	public float get_MaxScaleMultiplier() { }

	public float get_SearchRange() { }

}

