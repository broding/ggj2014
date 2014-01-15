#region File Description
//-----------------------------------------------------------------------------
// XNAGame.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
using Flakcore.Display;
using Flakcore;


#endregion

#region Using Statements
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;

#endregion
namespace XNA
{
	/// <summary>
	/// Default Project Template
	/// </summary>
	public class FlakcoreGame : Game
	{

		#region Fields

		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;
		Core core;

		#endregion

		#region Initialization

		public FlakcoreGame ()
		{

			graphics = new GraphicsDeviceManager (this);
			
			Content.RootDirectory = "Content";

			graphics.IsFullScreen = false;
			IsMouseVisible = false;
		}

		/// <summary>
		/// Overridden from the base Game.Initialize. Once the GraphicsDevice is setup,
		/// we'll use the viewport to initialize some values.
		/// </summary>
		protected override void Initialize ()
		{
			base.Initialize ();
		}

		/// <summary>
		/// Load your graphics content.
		/// </summary>
		protected override void LoadContent ()
		{
			// Create a new SpriteBatch, which can be use to draw textures.
			spriteBatch = new SpriteBatch (graphics.GraphicsDevice);

			core = new Core (new Vector2 (1024, 768), graphics, Content);
			core.SwitchState (new GameState ());
		}

		#endregion

		#region Update and Draw

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update (GameTime gameTime)
		{
			// TODO: Add your update logic here			
            		
			core.Update (gameTime);
			base.Update (gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself. 
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw (GameTime gameTime)
		{
			core.Draw (spriteBatch, gameTime);

			//TODO: Add your drawing code here
			base.Draw (gameTime);
		}

		#endregion

	}
}
