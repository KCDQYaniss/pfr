namespace System.Threading;

[IsReadOnly]
public struct CancellationTokenRegistration : IEquatable, IDisposable, IAsyncDisposable
{
	private readonly CancellationCallbackInfo m_callbackInfo; //Field offset: 0x0
	private readonly SparselyPopulatedArrayAddInfo m_registrationInfo; //Field offset: 0x8

	internal CancellationTokenRegistration(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo registrationInfo) { }

	public override void Dispose() { }

	public override ValueTask DisposeAsync() { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(CancellationTokenRegistration other) { }

	public virtual int GetHashCode() { }

	public bool Unregister() { }

}

