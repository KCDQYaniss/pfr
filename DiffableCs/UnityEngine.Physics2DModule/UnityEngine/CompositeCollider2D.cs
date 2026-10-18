namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/CompositeCollider2D.h")]
[RequireComponent(typeof(Rigidbody2D))]
public sealed class CompositeCollider2D : Collider2D
{

	public int pathCount
	{
		 get { } //Length: 78
	}

	public int pointCount
	{
		 get { } //Length: 78
	}

	public int get_pathCount() { }

	public int get_pointCount() { }

	public int GetPath(int index, Vector2[] points) { }

	[NativeMethod("GetPathArray_Binding")]
	private int GetPathArray_Internal(int index, Vector2[] points) { }

}

