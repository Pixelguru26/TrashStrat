﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Myra.Graphics2D;
using Myra.Graphics2D.UI;

namespace TrashStrat.Lib
{
	class MenuState : State
	{
		public MenuState(StateMachine Parent) : base(Parent) { }
		Desktop host;

		public override void Initialize()
		{
			
		}

		public override void LoadContent()
		{
			var testText = new TextBlock
			{
				Text = "Testy text"
			};

			host = new Desktop();
			host.Widgets.Add(testText);
		}

		public override void UnloadContent()
		{
			
		}

		public override void Update(GameTime gameTime, double deltaTime)
		{
			
		}

		public override void Draw(GameTime gameTime, GraphicsDeviceManager graphics, SpriteBatch spriteBatch)
		{
			//GraphicsDevice GraphicsDevice = graphics.GraphicsDevice;
			host.Bounds = new Rectangle(0, 0, graphics.GraphicsDevice.PresentationParameters.BackBufferWidth, graphics.GraphicsDevice.PresentationParameters.BackBufferHeight);
			host.Render();
		}
	}
}
