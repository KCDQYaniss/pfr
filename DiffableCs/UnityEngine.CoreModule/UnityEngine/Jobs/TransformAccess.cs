namespace UnityEngine.Jobs;

[NativeHeader("Runtime/Transform/ScriptBindings/TransformAccess.bindings.h")]
public struct TransformAccess
{
	private IntPtr hierarchy; //Field offset: 0x0
	private int index; //Field offset: 0x8

	public Vector3 localPosition
	{
		 get { } //Length: 132
		 set { } //Length: 93
	}

	public Quaternion localRotation
	{
		 get { } //Length: 120
		 set { } //Length: 93
	}

	public Vector3 position
	{
		 get { } //Length: 132
	}

	public Quaternion rotation
	{
		 get { } //Length: 120
	}

	public Vector3 get_localPosition() { }

	public Quaternion get_localRotation() { }

	public Vector3 get_position() { }

	public Quaternion get_rotation() { }

	[NativeMethod(Name = "TransformAccessBindings::GetLocalPosition", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	private static void GetLocalPosition(ref TransformAccess access, out Vector3 p) { }

	[NativeMethod(Name = "TransformAccessBindings::GetLocalRotation", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	private static void GetLocalRotation(ref TransformAccess access, out Quaternion r) { }

	[NativeMethod(Name = "TransformAccessBindings::GetPosition", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	private static void GetPosition(ref TransformAccess access, out Vector3 p) { }

	[NativeMethod(Name = "TransformAccessBindings::GetRotation", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	private static void GetRotation(ref TransformAccess access, out Quaternion r) { }

	public void set_localPosition(Vector3 value) { }

	public void set_localRotation(Quaternion value) { }

	[NativeMethod(Name = "TransformAccessBindings::SetLocalPosition", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	private static void SetLocalPosition(ref TransformAccess access, ref Vector3 p) { }

	[NativeMethod(Name = "TransformAccessBindings::SetLocalRotation", IsThreadSafe = True, IsFreeFunction = True, ThrowsException = True)]
	private static void SetLocalRotation(ref TransformAccess access, ref Quaternion r) { }

}

