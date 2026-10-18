namespace UnityEngine.UIElements;

internal struct TransitionData : IStyleDataGroup, IEquatable
{
	public List transitionDelay; //Field offset: 0x0
	public List transitionDuration; //Field offset: 0x8
	public List transitionProperty; //Field offset: 0x10
	public List transitionTimingFunction; //Field offset: 0x18

	public override TransitionData Copy() { }

	public override void CopyFrom(ref TransitionData other) { }

	public override bool Equals(TransitionData other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(TransitionData lhs, TransitionData rhs) { }

}

