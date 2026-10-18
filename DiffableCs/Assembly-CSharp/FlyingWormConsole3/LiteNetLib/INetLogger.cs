namespace FlyingWormConsole3.LiteNetLib;

public interface INetLogger
{

	public void WriteNet(NetLogLevel level, string str, object[] args) { }

}

