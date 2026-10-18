namespace Steamworks;

public struct RemotePlayInput_t
{
	internal struct OptionValue
	{
		public RemotePlayInputMouseMotion_t m_MouseMotion; //Field offset: 0x0
		public ERemotePlayMouseButton m_eMouseButton; //Field offset: 0x0
		public RemotePlayInputMouseWheel_t m_MouseWheel; //Field offset: 0x0
		public RemotePlayInputKey_t m_Key; //Field offset: 0x0

	}

	public RemotePlaySessionID_t m_unSessionID; //Field offset: 0x0
	public ERemotePlayInputType m_eType; //Field offset: 0x4
	public OptionValue m_val; //Field offset: 0x8

}

