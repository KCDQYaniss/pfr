//Type is in global namespace

[GenerateBinarySerialization]
public class ClassTransformSync
{
	public ClassVector3 Position; //Field offset: 0x10
	public ClassQuaternion Rotation; //Field offset: 0x18

	public ClassTransformSync() { }

	public static ClassTransformSync FromUnity(TransformSync transformSync) { }

	public static ClassTransformSync[] FromUnity(TransformSync[] syncs) { }

	public TransformSync ToUnity() { }

	public static TransformSync[] ToUnity(ClassTransformSync[] syncs) { }

}

