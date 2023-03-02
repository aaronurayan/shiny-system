﻿using Raylib_cs;

using System.Numerics;

namespace Azimuth.UI
{
	public class Widget : IComparable<Widget>
	{
		public Rectangle Bounds => new Rectangle(position.X, position.Y, size.X, size.Y);
		
		public Vector2 position;
		public Vector2 size;
		public bool focused;
		
		protected int drawLayer;

		protected Widget(Vector2 _position, Vector2 _size)
		{
			position = _position;
			size = _size;
		}

		/// <summary> Higher numbers get drawn on top </summary>
		public void SetDrawLayer(int _layer)
		{
			drawLayer = _layer;
		}

		public virtual void Draw()
		{
			Raylib.DrawRectangleRec(Bounds, Color.RAYWHITE);
		}

		public virtual void Update(Vector2 _mousePos)
		{
			focused = Raylib.CheckCollisionPointRec(_mousePos, Bounds);
		}

		// Overridden from System.Object - Whenever a widget is used in string interpolation 
		// any sort of string operations, this will be called.
		public override string ToString()
		{
			return $"Widget:\n Position: {position}\n Size: {size}\n Draw Layer: {drawLayer}\n Focused: {focused}";
		}

		public int CompareTo(Widget? _other)
		{
			if(ReferenceEquals(this, _other))
				return 0;
			
			return ReferenceEquals(null, _other) ? 1 : drawLayer.CompareTo(_other.drawLayer);
		}
	}
}