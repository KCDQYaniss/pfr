namespace Dissonance.Datastructures;

public class ConcurrentPool`1 : IRecycler
{
	private readonly Func _factory; //Field offset: 0x0
	private readonly TransferBuffer _items; //Field offset: 0x0
	private readonly ReadonlyLockedValue _getter; //Field offset: 0x0
	private readonly ReadonlyLockedValue _putter; //Field offset: 0x0

	public ConcurrentPool`1(int maxSize, Func factory) { }

	private override void Dissonance.Datastructures.IRecycler<T>.Recycle(T item) { }

	[NotNull]
	public T Get() { }

	public void Put(T item) { }

}

