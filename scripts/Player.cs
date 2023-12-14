using Godot;
using System;

public partial class Player : CharacterBody2D
{
	[Export]
	public int Speed { get; set; } = 400;

	private Vector2 _target;

	public override void _Input(InputEvent @event)
	{
		if (@event.IsActionPressed("click"))
		{
			_target = GetGlobalMousePosition();
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		//pc user controls & mobile controls
		// Physics based movement than gets confirmed on chain and changes the dirrection the sprite moves too

		Velocity = Position.DirectionTo(_target) * Speed;


		if (Position.DistanceTo(_target) > 10)
		{
			MoveAndSlide();
		}

	}

}
