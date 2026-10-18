namespace EFT.HandBook;

public class HandbookData : BaseHandbookData
{
	public string Icon; //Field offset: 0x28
	public string Color; //Field offset: 0x30
	public int Order; //Field offset: 0x38
	public string Name; //Field offset: 0x40
	public Item Item; //Field offset: 0x48
	public ENodeType Type; //Field offset: 0x50
	public bool FromBuild; //Field offset: 0x54
	public Nullable RagfairLevelToTrade; //Field offset: 0x58
	private Color _backgroundColor; //Field offset: 0x60

	public Color BackgroundColor
	{
		 get { } //Length: 211
	}

	public HandbookData() { }

	public HandbookData Clone() { }

	private HandbookData CloneAs(ENodeType type) { }

	public HandbookData CloneAsCategory() { }

	public Color get_BackgroundColor() { }

	public virtual string ToString() { }

}

