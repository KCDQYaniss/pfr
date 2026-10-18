//Type is in global namespace

[GenerateBinarySerialization]
public sealed class ClassVector3
{
	public float x; //Field offset: 0x10
	public float y; //Field offset: 0x14
	public float z; //Field offset: 0x18

	public ClassVector3() { }

	public static ClassVector3 FromUnityVector3(Vector3 v) { }

	public static Vector3 op_Implicit(ClassVector3 vec) { }

	public static ClassVector3 op_Implicit(Vector3 vec) { }

	public static Vector3 op_Subtraction(ClassVector3 a, ClassVector3 b) { }

	public Vector3 ToUnityVector3() { }

}

