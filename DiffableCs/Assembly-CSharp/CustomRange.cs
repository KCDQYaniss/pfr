//Type is in global namespace

public struct CustomRange
{
	public float min; //Field offset: 0x0
	public float max; //Field offset: 0x4

	public CustomRange(float min, float max) { }

	public static CustomRange op_Addition(CustomRange c1, CustomRange c2) { }

	public static CustomRange op_Subtraction(CustomRange c1, CustomRange c2) { }

}

