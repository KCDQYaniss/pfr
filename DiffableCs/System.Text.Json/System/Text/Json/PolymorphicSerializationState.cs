namespace System.Text.Json;

internal enum PolymorphicSerializationState
{
	None = 0,
	PolymorphicReEntryStarted = 1,
	PolymorphicReEntrySuspended = 2,
	PolymorphicReEntryNotFound = 3,
}

