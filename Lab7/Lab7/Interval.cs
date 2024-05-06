using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Interval
    {
        private double _start;
        private double _end;

        public Interval(double start, double end)
        {
            if (start > end)
            {
                throw new ArgumentException("Начало интервала не может быть больше его конца.");
            }

            _start = start;
            _end = end;
        }

        public double Start
        {
            get { return _start; }
            set
            {
                if (value > _end)
                {
                    throw new ArgumentException("Начало интервала не может быть больше его конца.");
                }

                _start = value;
            }
        }

        public double End
        {
            get { return _end; }
            set
            {
                if (value < _start)
                {
                    throw new ArgumentException("Конец интервала не может быть меньше его начала.");
                }

                _end = value;
            }
        }

        public double Length => Math.Abs(_end - _start);

        public static Interval operator +(Interval a, Interval b)
        {
            return new Interval(a._start + b._start, a._end + b._end);
        }

        public static Interval operator -(Interval a, Interval b)
        {
            return new Interval(a._start - b._start, a._end - b._end);
        }

        public static Interval operator *(Interval a, Interval b)
        {
            double start = Math.Max(a._start, b._start);
            double end = Math.Min(a._end, b._end);
            if (start <= end)
            {
                return new Interval(start, end);
            }
            else
            {
                throw new InvalidOperationException("Intervals do not intersect");
            }
        }

        public static Interval operator ++(Interval a)
        {
            return new Interval(a._start - 1, a._end + 1);
        }

        public static Interval operator --(Interval a)
        {
            return new Interval(a._start + 1, a._end - 1);
        }

        public static bool operator ==(Interval a, Interval b)
        {
            return a.Length == b.Length;
        }

        public static bool operator !=(Interval a, Interval b)
        {
            return a.Length != b.Length;
        }

        public static bool operator <(Interval a, Interval b)
        {
            return a.Length < b.Length;
        }

        public static bool operator >(Interval a, Interval b)
        {
            return a.Length > b.Length;
        }

        public static bool operator true(Interval a)
        {
            return a.Length != 0;
        }

        public static bool operator false(Interval a)
        {
            return a.Length == 0;
        }

        public static explicit operator double(Interval a)
        {
            return a.Length;
        }

        public static explicit operator Interval(double length)
        {
            return new Interval(0, length);
        }

        public override string ToString()
        {
            return $"Interval from {_start} to {_end}";
        }
    }

}
