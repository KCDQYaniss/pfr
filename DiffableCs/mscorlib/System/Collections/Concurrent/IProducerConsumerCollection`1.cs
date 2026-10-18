namespace System.Collections.Concurrent;

public interface IProducerConsumerCollection`1 : IEnumerable, IEnumerable, ICollection
{

	public bool TryAdd(T item) { }

	public bool TryTake(out T item) { }

}

