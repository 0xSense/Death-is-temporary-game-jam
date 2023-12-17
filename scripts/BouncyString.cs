using Godot;
using System;
using System.ComponentModel;

public partial class BouncyString : CharacterBody2D
{
	// Called when the node enters the scene tree for the first time.
	[Export]
	public int Speed { get; set; } = 400;

	private Vector2 _target;
	private AnimatedSprite2D _stringSprite;

	public override void _Ready()
	{
		_stringSprite = GetNode<AnimatedSprite2D>("StringAnimation");

	}

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

		// collision animation play
		if (Input.IsActionPressed("click"))
		{
			_stringSprite.Play("string");
		}
	}


}
