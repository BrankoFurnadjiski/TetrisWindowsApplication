using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TetrisProject
{
    public class Scene
    {
        public static readonly Random random = new Random();

        public static readonly Color[] colors =
        {
            Color.White,
            Color.FromArgb(210,226,228),
            Color.FromArgb(197,221,227),
            Color.FromArgb(173,216,228),
            Color.FromArgb(126,197,219),
            Color.FromArgb(93,185,206),
            Color.FromArgb(0,151,189),
            Color.FromArgb(0,121,180),
            Color.FromArgb(0,121,180)
        };

        static readonly Shape[] shapes =
        {
            new LShape(),
            new SShape(),
            new ZShape(),
            new TShape(),
            new SquareShape(),
            new LineShape(),
            new MirroredLShape()
        };

        public Shape MovingShape { get; set; }
        public Shape NextShape { get; set; }

        public bool[,] Grid { get; set; }
        public List<Block> blocks;
        public List<int> ForRemoveLines { get; set; }

        public int Score { get; set; }
        public int Level { get; set; }
        public int StartedLevel { get; set; }

        public Scene(int level=1)
        {
            Grid = new bool[10,17];
            blocks = new List<Block>();
            NextShape = generateShape();
            MovingShape = generateShape();
            ForRemoveLines = new List<int>();
            Score = 0;
            Level = level;
            StartedLevel = level;
        }

        public void changeShape()
        {
            MovingShape = NextShape;
            NextShape = generateShape();
        }

        public bool gameOver()
        {
            return MovingShape.overlapping(blocks);
        }

        internal bool changedLevel()
        {
            if (Score > (Level - StartedLevel) * 1500 && Level < 8)
            {
                Level++;
                return true;
            }
            return false;
        }

        private void updateScore()
        {
            Score += 50 * ForRemoveLines.Count * (ForRemoveLines.Count + 1);
        }

        internal void drawNextShape(Graphics graphics)
        {
            graphics.Clear(Color.White);
            NextShape.drawNextShape(graphics);
        }

        public void drawBlocks(Graphics g)
        {
            foreach (Block block in blocks)
                block.draw(g,colors[Level]);
        }

        public void move()
        {
            if (anchor())
            {
                addShapeBlocks(MovingShape);
                if (checkForRemove())
                {
                    updateScore();
                    removeLines();
                }
                changeShape();
                return;
            }
            MovingShape.moveDown();
        }

        /*nova*/
        private bool checkForRemove()
        {
            for (int i = 0; i < 17; ++i)
            {
                int j = 0;
                for(j = 0; j < 10; ++j)
                {
                    if (!Grid[j, i])
                        break;
                }
                if(j == 10)
                {
                    ForRemoveLines.Add(i);
                }
                
            }
            return ForRemoveLines.Count != 0;
        }

        /*nova*/
        private void removeLines()
        {
            foreach(int i in ForRemoveLines)
            {
                for(int k = blocks.Count -1; k >=0; --k)
                {
                    if (blocks.ElementAt(k).getIndexJ() == i)
                    {
                        blocks.RemoveAt(k);
                    }
                }
                for (int j = 0; j < 10; ++j)
                    Grid[j, i] = false;
                setBlocks(i);
                changeGrid(i);
            }
            ForRemoveLines.Clear();
        }

        /*nova*/
        private void setBlocks(int i)
        {
            foreach(Block block in blocks)
            {
                if(block.getIndexJ() < i)
                {
                    block.moveBlock();
                }
            }
        }

        /*nova*/
        private void changeGrid(int i)
        {
            for(int j = i; j > 0; --j)
            {
                for(int k = 0; k < 10; ++k)
                {
                    Grid[k, j] = Grid[k, j - 1];
                }
            }
            for (int k = 0; k < 10; ++k)
            {
                Grid[k, 0] = false;
            }

        }

        public bool anchor()
        {
            if (MovingShape.touchingGround())
                return true;
            return MovingShape.touchingBottom(blocks);
        }

        public void addShapeBlocks(Shape shape)
        {
            foreach (Block block in shape.blocks)
            {
                blocks.Add(block);
                int i = block.getIndexI();
                int j = block.getIndexJ();
                Grid[i, j] = true;
            }
        }

        public bool blockLeft()
        {
            return MovingShape.touchingLeft(blocks);
        }

        public bool blockRight()
        {
            return MovingShape.touchingRight(blocks);
        }

        internal void moveLeft()
        {
            if(!blockLeft())
                MovingShape.moveLeft();
        }

        internal void moveRight()
        {
            if(!blockRight())
                MovingShape.moveRight();
        }

        internal void moveUp()
        {
            if (MovingShape.touchingGround()) return;

            Shape tmpShape = MovingShape.copyConstructor();
            tmpShape.rotate();

            if (tmpShape.overlapping(blocks)) return;

            MovingShape.rotate();
        }

        public void draw(Graphics g)
        {invokeShadow(g);
            MovingShape.draw(g,colors[Level]);
            drawBlocks(g);
        }

        public void invokeShadow(Graphics g)
        {
            Shape shadow = MovingShape.copyConstructor();
            shadow.changeColor(Color.FromArgb(50+5*Level,110,110,110));
            while(!(shadow.touchingBottom(blocks) || shadow.touchingGround()))
            {
                shadow.moveDown();
            }
            if (shouldInvokeShadow(shadow))
                shadow.draw(g, colors[Level]);
        }

        private bool shouldInvokeShadow(Shape shadow)
        {
            foreach (Block block in blocks)
            {
                foreach (Block b in shadow.blocks)
                {
                    if (b.getIndexI() == block.getIndexI())
                    {
                        if (b.getIndexJ() < block.getIndexJ() && block.getIndexJ() < 7)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        
        public Shape generateShape()
        {
            int index = random.Next(0, 7);
            return shapes[index].copyConstructor();
        }

    }
}
