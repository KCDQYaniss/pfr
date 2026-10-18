namespace UnityEngine;

[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
[RequiredByNativeCode]
public class Gradient : IEquatable
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public GradientAlphaKey[] alphaKeys
	{
		[FreeFunction("Gradient_Bindings::GetAlphaKeys", IsThreadSafe = True, HasExplicitThis = True)]
		 get { } //Length: 78
		[FreeFunction("Gradient_Bindings::SetAlphaKeys", IsThreadSafe = True, HasExplicitThis = True)]
		 set { } //Length: 93
	}

	public GradientColorKey[] colorKeys
	{
		[FreeFunction("Gradient_Bindings::GetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
		 get { } //Length: 78
		[FreeFunction("Gradient_Bindings::SetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
		 set { } //Length: 93
	}

	[NativeProperty(IsThreadSafe = True)]
	public GradientMode mode
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	[RequiredByNativeCode]
	public Gradient() { }

	[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	private void Cleanup() { }

	public virtual bool Equals(object o) { }

	public override bool Equals(Gradient other) { }

	[FreeFunction(Name = "Gradient_Bindings::Evaluate", IsThreadSafe = True, HasExplicitThis = True)]
	public Color Evaluate(float time) { }

	private void Evaluate_Injected(float time, out Color ret) { }

	protected virtual void Finalize() { }

	[FreeFunction("Gradient_Bindings::GetAlphaKeys", IsThreadSafe = True, HasExplicitThis = True)]
	public GradientAlphaKey[] get_alphaKeys() { }

	[FreeFunction("Gradient_Bindings::GetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
	public GradientColorKey[] get_colorKeys() { }

	public GradientMode get_mode() { }

	public virtual int GetHashCode() { }

	[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = True)]
	private static IntPtr Init() { }

	[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = True, HasExplicitThis = True)]
	private bool Internal_Equals(IntPtr other) { }

	[FreeFunction("Gradient_Bindings::SetAlphaKeys", IsThreadSafe = True, HasExplicitThis = True)]
	public void set_alphaKeys(GradientAlphaKey[] value) { }

	[FreeFunction("Gradient_Bindings::SetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
	public void set_colorKeys(GradientColorKey[] value) { }

	public void set_mode(GradientMode value) { }

}

