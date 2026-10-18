//Type is in global namespace

[GenerateBinarySerialization]
public sealed class ClassQuaternion
{
	public float x; //Field offset: 0x10
	public float y; //Field offset: 0x14
	public float z; //Field offset: 0x18
	public float w; //Field offset: 0x1C

	public ClassQuaternion() { }

	public static ClassQuaternion FromUnityQuaternion(Quaternion q) { }

	public static Quaternion op_Implicit(ClassQuaternion q) { }

	public static ClassQuaternion op_Implicit(Quaternion q) { }

	public Quaternion ToUnityQuaternion() { }

}

