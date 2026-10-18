namespace UnityEngine;

[NativeHeader("Modules/Physics/Rigidbody.h")]
[RequireComponent(typeof(Transform))]
public class Rigidbody : Component
{

	public float angularDrag
	{
		 set { } //Length: 94
	}

	public Vector3 angularVelocity
	{
		 get { } //Length: 104
		 set { } //Length: 93
	}

	public Vector3 centerOfMass
	{
		 get { } //Length: 104
	}

	public CollisionDetectionMode collisionDetectionMode
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public RigidbodyConstraints constraints
	{
		 set { } //Length: 91
	}

	public bool detectCollisions
	{
		 set { } //Length: 93
	}

	public float drag
	{
		 set { } //Length: 94
	}

	public LayerMask excludeLayers
	{
		 set { } //Length: 86
	}

	public Vector3 inertiaTensor
	{
		 get { } //Length: 104
	}

	public RigidbodyInterpolation interpolation
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public bool isKinematic
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public float mass
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public float maxAngularVelocity
	{
		 get { } //Length: 78
	}

	public float maxDepenetrationVelocity
	{
		 set { } //Length: 94
	}

	public Vector3 position
	{
		 get { } //Length: 104
		 set { } //Length: 93
	}

	public Quaternion rotation
	{
		 get { } //Length: 102
		 set { } //Length: 93
	}

	public bool useGravity
	{
		 set { } //Length: 93
	}

	public Vector3 velocity
	{
		 get { } //Length: 104
		 set { } //Length: 93
	}

	public Vector3 worldCenterOfMass
	{
		 get { } //Length: 104
	}

	public Rigidbody() { }

	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	private void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddForce(Vector3 force) { }

	public void AddForce(Vector3 force, ForceMode mode) { }

	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddForceAtPosition(Vector3 force, Vector3 position) { }

	private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) { }

	public void AddRelativeForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddRelativeForce(Vector3 force) { }

	private void AddRelativeForce_Injected(ref Vector3 force, ForceMode mode) { }

	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	[ExcludeFromDocs]
	public void AddRelativeTorque(Vector3 torque) { }

	private void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	public void AddTorque(Vector3 torque, ForceMode mode) { }

	private void AddTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	public Vector3 get_angularVelocity() { }

	private void get_angularVelocity_Injected(out Vector3 ret) { }

	public Vector3 get_centerOfMass() { }

	private void get_centerOfMass_Injected(out Vector3 ret) { }

	public CollisionDetectionMode get_collisionDetectionMode() { }

	public Vector3 get_inertiaTensor() { }

	private void get_inertiaTensor_Injected(out Vector3 ret) { }

	public RigidbodyInterpolation get_interpolation() { }

	public bool get_isKinematic() { }

	public float get_mass() { }

	public float get_maxAngularVelocity() { }

	public Vector3 get_position() { }

	private void get_position_Injected(out Vector3 ret) { }

	public Quaternion get_rotation() { }

	private void get_rotation_Injected(out Quaternion ret) { }

	public Vector3 get_velocity() { }

	private void get_velocity_Injected(out Vector3 ret) { }

	public Vector3 get_worldCenterOfMass() { }

	private void get_worldCenterOfMass_Injected(out Vector3 ret) { }

	public Vector3 GetPointVelocity(Vector3 worldPoint) { }

	private void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret) { }

	public bool IsSleeping() { }

	public void MovePosition(Vector3 position) { }

	private void MovePosition_Injected(ref Vector3 position) { }

	public void MoveRotation(Quaternion rot) { }

	private void MoveRotation_Injected(ref Quaternion rot) { }

	public void ResetInertiaTensor() { }

	public void set_angularDrag(float value) { }

	public void set_angularVelocity(Vector3 value) { }

	private void set_angularVelocity_Injected(ref Vector3 value) { }

	public void set_collisionDetectionMode(CollisionDetectionMode value) { }

	public void set_constraints(RigidbodyConstraints value) { }

	public void set_detectCollisions(bool value) { }

	public void set_drag(float value) { }

	public void set_excludeLayers(LayerMask value) { }

	private void set_excludeLayers_Injected(ref LayerMask value) { }

	public void set_interpolation(RigidbodyInterpolation value) { }

	public void set_isKinematic(bool value) { }

	public void set_mass(float value) { }

	public void set_maxDepenetrationVelocity(float value) { }

	public void set_position(Vector3 value) { }

	private void set_position_Injected(ref Vector3 value) { }

	public void set_rotation(Quaternion value) { }

	private void set_rotation_Injected(ref Quaternion value) { }

	public void set_useGravity(bool value) { }

	public void set_velocity(Vector3 value) { }

	private void set_velocity_Injected(ref Vector3 value) { }

	public void Sleep() { }

	public void WakeUp() { }

}

