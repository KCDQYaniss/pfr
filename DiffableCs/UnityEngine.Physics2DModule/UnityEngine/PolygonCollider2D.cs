namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/PolygonCollider2D.h")]
public sealed class PolygonCollider2D : Collider2D
{

	public int pathCount
	{
		 get { } //Length: 78
	}

	public int get_pathCount() { }

	public Vector2[] GetPath(int index) { }

	[NativeMethod("GetPath_Binding")]
	private Vector2[] GetPath_Internal(int index) { }

	[NativeMethod("GetPointCount")]
	public int GetTotalPointCount() { }

}

