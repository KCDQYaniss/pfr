//Type is in global namespace

[Extension]
public static class PlayerFrameExtension
{

	[Extension]
	public static void ReadPlayerFrame(PlayerFrame playerFrame, byte[] buffer, ref int offset) { }

	[Extension]
	public static PlayerFrame ReadPlayerFrame(byte[] buffer, ref int offset) { }

	[Extension]
	public static int Write(byte[] buffer, PlayerFrame playerFrame, int offset = 0) { }

}

