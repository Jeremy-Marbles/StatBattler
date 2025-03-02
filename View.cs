using Godot;
using System;

public partial class View : Camera2D
{
	private bool isDragging = false;
	private Vector2 dragStartPOS;
	private Vector2 cameraStartPOS;
	
	public override void _Input(InputEvent @event)
	{
		//GD.Print(@event.AsText());
		if (@event is InputEventMouseButton mbEvent) {
			if ((MouseButton)mbEvent.ButtonIndex == MouseButton.Left) {
				if (mbEvent.Pressed) {
					isDragging = true;
					dragStartPOS = mbEvent.Position;
					cameraStartPOS = mbEvent.Position;
				} else {
					isDragging = false;
				}
			}
		}
		else if (@event is InputEventMouseMotion mmEvent && isDragging) {
			Vector2 dragOffset = mmEvent.Position - dragStartPOS;
			Position = cameraStartPOS - dragOffset;
		}
	}
}
