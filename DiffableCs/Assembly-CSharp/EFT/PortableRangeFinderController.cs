namespace EFT;

internal class PortableRangeFinderController : UsableItemController
{
	public class PortableRangeFinderDropBackpackOperation : DropBackpackOperation
	{

		public PortableRangeFinderDropBackpackOperation(PortableRangeFinderController controller) { }

		protected virtual void InitiateIdlingOperation() { }

		public virtual void SetAiming(bool isAiming) { }

	}

	public class PortableRangeFinderIdling : Idling
	{

		public PortableRangeFinderIdling(PortableRangeFinderController controller) { }

		public virtual void HideWeapon(Action onHidden, bool fastDrop) { }

		protected virtual void InitiateDropBackpackOperation(IOneItemOperation oneItemOperation, Callback callback) { }

		public virtual void SetAiming(bool isAiming) { }

	}

	public class PortableRangeFinderRemove : Remove
	{

		public PortableRangeFinderRemove(PortableRangeFinderController controller) { }

		public virtual void Start(Action onHidden, bool fastDrop) { }

	}

	public class PortableRangeFinderSpawnOperation : SpawnOperation
	{

		public PortableRangeFinderSpawnOperation(PortableRangeFinderController controller) { }

		protected virtual void SetIdlingOperation() { }

		protected virtual void SetLeftStanceAnimOnStartOperation() { }

	}

	internal sealed class ServerPortableRangeFinderDropBackpackOperation : ServerDropBackpackOperation
	{

		public ServerPortableRangeFinderDropBackpackOperation(PortableRangeFinderController controller) { }

	}

	private const float RANGEFINDER_AIM_SPEED = 2; //Field offset: 0x0
	private OpticSight _opticSight; //Field offset: 0xE0
	private TacticalRangeFinderController _rangeFinderController; //Field offset: 0xE8

	public OpticSight CurrentOpticSight
	{
		 get { } //Length: 8
	}

	public PortableRangeFinderController() { }

	[CompilerGenerated]
	private ObjectInHandsOperation <GetOperationFactoryDelegates>b__5_0() { }

	[CompilerGenerated]
	private ObjectInHandsOperation <GetOperationFactoryDelegates>b__5_1() { }

	[CompilerGenerated]
	private ObjectInHandsOperation <GetOperationFactoryDelegates>b__5_2() { }

	[CompilerGenerated]
	private ObjectInHandsOperation <GetOperationFactoryDelegates>b__5_3() { }

	public OpticSight get_CurrentOpticSight() { }

	protected virtual Dictionary GetOperationFactoryDelegates() { }

	protected virtual void InitializeController(Player player, WeaponPrefab weaponPrefab) { }

	protected virtual void InitiateSpawnOperation(Action callback) { }

	protected virtual void StateChangedHandler(EPlayerState previousstate, EPlayerState nextstate) { }

}

