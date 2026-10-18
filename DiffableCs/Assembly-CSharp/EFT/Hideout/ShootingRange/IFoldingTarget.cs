namespace EFT.Hideout.ShootingRange;

public interface IFoldingTarget
{

	public Task Fold(bool mute, CancellationToken token) { }

	public Task Rocking(CancellationToken token) { }

	public Task Unfold(bool mute, CancellationToken token) { }

}

