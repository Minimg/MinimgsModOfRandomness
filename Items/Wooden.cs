using Terraria.ID;
using Terraria.ModLoader;

namespace MinimgMod.Items
{
    public class Wooden : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden");
			Tooltip.SetDefault("Wooden.");
		}
		public override void SetDefaults()
		{
			item.damage = 2;
            item.melee = true;
			item.width = 2;
			item.height = 2;
			item.useTime = 1;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 25;
			item.rare = 0;
			item.UseSound = SoundID.Item4;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 10);
			recipe.AddRecipe();
		}
	}
}

