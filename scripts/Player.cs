using Godot;
using System;

public partial class Player : CharacterBody2D
{
	//movement needs to be confirmed on chain
	[Export]
	public int Speed { get; set; } = 400;

	private Vector2 _target;

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	public void Bounce()
	{
		GD.Print("Bounce");
	}

}
