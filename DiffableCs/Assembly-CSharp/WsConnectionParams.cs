//Type is in global namespace

internal struct WsConnectionParams
{
	public string EndpointUrl; //Field offset: 0x0
	public string TokenB64; //Field offset: 0x8
	public float KeepAliveInterval; //Field offset: 0x10
	public float[] ConfirmationTimeouts; //Field offset: 0x18
	public Action ActionOnReconnect; //Field offset: 0x20
	public Func OnReconnectAttemptAsync; //Field offset: 0x28

}

