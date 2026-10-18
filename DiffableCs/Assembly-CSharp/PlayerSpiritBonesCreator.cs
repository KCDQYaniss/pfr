//Type is in global namespace

[ExecuteInEditMode]
public class PlayerSpiritBonesCreator : MonoBehaviour
{
	internal class PoseConfig
	{
		public bool Collect; //Field offset: 0x10
		public PoseType PoseType; //Field offset: 0x11
		public string AnimatorStateName; //Field offset: 0x18
		public bool ProneFlag; //Field offset: 0x20
		[Range(0, 1)]
		public float LevelParam; //Field offset: 0x24
		[Range(-5, 5)]
		public float TiltParam; //Field offset: 0x28
		[Range(-1, 1)]
		public int StepParam; //Field offset: 0x2C

		public PoseConfig() { }

	}

	public GameObject PlayerSuperior; //Field offset: 0x20
	public PlayerSpirit PlayerSpirit; //Field offset: 0x28
	public string PlayerSpiritPath; //Field offset: 0x30
	[SerializeField]
	private Animator _playerAnimator; //Field offset: 0x38
	public PoseConfig[] PoseConfigs; //Field offset: 0x40

	public PlayerSpiritBonesCreator() { }

}

