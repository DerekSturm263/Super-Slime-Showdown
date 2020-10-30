using UnityEngine;

public static class Moves
{
    // Typeless moves.

    public static Move Roll;                         // Start with the move.
    public static Move Slam;                             // Unlock the move.
    public static Move Headbutt;                         // Unlock the move.
    public static Move WarmUp;                           // Unlock the move.
    public static Move Foresight;                        // Unlock the move.

    // Nature moves: Mostly involve restoring HP or Energy.

    public static Move Heal;            // Unlock the move through leveling.
    public static Move Uproot;          // Unlock the move through leveling.
    public static Move Grow;            // Unlock the move through leveling.
    public static Move SawgrassSlice;   // Unlock the move through leveling.
    public static Move ProtectionLeaf;  // Unlock the move through leveling.
    public static Move TwistingVines;   // Unlock the move through leveling.
    public static Move SuperHeal;         // Find the move in the overworld.
    public static Move PetalStorm;        // Find the move in the overworld.
    public static Move SneakAttack;             // Unlock by beating a boss.
    public static Move BulbousBeatdown;         // Unlock by beating a boss.

    // Water Moves:
                                      
    public static Move Splash;          // Unlock the move through leveling.
    public static Move Downpour;        // Unlock the move through leveling.
    public static Move Rehydrate;       // Unlock the move through leveling.
    public static Move Waterball;       // Unlock the move through leveling.
    public static Move Aquify;          // Unlock the move through leveling.
    public static Move Absorption;      // Unlock the move through leveling.
    public static Move ToweringWave;      // Find the move in the overworld.
    public static Move CorrosiveBlast;    // Find the move in the overworld.
    public static Move WaterDown;               // Unlock by beating a boss.
    public static Move Tsunami;                 // Unlock by beating a boss.

    // Fire Moves: Mostly involve a chance to burn the opponent.

    public static Move Firebreath;      // Unlock the move through leveling.
    public static Move FlameShot;       // Unlock the move through leveling.
    public static Move HeatUp;          // Unlock the move through leveling.
    public static Move Fireball;        // Unlock the move through leveling.
    public static Move ScorchingSlap;   // Unlock the move through leveling.
    public static Move FlashFire;       // Unlock the move through leveling.
    public static Move Eruption;          // Find the move in the overworld.
    public static Move BurnBash;          // Find the move in the overworld.
    public static Move LavaSpill;               // Unlock by beating a boss.
    public static Move Inferno;                 // Unlock by beating a boss.

    // Ice Moves: Mostly involve a chance to freeze the opponent.

    public static Move FrozenTap;       // Unlock the move through leveling.
    public static Move IceTackle;       // Unlock the move through leveling.
    public static Move Freeze;          // Unlock the move through leveling.
    public static Move IcicleShot;      // Unlock the move through leveling.
    public static Move BuildingIce;     // Unlock the move through leveling.
    public static Move Icebreath;       // Unlock the move through leveling.
    public static Move Crystalize;        // Find the move in the overworld.
    public static Move BlackIce;          // Find the move in the overworld.
    public static Move DryIceSlam;              // Unlock by beating a boss.
    public static Move Hailstorm;               // Unlock by beating a boss.

    // Earth Moves: Mostly involve dealing heavy damage.

    public static Move MudShot;         // Unlock the move through leveling.
    public static Move PebbleToss;      // Unlock the move through leveling.
    public static Move Landslide;       // Unlock the move through leveling.
    public static Move SharpRocks;      // Unlock the move through leveling.
    public static Move RockWall;        // Unlock the move through leveling.
    public static Move SandBlast;               // Unlock by beating a boss.
    public static Move FaultLine;               // Unlock by beating a boss.
    public static Move Terrawave;         // Find the move in the overworld.
    public static Move Earthquake;        // Find the move in the overworld.
    public static Move SeismicSmash;    // Unlock the move through leveling.

    // Volt Moves: Mostly involve waiting a turn to deal extra damage and shocking the opponent.

    public static Move ZippityZap;      // Unlock the move through leveling.
    public static Move Charge;          // Unlock the move through leveling.
    public static Move Thundershock;    // Unlock the move through leveling.
    public static Move LightningQuickTackle;// Unlock the move through leveling.
    public static Move ElectroPulse;    // Unlock the move through leveling.
    public static Move Resistor;        // Unlock the move through leveling.
    public static Move ShockStrike;       // Find the move in the overworld.
    public static Move LightingBoltBlast; // Find the move in the overworld.
    public static Move ElectricalOverload;      // Unlock by beating a boss.
    public static Move GalvanicExplosion;       // Unlock by beating a boss.

    // Wind Moves: Mostly involve affecting the speed of the user or the opponent.

    public static Move GentleBreeze; // Unlock the move through leveling.
    public static Move WindCutter; // Unlock the move through leveling.
    public static Move JetStream; // Unlock the move through leveling.
    public static Move WindMove4; // Unlock the move through leveling.
    public static Move WindMove5; // Unlock the move through leveling.
    public static Move WindMove6; // Unlock the move through leveling.
    public static Move Tornado; // Find the move in the overworld.
    public static Move AirPollution; // Find the move in the overworld.
    public static Move WindMove9; // Unlock by beating a boss.
    public static Move WindMove10; // Unlock by beating a boss.

    // Toxin Moves: Mostly involve a chance to poison the opponent.

    public static Move PoisonSpit; // Unlock the move through leveling.
    public static Move ToxicBlock; // Unlock the move through leveling.
    public static Move VenomousStrike; // Unlock the move through leveling.
    public static Move ToxinMove4; // Unlock the move through leveling.
    public static Move PoisonPummel; // Unlock the move through leveling.
    public static Move ToxinMove6; // Unlock the move through leveling.
    public static Move PoisonFangs; // Find the move in the overworld.
    public static Move ToxicSludge; // Find the move in the overworld.
    public static Move ToxinMove9; // Unlock by beating a boss.
    public static Move ToxinMove10; // Unlock by beating a boss.

    // Light Moves: Mostly involve restoring HP or status effects upon the user.

    public static Move HeavenlyRestore; // Unlock the move through leveling.
    public static Move HaloHop; // Unlock the move through leveling.
    public static Move SavingGrace; // Unlock the move through leveling.
    public static Move ShiningStrike; // Unlock the move through leveling.
    public static Move LightMove5; // Unlock the move through leveling.
    public static Move LightMove6; // Unlock the move through leveling.
    public static Move BlindingLight; // Find the move in the overworld.
    public static Move PhotonBlast; // Find the move in the overworld.
    public static Move LightMove9; // Unlock by beating a boss.
    public static Move LightMove10; // Unlock by beating a boss.

    // Shadow Moves: Mostly involve indrect bonuses and cursing the opponent.

    public static Move Backstab;       // Unlock the move through leveling.
    public static Move UmbraSlash;     // Unlock the move through leveling.
    public static Move LifeSteal;      // Unlock the move through leveling.
    public static Move Curse;          // Unlock the move through leveling.
    public static Move Nightmare;      // Unlock the move through leveling.
    public static Move EvilPlan;       // Unlock the move through leveling.
    public static Move ShadowMove7;      // Find the move in the overworld.
    public static Move BlackHole;        // Find the move in the overworld.
    public static Move Manipulate;             // Unlock by beating a boss.
    public static Move PitchBlackTerror;       // Unlock by beating a boss.

    public static string particlePath = "Prefabs/Battle/Particles/";
    public static string animationPath = "Animations/Battle/Slimes";
    
    public static BattleEntity GetUser(bool opposite = false)
    {
        BattleEntity user;

        if (BattleManager.battleTurn == BattleManager.BattleTurn.PlayerTurn)
            user = (!opposite) ? BattleManager.player : (BattleEntity) BattleManager.enemy;
        else
            user = (!opposite) ? BattleManager.enemy : (BattleEntity) BattleManager.player;

        return user;
    }

    public static BattleManager GetBattleManager()
    {
        return GameObject.FindGameObjectWithTag("BattleManager").GetComponent<BattleManager>();
    }

    public static void Initialize()
    {
        Roll = new Move("Roll", "The user rolls their body into the target.", 20f, 0f, Types.Typeless);
        Slam = new Move("Slam", "The user slams their body in the target.", 40f, 3f, Types.Typeless);
        Headbutt = new Move("Headbutt", "The user headbutts the target.", 60f, 6f, Types.Typeless);
        WarmUp = new Move("Warm Up", "The user warms up for their next attack.", 0f, 0f, Types.Typeless, Move.Function.Buff);
        Foresight = new Move("Foresight", "The user predicts what the target will do so they might dodge it.", 0f, 0f, Types.Typeless, Move.Function.Buff);

        // Nature type moves.
        Heal = new Move("Heal", "The user heals back some of their HP.", 0f, 6f, Types.Nature, Move.Function.Heal);
        Heal.ExtraEffect = () =>
        {
            BattleManager bm = GetBattleManager();

            float RNG = Random.Range(0.8f, 1.0f);
            float bestBonus = (GetUser().TopTypes.Contains(Types.Nature)) ? 1.25f : 1f;
            int healAmount = (int) ((GetUser().entityStats.HPMax * GetUser().TypeAffinities[Types.Nature] / 6f) * RNG * bestBonus);

            // Caps damage if it's greater than the target's HP.
            healAmount = (healAmount > GetUser().entityStats.HPMax - GetUser().entityStats.HPCurrent) ? (int) (GetUser().entityStats.HPMax - GetUser().entityStats.HPCurrent) : healAmount;

            GetUser().Heal(healAmount);
            GetUser().LoseEnergy(6);

            bm.Write(GetUser().Name + " used Heal and healed " + healAmount + " damage!");
        };
        Uproot = new Move("Uproot", "The user scoops the opponent from the ground.", 20f, 2f, Types.Nature);
        Grow = new Move("Grow", "The user heals back some of their Energy and boosts the damage they do next turn.", 0f, 0f, Types.Nature, Move.Function.Restore_Energy);
        Grow.ExtraEffect = () =>
        {
            BattleManager bm = GetBattleManager();

            float RNG = Random.Range(0.8f, 1.0f);
            float bestBonus = (GetUser().TopTypes.Contains(Types.Nature)) ? 1.25f : 1f;
            int restoreAmount = (int)((GetUser().entityStats.EnergyMax * GetUser().TypeAffinities[Types.Nature] / 6f) * RNG * bestBonus);

            // Caps damage if it's greater than the target's HP.
            restoreAmount = (restoreAmount > GetUser().entityStats.EnergyMax - GetUser().entityStats.EnergyCurrent) ? (int)(GetUser().entityStats.EnergyMax - GetUser().entityStats.EnergyCurrent) : restoreAmount;

            GetUser().GainEnergy(restoreAmount);

            bm.Write(GetUser().Name + " used Grow and restored " + restoreAmount + " energy!");

            bm.turnEffects[bm.turnsPassed + 2].Add(() =>
            {
                GetUser().damageBuff = 1.5f;
            });
        };
        SawgrassSlice = new Move("Sawgrass Slice", "The user slices the opponent with a sharp blade of grass.", 40f, 4f, Types.Nature);
        ProtectionLeaf = new Move("Protection Leaf", "The user protects themselves from the next attack.", 0f, 6f, Types.Nature, Move.Function.Block);
        /* Doesn't work */ ProtectionLeaf.ExtraEffect = () =>
        {
            BattleManager bm = GetBattleManager();

            bm.Write(GetUser().Name + " used Protection Leaf!");

            bm.turnEffects[bm.turnsPassed + 1].Add(() =>
            {
                // Take 0 damage.
            });
        };
        TwistingVines = new Move("Twisting Vines", "The user grows vines out of the ground to attack the opponent.", 60f, 6f, Types.Nature);
        SuperHeal = new Move("Super Heal", "The user heals back some of their HP for 3 turns.", 0f, 8f, Types.Nature, Move.Function.Heal);
        SuperHeal.ExtraEffect = () =>
        {
            BattleManager bm = GetBattleManager();

            bm.Write(GetUser().Name + " used Super Heal!");
            GetUser().LoseEnergy(6);

            for (uint i = 2; i <= 6; i += 2)
            {
                bm.turnEffects[bm.turnsPassed + i].Add(() =>
                {
                    float RNG = Random.Range(0.8f, 1.0f);
                    float bestBonus = (GetUser().TopTypes.Contains(Types.Nature)) ? 1.25f : 1f;
                    int healAmount = (int)((GetUser().entityStats.HPMax * GetUser().TypeAffinities[Types.Nature] / 8f) * RNG * bestBonus);

                    // Caps damage if it's greater than the target's HP.
                    healAmount = (healAmount > GetUser().entityStats.HPMax - GetUser().entityStats.HPCurrent) ? (int)(GetUser().entityStats.HPMax - GetUser().entityStats.HPCurrent) : healAmount;

                    GetUser().Heal(healAmount);
                    bm.UpdateStats();
                });
            }
        };
        PetalStorm = new Move("Petal Storm", "The user calls upon a huge storm of petals to attack the opponent.", 100f, 16f, Types.Nature);
        SneakAttack = new Move("Sneak Attack", "The user sneaks through the grass to deliver a surprise attack onto the opponent.", 80f, 10f, Types.Nature);
        BulbousBeatdown = new Move("Bulbous Beatdown", "The user uses their bulbs to beat the opponent into oblivion.", 120f, 16f, Types.Nature);

        // Water type moves.
        Splash = new Move("Splash", "The user makes a splash in the water.", 15f, 2f, Types.Water);
        Downpour = new Move("Downpout", "The user calls rain down on the opponent.", 30f, 4f, Types.Water);
        Rehydrate = new Move("Rehydrate", "The user rehydrates themselves to regain some HP and Energy.", 0f, 0f, Types.Water, Move.Function.Heal);
        Rehydrate.ExtraEffect = () =>
        {
            BattleManager bm = GetBattleManager();

            float RNG = Random.Range(0.8f, 1.0f);
            float bestBonus = (GetUser().TopTypes.Contains(Types.Water)) ? 1.25f : 1f;
            int healAmount = (int)((GetUser().entityStats.HPMax * GetUser().TypeAffinities[Types.Water] / 6f) * RNG * bestBonus);
            healAmount = (healAmount > GetUser().entityStats.HPMax - GetUser().entityStats.HPCurrent) ? (int)(GetUser().entityStats.HPMax - GetUser().entityStats.HPCurrent) : healAmount;

            float RNG2 = Random.Range(0.8f, 1.0f);
            float bestBonus2 = (GetUser().TopTypes.Contains(Types.Water)) ? 1.25f : 1f;
            int restoreAmount = (int)((GetUser().entityStats.EnergyMax * GetUser().TypeAffinities[Types.Water] / 6f) * RNG2 * bestBonus2);
            restoreAmount = (restoreAmount > GetUser().entityStats.EnergyMax - GetUser().entityStats.EnergyCurrent) ? (int)(GetUser().entityStats.EnergyMax - GetUser().entityStats.EnergyCurrent) : restoreAmount;

            GetUser().Heal(healAmount);
            GetUser().GainEnergy(restoreAmount);

            bm.Write(GetUser().Name + " used Rehydrate and healed " + healAmount + " damage and restored " + restoreAmount + " energy!");
        };
        Waterball = new Move("Waterball", "The user shoots a waterball at the opponent.", 50f, 6f, Types.Water);
        Aquify = new Move("Aquify", "The user blasts the opponent with high-speed water.", 60f, 6f, Types.Water);
        Absorption = new Move("Absorption", "The user absorbs all the water nearby to heal themselves. If there is water in the terrain, this increases.", 0f, 10f, Types.Water, Move.Function.Heal);
        Absorption.ExtraEffect = () =>
        {
            BattleManager bm = GetBattleManager();

            float RNG = Random.Range(0.8f, 1.0f);
            float bestBonus = (GetUser().TopTypes.Contains(Types.Water)) ? 1.25f : 1f;
            int healAmount = (int)((GetUser().entityStats.HPMax * GetUser().TypeAffinities[Types.Water] / 6f) * RNG * bestBonus);

            // Caps damage if it's greater than the target's HP.
            healAmount = (healAmount > GetUser().entityStats.HPMax - GetUser().entityStats.HPCurrent) ? (int)(GetUser().entityStats.HPMax - GetUser().entityStats.HPCurrent) : healAmount;

            GetUser().Heal(healAmount);
            GetUser().LoseEnergy(10);

            bm.Write(GetUser().Name + " used Absorption and healed " + healAmount + " damage!");
        };
        ToweringWave = new Move("Towering Wave", "The user calls upon a giant wave to engulf the opponent.", 80f, 8f, Types.Water);
        CorrosiveBlast = new Move("Corrosive Blast", "The user blasts high-speed water at the opponent.", 100f, 12f, Types.Water);
        WaterDown = new Move("Water Down", "The opponent's non-water type moves deal less damage for 3 turns.", 60f, 8f, Types.Water);
        /* Doesn't work */ WaterDown.ExtraEffect = () =>
        {
            BattleManager bm = GetBattleManager();

            for (uint i = 1; i <= 5; i += 2)
            {
                bm.turnEffects[bm.turnsPassed + i].Add(() =>
                {
                    // Set the power of non-water type moves lower.
                });
            }
        };
        Tsunami = new Move("Tsunami", "The user creates an earthquake that causes a tsunami that drenches the opponent.", 120f, 14f, Types.Water);

        // Fire type moves.
        Firebreath = new Move("Firebreath", "The user uses their firebreath to burn the opponent.", 20f, 4f, Types.Fire); // Small chance of burn.
        FlameShot = new Move("Flame Shot", "The user throws fire at the opponent.", 30f, 6f, Types.Fire); // Medium chance of burn.
        HeatUp = new Move("Heat Up", "The user boosts the power of their fire type moves during the next turn.", 0f, 6f, Types.Fire, Move.Function.Buff);
        /* Doesnt work */ HeatUp.ExtraEffect = () =>
        {
            BattleManager bm = GetBattleManager();

            bm.turnEffects[bm.turnsPassed + 2].Add(() =>
            {
                // Power up user's fire type moves.
            });
        };
        Fireball = new Move("Fireball", "The user casts a fireball towards the opponent.", 60f, 8f, Types.Fire);
        ScorchingSlap = new Move("Scorching Slap", "The user slaps the opponent with a fist of fire.", 80f, 12f, Types.Fire); // High chance of burn.
        FlashFire = new Move("Flash Fire", "The user causes a flash fire to hurt the opponent.", 90f, 12f, Types.Fire);
        Eruption = new Move("Eruption{", "The user erupts into flames and sends burning magma towards the opponent.", 100f, 14f, Types.Fire); // High chance of burn.
        BurnBash = new Move("Burn Bash", "The user slams into the opponent with its entire body engulfed in flames.", 100f, 12f, Types.Fire);
        LavaSpill = new Move("Lava Spill", "The user creates lava out of the ground to burn the opponent.", 120f, 16f, Types.Fire); // Definite chance of burn.
        Inferno = new Move("Inferno", "The user casts a fiery hell upon the opponent to burn them into oblivion.", 140f, 16f, Types.Fire); // High chance of burn.

        // Ice type moves.
        FrozenTap = new Move("Frozen Tap", "The user taps the opponent with a cold touch.", 20f, 4f, Types.Ice); // Small chance of freeze.
        IceTackle = new Move("Ice Tackle", "The user tackles the opponent with a frozen body.", 40f, 6f, Types.Ice); // Small chance of freeze.
        Freeze = new Move("Freeze", "The user freezes the opponent.", 0f, 6f, Types.Ice, Move.Function.Give_Status); // Definite chance of freeze.
        IcicleShot = new Move("Icicle Shot", "The user shoots an icicle at the opponent.", 50f, 6f, Types.Ice);
        BuildingIce = new Move("Building Ice", "The user boosts their defense and damage dealt by ice type moves for 3 turns.", 0f, 8f, Types.Ice, Move.Function.Buff);
        Icebreath = new Move("Icebreath", "The user uses a strong ice breath attack on the opponent.", 60f, 8f, Types.Ice); // Medium chance of freeze.
        Crystalize = new Move("Crystalize", "The user crystalizes the air around them to attack the opponent.", 80f, 10f, Types.Ice);
        BlackIce = new Move("Black Ice", "The user creates black ice on the ground, which may cause the opponent to miss.", 80f, 12f, Types.Ice);
        DryIceSlam = new Move("Dry Ice Slam", "The user slams into the opponent at full force with a frozen body.", 80f, 16f, Types.Ice); // 50% of burn, 50% of freeze.
        Hailstorm = new Move("Hailstorm", "The user calls upon a hailstorm to rain down snow on the opponent.", 100f, 16f, Types.Ice); // High chance of freeze.

        // Earth type moves.
        MudShot = new Move("Mud Shot", "The user tosses mud at the opponent.", 10f, 4f, Types.Earth); // Medium chance to blind.
        PebbleToss = new Move("Pebble Toss", "The user tosses a pebble at the opponent.", 30f, 6f, Types.Earth);
        Landslide = new Move("Landslide", "THe user causes a landslide that buries the opponent.", 60f, 10f, Types.Earth);
        SharpRocks = new Move("Sharp Rocks", "The opponent tosses sharp rocks on the ground that hurt the opponent when they attack.", 0f, 8f, Types.Earth, Move.Function.Give_Status);
        RockWall = new Move("Rock Wall", "The user raises a wall of rocks to protect themselves.", 0f, 8f, Types.Earth, Move.Function.Block);
        SandBlast = new Move("Sand Blast", "The user blasts the opponent with sand.", 80f, 12f, Types.Earth);
        FaultLine = new Move("Fault Line", "The user discovers a fault line under the opponent that opens up to swallow them.", 100f, 16f, Types.Earth);
        Terrawave = new Move("Terrawave", "The user slams into the ground so hard that the ground moves in waves, sending the opponent into the air.", 100f, 14f, Types.Earth);
        Earthquake = new Move("Earthquake", "The user causes an earthquake to damage the opponent.", 140f, 18f, Types.Earth);
        SeismicSmash = new Move("Seismic Smash", "The user slams into the opponent with tremendous force.", 140f, 16f, Types.Earth);
        
        // Volt type moves. Need to have damage and energy balanced.
        ZippityZap = new Move("Zippity-Zap", "The user zaps the opponent with electricity.", 30f, 10f, Types.Volt);
        Charge = new Move("Charge", "The user charges up their electric energy.", 45f, 20f, Types.Volt);
        Thundershock = new Move("Thundershock", "The user shocks the opponent.", 60f, 25f, Types.Volt);
        LightningQuickTackle = new Move("Lightning Quick Tackle", "The user tackles the opponent at lightning speed.", 0f, 0f, Types.Volt);
        ElectroPulse = new Move("Electro Pulse", "THe user shocks the opponent with a burst of elecromagnetic power.", 0f, 0f, Types.Volt);
        Resistor = new Move("Resistor", "The user resists the opponent's next move.", 0f, 0f, Types.Volt);
        ShockStrike = new Move("Shock Strike", "The user strikes the opponent with electricity.", 80f, 35f, Types.Volt);
        LightingBoltBlast = new Move("Lightning Bolt Blast", "The user calls down lightning upon the opponent.", 100f, 50f, Types.Volt);
        ElectricalOverload = new Move("Electrical Overload", "The user charges up too much electricity and explodes.", 0f, 0f, Types.Volt);
        GalvanicExplosion = new Move("Galvanic Explosion", "The user creates an explosion of electricity that engulfs the opponent.", 0f, 0f, Types.Volt);

        // Wind type moves.
        GentleBreeze = new Move("Gentle Breeze", "The user creates a gentle breeze aimed towards the opponent.", 10f, 5f, Types.Wind);
        WindCutter = new Move("Wind Cutter", "The user cuts the air to strike the opponent.", 40f, 10f, Types.Wind);
        JetStream = new Move("Jet Stream", "The user creates a jetstream to harm the opponent.", 70f, 20f, Types.Wind);
        WindMove4 = new Move("Wind Move 3", "", 0f, 0f, Types.Wind);
        WindMove5 = new Move("Wind Move 4", "", 0f, 0f, Types.Wind);
        WindMove6 = new Move("Wind Move 5", "", 0f, 0f, Types.Wind);
        Tornado = new Move("Tornado", "The user summons a tornado to sweep up the opponent.", 90f, 35f, Types.Wind);
        AirPollution = new Move("Air Pollution", "The user poisons the air around themself and the opponent.", 0f, 0f, Types.Wind); // Definite chance to poison the user and the opponent.
        WindMove9 = new Move("Wind Move 9", "", 0f, 0f, Types.Wind);
        WindMove10 = new Move("Wind Move 10", "", 0f, 0f, Types.Wind);

        // Toxin type moves.
        PoisonSpit = new Move("Poison Spit", "The user spits poison at the opponent.", 20f, 10f, Types.Toxin, Move.Function.Give_Status); // Low chance of poison.
        ToxicBlock = new Move("Toxic Block", "The user blocks the next attack from the opponent.", 0f, 0f, Types.Toxin, Move.Function.Block); // Low chance of poison.
        VenomousStrike = new Move("Venomous Strike", "The user strikes the opponent with a venomous attack.", 70f, 30f, Types.Toxin); // High chance of poison.
        ToxinMove4 = new Move("Toxin Move 3", "", 0f, 0f, Types.Toxin);
        PoisonPummel = new Move("Poison Pummel", "", 0f, 0f, Types.Toxin);
        ToxinMove6 = new Move("Toxin Move 5", "", 0f, 0f, Types.Toxin);
        PoisonFangs = new Move("Poison Fangs", "The user bites down into the opponent with their poisonous fangs.", 50f, 15f, Types.Toxin); // Medium chance of poison.
        ToxicSludge = new Move("Toxic Sludge", "The user sends a wave of toxic sludge towards the opponent.", 85f, 25f, Types.Toxin); // High chance of poison.
        ToxinMove9 = new Move("Toxin Move 9", "", 0f, 0f, Types.Toxin);
        ToxinMove10 = new Move("Toxin Move 10", "", 0f, 0f, Types.Toxin);

        // Light type moves.
        HeavenlyRestore = new Move("Heavenly Restore", "The user regains some HP by healing themselves.", 0f, 4f, Types.Light, Move.Function.Heal);
        HeavenlyRestore.ExtraEffect = () =>
        {
            BattleManager bm = GetBattleManager();

            float RNG = Random.Range(0.8f, 1.0f);
            float bestBonus = (GetUser().TopTypes.Contains(Types.Light)) ? 1.25f : 1f;
            int healAmount = (int)((GetUser().entityStats.HPMax * GetUser().TypeAffinities[Types.Light] / 8f) * RNG * bestBonus);

            // Caps damage if it's greater than the target's HP.
            healAmount = (healAmount > GetUser().entityStats.HPMax - GetUser().entityStats.HPCurrent) ? (int)(GetUser().entityStats.HPMax - GetUser().entityStats.HPCurrent) : healAmount;

            GetUser().Heal(healAmount);
            GetUser().LoseEnergy(HeavenlyRestore.EnergyUse);

            bm.Write(GetUser().Name + " used Heavenly Restore and healed " + healAmount + " damage!");
        };
        HaloHop = new Move("Halo Hop", "The user hops into the air and lands on top of the opponent.", 30f, 10f, Types.Light);
        SavingGrace = new Move("Saving Grace", "The user blesses themselves.", 0f, 10f, Types.Light, Move.Function.Buff); // Definite chance to bless the user.
        ShiningStrike = new Move("Light Move 3", "", 0f, 0f, Types.Light);
        LightMove5 = new Move("Light Move 4", "", 0f, 0f, Types.Light);
        LightMove6 = new Move("Light Move 5", "", 0f, 0f, Types.Light);
        BlindingLight = new Move("Blinding Light", "The user casts a blinding light to blind the opponent.", 0f, 15f, Types.Light, Move.Function.Give_Status); // Definite chance of blindness.
        PhotonBlast = new Move("Photon Blast", "The user uses photons the blast the opponent.", 100f, 40f, Types.Light);
        LightMove9 = new Move("Light Move 9", "", 0f, 0f, Types.Light);
        LightMove10 = new Move("Light Move 10", "", 0f, 0f, Types.Light);

        // Dark type moves.
        Backstab = new Move("Backstab", "The user waits to attack the opponent until the next turn.", 35f, 8f, Types.Shadow);
        /* Doesn't work */ Backstab.ExtraEffect = () =>
        {
            BattleManager bm = GetBattleManager();

            bm.Write(GetUser().Name + " is waiting to use Backstab...");

            bm.turnEffects[bm.turnsPassed + 2].Add(() =>
            {
                // Attack.

                BattleEntity target = (GetUser() is BattlePlayer) ? (BattleEntity)BattleManager.enemy : BattleManager.player;

                int totalDamage = GetUser().CalcDamage(Backstab, target);
                target.TakeDamage(totalDamage);
                GetUser().LoseEnergy(8);

                bm.ignoreOptions = true;

                bm.Write(GetUser().Name + " used Backstab and did " + totalDamage + " damage!");
            });
        };
        UmbraSlash = new Move("UmbraSlash", ".", 0f, 10f, Types.Shadow);
        LifeSteal = new Move("Life Steal", ".", 40f, 15f, Types.Shadow);
        Curse = new Move("Curse", "", 0f, 0f, Types.Shadow);
        Nightmare = new Move("Nightmare", "", 0f, 0f, Types.Shadow);
        EvilPlan = new Move("Evil Plan", "", 0f, 0f, Types.Shadow);
        ShadowMove7 = new Move("ShadowMove7", "", 0f, 0f, Types.Shadow);
        BlackHole = new Move("Black Hole", ".", 100f, 40f, Types.Shadow);
        Manipulate = new Move("Manipulate", "", 0f, 0f, Types.Shadow);
        PitchBlackTerror = new Move("Pitch Black Terror", "", 0f, 0f, Types.Shadow);
    }
}
