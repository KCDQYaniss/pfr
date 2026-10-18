//Type is in global namespace

[CreateAssetMenu(menuName = "Seasons/SeasonsMaterialsGrassStub")]
[Obfuscation(Exclude = True)]
public sealed class SeasonsMaterialsGrassStub : SeasonsMaterialsGrass
{

	public SeasonsMaterialsGrassStub() { }

	public virtual void Fix() { }

	public virtual Task LoadAutumn() { }

	public virtual Task LoadAutumnLate() { }

	public virtual Task LoadSpring() { }

	public virtual Task LoadSpringEarly() { }

	public virtual Task LoadSummer() { }

	public virtual Task LoadWinter() { }

	public virtual void Unload() { }

}

