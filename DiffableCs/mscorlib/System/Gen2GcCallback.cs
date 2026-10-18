namespace System;

internal sealed class Gen2GcCallback : CriticalFinalizerObject
{
	private Func _callback; //Field offset: 0x10
	private GCHandle _weakTargetObj; //Field offset: 0x18

	private Gen2GcCallback() { }

	protected virtual void Finalize() { }

	public static void Register(Func callback, object targetObj) { }

	private void Setup(Func callback, object targetObj) { }

}

