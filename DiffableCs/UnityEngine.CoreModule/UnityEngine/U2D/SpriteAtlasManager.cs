namespace UnityEngine.U2D;

[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlasManager.h")]
[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
[StaticAccessor("GetSpriteAtlasManager()", StaticAccessorType::Dot (0))]
public class SpriteAtlasManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action atlasRequested; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action atlasRegistered; //Field offset: 0x8

	public static event Action atlasRegistered
	{
		[CompilerGenerated]
		 add { } //Length: 304
		[CompilerGenerated]
		 remove { } //Length: 304
	}

	[CompilerGenerated]
	public static void add_atlasRegistered(Action value) { }

	[RequiredByNativeCode]
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	internal static void Register(SpriteAtlas spriteAtlas) { }

	[CompilerGenerated]
	public static void remove_atlasRegistered(Action value) { }

	[RequiredByNativeCode]
	private static bool RequestAtlas(string tag) { }

}

