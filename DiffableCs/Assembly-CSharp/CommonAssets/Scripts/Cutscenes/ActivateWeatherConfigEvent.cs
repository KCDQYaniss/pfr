namespace CommonAssets.Scripts.Cutscenes;

[Obfuscation(Exclude = True)]
public class ActivateWeatherConfigEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private string <WeatherConfigId>k__BackingField; //Field offset: 0x18

	public private string WeatherConfigId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ActivateWeatherConfigEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public string get_WeatherConfigId() { }

	public void Invoke(string weatherConfigId) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_WeatherConfigId(string value) { }

}

