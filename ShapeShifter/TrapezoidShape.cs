﻿using System.Collections.Generic;
using System.Drawing;

namespace ShapeShifter
{
    /// <summary>
    /// Трапеция
    /// </summary>
    public class TrapezoidShape : Shape
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="location">Позиция</param>
        public TrapezoidShape(Point location) : base(location)
        {
            // PASS
        }

        /// <summary>
        /// Тип
        /// </summary>
        public override ShapeType Type => ShapeType.Trapezoid;

        /// <summary>
        /// Представление в виде массива точек в порядке построения
        /// </summary>
        /// <returns></returns>
        protected override PointF[] ShapePoints
        {
            get
            {
                Rectangle box = new Rectangle(Location, Size);

                List<PointF> result = new List<PointF>
                {
                    new PointF(box.Right, box.Top + box.Height / 4),
                    new PointF(box.Right, box.Bottom - box.Height / 4),
                    new PointF(box.Left, box.Bottom),
                    new PointF(box.Left, box.Top)
                };

                return result.ToArray();
            }
        }
    }
}