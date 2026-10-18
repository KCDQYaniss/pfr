namespace System.Net.NetworkInformation;

public class PingCompletedEventArgs : AsyncCompletedEventArgs
{
	private PingReply reply; //Field offset: 0x28

	internal PingCompletedEventArgs(Exception ex, bool cancelled, object userState, PingReply reply) { }

}

