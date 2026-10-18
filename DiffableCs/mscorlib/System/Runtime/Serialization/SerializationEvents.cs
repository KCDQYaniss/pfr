namespace System.Runtime.Serialization;

internal sealed class SerializationEvents
{
	private readonly List _onSerializingMethods; //Field offset: 0x10
	private readonly List _onSerializedMethods; //Field offset: 0x18
	private readonly List _onDeserializingMethods; //Field offset: 0x20
	private readonly List _onDeserializedMethods; //Field offset: 0x28

	internal bool HasOnSerializingEvents
	{
		internal get { } //Length: 19
	}

	internal SerializationEvents(Type t) { }

	private static SerializationEventHandler AddOnDelegate(object obj, SerializationEventHandler handler, List methods) { }

	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }

	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	internal bool get_HasOnSerializingEvents() { }

	private List GetMethodsWithAttribute(Type attribute, Type t) { }

	private static void InvokeOnDelegate(object obj, StreamingContext context, List methods) { }

	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

}

