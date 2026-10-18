namespace UnityEngine;

[NativeClass("TextRendering::Font")]
[NativeHeader("Modules/TextRendering/Public/Font.h")]
[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
[StaticAccessor("TextRenderingPrivate", StaticAccessorType::DoubleColon (2))]
public sealed class Font : Object
{
	internal sealed class FontTextureRebuildCallback : MulticastDelegate
	{

		public FontTextureRebuildCallback(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action textureRebuilt; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private FontTextureRebuildCallback m_FontTextureRebuildCallback; //Field offset: 0x18

	public static event Action textureRebuilt
	{
		[CompilerGenerated]
		 add { } //Length: 293
		[CompilerGenerated]
		 remove { } //Length: 293
	}

	public bool dynamic
	{
		 get { } //Length: 78
	}

	public int fontSize
	{
		 get { } //Length: 78
	}

	[NativeProperty("LineSpacing", False, TargetType::Function (0))]
	public int lineHeight
	{
		 get { } //Length: 78
	}

	public Material material
	{
		 get { } //Length: 78
	}

	public Font() { }

	[CompilerGenerated]
	public static void add_textureRebuilt(Action value) { }

	public bool get_dynamic() { }

	public int get_fontSize() { }

	public int get_lineHeight() { }

	public Material get_material() { }

	public bool HasCharacter(char c) { }

	private bool HasCharacter(int c) { }

	private static void Internal_CreateFont(Font self, string name) { }

	[RequiredByNativeCode]
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	[CompilerGenerated]
	public static void remove_textureRebuilt(Action value) { }

}

