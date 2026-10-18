namespace Audio.Data;

public abstract class SoundContainerBase`2 : ScriptableObject
{

	protected SoundContainerBase`2() { }

	public abstract bool TryGetContent(T soundType, out TN content) { }

}

