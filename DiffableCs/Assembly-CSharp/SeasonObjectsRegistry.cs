//Type is in global namespace

public sealed class SeasonObjectsRegistry : MonoBehaviourSingleton
{
	private readonly List _collection; //Field offset: 0x20
	private bool _isActive; //Field offset: 0x28

	public SeasonObjectsRegistry() { }

	public void Add(GameObject go) { }

	public void Clear(bool restore = false) { }

	public void Remove(GameObject go, bool restore = false) { }

	public void SetActiveToObjects(bool isActive) { }

}

