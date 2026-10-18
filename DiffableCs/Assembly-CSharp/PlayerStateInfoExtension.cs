//Type is in global namespace

[Extension]
public static class PlayerStateInfoExtension
{

	[Extension]
	public static PlayerStateInfo ReadPlayerStateInfo(byte[] buffer, ref int offset) { }

	[Extension]
	public static int Write(byte[] buffer, PlayerStateInfo info, int offset = 0) { }

}

