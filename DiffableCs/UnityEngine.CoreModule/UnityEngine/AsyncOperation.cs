namespace UnityEngine;

[NativeHeader("Runtime/Misc/AsyncOperation.h")]
[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
[RequiredByNativeCode]
public class AsyncOperation : YieldInstruction
{
	internal IntPtr m_Ptr; //Field offset: 0x10
	private Action m_completeCallback; //Field offset: 0x18

	public event Action completed
	{
		 add { } //Length: 371
		 remove { } //Length: 245
	}

	public bool allowSceneActivation
	{
		[NativeMethod("GetAllowSceneActivation")]
		 get { } //Length: 78
		[NativeMethod("SetAllowSceneActivation")]
		 set { } //Length: 93
	}

	public bool isDone
	{
		[NativeMethod("IsDone")]
		 get { } //Length: 78
	}

	public int priority
	{
		[NativeMethod("SetPriority")]
		 set { } //Length: 91
	}

	public float progress
	{
		[NativeMethod("GetProgress")]
		 get { } //Length: 78
	}

	public AsyncOperation() { }

	public void add_completed(Action value) { }

	protected virtual void Finalize() { }

	[NativeMethod("GetAllowSceneActivation")]
	public bool get_allowSceneActivation() { }

	[NativeMethod("IsDone")]
	public bool get_isDone() { }

	[NativeMethod("GetProgress")]
	public float get_progress() { }

	[NativeMethod(IsThreadSafe = True)]
	[StaticAccessor("AsyncOperationBindings", StaticAccessorType::DoubleColon (2))]
	private static void InternalDestroy(IntPtr ptr) { }

	[RequiredByNativeCode]
	internal void InvokeCompletionEvent() { }

	public void remove_completed(Action value) { }

	[NativeMethod("SetAllowSceneActivation")]
	public void set_allowSceneActivation(bool value) { }

	[NativeMethod("SetPriority")]
	public void set_priority(int value) { }

}

