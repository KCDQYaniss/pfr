namespace EFT;

public sealed class Transit
{
	public string raidId; //Field offset: 0x10
	public int count; //Field offset: 0x18
	public string[] maps; //Field offset: 0x20
	public bool events; //Field offset: 0x28

	public Transit(string raidId, int count, string[] maps, bool events) { }

}

