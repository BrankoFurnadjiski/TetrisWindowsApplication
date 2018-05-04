using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TetrisProject
{
    public class SShape : Shape
    {
        public SShape()
        {
            Color = Color.DeepPink;
            blocks = new List<Block>();

            blocks.Add(new Block(new Point(121, 1), Color));
            blocks.Add(new Block(new Point(121, 31), Color));
            blocks.Add(new Block(new Point(151,31), Color));
            blocks.Add(new Block(new Point(151,61), Color));

            RotatePosition = 0;
        }

        public override Shape copyConstructor()
        {
            SShape resultShape = new SShape();
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
            if (RotatePosition == 0)
            {
                rotatePosition0();
            }
            else
            {
                rotatePosition1();
            }
        }

        private void rotatePosition0()
        {
            if (canMoveRight)
            {
                blocks[0].Position = new Point(blocks[2].Position.X - 30, blocks[2].Position.Y + 30);
                blocks[1].Position = new Point(blocks[2].Position.X, blocks[2].Position.Y + 30);
                blocks[3].Position = new Point(blocks[2].Position.X + 30, blocks[2].Position.Y);
                RotatePosition = 1;
            }
        }

        private void rotatePosition1()
        {
            blocks[0].Position = new Point(blocks[2].Position.X - 30, blocks[2].Position.Y - 30);
            blocks[1].Position = new Point(blocks[2].Position.X - 30, blocks[2].Position.Y);
            blocks[3].Position = new Point(blocks[2].Position.X, blocks[2].Position.Y + 30);
            RotatePosition = 0;
        }
    }
}
