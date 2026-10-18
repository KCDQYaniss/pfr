namespace Steamworks;

[CallbackIdentity(6001)]
public struct SteamTimelineGamePhaseRecordingExists_t
{
	public const int k_iCallback = 6001; //Field offset: 0x0
	private byte[] m_rgchPhaseID_; //Field offset: 0x0
	public ulong m_ulRecordingMS; //Field offset: 0x8
	public ulong m_ulLongestClipMS; //Field offset: 0x10
	public uint m_unClipCount; //Field offset: 0x18
	public uint m_unScreenshotCount; //Field offset: 0x1C

	public string m_rgchPhaseID
	{
		 get { } //Length: 125
		 set { } //Length: 23
	}

	public string get_m_rgchPhaseID() { }

	public void set_m_rgchPhaseID(string value) { }

}

