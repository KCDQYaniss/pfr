namespace EFT.UI.Tutorial;

[CreateAssetMenu(menuName = "Scriptable objects/KeyViewContentGenerator", fileName = "KeyViewContentGenerator")]
public class KeyViewContentGenerator : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__9_1; //Field offset: 0x8
		public static Func <>9__9_2; //Field offset: 0x10
		public static Func <>9__9_4; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <GetKeyBinding>b__9_1(InputSource keyVariant) { }

		internal bool <GetKeyBinding>b__9_2(InputSource keyVariant) { }

		internal bool <GetKeyBinding>b__9_4(InputSource keyVariant) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public KeyCombination keyCombination; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <GetKeyBinding>b__5(AxisGroup e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_1
	{
		public EGameKey key; //Field offset: 0x10

		public <>c__DisplayClass9_1() { }

		internal bool <GetKeyBinding>b__0(KeyGroup e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_2
	{
		public EGameKey secondKey; //Field offset: 0x10

		public <>c__DisplayClass9_2() { }

		internal bool <GetKeyBinding>b__3(KeyGroup e) { }

	}

	public Sprite KeySmall; //Field offset: 0x18
	public Sprite KeyBig; //Field offset: 0x20
	public Sprite KeyComma; //Field offset: 0x28
	public Sprite KeyMouseBoth; //Field offset: 0x30
	public Sprite KeyMouseLeft; //Field offset: 0x38
	public Sprite KeyMouseMiddle; //Field offset: 0x40
	public Sprite KeyMouseRight; //Field offset: 0x48
	public Sprite KeyPlus; //Field offset: 0x50
	private readonly HashSet _predefinedKeys; //Field offset: 0x58

	public KeyViewContentGenerator() { }

	private void FulfillAxisKeys(InputSource axisInput, List keys) { }

	public KeyBinding GetDoubleClickKeyBinding() { }

	private Key GetKey(KeyCode keyCode, string axisName = "") { }

	public KeyBinding GetKeyBinding(KeyCombination keyCombination, bool textImages = false, bool controlButtonsAtStart = false) { }

	private Sprite GetKeySprite(KeyCode keyCode, string keyAlias, string axisName = "") { }

	public bool IsSpecialSprite(Sprite sprite) { }

}

