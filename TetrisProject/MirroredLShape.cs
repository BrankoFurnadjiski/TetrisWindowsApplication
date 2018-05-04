using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TetrisProject
{
    public class MirroredLShape : Shape
    {
        public MirroredLShape()
        {
            Color = Color.Purple;
            blocks = new List<Block>();

            blocks.Add(new Block(new Point(121, 1), Color));
            blocks.Add(new Block(new Point(151, 1), Color));
            blocks.Add(new Block(new Point(151, 31), Color));
            blocks.Add(new Block(new Point(151, 61), Color));

            RotatePosition = 0;
        }

        public override Shape copyConstructor()
        {
            MirroredLShape resultShape = new MirroredLShape();
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
            else if (RotatePosition == 1)
            {
                rotatePosition1();
            }
            else if (RotatePosition == 2)
            {
                rotatePosition2();
            }
            else if (RotatePosition == 3)
            {
                rotatePosition3();
            }
        }

        void rotatePosition0()
        {
            if (canMoveRight)
            {
                blocks[0].Position = new Point(blocks[2].Position.X + 30, blocks[2].Position.Y - 30);
                blocks[1].Position = new Point(blocks[2].Position.X + 30, blocks[2].Position.Y);
                blocks[3].Position = new Point(blocks[2].Position.X - 30, blocks[2].Position.Y);
                RotatePosition = 1;
            }
        }

        void rotatePosition1()
        {
            blocks[0].Position = new Point(blocks[2].Position.X + 30, blocks[2].Position.Y + 30);
            blocks[1].Position = new Point(blocks[2].Position.X, blocks[2].Position.Y + 30);
            blocks[3].Position = new Point(blocks[2].Position.X, blocks[2].Position.Y - 30);
            RotatePosition = 2;
        }

        void rotatePosition2()
        {
            if (canMoveLeft)
            {
                blocks[0].Position = new Point(blocks[2].Position.X - 30, blocks[2].Position.Y + 30);
                blocks[1].Position = new Point(blocks[2].Position.X - 30, blocks[2].Position.Y);
                blocks[3].Position = new Point(blocks[2].Position.X + 30, blocks[2].Position.Y);
                RotatePosition = 3;
            }
        }

        void rotatePosition3()
        {
            blocks[0].Position = new Point(blocks[2].Position.X - 30, blocks[2].Position.Y - 30);
            blocks[1].Position = new Point(blocks[2].Position.X, blocks[2].Position.Y - 30);
            blocks[3].Position = new Point(blocks[2].Position.X, blocks[2].Position.Y + 30);
            RotatePosition = 0;
        }
    }
}
