namespace EFT;

public struct ReloadWithAmmo
{
	internal enum EReloadWithAmmoStatus
	{
		None = 0,
		StartReload = 1,
		EndReload = 2,
		AbortReload = 3,
	}

	private const int MAX_AMMO_IDS = 63; //Field offset: 0x0
	private const int MAX_RELOAD_STATUS = 3; //Field offset: 0x0
	public bool Reload; //Field offset: 0x0
	public bool FastReload; //Field offset: 0x1
	public EReloadWithAmmoStatus ReloadWithAmmoStatus; //Field offset: 0x4
	public int AmmoLoadedToMag; //Field offset: 0x8
	public string[] AmmoIds; //Field offset: 0x10
	public int[] ShellsIds; //Field offset: 0x18

	public static void Serialize(IBitStream serializer, ref ReloadWithAmmo reloadWithAmmoPacket) { }

	public virtual string ToString() { }

}

