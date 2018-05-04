using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TetrisProject
{
    public class ZShape : Shape
    {
        public ZShape()
        {
            Color = Color.Green;
            blocks = new List<Block>();

            blocks.Add(new Block(new Point(151,1), Color));
            blocks.Add(new Block(new Point(121, 31), Color));
            blocks.Add(new Block(new Point(151, 31), Color));
            blocks.Add(new Block(new Point(121,61), Color));

            RotatePosition = 0;
        }

        public override Shape copyConstructor()
        {
            ZShape resultShape = new ZShape();
            resultShape.Color = this.Color;
            for(int i=0; i<blocks.Count;++i)
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
            if (canMoveLeft)
            {
                blocks[0].Position = new Point(blocks[1].Position.X - 30, blocks[1].Position.Y - 30);
                blocks[2].Position = new Point(blocks[1].Position.X, blocks[1].Position.Y - 30);
                blocks[3].Position = new Point(blocks[1].Position.X + 30, blocks[1].Position.Y);
                RotatePosition = 1;
            }
        }

        private void rotatePosition1()
        {
            blocks[0].Position = new Point(blocks[1].Position.X + 30, blocks[1].Position.Y - 30);
            blocks[2].Position = new Point(blocks[1].Position.X + 30, blocks[1].Position.Y);
            blocks[3].Position = new Point(blocks[1].Position.X, blocks[1].Position.Y + 30);
            RotatePosition = 0;
        }
    }
}
