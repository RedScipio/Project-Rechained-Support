﻿using System.Collections.Generic;
using static SingleplayerLauncher.Names.Hero;
using static SingleplayerLauncher.Names.Trap;
using static SingleplayerLauncher.Names.TrapPartSlot;

namespace SingleplayerLauncher.Model
{
    public class Trap : SlotItem
    {

    public int CoinCost { get; private set; }
    public string[] TrapPartSlots { get; private set; }

        // static members
        public static Trap ArcaneBowlingBall = new Trap()
        {
            Id = 100,
            Name = ARCANE_BOWLING_BALL,
            Description = "Fires an orb in a straight line, dealing arcane damage. The orb's damage causes subsequent Arcane attacks to deal more damage. +25% damage when used by Stinkeye.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapArcaneOrb",


        };
        public static Trap ArcanePhaser = new Trap()
        {
            Id = 101,
            Name = ARCANE_PHASER,
            Description = "Emits a cloud of Arcane energy when triggered, dealing Arcane damage to enemies that walk across it. Trap expires after firing 9 times.",
            TrapPartSlots = new string[] { COMPONENTS, FIELD, RESONATOR },
            ItemTemplateName = "SpitfireGame.RItemTrapArcanePhase",


        };
        public static Trap ArrowWall = new Trap()
        {
            Id = 102,
            Name = ARROW_WALL,
            Description = "Fires a barrage of arrows in a straight line when triggered, dealing Physical damage.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapArrowWall",


        };
        public static Trap BGHArrowWall = new Trap()
        {
            Id = 103,
            Name = BGH_ARROW_WALL,
            Description = "ONLY attacks Hunter Minions, Bosses and Mercenaries. Fires a barrage of magical, mercenary and boss seeking arrows, dealing a portion of the target's max health and a bonus as damage.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapArrowWallGlorySeeker",


        };
        public static Trap CeilingBallista = new Trap()
        {
            Id = 104,
            Name = CEILING_BALLISTA,
            Description = "Fires long-range arrows radially from above when triggered, dealing Physical damage. It also targets Unstable Rifts but deals very low damage to them  opposed to the Big Game Hunting Ballista.Ballistas, activation range is lengthened / shortened by Line of Sight(LoS).So if minions come around a corner, the activation range is changed based on the trap's LoS and any Triggers would activate at that point.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapBallistaCeiling",


        };
        public static Trap DragonsLance = new Trap()
        {
            Id = 105,
            Name = DRAGONS_LANCE,
            Description = "Fires a magical lance when triggered, dealing Arcane damage. Lance casts a debuff, causing Arcane attacks to deal more damage. Dragon's Lance, activation range is lengthened / shortened by Line of Sight(LoS).So if minions come around a corner, the activation range is changed based on the trap's LoS and any Triggers would activate at that point.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapBallistaCeilingArcane",


        };
        public static Trap BGHCeilingBallista = new Trap()
        {
            Id = 106,
            Name = BGH_CEILING_BALLISTA,
            Description = "ONLY attacks Hunter Minions, Bosses and Mercenaries. Also attacks Unstable Rifts Fires Mercenary and Boss seeking arrows, dealing a portion of the target's max health plus a bonus as damage.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapBallistaCeilingGlorySeeker",


        };
        public static Trap Barricade = new Trap()
        {
            Id = 107,
            Name = BARRICADE,
            Description = "Blocks and redirects Minion paths. Useful for forcing Minions into Traps.",
            TrapPartSlots = new string[] { CLADDING, COMPONENTS, FRAME },
            ItemTemplateName = "SpitfireGame.RItemTrapBarricade",

        };
        public static Trap GreatWallBarricade = new Trap()
        {
            Id = 108,
            Name = GREAT_WALL_BARRICADE,
            Description = "Blocks and redirects minions. The Great Wall Barricade is a longer version of the Barricade.",
            TrapPartSlots = new string[] { CLADDING, COMPONENTS, FRAME },
            ItemTemplateName = "SpitfireGame.RItemTrapBarricadeGreatWall",

        };
        public static Trap BoomBarrel = new Trap()
        {
            Id = 109,
            Name = BOOM_BARREL,
            Description = "Explodes when hit, dealing damage in a small area. -20% cost when used by Deadeye.",
            TrapPartSlots = new string[] { RESONATOR, COMPONENTS, RESONATOR },
            ItemTemplateName = "SpitfireGame.RItemTrapBoomBarrel",


        };
        public static Trap BoomBarrelRoller = new Trap()
        {
            Id = 110,
            Name = BOOM_BARREL_ROLLER,
            Description = "Occasionally rolls out Boom Barrels which explode when hit, dealing damage in a small area.",
            TrapPartSlots = new string[] { COIL, COMPONENTS, COIL },
            ItemTemplateName = "SpitfireGame.RItemTrapBoomBarrelDispenser",


        };
        public static Trap BoulderChute = new Trap()
        {
            Id = 111,
            Name = BOULDER_CHUTE,
            Description = "Drops boulders on Enemies when shot by a hero. Boulders deal Physical damage.",
            TrapPartSlots = new string[] { COMPONENTS, RESONATOR, SPRING },
            ItemTemplateName = "SpitfireGame.RItemTrapBoulderChute",


        };
        public static Trap IcicleImpaler = new Trap()
        {
            Id = 112,
            Name = ICICLE_IMPALER,
            Description = "Drops sharp icicles when shot by a Hero, dealing Frost damage and casting Chilled on Enemies.",
            TrapPartSlots = new string[] { COMPONENTS, RESONATOR, SPRING },
            ItemTemplateName = "SpitfireGame.RItemTrapBoulderChuteFrost",


        };
        public static Trap Brimstone = new Trap()
        {
            Id = 113,
            Name = BRIMSTONE,
            Description = "Burns Enemies that walk across its embers, dealing Fire damage over time. Fire damage from multiple brimstones does not stack.",
            TrapPartSlots = new string[] { FIELD, RESONATOR, SPRING },
            ItemTemplateName = "SpitfireGame.RItemTrapBrimstone",


        };
        public static Trap CoinForge = new Trap()
        {
            Id = 114,
            Name = COIN_FORGE,
            Description = "Enemies are worth 64% additional coin if they are killed on this trap. +10% additional coin when used by Dobbin.",
            TrapPartSlots = new string[] { FIELD, FIELD, FIELD },
            ItemTemplateName = "SpitfireGame.RItemTrapCoinForge",


        };
        public static Trap CursedGround = new Trap()
        {
            Id = 115,
            Name = CURSED_GROUND,
            Description = "Deals Arcane damage that increases as Enemies stay on this tile. Also causes subsequent Arcane attacks to deal more damage. +25% damage when used by Oziel.",
            TrapPartSlots = new string[] { FIELD, RESONATOR, SPRING },
            ItemTemplateName = "SpitfireGame.RItemTrapCursedGround",


        };
        public static Trap Decoy = new Trap()
        {
            Id = 116,
            Name = DECOY,
            Description = "Attracts Enemies to attack it until it is destroyed. The decoy does not respawn and must be replaced. Trap is free when used by Maximilian.",
            TrapPartSlots = new string[] { CLADDING, COMPONENTS, FRAME },
            ItemTemplateName = "SpitfireGame.RItemTrapDecoySturdy",

        };
        public static Trap SpitfireWall = new Trap()
        {
            Id = 117,
            Name = SPITFIRE_WALL,
            Description = "Spits fireballs at Enemies, dealing Fire damage over time. Fire damage from multiple spitfire walls does not stack.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapFireArrowWall",


        };
        public static Trap FireCracker = new Trap()
        {
            Id = 118,
            Name = FIRE_CRACKER,
            Description = "Emits a fiery mist, dealing Fire damage over time when triggered. Fire damage from multiple fire crackers does not stack.",
            TrapPartSlots = new string[] { FIELD, RESONATOR, SPRING },
            ItemTemplateName = "SpitfireGame.RItemTrapFireCracks",


        };
        public static Trap FlipTrap = new Trap()
        {
            Id = 119,
            Name = FLIP_TRAP,
            Description = "Flips enemies into the air when triggered. This trap is useful for propelling Enemies into other traps.",
            TrapPartSlots = new string[] { ACCUMULATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapFlip",


        };
        public static Trap FloorScorcher = new Trap()
        {
            Id = 120,
            Name = FLOOR_SCORCHER,
            Description = "Scorches Enemies when triggered, dealing Fire damage over time. Fire damage from multiple floor scorchers does not stack.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapFloorScorcher",


        };
        public static Trap TempleAlarmGong = new Trap()
        {
            Id = 121,
            Name = TEMPLE_ALARM_GONG,
            Description = "This ancient gong sounds an alarm when Enemies approach and slows them by 70%. -20% cooldown when used by Yi-Lin.",
            TrapPartSlots = new string[] { FIELD, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapGong",
            CoinCost = 1000,
        };
        public static Trap Grinder = new Trap()
        {
            Id = 122,
            Name = GRINDER,
            Description = "Grinds up Enemies walking past it, dealing Physical damage until it jams. After jamming, the Grinder must cooldown to reset.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapGrinder",


        };
        public static Trap QuarterPounder = new Trap()
        {
            Id = 123,
            Name = QUARTER_POUNDER,
            Description = "Pounds one quarter of the trap area when triggered, dealing high Physical damage and stunning Minions.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapHammerDrop",


        };
        public static Trap Haymaker = new Trap()
        {
            Id = 124,
            Name = HAYMAKER,
            Description = "Descends from the ceiling and spins when triggered, knocking Enemies around and dealing Physical damage.",
            TrapPartSlots = new string[] { ACCUMULATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapHaymaker",


        };
        public static Trap HealingWell = new Trap()
        {
            Id = 125,
            Name = HEALING_WELL,
            Description = "Casts a health regeneration buff on an ally. The buff is dispelled upon taking damage. Once used, it must reset.",
            TrapPartSlots = new string[] { ATTUNER, COIL, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapHealingWell",


        };
        public static Trap IceShard = new Trap()
        {
            Id = 126,
            Name = ICE_SHARD,
            Description = "Cuts enemies, dealing Frost damage and casting Chilled on them. Enemies are frozen after multiple stacks of Chilled (5 stacks).",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapIceSpike",


        };
        public static Trap IceVent = new Trap()
        {
            Id = 127,
            Name = ICE_VENT,
            Description = "Emits icy mist that deals Frost damage and casts Chilled on enemies. Enemies are frozen after multiple stacks of Chilled (5 stacks). +25% damage when used by Hogarth.",
            TrapPartSlots = new string[] { FIELD, RESONATOR, SPRING },
            ItemTemplateName = "SpitfireGame.RItemTrapIceVent",


        };
        public static Trap LightningRod = new Trap()
        {
            Id = 128,
            Name = LIGHTNING_ROD,
            Description = "Shocks Enemies beneath it with lightning when triggered. Every few times this trap fires, it becomes more powerful, allowing its attack to chain to additional Enemies.",
            TrapPartSlots = new string[] { COMPONENTS, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapLightningRod",


        };
        public static Trap ManaWell = new Trap()
        {
            Id = 129,
            Name = MANA_WELL,
            Description = "Grants a mana regeneration buff to a nearby ally. Buff is lost upon taking damage. Once used, the Mana Well must reset.",
            TrapPartSlots = new string[] { ATTUNER, COIL, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapManaWell",


        };
        public static Trap SummonerTrap = new Trap()
        {
            Id = 130,
            Name = SUMMONER_TRAP,
            Description = "Calls a ghostly summoned retainer to fight for the Hero. If it is killed, the trap must reset. Limit 2 at a time. +25 trap health if used by Gabriella.Revenge Rune and Reusable Shielding have a cooldown of 300 seconds(5 minutes) when used in Summoner Trap.",
            TrapPartSlots = new string[] { CLADDING, COMPONENTS, FRAME },
            ItemTemplateName = "SpitfireGame.RItemTrapMinionSpawner",


        };
        public static Trap NaphthaSprayer = new Trap()
        {
            Id = 131,
            Name = NAPHTHA_SPRAYER,
            Description = "Sprays enemies with naphtha when triggered. Naphtha causes Enemies to take increased Fire damage. Trap is free when used by Smolder.",
            TrapPartSlots = new string[] { COMPONENTS, FIELD, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapNapthaSprayer",


        };
        public static Trap OverloadTrap = new Trap()
        {
            Id = 132,
            Name = OVERLOAD_TRAP,
            Description = "Overloads traps, dealing damage when triggered and disabling floor traps that deal damage. +25% damage when used by Zoey.",
            TrapPartSlots = new string[] { COMPONENTS, RESONATOR, SPRING },
            ItemTemplateName = "SpitfireGame.RItemTrapOverload",


        };
        public static Trap PowerupDamage = new Trap()
        {
            Id = 133,
            Name = POWERUP_DAMAGE,
            Description = "Drops a Powerup that boosts player damage for a short time.",
            TrapPartSlots = new string[] { ATTUNER, COIL, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapPlayerPowerup",


        };
        public static Trap Pounder = new Trap()
        {
            Id = 134,
            Name = POUNDER,
            Description = "Pounds Enemies that pass beneath it when triggered, dealing Physical damage.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapPounder",


        };
        public static Trap ConcussivePounder = new Trap()
        {
            Id = 135,
            Name = CONCUSSIVE_POUNDER,
            Description = "Pounds Enemies into the ground when triggered, stunning them. Deals no damage.",
            TrapPartSlots = new string[] { COIL, COMPONENTS, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapPounderConcussive",


        };
        public static Trap PowerGenerator = new Trap()
        {
            Id = 136,
            Name = POWER_GENERATOR,
            Description = "Generates coin for the owner if Enemies walk in front of it. Loses health each time it generates coin. Doesn't return coin when sold. Note: Generates 468 coins per wave at Tier 7.",
            TrapPartSlots = new string[] { FIELD, COMPONENTS, FIELD },
            ItemTemplateName = "SpitfireGame.RItemTrapPowerGenerator",


        };
        public static Trap PushTrap = new Trap()
        {
            Id = 137,
            Name = PUSH_TRAP,
            Description = "Shoves Enemies when triggered, pushing them away and dealing Physical damage.",
            TrapPartSlots = new string[] { ACCUMULATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapPushTrap",


        };
        public static Trap SawOfArctos = new Trap()
        {
            Id = 138,
            Name = SAW_OF_ARCTOS,
            Description = "Slices through Enemies with an ice blade, dealing Frost damage and casting Chilled on them. Enemies are frozen with 5 Chilled Stacks. + 25% damage when used by Tundra.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapSawOfArctos",


        };
        public static Trap ShieldPowerup = new Trap()
        {
            Id = 139,
            Name = SHIELD_POWERUP,
            Description = "Drops a Powerup for Heroes that temporarily reduces damage taken.",
            TrapPartSlots = new string[] { ATTUNER, COIL, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapShieldSpawner",


        };
        public static Trap SpeedPad = new Trap()
        {
            Id = 140,
            Name = SPEED_PAD,
            Description = "Increases the movement speed of a Hero crossing it. Pad must reset after use.",
            TrapPartSlots = new string[] { ATTUNER, COIL, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapSpeedPad",


        };
        public static Trap FloorSpikes = new Trap()
        {
            Id = 141,
            Name = FLOOR_SPIKES,
            Description = "Skewers Enemies from below when triggered, dealing Physical damage.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapSpikes",


        };
        public static Trap SpikeWall = new Trap()
        {
            Id = 142,
            Name = SPIKE_WALL,
            Description = "Swings a wall of spikes at Enemies when triggered, knocking them back and dealing Physical damage.",
            TrapPartSlots = new string[] { ACCUMULATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapSpikeWall",


        };
        public static Trap SteamVent = new Trap()
        {
            Id = 143,
            Name = STEAM_VENT,
            Description = "Blows small and normal-sized Minions into the air when triggered. Slows large Minions. Trap deals no damage.",
            TrapPartSlots = new string[] { COIL, COMPONENTS, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapSteamVent",


        };
        public static Trap SwingingMace = new Trap()
        {
            Id = 144,
            Name = SWINGING_MACE,
            Description = "Continuously swings a large mace, pummeling enemies that pass beneath it and dealing Physical damage.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapSwingingMace",


        };
        public static Trap TarTrap = new Trap()
        {
            Id = 145,
            Name = TAR_TRAP,
            Description = "Tars the feet of Enemies crossing it, causing them to be slowed while on the trap.",
            TrapPartSlots = new string[] { FIELD, COMPONENTS, FIELD },
            ItemTemplateName = "SpitfireGame.RItemTrapTar",


        };
        public static Trap ViscousTar = new Trap()
        {
            Id = 146,
            Name = VISCOUS_TAR,
            Description = "Tars the feet of Enemies crossing it, causing them to be slowed while on the trap and for a short duration afterwards.",
            TrapPartSlots = new string[] { FIELD, COMPONENTS, FIELD },
            ItemTemplateName = "SpitfireGame.RItemTrapTarViscous",


        };
        public static Trap ShockZapper = new Trap()
        {
            Id = 147,
            Name = SHOCK_ZAPPER,
            Description = "Zaps enemies with Lightning, dealing Lightning damage. Enemies killed by Lightning explode, dealing damage in an area.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapTeslaCoil",


        };
        public static Trap BGHShockZapper = new Trap()
        {
            Id = 148,
            Name = BGH_SHOCK_ZAPPER,
            Description = "ONLY attacks Hunter Minions, Bosses and Mercenaries. Zaps Mercenaries and Bosses with Lightning, dealing a portion of targets' max health as damage plus a bonus.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, COMPONENTS },
            ItemTemplateName = "SpitfireGame.RItemTrapTeslaCoilGlorySeeker",


        };
        public static Trap TripWire = new Trap()
        {
            Id = 149,
            Name = TRIP_WIRE,
            Description = "When a Minion 'trips' on the trip wire, it triggers nearby Traps. Wire is destroyed on use. -20% trap cost when used by Midnight.",
            TrapPartSlots = new string[] { COMPONENTS, TRIGGER, FIELD },
            ItemTemplateName = "SpitfireGame.RItemTrapTripwire",
            CoinCost = 1000,
        };
        public static Trap WallBlades = new Trap()
        {
            Id = 150,
            Name = WALL_BLADES,
            Description = "Slices and dices Enemies when triggered, dealing Physical damage.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapWallBlades",


        };
        public static Trap WallCharger = new Trap()
        {
            Id = 151,
            Name = WALL_CHARGER,
            Description = "Shocks Enemies that walk by it, dealing Lightning damage. Enemies killed by Lightning explode, dealing damage in an area.",
            TrapPartSlots = new string[] { RESONATOR, SPRING, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapWallBladesCharged",


        };
        public static Trap WebSpinner = new Trap()
        {
            Id = 152,
            Name = WEB_SPINNER,
            Description = "Spins a web around Enemies when triggered, slowing their attack speed and causing them to be slowed.",
            TrapPartSlots = new string[] { COMPONENTS, FIELD, TRIGGER },
            ItemTemplateName = "SpitfireGame.RItemTrapWebSpinner",

        };


        public static Dictionary<string, SlotItem> Traps = new Dictionary<string, SlotItem>
        {
            //{ "Acid Sprayer", null },
            { ARCANE_BOWLING_BALL, ArcaneBowlingBall },
            { ARCANE_PHASER, ArcanePhaser },
            { ARROW_WALL, ArrowWall },
            { BGH_ARROW_WALL, BGHArrowWall },
            { CEILING_BALLISTA, CeilingBallista },
            { DRAGONS_LANCE, DragonsLance },
            { BGH_CEILING_BALLISTA, BGHCeilingBallista },
            { BARRICADE, Barricade },
            { GREAT_WALL_BARRICADE, GreatWallBarricade },
            { BOOM_BARREL, BoomBarrel },
            { BOOM_BARREL_ROLLER, BoomBarrelRoller },
            { BOULDER_CHUTE, BoulderChute },
            { ICICLE_IMPALER, IcicleImpaler },
            { BRIMSTONE, Brimstone },
            { COIN_FORGE, CoinForge },
            { CURSED_GROUND, CursedGround },
            { DECOY, Decoy },
            { SPITFIRE_WALL, SpitfireWall },
            { FIRE_CRACKER, FireCracker },
            { FLIP_TRAP, FlipTrap },
            { FLOOR_SCORCHER, FloorScorcher },
            { TEMPLE_ALARM_GONG, TempleAlarmGong },
            { GRINDER, Grinder },
            { QUARTER_POUNDER, QuarterPounder },
            { HAYMAKER, Haymaker },
            { HEALING_WELL, HealingWell },
            { ICE_SHARD, IceShard },
            { ICE_VENT, IceVent },
            { LIGHTNING_ROD, LightningRod },
            { MANA_WELL, ManaWell },
            { SUMMONER_TRAP, SummonerTrap },
            { NAPHTHA_SPRAYER, NaphthaSprayer },
            { OVERLOAD_TRAP, OverloadTrap },
            { POWERUP_DAMAGE, PowerupDamage },
            { POUNDER, Pounder },
            { CONCUSSIVE_POUNDER, ConcussivePounder },
            { POWER_GENERATOR, PowerGenerator },
            //{ "Projectile Shield", null },
            { PUSH_TRAP, PushTrap },
            { SAW_OF_ARCTOS, SawOfArctos },
            { SHIELD_POWERUP, ShieldPowerup },
            { SPEED_PAD, SpeedPad },
            { FLOOR_SPIKES, FloorSpikes },
            { SPIKE_WALL, SpikeWall },
            { STEAM_VENT, SteamVent },
            { SWINGING_MACE, SwingingMace },
            { TAR_TRAP, TarTrap },
            { VISCOUS_TAR, ViscousTar },
            { SHOCK_ZAPPER, ShockZapper },
            { BGH_SHOCK_ZAPPER, BGHShockZapper },
            { TRIP_WIRE, TripWire},
            { WALL_BLADES, WallBlades },
            { WALL_CHARGER, WallCharger },
            { WEB_SPINNER, WebSpinner }
        };


        public static Dictionary<int, SlotItem> TrapsById = new Dictionary<int, SlotItem>
        {
            //{ AcidSprayer.Id, null },
            { ArcaneBowlingBall.Id, ArcaneBowlingBall },
            { ArcanePhaser.Id, ArcanePhaser },
            { ArrowWall.Id, ArrowWall },
            { BGHArrowWall.Id, BGHArrowWall },
            { CeilingBallista.Id, CeilingBallista },
            { DragonsLance.Id, DragonsLance },
            { BGHCeilingBallista.Id, BGHCeilingBallista },
            { Barricade.Id, Barricade },
            { GreatWallBarricade.Id, GreatWallBarricade },
            { BoomBarrel.Id, BoomBarrel },
            { BoomBarrelRoller.Id, BoomBarrelRoller },
            { BoulderChute.Id, BoulderChute },
            { IcicleImpaler.Id, IcicleImpaler },
            { Brimstone.Id, Brimstone },
            { CoinForge.Id, CoinForge },
            { CursedGround.Id, CursedGround },
            { Decoy.Id, Decoy },
            { SpitfireWall.Id, SpitfireWall },
            { FireCracker.Id, FireCracker },
            { FlipTrap.Id, FlipTrap },
            { FloorScorcher.Id, FloorScorcher },
            { TempleAlarmGong.Id, TempleAlarmGong },
            { Grinder.Id, Grinder },
            { QuarterPounder.Id, QuarterPounder },
            { Haymaker.Id, Haymaker },
            { HealingWell.Id, HealingWell },
            { IceShard.Id, IceShard },
            { IceVent.Id, IceVent },
            { LightningRod.Id, LightningRod },
            { ManaWell.Id, ManaWell },
            { SummonerTrap.Id, SummonerTrap },
            { NaphthaSprayer.Id, NaphthaSprayer },
            { OverloadTrap.Id, OverloadTrap },
            { PowerupDamage.Id, PowerupDamage },
            { Pounder.Id, Pounder },
            { ConcussivePounder.Id, ConcussivePounder },
            { PowerGenerator.Id, PowerGenerator },
            //{ ShieldProjectile.Id, null },
            { PushTrap.Id, PushTrap },
            { SawOfArctos.Id, SawOfArctos },
            { ShieldPowerup.Id, ShieldPowerup },
            { SpeedPad.Id, SpeedPad },
            { FloorSpikes.Id, FloorSpikes },
            { SpikeWall.Id, SpikeWall },
            { SteamVent.Id, SteamVent },
            { SwingingMace.Id, SwingingMace },
            { TarTrap.Id, TarTrap },
            { ViscousTar.Id, ViscousTar },
            { ShockZapper.Id, ShockZapper },
            { BGHShockZapper.Id, BGHShockZapper },
            { TripWire.Id, TripWire},
            { WallBlades.Id, WallBlades },
            { WallCharger.Id, WallCharger },
            { WebSpinner.Id, WebSpinner }
        };
    }
}
