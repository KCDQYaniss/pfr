namespace Mirror;

public class NetworkReaderPooled : NetworkReader, IDisposable
{

	internal NetworkReaderPooled(byte[] bytes) { }

	internal NetworkReaderPooled(ArraySegment segment) { }

	public override void Dispose() { }

}

