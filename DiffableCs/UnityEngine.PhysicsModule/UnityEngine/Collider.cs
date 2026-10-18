namespace UnityEngine;

[NativeHeader("Modules/Physics/Collider.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode]
public class Collider : Component
{

	public Rigidbody attachedRigidbody
	{
		[NativeMethod("GetRigidbody")]
		 get { } //Length: 78
	}

	public Bounds bounds
	{
		 get { } //Length: 108
	}

	public float contactOffset
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public bool enabled
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public bool isTrigger
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public PhysicMaterial material
	{
		[NativeMethod("SetMaterial")]
		 set { } //Length: 93
	}

	[NativeMethod("Material")]
	public PhysicMaterial sharedMaterial
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public Collider() { }

	public Vector3 ClosestPoint(Vector3 position) { }

	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	[NativeMethod("GetRigidbody")]
	public Rigidbody get_attachedRigidbody() { }

	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	public float get_contactOffset() { }

	public bool get_enabled() { }

	public bool get_isTrigger() { }

	public PhysicMaterial get_sharedMaterial() { }

	[NativeName("ClosestPointOnBounds")]
	private void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	private void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }

	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	public void set_contactOffset(float value) { }

	public void set_enabled(bool value) { }

	public void set_isTrigger(bool value) { }

	[NativeMethod("SetMaterial")]
	public void set_material(PhysicMaterial value) { }

	public void set_sharedMaterial(PhysicMaterial value) { }

}

