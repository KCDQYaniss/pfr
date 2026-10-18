namespace UnityEngine;

[NativeHeader("Runtime/Export/Networking/Ping.bindings.h")]
public sealed class Ping
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public bool isDone
	{
		 get { } //Length: 93
	}

	public int time
	{
		 get { } //Length: 78
	}

	public Ping(string address) { }

	[ThreadAndSerializationSafe]
	public void DestroyPing() { }

	protected virtual void Finalize() { }

	public bool get_isDone() { }

	public int get_time() { }

	[FreeFunction("CreatePing")]
	private static IntPtr Internal_Create(string address) { }

	[FreeFunction("DestroyPing", IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr ptr) { }

	[NativeName("GetIsDone")]
	private bool Internal_IsDone() { }

}

