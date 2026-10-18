namespace BattlEye;

public interface IBattlEyeClientRequestHandler
{

	public void OnRequestRestart(ERestartReason reason) { }

	public void OnSendPacket(byte[] bePacket, int packetOffset, int packetLength) { }

}

