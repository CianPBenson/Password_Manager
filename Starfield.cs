using System;
using System.Collections.Generic;
using System.Drawing;

namespace StarLib
{
    public class StarField
    {
        private List<Star> stars = new List<Star>();
        private List<ShootingStar> shootingStars = new List<ShootingStar>();
        private static Random rand = new Random();

        private int shootingStarCooldown = 0;
        private readonly int numStars;
        private readonly float repelRadius = 100f;
        private readonly float repelForce = 4f;
        private readonly float returnForce = 0.05f;
        private readonly float damping = 0.9f;

        public StarField(int numStars = 100)
        {
            this.numStars = numStars;
        }

        public void Initialize(Size clientSize)
        {
            stars.Clear();
            for (int i = 0; i < numStars; i++)
            {
                float size = (float)(rand.NextDouble() * 2f + 1.5f);
                stars.Add(new Star(
                    rand.Next(clientSize.Width),
                    rand.Next(clientSize.Height),
                    size));
            }
        }

        public void Update(Point mousePosition, Size clientSize)
        {
            foreach (var star in stars)
            {
                float dx = star.Position.X - mousePosition.X;
                float dy = star.Position.Y - mousePosition.Y;
                float dist = (float)Math.Sqrt(dx * dx + dy * dy);

                if (dist < repelRadius && dist > 0.1f)
                {
                    float factor = (repelRadius - dist) / repelRadius;
                    star.Velocity.X += (dx / dist) * factor * repelForce;
                    star.Velocity.Y += (dy / dist) * factor * repelForce;
                }

                star.Velocity.X += (star.OriginalPosition.X - star.Position.X) * returnForce;
                star.Velocity.Y += (star.OriginalPosition.Y - star.Position.Y) * returnForce;

                star.Velocity.X *= damping;
                star.Velocity.Y *= damping;

                star.Position.X += star.Velocity.X;
                star.Position.Y += star.Velocity.Y;

                star.Update(mousePosition);
            }

            if (shootingStarCooldown <= 0)
            {
                PointF start = rand.Next(2) == 0
                    ? new PointF(rand.Next(clientSize.Width), -10)
                    : new PointF(-10, rand.Next(clientSize.Height));

                PointF velocity = new PointF(rand.Next(25, 40), rand.Next(15, 25));

                Color[] colors = new[] {
                    Color.White, Color.Cyan, Color.LightBlue, Color.LightGreen,
                    Color.FromArgb(255, 255, 100, 100),
                    Color.FromArgb(255, 100, 255, 255)
                };
                Color color = colors[rand.Next(colors.Length)];

                shootingStars.Add(new ShootingStar(start, velocity, rand.Next(2, 4), color));
                shootingStarCooldown = rand.Next(30, 100);
            }
            else
            {
                shootingStarCooldown--;
            }

            shootingStars.RemoveAll(s =>
            {
                s.Update();
                return s.IsDead;
            });
        }

        public void Draw(Graphics g)
        {
            foreach (var star in stars)
            {
                using (Brush b = new SolidBrush(star.CurrentColor))
                {
                    g.FillEllipse(b,
                        star.Position.X - star.Size / 2,
                        star.Position.Y - star.Size / 2,
                        star.Size,
                        star.Size);
                }
            }

            foreach (var s in shootingStars)
            {
                using (Pen pen = new Pen(Color.FromArgb((int)(s.Opacity * 255), s.Color), s.Size))
                {
                    PointF tail = new PointF(s.Position.X - s.Velocity.X * 5, s.Position.Y - s.Velocity.Y * 5);
                    g.DrawLine(pen, s.Position, tail);
                }
            }
        }
    }

    internal class ShootingStar
    {
        public PointF Position;
        public PointF Velocity;
        public float Size;
        public float Opacity;
        public Color Color;

        public ShootingStar(PointF startPosition, PointF velocity, float size, Color color)
        {
            Position = startPosition;
            Velocity = velocity;
            Size = size;
            Opacity = 1f;
            Color = color;
        }

        public void Update()
        {
            Position.X += Velocity.X;
            Position.Y += Velocity.Y;
            Opacity -= 0.01f;
        }

        public bool IsDead => Opacity <= 0;
    }

    internal class Star
    {
        public PointF OriginalPosition;
        public PointF Position;
        public PointF Velocity;
        public float Size;

        public Color CurrentColor = Color.White;
        private Color TargetColor = Color.White;

        private int twinkleCooldown = 0;
        private static Random rand = new Random();

        public Star(float x, float y, float size)
        {
            OriginalPosition = new PointF(x, y);
            Position = new PointF(x, y);
            Velocity = new PointF(0, 0);
            Size = size;
            twinkleCooldown = rand.Next(15, 60);
        }

        public void Update(Point mousePosition)
        {
            float dx = Position.X - mousePosition.X;
            float dy = Position.Y - mousePosition.Y;
            float dist = (float)Math.Sqrt(dx * dx + dy * dy);

            TargetColor = dist < 100 ? Color.Red : Color.White;

            Velocity.X += (float)(rand.NextDouble() * 0.04 - 0.02);
            Velocity.Y += (float)(rand.NextDouble() * 0.04 - 0.02);

            Position.X += Velocity.X;
            Position.Y += Velocity.Y;

            Velocity.X *= 0.95f;
            Velocity.Y *= 0.95f;

            CurrentColor = ColorLerp(CurrentColor, TargetColor, 0.05f);
        }

        private Color ColorLerp(Color from, Color to, float t)
        {
            int r = (int)(from.R + (to.R - from.R) * t);
            int g = (int)(from.G + (to.G - from.G) * t);
            int b = (int)(from.B + (to.B - from.B) * t);
            return Color.FromArgb(255, r, g, b);
        }
    }
}
