namespace System.Text.Json;

internal enum StackFramePropertyState
{
	None = 0,
	ReadName = 1,
	Name = 2,
	ReadValue = 3,
	ReadValueIsEnd = 4,
	TryRead = 5,
}

