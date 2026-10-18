namespace UnityEngine.AI;

[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
[UsedByNativeCode]
public struct NavMeshBuildSource
{
	private Matrix4x4 m_Transform; //Field offset: 0x0
	private Vector3 m_Size; //Field offset: 0x40
	private NavMeshBuildSourceShape m_Shape; //Field offset: 0x4C
	private int m_Area; //Field offset: 0x50
	private int m_InstanceID; //Field offset: 0x54
	private int m_ComponentID; //Field offset: 0x58
	private int m_GenerateLinks; //Field offset: 0x5C

	public int area
	{
		 set { } //Length: 4
	}

	public Component component
	{
		 get { } //Length: 77
	}

	public NavMeshBuildSourceShape shape
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public Vector3 size
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public Object sourceObject
	{
		 get { } //Length: 77
	}

	public Matrix4x4 transform
	{
		 get { } //Length: 34
		 set { } //Length: 31
	}

	public Component get_component() { }

	public NavMeshBuildSourceShape get_shape() { }

	public Vector3 get_size() { }

	public Object get_sourceObject() { }

	public Matrix4x4 get_transform() { }

	[StaticAccessor("NavMeshBuildSource", StaticAccessorType::DoubleColon (2))]
	private static Component InternalGetComponent(int instanceID) { }

	[StaticAccessor("NavMeshBuildSource", StaticAccessorType::DoubleColon (2))]
	private static Object InternalGetObject(int instanceID) { }

	public void set_area(int value) { }

	public void set_shape(NavMeshBuildSourceShape value) { }

	public void set_size(Vector3 value) { }

	public void set_transform(Matrix4x4 value) { }

}

