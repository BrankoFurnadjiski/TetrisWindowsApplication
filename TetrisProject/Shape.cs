using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TetrisProject
{
    public abstract class Shape
    {
        public List<Block> blocks;
        protected int RotatePosition { get; set; }
        public Color Color { get; set; }

        public bool canMoveLeft
        {
            get
            {
                foreach (Block block in blocks)
                    if (block.Position.X == 1) return false;
                return true;
            }
        }
        public bool canMoveRight
        {
            get
            {
                foreach (Block block in blocks)
                    if (block.Position.X == 271) return false;
                return true;
            }
        }

        public void changeColor(Color color)
        {
            foreach(Block block in blocks)
            {
                block.Color = color;
            }
        }

        public void draw(Graphics g,Color lineColor)
        {
            foreach (Block block in blocks)
            {
                block.draw(g,lineColor);
            }
        }

        public void drawNextShape(Graphics g)
        {
            foreach (Block block in blocks)
            {
                block.drawNextShape(g);
            }
        }

        public void moveDown()
        {
            foreach(Block block in blocks)
            {
                block.moveBlock();
            }
        }

        public void moveLeft()
        {
            if (canMoveLeft)
            {
                foreach (Block block in blocks)
                {
                    block.Position = new Point(block.Position.X - 30, block.Position.Y);
                }
            }
        }

        public void moveRight()
        {
            if (canMoveRight)
            {
                foreach (Block block in blocks)
                {
                    block.Position = new Point(block.Position.X + 30, block.Position.Y);
                }
            }
        }

        public bool touchingGround()
        {
            foreach(Block block in blocks)
            {
                if (block.touchingGround()) return true;
            }
            return false;
        }

        public bool overlapping(List<Block> blocks)
        {
            foreach (Block block in this.blocks)
            {
                foreach (Block block1 in blocks)
                {
                    if (block.overlapping(block1))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool touchingLeft(List<Block> blocks)
        {
            foreach (Block block in this.blocks)
            {
                foreach (Block another in blocks)
                {
                    if (block.touchingLeft(another)) return true;
                }
            }
            return false;
        }

        public bool touchingRight(List<Block> blocks)
        {
            foreach (Block block in this.blocks)
            {
                foreach (Block another in blocks)
                {
                    if (block.touchingRight(another)) return true;
                }
            }
            return false;
        }

        public bool touchingBottom(List<Block> blocks)
        {
            foreach (Block block in this.blocks)
            {
                foreach (Block another in blocks)
                {
                    if (block.touchingBottom(another)) return true;
                }
            }
            return false;
        }

        abstract public void rotate();

        abstract public Shape copyConstructor();
        
    }
}
