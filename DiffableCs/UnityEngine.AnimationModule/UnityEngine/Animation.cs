namespace UnityEngine;

[DefaultMember("Item")]
[NativeHeader("Modules/Animation/Animation.h")]
public sealed class Animation : Behaviour, IEnumerable
{
	private sealed class Enumerator : IEnumerator
	{
		private Animation m_Outer; //Field offset: 0x10
		private int m_CurrentIndex; //Field offset: 0x18

		public override object Current
		{
			 get { } //Length: 104
		}

		internal Enumerator(Animation outer) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}


	public bool animatePhysics
	{
		 get { } //Length: 78
	}

	public AnimationClip clip
	{
		 get { } //Length: 78
	}

	public AnimationState Item
	{
		 get { } //Length: 93
	}

	public void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	[ExcludeFromDocs]
	public void CrossFade(string animation, float fadeLength) { }

	public bool get_animatePhysics() { }

	public AnimationClip get_clip() { }

	public AnimationState get_Item(string name) { }

	public override IEnumerator GetEnumerator() { }

	[FreeFunction("AnimationBindings::GetState", HasExplicitThis = True)]
	internal AnimationState GetState(string name) { }

	[FreeFunction("AnimationBindings::GetStateAtIndex", HasExplicitThis = True, ThrowsException = True)]
	internal AnimationState GetStateAtIndex(int index) { }

	[NativeName("GetAnimationStateCount")]
	internal int GetStateCount() { }

	[ExcludeFromDocs]
	public bool Play() { }

	public bool Play(PlayMode mode) { }

	public bool Play(string animation, PlayMode mode) { }

	[ExcludeFromDocs]
	public bool Play(string animation) { }

	[NativeName("Play")]
	private bool PlayDefaultAnimation(PlayMode mode) { }

	public void Rewind(string name) { }

	[NativeName("Rewind")]
	private void RewindNamed(string name) { }

	public void Stop() { }

}

