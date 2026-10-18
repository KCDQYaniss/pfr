namespace EFT;

public class AnimatorResetter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string runtimeLayerName; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <SoftReset>b__0(LayerState e) { }

	}

	internal class LayerState
	{
		public string layerName; //Field offset: 0x10
		public string stateName; //Field offset: 0x18

		public LayerState() { }

	}

	internal class ParameterDefault
	{
		public string name; //Field offset: 0x10
		public AnimatorControllerParameterType type; //Field offset: 0x18
		public float floatValue; //Field offset: 0x1C
		public int intValue; //Field offset: 0x20
		public bool boolValue; //Field offset: 0x24

		public ParameterDefault() { }

	}

	[SerializeField]
	private Animator _animator; //Field offset: 0x20
	[SerializeField]
	private List _entryStates; //Field offset: 0x28
	[SerializeField]
	private List _defaultParameters; //Field offset: 0x30

	public AnimatorResetter() { }

	public void SoftReset() { }

}

