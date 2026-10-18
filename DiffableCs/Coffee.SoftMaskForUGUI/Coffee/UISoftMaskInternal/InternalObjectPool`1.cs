namespace Coffee.UISoftMaskInternal;

internal class InternalObjectPool`1
{
	private readonly Predicate _onValid; //Field offset: 0x0
	private readonly ObjectPool _pool; //Field offset: 0x0

	public InternalObjectPool`1(Func onCreate, Predicate onValid, Action onReturn) { }

	public T Rent() { }

	public void Return(ref T instance) { }

}

