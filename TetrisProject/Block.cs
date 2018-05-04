using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProject
{
    public class Block
    {
        public Point Position { get; set; }
        public int Side { get; private set; }
        public Color Color { get; set; }
        public int LineWidth { get; set; }

        public Block(Point Position, Color Color)
        {
            this.Position = Position;
            Side = 30;
            this.Color = Color;
            LineWidth = 2;
        }

        public void draw(Graphics g,Color lineColor)
        {
            g.FillRectangle(new SolidBrush(lineColor), Position.X, Position.Y, Side, Side);
            g.FillRectangle(new SolidBrush(Color), Position.X + LineWidth, Position.Y + LineWidth, Side - LineWidth, Side - LineWidth);
        }

        public void drawNextShape(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.White), Position.X - 75, Position.Y+25, Side, Side);
            g.FillRectangle(new SolidBrush(Color), Position.X -75 + LineWidth, Position.Y + 25 + LineWidth, Side - LineWidth, Side - LineWidth);
        }

        public int getIndexI()
        {
            return Position.X / 30;
        }

        public int getIndexJ()
        {
            return Position.Y / 30;
        }

        public bool touchingBottom(Block another)
        {
            return (this.Position.Y + 30 == another.Position.Y) && (this.Position.X == another.Position.X);
        }

        public bool touchingLeft(Block another)
        {
            return (this.Position.Y == another.Position.Y) && (this.Position.X - 30 == another.Position.X);
        }

        public bool touchingRight(Block another)
        {
            return (this.Position.Y == another.Position.Y) && (this.Position.X + 30 == another.Position.X);
        }

        public bool touchingGround()
        {
            return this.Position.Y == 481;
        }

        public bool overlapping(Block another)
        {
            return (this.Position.Y == another.Position.Y) && (this.Position.X == another.Position.X);
        }

        public void moveBlock()
        {
            Position = new Point(Position.X, Position.Y + 30);
        }

    }
}
