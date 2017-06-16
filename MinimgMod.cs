using Terraria.ModLoader;

namespace MinimgMod
{
	class MinimgMod : Mod
	{
		public MinimgMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
