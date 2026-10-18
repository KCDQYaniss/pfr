namespace EFT.RocketLauncher.Explosion;

public class CollisionsHandlerModel : ICollisionsHandler
{
	private readonly Collider[] _playerCollidersParts; //Field offset: 0x10
	private IPlayer _player; //Field offset: 0x18
	private Weapon _weapon; //Field offset: 0x20
	private IComputableUnitSettings _computableUnitSettings; //Field offset: 0x28
	private WeightMultipliers _weightMultipliers; //Field offset: 0x30

	public CollisionsHandlerModel() { }

	private float CalculateWeightMultiplier(float weight) { }

	public override bool HandleCollider(Collider collider, ComputableUnit unit) { }

	public void Initialize(Weapon weapon, IPlayer player, IComputableUnitSettings settings, WeightMultipliers weightMultipliers) { }

	private bool IsInLayerMask(Collider collider, LayerMask layerMask) { }

	private bool TryGlassCollision(Collider collision) { }

	private void TryPlayerCollision(Collider collision, ComputableUnit unit) { }

}

