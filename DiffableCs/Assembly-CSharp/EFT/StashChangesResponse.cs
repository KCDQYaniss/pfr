namespace EFT;

public sealed class StashChangesResponse
{
	public FlatItem[] new; //Field offset: 0x10
	public FlatItem[] change; //Field offset: 0x18
	public FlatItem[] del; //Field offset: 0x20

	public StashChangesResponse() { }

}

