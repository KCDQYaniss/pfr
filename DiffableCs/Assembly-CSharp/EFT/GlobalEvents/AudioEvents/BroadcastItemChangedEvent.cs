namespace EFT.GlobalEvents.AudioEvents;

[Obfuscation(Exclude = True)]
public class BroadcastItemChangedEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private ERadioStation <RadioStation>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <ClipIndex>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private EBroadcastItemType <ItemType>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <CrossfadeDuration>k__BackingField; //Field offset: 0x24

	public private int ClipIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float CrossfadeDuration
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private EBroadcastItemType ItemType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private ERadioStation RadioStation
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BroadcastItemChangedEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public int get_ClipIndex() { }

	[CompilerGenerated]
	public float get_CrossfadeDuration() { }

	[CompilerGenerated]
	public EBroadcastItemType get_ItemType() { }

	[CompilerGenerated]
	public ERadioStation get_RadioStation() { }

	public void Invoke(ERadioStation station, BroadcastItemData broadcastItemData, float crossfadeTime) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_ClipIndex(int value) { }

	[CompilerGenerated]
	private void set_CrossfadeDuration(float value) { }

	[CompilerGenerated]
	private void set_ItemType(EBroadcastItemType value) { }

	[CompilerGenerated]
	private void set_RadioStation(ERadioStation value) { }

}

