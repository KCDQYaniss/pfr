namespace GPUInstancer;

public class GPUInstancerPrefabPrototype : GPUInstancerPrototype
{
	internal class RigidbodyData
	{
		public bool useGravity; //Field offset: 0x10
		public float angularDrag; //Field offset: 0x14
		public float mass; //Field offset: 0x18
		public RigidbodyConstraints constraints; //Field offset: 0x1C
		public float drag; //Field offset: 0x20
		public bool isKinematic; //Field offset: 0x24
		public RigidbodyInterpolation interpolation; //Field offset: 0x28

		public RigidbodyData() { }

	}

	public bool enableRuntimeModifications; //Field offset: 0x88
	public bool startWithRigidBody; //Field offset: 0x89
	public bool addRemoveInstancesAtRuntime; //Field offset: 0x8A
	public int extraBufferSize; //Field offset: 0x8C
	public bool addRuntimeHandlerScript; //Field offset: 0x90
	public bool hasRigidBody; //Field offset: 0x91
	public RigidbodyData rigidbodyData; //Field offset: 0x98
	public bool meshRenderersDisabled; //Field offset: 0xA0
	public bool isTransformsSerialized; //Field offset: 0xA1
	public TextAsset serializedTransformData; //Field offset: 0xA8
	public int serializedTransformDataCount; //Field offset: 0xB0

	public GPUInstancerPrefabPrototype() { }

}

