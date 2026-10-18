namespace EFT;

public struct ReloadBarrels
{
	private const int MAX_AMMO_IDS = 63; //Field offset: 0x0
	public bool Reload; //Field offset: 0x0
	public string[] AmmoIds; //Field offset: 0x8
	public byte[] LocationDescription; //Field offset: 0x10

	public static void Serialize(IBitStream stream, ref ReloadBarrels packet) { }

}

