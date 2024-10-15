using MelonLoader;
using BTD_Mod_Helper;
using OldTackShooter;
using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using System.Collections.Generic;
using System.Linq;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using BTD_Mod_Helper.Api.Display;
using Il2CppAssets.Scripts.Unity.Display;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using static OldTackShooter.Texture000;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Unity;
using Il2Cpp;
using System.Collections.Specialized;
using UnityEngine;
using BTD_Mod_Helper.Api;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppSystem.IO;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Unity.Towers.Behaviors.Abilities;
using BTD_Mod_Helper.Api.Enums;
using Il2CppAssets.Scripts.Models.Effects;
using Il2CppAssets.Scripts.Utils;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using Il2CppNinjaKiwi.Common.ResourceUtils;

[assembly: MelonInfo(typeof(OldTackShooter.OldTackShooter), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace OldTackShooter;

public class OldTackShooter : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<OldTackShooter>("Old Tack Shooter loaded!");
        //Hi Code Readers this is a rly old mod so dont expect some cool stuff
    }
}
public class Texture000 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers.Max() < 1;
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture000");
    }
}
public class Texture100 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers[0] == 1;
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture100");
    }
}
public class Texture200 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;
    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers[0] == 2; 
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture200");
    }
}
public class Texture300 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers[0] == 3;
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture300");
    }
}
public class Texture010 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers[1] == 1;
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture100");
    }
}
public class Texture020 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers[1] == 2;
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture200");
    }
}
public class Texture030 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers[1] == 3;
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture030");
    }
}
public class Texture040 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers[1] == 4;
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture040");
    }
}
public class Texture050 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers[1] == 5;
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture050");
    }
}
public class Texture400 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers[0] == 4;
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture400");
    }
}
public class Texture500 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers[0] == 5;
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture500");
    }
}
public class Texture001 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers[2] == 1;
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture001");
    }
}
public class Texture002 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers[2] == 2;
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture002");
    }
}
public class Texture003 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers[2] == 3;
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture003");
    }
}
public class Texture004 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers[2] == 4;
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture004");
    }
}
public class Texture005 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers)
    {
        return tiers[2] == 5;
    }
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture005");
    }
}
public class OldBlade : ModDisplay
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Tier030Projectile");
        node.gameObject.transform.GetChild(0).localScale = new Vector3(2, 2);
    }
}
public class OldBlade2 : ModDisplay
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Tier050Projectile");
        node.gameObject.transform.GetChild(0).localScale = new Vector3(2, 2);
    }
}
public class OldTack : ModDisplay
    {
        public override string BaseDisplay => Generic2dDisplay;
        public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, "OldTack");
        }
    }
    public class Tier400Projectile : ModDisplay
    {
        public override string BaseDisplay => Generic2dDisplay;
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, "Tier400Projectile");
            node.gameObject.transform.GetChild(0).localScale = new Vector3(3, 3);
    }
 }
public class Tier500Projectile : ModDisplay
{
    public override string BaseDisplay => Generic2dDisplay;
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Tier400Projectile");
        node.gameObject.transform.GetChild(0).localScale = new Vector3(5, 5);
    }
}
public class Texture555 : ModTowerDisplay<OldTackShooter1>
{
    public override string BaseDisplay => Generic2dDisplay;

    public override Il2CppAssets.Scripts.Simulation.SMath.Vector3 PositionOffset => new(0, 0, 100);
    public override bool UseForTower(int[] tiers) => IsParagon(tiers);
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "Texture555");
    }
}

public class BigTack : ModDisplay
{
    public override string BaseDisplay => Generic2dDisplay;
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "OldTack");
        node.gameObject.transform.GetChild(0).localScale = new Vector3(3, 3);
    }
}
public class HugeTack : ModDisplay
{
    public override string BaseDisplay => Generic2dDisplay;
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "OldTack");
        node.gameObject.transform.GetChild(0).localScale = new Vector3(7, 7);
    }
}
public class BladeHugeTack : ModDisplay
{
    public override string BaseDisplay => Generic2dDisplay;
    public override void ModifyDisplayNode(UnityDisplayNode node)
    {
        Set2DTexture(node, "555Projectile");
        node.gameObject.transform.GetChild(0).localScale = new Vector3(7, 7);
    }
}
public class OldTackShooter1 : ModTower
{
    public override string Portrait => "OldTackShooterPortrait";
    public override string Icon => "OldTackShooterIcon";
    public override string DisplayName => "Old Tack Shooter";
    public override TowerSet TowerSet => TowerSet.Primary;
    public override ParagonMode ParagonMode => ParagonMode.Base000;
    public override string BaseTower => TowerType.TackShooter;
    public override int Cost => 360;

    public override int TopPathUpgrades => 5;
    public override int MiddlePathUpgrades => 5;
    public override int BottomPathUpgrades => 5;
    public override string Description => "Old Tack Shooter For The Og! (BTD 5 Tack Shooter)";
    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            towerModel.GetDescendant<DamageModel>().damage = 1;
            var attackModel = towerModel.GetAttackModel();
            var projectile = attackModel.weapons[0].projectile;
            projectile.pierce = 1;
            projectile.ApplyDisplay<OldTack>();
        }
    }

    public override int GetTowerIndex(List<TowerDetailsModel> towerSet)
    {
        return towerSet.First(model => model.towerId == TowerType.BombShooter).towerIndex + 1;
    }
    public override bool IsValidCrosspath(int[] tiers) =>
        ModHelper.HasMod("UltimateCrosspathing") || base.IsValidCrosspath(tiers);
}
public class FasterShooting : ModUpgrade<OldTackShooter1>
{
    public override int Path => TOP;
    public override int Tier => 1;
    public override int Cost => 180;
    public override string Icon => "Top1";
    public override string Portrait => "Texture100";
    public override string Description => "Shoots tacks faster.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            weaponModel.rate = .666666f;
        }
    }
}
public class EvenFasterShooting : ModUpgrade<OldTackShooter1>
{
    public override int Path => TOP;
    public override int Tier => 2;
    public override int Cost => 255;
    public override string Icon => "Top2";
    public override string Portrait => "Texture200";
    public override string Description => "Further increases attack speed.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            weaponModel.rate = .555555f;
        }
    }
}
public class TackSprayer : ModUpgrade<OldTackShooter1>
{
    public override int Path => TOP;
    public override int Tier => 3;
    public override int Cost => 425;
    public override string Icon => "Top3";
    public override string Portrait => "Texture300";
    public override string Description => "Sprays out 16 tacks per volley instead of the usual 8.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            towerModel.GetDescendant<DamageModel>().damage = 2;
            towerModel.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel_", 16, 0, 360, null, false, false);
        }
    }
}
public class RingOfFire : ModUpgrade<OldTackShooter1>
{
    public override int Path => TOP;
    public override int Tier => 4;
    public override int Cost => 2125;
    public override string Icon => "Top4";
    public override string Portrait => "Texture400";
    public override string Description => "Shoots out rings of quick flames instead of tacks. Also gains extra range.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            towerModel.GetDescendant<DamageModel>().damage = 10;
            var attackModel = towerModel.GetAttackModel();
            var projectile = attackModel.weapons[0].projectile;
            projectile.pierce = 4;
            projectile.ApplyDisplay<Tier400Projectile>();
            weaponModel.rate = .222222f;
            towerModel.range += 4f;
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Moab", "Moab", 1, 18, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Bfb", "Bfb", 1, 24, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Zomg", "Zomg", 1, 50, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Ddt", "Ddt", 1, 72, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Bad", "Bad", 1, 78, false, true));
            weaponModel.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
            weaponModel.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.Purple;
        }
    }
}
public class DoomOfFire : ModUpgrade<OldTackShooter1>
{
    public override int Path => TOP;
    public override int Tier => 5;
    public override int Cost => 78500;
    public override string Icon => "Top5";
    public override string Portrait => "Texture500";
    public override string Description => "Shoots out rings of very quick mega flame that burn down every bloon!";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            foreach (var projectileModel in towerModel.GetDescendants<ProjectileModel>().ToArray())
            {
                towerModel.GetDescendant<DamageModel>().damage = 1400;
                var attackModel = towerModel.GetAttackModel();
                var projectile = attackModel.weapons[0].projectile;
                projectile.pierce = 100;
                projectile.ApplyDisplay<Tier500Projectile>();
                weaponModel.rate = .111111f;
                weaponModel.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
                weaponModel.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.Purple;
                var LavaBehavior = Game.instance.model.GetTowerFromId("Alchemist").GetDescendant<AddBehaviorToBloonModel>().Duplicate();
                LavaBehavior.GetBehavior<DamageOverTimeModel>().damage = 500f;
                LavaBehavior.GetBehavior<DamageOverTimeModel>().interval = 1 / 3f;
                LavaBehavior.lifespan = 9999;
                LavaBehavior.lifespanFrames = 9999;
                LavaBehavior.overlayType = "Fire";
                projectileModel.AddBehavior(LavaBehavior);
            }
        }
    }
}
public class ExtraRangeTacks  : ModUpgrade<OldTackShooter1>
{
    public override int Path => MIDDLE;
    public override int Tier => 1;
    public override int Cost => 85;
    public override string Icon => "Middle1";
    public override string Portrait => "Texture100";
    public override string Description => "Tacks have increased range.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            towerModel.range += 4f;
        }
    }
}
public class SuperRangeTacks : ModUpgrade<OldTackShooter1>
{
    public override int Path => MIDDLE;
    public override int Tier => 2;
    public override int Cost => 190;
    public override string Icon => "Middle2";
    public override string Portrait => "Texture200";
    public override string Description => "Tacks have further increased range.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            towerModel.range += 6f;
        }
    }
}
public class BladeShooter  : ModUpgrade<OldTackShooter1>
{
    public override int Path => MIDDLE;
    public override int Tier => 3;
    public override int Cost => 580;
    public override string Icon => "Middle3";
    public override string Portrait => "Texture300";
    public override string Description => "Converts the tower into a blade shooter that shoots out razor sharp blades that are harder for bloons to avoid.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {

            towerModel.GetDescendant<DamageModel>().damage = 4;
            var attackModel = towerModel.GetAttackModel();
            var projectile = attackModel.weapons[0].projectile;
            projectile.ApplyDisplay<OldBlade>();
            projectile.pierce = 6;
        }
    }
}
public class BladeMaelstrom : ModUpgrade<OldTackShooter1>
{
    public override int Path => MIDDLE;
    public override int Tier => 4;
    public override int Cost => 2295;
    public override string Icon => "Middle4";
    public override string Portrait => "Texture040";
    public override string Description => "Blade Maelstrom Ability: covers the area in an unstoppable storm of blades.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            towerModel.GetDescendant<DamageModel>().damage = 10;
            var attackModel = towerModel.GetAttackModel();
            var projectile = attackModel.weapons[0].projectile;
            projectile.pierce = 10;
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Moab", "Moab", 1, 25, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Bfb", "Bfb", 1, 35, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Zomg", "Zomg", 1, 70, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Ddt", "Ddt", 1, 75, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Bad", "Bad", 1, 85, false, true));
            towerModel.AddBehavior(Game.instance.model.GetTowerFromId("TackShooter-240").GetAbility());
            var Abillity = towerModel.GetAbility();
            Abillity.cooldown = 5;
            Abillity.icon = ModContent.GetSpriteReference<OldTackShooter>("Middle4");
        }
    }
}
public class SuperMaelstrom : ModUpgrade<OldTackShooter1>
{
    public override int Path => MIDDLE;
    public override int Tier => 5;
    public override int Cost => 58750;
    public override string Icon => "Middle5";
    public override string Portrait => "Texture050";
    public override string Description => "Blade Blade Blade! the blade have become so sharp that they go pass any bloon";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            towerModel.RemoveBehavior<AbilityModel>();
            towerModel.GetDescendant<DamageModel>().damage = 1780;
            var attackModel = towerModel.GetAttackModel();
            var projectile = attackModel.weapons[0].projectile;
            projectile.pierce = 999999;
            projectile.ApplyDisplay<OldBlade2>();
            weaponModel.rate = .111111f;
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Moab", "Moab", 1, 9999, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Bfb", "Bfb", 1, 9999, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Zomg", "Zomg", 1, 9999, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Ddt", "Ddt", 1, 9999, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Bad", "Bad", 1, 9999, false, true));
            towerModel.AddBehavior(Game.instance.model.GetTowerFromId("TackShooter-250").GetAbility());
            var Abillity = towerModel.GetAbility();
            Abillity.cooldown = 0;
            Abillity.icon = ModContent.GetSpriteReference<OldTackShooter>("Middle5");
        }
    }
}
public class CamoTacks : ModUpgrade<OldTackShooter1>
{
    public override int Path => BOTTOM;
    public override int Tier => 1;
    public override int Cost => 250;
    public override string Icon => "Bottom1";
    public override string Portrait => "Texture001";
    public override string Description => "Tacks can now pop camo.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
        }
    }
}
public class HomingTacks : ModUpgrade<OldTackShooter1>
{
    public override int Path => BOTTOM;
    public override int Tier => 2;
    public override int Cost => 750;
    public override string Icon => "Bottom2";
    public override string Portrait => "Texture002";
    public override string Description => "Tacks seek out the bloon from anywhere on the map.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            var attackModel = towerModel.GetAttackModel();
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
            var HomingTack = Game.instance.model.GetTowerFromId("WizardMonkey-500").GetWeapon().projectile.GetBehavior<TrackTargetModel>().Duplicate<TrackTargetModel>();
            HomingTack.distance = 999;
            HomingTack.constantlyAquireNewTarget = true;
            weaponModel.projectile.GetBehavior<TravelStraitModel>().lifespan = 1.4f;
            attackModel.weapons[0].projectile.AddBehavior(HomingTack);
        }
    }
}
public class ExplodingTacks : ModUpgrade<OldTackShooter1>
{
    public override int Path => BOTTOM;
    public override int Tier => 3;
    public override int Cost => 1250;
    public override string Icon => "Bottom3";
    public override string Portrait => "Texture003";
    public override string Description => "Tacks explode dealing extra damage.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            towerModel.GetDescendant<DamageModel>().damage = 3;
            var First = towerModel.GetWeapon();
            var Third = First.Duplicate();
            Third.name = "WeaponModel_Third";
            var bloonImpact = Game.instance.model.GetTower(TowerType.BombShooter, 4);
            var slowModel = bloonImpact.GetDescendant<SlowModel>().Duplicate();
            var slowModifierForTagModel = bloonImpact.GetDescendant<SlowModifierForTagModel>().Duplicate();
            Third.projectile.collisionPasses = new[] { -1, 0 };
            Third.projectile.AddBehavior(slowModel);
            Third.projectile.AddBehavior(slowModifierForTagModel);
            towerModel.GetAttackModel().AddWeapon(Third);
            var bomb = Game.instance.model.GetTower(TowerType.BombShooter, 3).GetWeapon().projectile.Duplicate();
            var pb = bomb.GetBehavior<CreateProjectileOnContactModel>();
            var sound = bomb.GetBehavior<CreateSoundOnProjectileCollisionModel>();
            var effect = bomb.GetBehavior<CreateEffectOnContactModel>();
            var behavior = new CreateProjectileOnExhaustFractionModel(
                "CreateProjectileOnExhaustFractionModel_",
                pb.projectile, pb.emission, 1f, 1f, true, false, false);
            First.projectile.AddBehavior(behavior);
            var soundBehavior = new CreateSoundOnProjectileExhaustModel(
                "CreateSoundOnProjectileExhaustModel_",
                sound.sound1, sound.sound2, sound.sound3, sound.sound4, sound.sound5);
            First.projectile.AddBehavior(soundBehavior);
            var eB = new CreateEffectOnExhaustedModel("CreateEffectOnExhaustedModel_", new PrefabReference(), 0f, Fullscreen.No,
                false, effect.effectModel);
            First.projectile.AddBehavior(eB);
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
        }
    }
}
public class BigTacks : ModUpgrade<OldTackShooter1>
{
    public override int Path => BOTTOM;
    public override int Tier => 4;
    public override int Cost => 2450;
    public override string Icon => "Bottom4";
    public override string Portrait => "Texture004";
    public override string Description => "Big Tack Deal Extra Damage And Have Extra Pierce.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            var attackModel = towerModel.GetAttackModel();
            var projectile = attackModel.weapons[0].projectile;
            projectile.pierce = 14;
            projectile.ApplyDisplay<BigTack>();
            towerModel.GetDescendant<DamageModel>().damage = 10;
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Moab", "Moab", 1, 70, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Bfb", "Bfb", 1, 80, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Zomg", "Zomg", 1, 90, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Ddt", "Ddt", 1, 60, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Bad", "Bad", 1, 30, false, true));
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
        }
    }
}
public class HugeTacks : ModUpgrade<OldTackShooter1>
{
    public override int Path => BOTTOM;
    public override int Tier => 5;
    public override int Cost => 57800;
    public override string Icon => "Bottom5";
    public override string Portrait => "Texture005";
    public override string Description => "Shoot Out 32 HUGE TACK Very fast dealing crazy amount of damage with very high pierce.";

    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            towerModel.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel_", 32, 0, 360, null, false, false);
            var attackModel = towerModel.GetAttackModel();
            var projectile = attackModel.weapons[0].projectile;
            projectile.pierce = 14;
            projectile.ApplyDisplay<HugeTack>();
            towerModel.GetDescendant<DamageModel>().damage = 1720;
            weaponModel.rate = .111111f;
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Moab", "Moab", 1, 9999, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Bfb", "Bfb", 1, 9999, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Zomg", "Zomg", 1, 9999, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Ddt", "Ddt", 1, 9999, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Bad", "Bad", 1, 9999, false, true));
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
        }
    }
}
public class GoldyTackShooter : ModParagonUpgrade<OldTackShooter1>
{
    public override int Cost => 400000;
    public override string Description => "The Godly Tack Shooter?";
    public override string DisplayName => "Godly Tack Shooter";
    public override string Icon => "ParagonIcon";
    public override string Portrait => "Texture555";
    public override void ApplyUpgrade(TowerModel towerModel)
    {
        foreach (var weaponModel in towerModel.GetWeapons())
        {
            towerModel.range += 10f;
            towerModel.AddBehavior(Game.instance.model.GetTowerFromId("TackShooter-250").GetAbility());
            var Abillity = towerModel.GetAbility();
            Abillity.cooldown = 0;
            Abillity.icon = ModContent.GetSpriteReference<OldTackShooter>("ParagonIcon");
            var First = towerModel.GetWeapon();
            var Third = First.Duplicate();
            Third.name = "WeaponModel_Third";
            var bloonImpact = Game.instance.model.GetTower(TowerType.BombShooter, 4);
            var slowModel = bloonImpact.GetDescendant<SlowModel>().Duplicate();
            var slowModifierForTagModel = bloonImpact.GetDescendant<SlowModifierForTagModel>().Duplicate();
            Third.projectile.collisionPasses = new[] { -1, 0 };
            Third.projectile.AddBehavior(slowModel);
            Third.projectile.AddBehavior(slowModifierForTagModel);
            towerModel.GetAttackModel().AddWeapon(Third);
            var bomb = Game.instance.model.GetTower(TowerType.BombShooter, 3).GetWeapon().projectile.Duplicate();
            var pb = bomb.GetBehavior<CreateProjectileOnContactModel>();
            var sound = bomb.GetBehavior<CreateSoundOnProjectileCollisionModel>();
            var effect = bomb.GetBehavior<CreateEffectOnContactModel>();
            var behavior = new CreateProjectileOnExhaustFractionModel(
                "CreateProjectileOnExhaustFractionModel_",
                pb.projectile, pb.emission, 1f, 1f, true, false, false);
            First.projectile.AddBehavior(behavior);
            var soundBehavior = new CreateSoundOnProjectileExhaustModel(
                "CreateSoundOnProjectileExhaustModel_",
                sound.sound1, sound.sound2, sound.sound3, sound.sound4, sound.sound5);
            First.projectile.AddBehavior(soundBehavior);
            var eB = new CreateEffectOnExhaustedModel("CreateEffectOnExhaustedModel_", new PrefabReference(), 0f, Fullscreen.No,
                false, effect.effectModel);
            First.projectile.AddBehavior(eB);
            towerModel.GetWeapon().emission = new ArcEmissionModel("ArcEmissionModel_", 32, 0, 360, null, false, false);
            var attackModel = towerModel.GetAttackModel();
            var projectile = attackModel.weapons[0].projectile;
            projectile.pierce = 999999;
            projectile.ApplyDisplay<BladeHugeTack>();
            towerModel.GetDescendant<DamageModel>().damage = 999991;
            weaponModel.rate = .111111f;
            weaponModel.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Moab", "Moab", 1, 999991, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Bfb", "Bfb", 1, 999991, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Zomg", "Zomg", 1, 999991, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Ddt", "Ddt", 1, 999991, false, true));
            weaponModel.projectile.AddBehavior(new DamageModifierForTagModel("Bad", "Bad", 1, 999991, false, true));
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
            var HomingTack = Game.instance.model.GetTowerFromId("WizardMonkey-500").GetWeapon().projectile.GetBehavior<TrackTargetModel>().Duplicate<TrackTargetModel>();
            HomingTack.distance = 999;
            HomingTack.constantlyAquireNewTarget = true;
            weaponModel.projectile.GetBehavior<TravelStraitModel>().lifespan = 1.4f;
            attackModel.weapons[0].projectile.AddBehavior(HomingTack);
        }
    }
}