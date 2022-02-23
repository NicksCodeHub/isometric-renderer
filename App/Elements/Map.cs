using System.Collections.Generic;
using IsometricRenderer.App.Models;
using IsometricRenderer.App.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace IsometricRenderer.App.Elements
{
    internal class Map
    {
        private List<List<TileModel>> _tiles { get; set; }

        private int _tile_width_px = 32;
        private int _tile_height_px = 16;

        internal int MapHeight_Tiles = 40;
        internal int MapWidth_Tiles = 20;


        internal Map()
        {

        }

        internal void Initialize()
        {
            _tiles = new List<List<TileModel>>();
            var tile_green_large = Constants.ContentManager.Load<Texture2D>("Graphics/tile-green-large");

            for (int y = 0; y < MapHeight_Tiles; y++)
            {
                _tiles.Add(new List<TileModel>());
                for (int x = 0; x < MapWidth_Tiles; x++)
                {
                    _tiles[y].Add(new TileModel(tile_green_large, new Vector2(x, y), 0));
                }
            }

        }

        internal void Update(GameTime gameTime)
        {
        }

        internal void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            // Isometric is to render back to front.
            int half_tile_height_px = _tile_height_px / 2;
            int half_tile_width_px = _tile_width_px / 2;
            for (int y = 0; y < MapHeight_Tiles; y++)
            {
                int render_y_px = y * half_tile_height_px;
                for (int x = 0; x < MapWidth_Tiles; x++)
                {
                    int render_x_offset_px = (y & 1) * half_tile_width_px;
                    int render_x_px = render_x_offset_px + (x * _tile_width_px);
                    spriteBatch.Draw(_tiles[y][x].Texture, new Vector2(render_x_px, render_y_px), Color.White);
                }
            }
        }
    }
}