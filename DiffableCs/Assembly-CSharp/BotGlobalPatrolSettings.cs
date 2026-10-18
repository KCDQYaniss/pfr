//Type is in global namespace

public class BotGlobalPatrolSettings
{
	[Comment("Время которое бот проводит на точке для осмотра на обычном пути")]
	public float LOOK_TIME_BASE; //Field offset: 0x10
	[Comment(" Время которое бот проводит на точки Резервного пути")]
	public float RESERVE_TIME_STAY; //Field offset: 0x14
	[Comment(" Время которое бот проводит на точке лута Резервного пути")]
	public float RESERVE_LOOT_TIME_STAY; //Field offset: 0x18
	[Comment("Дельта поиска длуга на резервном пути для душевной беседы")]
	public float FRIEND_SEARCH_SEC; //Field offset: 0x1C
	[Comment("Дельта фразы в беседе")]
	public float TALK_DELAY; //Field offset: 0x20
	[Comment("Дельта на говорливость")]
	public float MIN_TALK_DELAY; //Field offset: 0x24
	[Comment("Если друзей нет то будем говорить с такой дельтой")]
	public float TALK_DELAY_BIG; //Field offset: 0x28
	[Comment("базовое время когда бот может решить сменить пути")]
	public float CHANGE_WAY_TIME; //Field offset: 0x2C
	[Comment(null)]
	public float MIN_DIST_TO_CLOSE_TALK; //Field offset: 0x30
	[Comment("Коэфициент на который режется дистанция в \"мирном\" режиме")]
	public float VISION_DIST_COEF_PEACE; //Field offset: 0x34
	[Comment(null)]
	public float MIN_DIST_TO_CLOSE_TALK_SQR; //Field offset: 0x38
	[Comment("Шанс срезать путь при патрулировании")]
	public float CHANCE_TO_CUT_WAY_0_100; //Field offset: 0x3C
	[Comment("Минимальный процент на который дистанци пути при патруле мб срезанна")]
	public float CUT_WAY_MIN_0_1; //Field offset: 0x40
	[Comment("Максимальный")]
	public float CUT_WAY_MAX_0_1; //Field offset: 0x44
	[Comment("Шанс сменить путь патрулирования")]
	public float CHANCE_TO_CHANGE_WAY_0_100; //Field offset: 0x48
	[Comment("Вероятность того что бот попытается сделать контрольный выстрел в тело врага")]
	public int CHANCE_TO_SHOOT_DEADBODY; //Field offset: 0x4C
	[Comment("Время жизни подозрительной точки.")]
	public float SUSPETION_PLACE_LIFETIME; //Field offset: 0x50
	[Comment("Через сколько времени если бот встал на резервный маршрут он попробует найти новый.")]
	public float RESERVE_OUT_TIME; //Field offset: 0x54
	[Comment("Дистанция до срединной точки пути для резервных путей что бы путь можно было выбрать.")]
	public float CLOSE_TO_SELECT_RESERV_WAY; //Field offset: 0x58
	[Comment("Если бот захочет выполнить запрос на предупреждение он должен быть ближе чем Х к цели по ОСИ Y - это для этажности, но если земля кривая то лучше ставить побольше.")]
	public float MAX_YDIST_TO_START_WARN_REQUEST_TO_REQUESTER; //Field offset: 0x5C
	[Comment("Если бот захочет выполнить запрос на предупреждение он должен быть ближе чем Х к цели по ОСИ Y - это для этажности, но если земля кривая то лучше ставить побольше. Только для друзей отряда")]
	public float MAX_YDIST_TO_START_WARN_REQUEST_TO_REQUESTER_ALLY; //Field offset: 0x60
	[Comment("Может ли вставать на альтернативные пути")]
	public bool CAN_CHOOSE_RESERV; //Field offset: 0x64
	[Comment("использует ли ТОЛЬКО на альтернативные пути")]
	public bool USE_ONLY_RESERV; //Field offset: 0x65
	[Comment("всегда выбирают одинаковый с боссом патрульный маршрут")]
	public bool SAME_WITH_BOSS_WAY; //Field offset: 0x66
	[Comment("Переодичность смены направления взгляда головы.")]
	public float HEAD_TURN_PERIOD_TIME; //Field offset: 0x68
	[Comment("Переодичность смены направления взгляда головы.")]
	public float HEAD_FRONT_PERIOD_TIME; //Field offset: 0x6C
	[Comment("Шанс проиграть жест при встречи")]
	public float CHANCE_TO_PLAY_GESTURE_WHEN_CLOSE; //Field offset: 0x70
	[Comment("Скорость поворота головы")]
	public float HEAD_TURN_SPEED; //Field offset: 0x74
	[Comment("Угл поворота")]
	public float HEAD_ANG_ROTATE; //Field offset: 0x78
	[Comment("Количество точек скопления лута, из которых бот выбирает случайную")]
	public int LOOT_PATROL_POTENTIAL_CLUSTERS_AMOUNT; //Field offset: 0x7C
	[Comment("шанс сказать фразу во время приветствия")]
	public float CHANCE_TO_PLAY_VOICE_WHEN_CLOSE; //Field offset: 0x80
	[Comment(null)]
	public float GO_TO_NEXT_POINT_DELTA; //Field offset: 0x84
	[Comment(null)]
	public float GO_TO_NEXT_POINT_DELTA_RESERV_WAY; //Field offset: 0x88
	[Comment("С какого расстояния ощущают труп")]
	public float DEAD_BODY_SEE_DIST; //Field offset: 0x8C
	[Comment("Если бот оказался дальше чем Х метров то он забудет о теле")]
	public float DEAD_BODY_LEAVE_DIST; //Field offset: 0x90
	[Comment("Может ли бот смотреть на трупы в мирном режиме")]
	public bool CAN_LOOK_TO_DEADBODIES; //Field offset: 0x94
	[Comment("Сколько бот будет делать PeacefulAction")]
	public float GESTURE_LENGTH; //Field offset: 0x98
	[Comment("Надо ли остановиться для PeacefulAction")]
	public bool SHALL_STOP_IN_PEACEFUL_ACTION; //Field offset: 0x9C
	[Comment("Зафорсить ли оппонента на акшен")]
	public bool FORCE_OPPONENT_TO_PEAEFUL; //Field offset: 0x9D
	[Comment("Сколько секунд бот будет стоять на точке применения набора хирурга")]
	public float RESERVE_USE_SURGE_TIME_STAY; //Field offset: 0xA0
	[Comment(null)]
	public bool RESERV_CAN_USE_MEDS; //Field offset: 0xA4
	[Comment("Надо ли остановиться для PeacefulAction")]
	public bool USE_PATROL_POINT_ACTION_MOVE_BY_RESERVE_WAY; //Field offset: 0xA5
	[Comment("Шанс начать использовать хир набор если бот смотрит на тело.")]
	public float USE_SURGIAL_KIT_OVER_THE_BODY_CAHNCE_100; //Field offset: 0xA8
	[Comment("Шанс начать использовать хир набор второй раз если бот смотрит на тело.")]
	public float USE_SURGIAL_KIT_OVER_THE_BODY_SECOND_CAHNCE_100; //Field offset: 0xAC
	[Comment("Если у фолловера стоит режим изди вместе с боссом то он задержится на Х")]
	public float FOLLOWER_START_MOVE_DELAY; //Field offset: 0xB0
	[Comment("Использование закешированных путей для патруля")]
	public bool USE_CHACHE_WAYS; //Field offset: 0xB4
	[Comment("Список вещей доступных для дропа")]
	public string ITEMS_TO_DROP; //Field offset: 0xB8
	[Comment("Шанс что бот побежит между точками на патруле если это предусмотрено другими условиями и бот использует кешированные маршруты")]
	public float SPRINT_BETWEEN_CACHED_POINTS; //Field offset: 0xC0
	[Comment("Базовая Переодичность проверки магазина")]
	public float CHECK_MAGAZIN_PERIOD; //Field offset: 0xC4
	[Comment("Переодичность с которой бот может есть/пить")]
	public float EAT_DRINK_PERIOD; //Field offset: 0xC8
	[Comment(null)]
	public float WATCH_SECOND_WEAPON_PERIOD; //Field offset: 0xCC
	[Comment(null)]
	public bool CAN_WATCH_SECOND_WEAPON; //Field offset: 0xD0
	[Comment("Базовое время осмотра трупа")]
	public float DEAD_BODY_LOOK_PERIOD; //Field offset: 0xD4
	[Comment(null)]
	public bool CAN_HARD_AIM; //Field offset: 0xD8
	[Comment(null)]
	public bool CAN_PEACEFUL_LOOK; //Field offset: 0xD9
	[Comment(null)]
	public bool CAN_FRIENDLY_TILT; //Field offset: 0xDA
	[Comment("может ли бот жестикулировать")]
	public bool CAN_GESTUS; //Field offset: 0xDB
	[Comment("При рождении будет пытаться выбрать резервный путь")]
	public bool TRY_CHOOSE_RESERV_WAY_ON_START; //Field offset: 0xDC
	[Comment(null)]
	public bool CAN_CHECK_MAGAZINE; //Field offset: 0xDD
	[Comment(" При поднятии предмета всегда отправлять в рюкзак или контейнер")]
	public bool PICKUP_ITEMS_TO_BACKPACK_OR_CONTAINER; //Field offset: 0xDE
	public bool DO_RANDOM_DROP_ITEM; //Field offset: 0xDF
	[Comment("Диапазон времени, которое должно пройти после лутания для возможности лутаться в соледующий раз")]
	public float STAY_AFTER_LOOT_TIME_MIN; //Field offset: 0xE0
	[Comment("Диапазон времени, которое должно пройти после лутания для возможности лутаться в соледующий раз")]
	public float STAY_AFTER_LOOT_TIME_MAX; //Field offset: 0xE4
	[Comment("Боты используют реальный лутинг или его симуляцию")]
	public bool USE_REAL_LOOTING; //Field offset: 0xE8
	[Comment("Вероятность в процентах того, что бот дропнет вещь, которую он не стал брать из трупа. Больше = вероятнее.")]
	public float DEAD_BODY_DROP_ITEM_PROBABILITY; //Field offset: 0xEC
	[Comment("рандом скорости с которйо боыт ходят патролят в слое патроллинга")]
	public float MIN_SPEED_ON_PATROL; //Field offset: 0xF0
	[Comment("рандом скорости с которйо боыт ходят патролят в слое патроллинга")]
	public float MAX_SPEED_ON_PATROL; //Field offset: 0xF4
	[Comment("Может ли бот в целом искать места для лута и соответственно их использовать")]
	public bool CAN_FIND_LOOT; //Field offset: 0xF8

	public BotGlobalPatrolSettings() { }

	public void Update() { }

}

