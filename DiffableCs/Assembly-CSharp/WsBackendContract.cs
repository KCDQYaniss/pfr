//Type is in global namespace

public static class WsBackendContract
{

	public static byte[] GetConfirmationWireData(string wsMessageId) { }

	public static byte[] GetRequestWireData(WsRequestJson wsRequestJson) { }

	public static bool TryParseMessage(MessageEventArgs e, out WsWireMessageType messageType, out string trackingId, out string payloadType, out string payload) { }

	public static bool TryParseMessage(byte[] rawData, out WsWireMessageType messageType, out string trackingId, out string payloadType, out string payload) { }

	private static bool TryParseMessageFailed(out WsWireMessageType messageType, out string trackingId, out string payloadType, out string payload) { }

}

