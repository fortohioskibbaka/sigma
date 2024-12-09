using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using Rectangle = Microsoft.Xna.Framework.Rectangle;

namespace sigma
{
    internal class Tribble

    {

        private Texture2D _texture;
        private Microsoft.Xna.Framework.Rectangle _Rectangle;  
        private Vector2 _speed;


        public Tribble(Texture2D texture, Rectangle rectangle, Vector2 speed)
        {
            _Rectangle = rectangle;
            _speed = speed;
            _texture = texture;




        }
        public Texture2D texture
        {

            get { return _texture; }


        }

        public Vector2 speed
        {


            get { return _speed; }
            set { _speed = value; }




        }

        public void move()
        {



            _Rectangle.Offset( _speed );
        }
    }

}
