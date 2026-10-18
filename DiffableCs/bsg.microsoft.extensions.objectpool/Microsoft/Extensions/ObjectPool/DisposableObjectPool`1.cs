namespace Microsoft.Extensions.ObjectPool;

public sealed class DisposableObjectPool`1 : DefaultObjectPool, IDisposable
{
	private bool _isDisposed; //Field offset: 0x0

	public DisposableObjectPool`1(IPooledObjectPolicy policy) { }

	public DisposableObjectPool`1(IPooledObjectPolicy policy, int maximumRetained) { }

	[CompilerGenerated]
	private void <Get>g__ThrowObjectDisposedException|3_0() { }

	public override void Dispose() { }

	private void DisposeItem(T item) { }

	public virtual T Get() { }

	public virtual void Return(T obj) { }

	private bool ReturnCore(T obj) { }

}

