namespace Audio.AmbientSubsystem.Data;

public abstract class EnumSoundContentPreset`2 : ScriptableObject
{
	private class Content : SerializableEnumDictionary
	{

		public Content() { }

	}

	[SerializeField]
	private Content _content; //Field offset: 0x0

	protected EnumSoundContentPreset`2() { }

	public bool TryGetContent(TEnum key, out TObj content) { }

}

