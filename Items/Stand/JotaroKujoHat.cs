using Terraria.ID;
using Terraria.ModLoader;

namespace JJPE.Items.Stand.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class JotaroKujoHat : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jotaro Kujo Cap");
			Tooltip.SetDefault("'Worn by the very legend himself.'");
		}
		public override void SetDefaults()
		{
            item.width = 22;
            item.height = 20;
            item.value = 5000;
            item.rare = 2;
            item.defense = 3;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = false;  //player make so the player hair does not show when the vanity mask is equipped.  add true if you want to show the player hair.
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddIngredient(ItemID.GoldOre, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
