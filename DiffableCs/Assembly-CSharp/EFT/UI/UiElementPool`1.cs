namespace EFT.UI;

public sealed class UiElementPool`1 : IDisposable
{
	private readonly Stack _pool; //Field offset: 0x0
	private readonly HashSet _poolInUse; //Field offset: 0x0
	private readonly TElement _prefab; //Field offset: 0x0
	private readonly Transform _parent; //Field offset: 0x0

	public UiElementPool`1(TElement prefab, Transform parent, int initialCapacity = 0) { }

	public void Clear(bool destroyInstances) { }

	private TElement CreateInstance() { }

	public override void Dispose() { }

	public TElement Get() { }

	private void Prewarm(int count) { }

	public void Release(TElement element) { }

}

