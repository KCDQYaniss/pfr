namespace EFT.NextObservedPlayer;

public sealed class AnimationStateHashDictionary
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8
		public static Func <>9__4_1; //Field offset: 0x10
		public static Func <>9__4_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__4_0(IPlayerStateContainerBehaviour x) { }

		internal int <.ctor>b__4_1(IPlayerStateContainerBehaviour x) { }

		internal EPlayerState <.ctor>b__4_2(IPlayerStateContainerBehaviour x) { }

	}

	private static Dictionary _statesIndexToName; //Field offset: 0x0
	private List _stateHashes; //Field offset: 0x10
	private Dictionary _statesHashToIndex; //Field offset: 0x18
	private Dictionary _statesHashToName; //Field offset: 0x20

	private static AnimationStateHashDictionary() { }

	public AnimationStateHashDictionary(IPlayerStateContainerBehaviour[] states) { }

	public int Get(int index) { }

}

