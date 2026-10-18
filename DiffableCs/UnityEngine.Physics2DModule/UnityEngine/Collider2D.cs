namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode(Optional = True)]
public class Collider2D : Behaviour
{

	public Rigidbody2D attachedRigidbody
	{
		[NativeMethod("GetAttachedRigidbody_Binding")]
		 get { } //Length: 78
	}

	public Vector2 offset
	{
		 get { } //Length: 95
	}

	[NativeMethod("GetAttachedRigidbody_Binding")]
	public Rigidbody2D get_attachedRigidbody() { }

	public Vector2 get_offset() { }

	private void get_offset_Injected(out Vector2 ret) { }

	public bool OverlapPoint(Vector2 point) { }

	private bool OverlapPoint_Injected(ref Vector2 point) { }

}

