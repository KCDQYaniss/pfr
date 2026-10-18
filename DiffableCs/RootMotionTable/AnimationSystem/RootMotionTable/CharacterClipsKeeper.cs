namespace AnimationSystem.RootMotionTable;

public sealed class CharacterClipsKeeper : ScriptableObject
{
	internal struct AnimationClipData
	{
		public AnimationClip clip; //Field offset: 0x0
		public ParameterRelatedCurve[] parameterRelatedCurves; //Field offset: 0x8

	}

	internal struct LayerData
	{
		public AnimationClipData[] clips; //Field offset: 0x0

	}

	public LayerData[] Clips; //Field offset: 0x18

	public CharacterClipsKeeper() { }

	public int GetClipIndex(int layerIndex, AnimationClip clip) { }

}

