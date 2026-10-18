//Type is in global namespace

public sealed class ObjectPool`1 : IDisposable
{
	private readonly Queue _pool; //Field offset: 0x0
	private readonly Func _constructor; //Field offset: 0x0
	private readonly Action _onReturnInPool; //Field offset: 0x0
	private readonly Action _destructor; //Field offset: 0x0

	public ObjectPool`1(int size, Func constructor, Action onReturnInPool = null, Action destructor = null) { }

	public override void Dispose() { }

	public void Return(T t) { }

	public T Withdraw() { }

}

