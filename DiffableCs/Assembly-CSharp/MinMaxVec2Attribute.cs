//Type is in global namespace

public class MinMaxVec2Attribute : PropertyAttribute
{
	public readonly float Min; //Field offset: 0x18
	public readonly float Max; //Field offset: 0x1C
	public readonly float Round; //Field offset: 0x20
	public readonly float InvRound; //Field offset: 0x24
	public readonly bool UseRound; //Field offset: 0x28

	public MinMaxVec2Attribute(float min, float max, float round = -1) { }

}

