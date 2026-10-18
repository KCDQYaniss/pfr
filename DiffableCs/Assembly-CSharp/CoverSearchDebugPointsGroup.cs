//Type is in global namespace

public class CoverSearchDebugPointsGroup : BotZoneDebugPointsGroup
{
	[SerializeField]
	private List _searchRadiuses; //Field offset: 0x58
	public float SpecialRadius; //Field offset: 0x60
	public bool DrawAll; //Field offset: 0x64

	public float SearchRadius
	{
		 get { } //Length: 137
	}

	public CoverSearchDebugPointsGroup(string label) { }

	public virtual void Draw() { }

	public float get_SearchRadius() { }

	public void SetRadius(string label, float radius) { }

}

