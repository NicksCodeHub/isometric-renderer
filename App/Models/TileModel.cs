using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace IsometricRenderer.App.Models
{
    internal class TileModel : BaseModel
    {
        internal Texture2D Texture { get; set; }
        internal Vector2 Position { get; set; }
        internal float Height { get; set; }

        internal TileModel(Texture2D texture, Vector2 position, float height)
        {
            this.Texture = texture;
            this.Position = position;
            this.Height = height;
        }

    }
}