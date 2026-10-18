//Type is in global namespace

public class GoToCoverTactical : TaclicalMoveNode
{

	protected virtual float CHANCE_TO_COVER_SPRINT_ON_MAX_DIST_OR_HIGHER
	{
		 get { } //Length: 9
	}

	protected virtual float CHANCE_TO_COVER_SPRINT_ON_MIN_DIST_OR_LOWER
	{
		 get { } //Length: 9
	}

	protected override float CHANCE_TO_SPRINT_ON_MAX_DIST_OR_HIGHER
	{
		 get { } //Length: 4
	}

	protected override float CHANCE_TO_SPRINT_ON_MIN_DIST_OR_LOWER
	{
		 get { } //Length: 4
	}

	protected virtual float ENEMY_VISIBLE_RECENTLY
	{
		 get { } //Length: 9
	}

	protected virtual float NEXT_COVER_LONG
	{
		 get { } //Length: 9
	}

	protected virtual float NEXT_COVER_SHORT
	{
		 get { } //Length: 9
	}

	protected virtual float STAY_AT_COVER
	{
		 get { } //Length: 9
	}

	protected virtual float STAY_AT_COVER_WITH_ENEMY
	{
		 get { } //Length: 9
	}

	public GoToCoverTactical(BotOwner bot) { }

	protected virtual float get_CHANCE_TO_COVER_SPRINT_ON_MAX_DIST_OR_HIGHER() { }

	protected virtual float get_CHANCE_TO_COVER_SPRINT_ON_MIN_DIST_OR_LOWER() { }

	protected override float get_CHANCE_TO_SPRINT_ON_MAX_DIST_OR_HIGHER() { }

	protected override float get_CHANCE_TO_SPRINT_ON_MIN_DIST_OR_LOWER() { }

	protected virtual float get_ENEMY_VISIBLE_RECENTLY() { }

	protected virtual float get_NEXT_COVER_LONG() { }

	protected virtual float get_NEXT_COVER_SHORT() { }

	protected virtual float get_STAY_AT_COVER() { }

	protected virtual float get_STAY_AT_COVER_WITH_ENEMY() { }

	protected virtual void LookSimple() { }

	protected virtual void LookStaingAtSub() { }

}

