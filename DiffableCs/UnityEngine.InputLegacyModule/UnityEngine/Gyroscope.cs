namespace UnityEngine;

[NativeHeader("Runtime/Input/GetInput.h")]
public class Gyroscope
{
	private int m_GyroIndex; //Field offset: 0x10

	public bool enabled
	{
		 set { } //Length: 92
	}

	public Vector3 rotationRateUnbiased
	{
		 get { } //Length: 131
	}

	internal Gyroscope(int index) { }

	public Vector3 get_rotationRateUnbiased() { }

	[FreeFunction("GetGyroRotationRateUnbiased")]
	private static Vector3 rotationRateUnbiased_Internal(int idx) { }

	private static void rotationRateUnbiased_Internal_Injected(int idx, out Vector3 ret) { }

	public void set_enabled(bool value) { }

	[FreeFunction("SetGyroEnabled")]
	private static void setEnabled_Internal(int idx, bool enabled) { }

}

