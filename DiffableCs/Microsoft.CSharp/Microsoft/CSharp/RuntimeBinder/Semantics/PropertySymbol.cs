namespace Microsoft.CSharp.RuntimeBinder.Semantics;

internal class PropertySymbol : MethodOrPropertySymbol
{
	[CompilerGenerated]
	private MethodSymbol <GetterMethod>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private MethodSymbol <SetterMethod>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private PropertyInfo <AssociatedPropertyInfo>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private bool <Bogus>k__BackingField; //Field offset: 0xC0

	public PropertyInfo AssociatedPropertyInfo
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool Bogus
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public MethodSymbol GetterMethod
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MethodSymbol SetterMethod
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public PropertySymbol() { }

	[CompilerGenerated]
	public PropertyInfo get_AssociatedPropertyInfo() { }

	[CompilerGenerated]
	public bool get_Bogus() { }

	[CompilerGenerated]
	public MethodSymbol get_GetterMethod() { }

	[CompilerGenerated]
	public MethodSymbol get_SetterMethod() { }

	[CompilerGenerated]
	public void set_AssociatedPropertyInfo(PropertyInfo value) { }

	[CompilerGenerated]
	public void set_Bogus(bool value) { }

	[CompilerGenerated]
	public void set_GetterMethod(MethodSymbol value) { }

	[CompilerGenerated]
	public void set_SetterMethod(MethodSymbol value) { }

}

