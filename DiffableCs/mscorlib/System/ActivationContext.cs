namespace System;

[ComVisible(False)]
public sealed class ActivationContext : IDisposable, ISerializable
{
	private bool _disposed; //Field offset: 0x10

	internal ActivationContext() { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	[MonoTODO("Missing serialization support")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

