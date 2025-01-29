using System;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Types.Collections
{
    [Serializable]
    public struct Grid<T> : System.IEquatable<Grid<T>>, Interfaces.IRotatable<Grid<T>>
    {
        [SerializeField][HideInInspector] private T[] _elements;
        [SerializeField][HideInInspector] private int _width, _height;

        public readonly int Width => _width;
        public readonly int Height => _height;

        public readonly T this[Index x, Index y]
        {
            get => _elements[y.Value * _width + x.Value];
            set => _elements[y.Value * _width + x.Value] = value;
        }

        public Grid(int width, int height)
        {
            _elements = new T[width * height];
            _width = width;
            _height = height;
        }

        public readonly Grid<T> Rotate90()
        {
            Grid<T> rotatedGrid = new(_width, _height);

            for (int x = 0; x < _width; ++x)
            {
                for (int y = 0; y < _height; ++y)
                {
                    rotatedGrid[x, y] = this[y, _width - x - 1];
                }
            }

            return rotatedGrid;
        }

        public readonly Grid<T> Rotate180() => Rotate90().Rotate90();

        public readonly Grid<T> Rotate270() => Rotate90().Rotate90().Rotate90();

        public readonly Grid<T> Transpose()
        {
            Grid<T> transposedGrid = new(_height, _width);

            for (int x = 0; x < _width; ++x)
            {
                for (int y = 0; y < _height; ++y)
                {
                    transposedGrid[x, y] = this[y, x];
                }
            }

            return transposedGrid;
        }

        public readonly bool Equals(Grid<T> other)
        {
            return _width == other._width && _height == other._height && Enumerable.SequenceEqual(_elements, other._elements);
        }

        public override readonly string ToString()
        {
            StringBuilder output = new();

            for (int y = 0; y < _height; ++y)
            {
                for (int x = 0; x < _width; ++x)
                {
                    output.Append(this[x, y].ToString() + ", ");
                }

                output.AppendLine();
            }

            return output.ToString();
        }
    }
}
