using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TetrisProject
{
    public class SquareShape : Shape
    {
        public SquareShape()
        {
            Color = Color.Brown;
            blocks = new List<Block>();

            blocks.Add(new Block(new Point(121, 1), Color));
            blocks.Add(new Block(new Point(151, 1), Color));
            blocks.Add(new Block(new Point(121, 31), Color));
            blocks.Add(new Block(new Point(151, 31), Color));
        }

        public override Shape copyConstructor()
        {
            SquareShape resultShape = new SquareShape();
            resultShape.Color = this.Color;
            for (int i = 0; i < blocks.Count; ++i)
            {
                resultShape.blocks[i] = new Block(this.blocks[i].Position, this.Color);
            }
            resultShape.RotatePosition = this.RotatePosition;
            return resultShape;
        }

        public override void rotate()
        {
            
        }
    }
}
