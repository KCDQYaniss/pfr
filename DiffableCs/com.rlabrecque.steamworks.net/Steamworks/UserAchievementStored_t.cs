namespace Steamworks;

[CallbackIdentity(1103)]
public struct UserAchievementStored_t
{
	public const int k_iCallback = 1103; //Field offset: 0x0
	public ulong m_nGameID; //Field offset: 0x0
	public bool m_bGroupAchievement; //Field offset: 0x8
	private byte[] m_rgchAchievementName_; //Field offset: 0x10
	public uint m_nCurProgress; //Field offset: 0x18
	public uint m_nMaxProgress; //Field offset: 0x1C

	public string m_rgchAchievementName
	{
		 get { } //Length: 125
		 set { } //Length: 24
	}

	public string get_m_rgchAchievementName() { }

	public void set_m_rgchAchievementName(string value) { }

}

