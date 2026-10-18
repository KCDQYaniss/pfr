namespace EFT.InventoryLogic;

public class TapeItem : CompletableItem
{
	public const string TAPES_CATEGORY = "65bcab6877b93a04772ae2d8"; //Field offset: 0x0
	private readonly TapeItemTemplate _template; //Field offset: 0x80

	public virtual IEnumerable ItemInteractionButtons
	{
		 get { } //Length: 83
	}

	public string Subtitles
	{
		 get { } //Length: 33
	}

	public string TapeId
	{
		 get { } //Length: 33
	}

	public string TranscriptText
	{
		 get { } //Length: 33
	}

	public TapeItem(string id, TapeItemTemplate template) { }

	public virtual IEnumerable get_ItemInteractionButtons() { }

	public string get_Subtitles() { }

	public string get_TapeId() { }

	public string get_TranscriptText() { }

	public string GetDescription(bool completed) { }

}

