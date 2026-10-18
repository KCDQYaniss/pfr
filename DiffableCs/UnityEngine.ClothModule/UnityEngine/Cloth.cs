namespace UnityEngine;

[NativeClass("Unity::Cloth")]
[NativeHeader("Modules/Cloth/Cloth.h")]
[RequireComponent(typeof(Transform), typeof(SkinnedMeshRenderer))]
public sealed class Cloth : Component
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <useContinuousCollision>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly bool <selfCollision>k__BackingField; //Field offset: 0x1C

	public Vector3[] vertices
	{
		[NativeName("GetPositions")]
		 get { } //Length: 78
	}

	[NativeName("GetPositions")]
	public Vector3[] get_vertices() { }

}

