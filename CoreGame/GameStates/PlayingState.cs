using PerishedEngine.GameObjects;
using Microsoft.Xna.Framework;
using PerishedEngine.GameObjects.Tiles;
using PerishedEngine.Utilities;
using LitJson;
using PerishedEngine.Managers;
using Microsoft.Xna.Framework.Input;
using CoreGame.GameObjects;
using FarseerPhysics.Dynamics;
using FarseerPhysics.Collision.Shapes;
using FarseerPhysics;

namespace PerishedEngine.GameStates
{
	public class PlayingState : GameState
	{
		private Player player;
		private Tilemap map = new Tilemap();
		private Camera cam;

		World world;
		Body body;
        CircleShape shape;

		public override void Init()
		{

            world = new World(new Vector2(0, 0.1f));
            body = new Body(world, Vector2.Zero, 0);
            body.BodyType = BodyType.Dynamic;
            shape = new CircleShape(0.5f, 1);
            Fixture fix = body.CreateFixture(shape);

            ConvertUnits.SetDisplayUnitToSimUnitRatio(64f);

            player = new Player();
			player.Init();
			cam = new Camera(game.GraphicsDevice.Viewport);
			GraphicsManager.Instance.cam = cam;
			JsonRead jr = new JsonRead();
			JsonData data = jr.ReadData("Data/Map.json");
			map.Init(data);
		}

		public override void Update(GameTime gameTime)
		{
            world.Step((float)gameTime.ElapsedGameTime.TotalSeconds);

			player.Update(gameTime);
            player.position = ConvertUnits.ToDisplayUnits(body.Position);

            cam.LookAt(player.position);

			/*if (InputManager.Instance.isDown(Keys.W) || InputManager.Instance.controllerIsDown(Buttons.DPadUp))
			{
				cam.Move(new Vector2(0, -5));
			}
			if (InputManager.Instance.isDown(Keys.A) || InputManager.Instance.controllerIsDown(Buttons.DPadLeft))
			{
				cam.Move(new Vector2(-5, 0));
			}
			if (InputManager.Instance.isDown(Keys.S) || InputManager.Instance.controllerIsDown(Buttons.DPadDown))
			{
				cam.Move(new Vector2(0, 5));
			}
			if (InputManager.Instance.isDown(Keys.D) || InputManager.Instance.controllerIsDown(Buttons.DPadRight))
			{
				cam.Move(new Vector2(5, 0));
			}*/

			if (InputManager.Instance.isDown(Keys.NumPad1))
			{
				cam.zoom = 1;
			}

			if (InputManager.Instance.isDown(Keys.NumPad2))
			{
				cam.zoom = 2;
			}

			if (InputManager.Instance.isDown(Keys.NumPad3))
			{
				cam.zoom = 3;
			}

			if (InputManager.Instance.isDown(Keys.NumPad4))
			{
				cam.zoom = 4;
			}

			if (InputManager.Instance.isDown(Keys.NumPad5))
			{
				cam.zoom = 5;
			}

			if (InputManager.Instance.isDown(Keys.NumPad6))
			{
				cam.zoom = 6;
			}

		}

		public override void Draw()
		{
			map.Draw();
			player.Draw();
		}
	}
}
