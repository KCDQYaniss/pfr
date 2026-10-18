namespace FastAnimatorSystem;

public sealed class OneDBlendTreeState : AbstractBlendTreeState
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__14_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GetMotionsNames>b__14_0(AbstractMotion x) { }

	}

	private readonly List _blendSettings; //Field offset: 0x88
	private float _cachedMotionDuration; //Field offset: 0x90
	private string _cachedMotionsToString; //Field offset: 0x98
	private bool _cachedLoop; //Field offset: 0xA0

	public List BlendSettings
	{
		 get { } //Length: 8
	}

	public virtual bool Loop
	{
		 get { } //Length: 32
	}

	protected virtual float RealMotionDuration
	{
		 get { } //Length: 58
	}

	public OneDBlendTreeState(string name, int hash, float speedMultiplier, AnimatorParameter speedAnimParam, List outTransitions, List blendSettings) { }

	public OneDBlendTreeState(string name, int hash, float speedMultiplier, AnimatorParameter speedAnimParam, List blendSettings) { }

	protected virtual void Dispose(bool disposing) { }

	public List get_BlendSettings() { }

	public virtual bool get_Loop() { }

	protected virtual float get_RealMotionDuration() { }

	private string GetMotionsNames() { }

	public virtual string ToString() { }

	private void UpdateCache() { }

}

