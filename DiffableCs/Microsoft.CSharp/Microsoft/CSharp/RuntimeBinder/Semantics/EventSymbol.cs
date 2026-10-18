namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal sealed class EventSymbol : Symbol
{
	public EventInfo AssociatedEventInfo; //Field offset: 0x38
	public bool isStatic; //Field offset: 0x40
	public bool isOverride; //Field offset: 0x41
	public CType type; //Field offset: 0x48
	public MethodSymbol methAdd; //Field offset: 0x50
	public MethodSymbol methRemove; //Field offset: 0x58
	[CompilerGenerated]
	private bool <IsWindowsRuntimeEvent>k__BackingField; //Field offset: 0x60

	public bool IsWindowsRuntimeEvent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public EventSymbol() { }

	[CompilerGenerated]
	public bool get_IsWindowsRuntimeEvent() { }

	[CompilerGenerated]
	public void set_IsWindowsRuntimeEvent(bool value) { }

}

