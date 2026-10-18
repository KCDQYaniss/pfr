//Type is in global namespace

public class MinMaxVec2IntAttribute : PropertyAttribute
{
	public readonly float Min; //Field offset: 0x18
	public readonly float Max; //Field offset: 0x1C

	public MinMaxVec2IntAttribute(int min, int max) { }

}

