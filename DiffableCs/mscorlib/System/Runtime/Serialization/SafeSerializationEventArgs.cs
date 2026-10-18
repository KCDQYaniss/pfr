namespace System.Runtime.Serialization;

public sealed class SafeSerializationEventArgs : EventArgs
{
	private StreamingContext m_streamingContext; //Field offset: 0x10
	private List m_serializedStates; //Field offset: 0x20

	internal IList SerializedStates
	{
		internal get { } //Length: 5
	}

	internal SafeSerializationEventArgs(StreamingContext streamingContext) { }

	internal IList get_SerializedStates() { }

}

