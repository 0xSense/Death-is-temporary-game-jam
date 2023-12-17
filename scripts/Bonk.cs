using Godot;
using System;

public partial class Bonk : CharacterBody2D
{
	//movement needs to be confirmed on chain
	[Export] public int _speed = 750;
	[Export] public int _count = 0;
	private const float Gravity = 100f;

	public override void _PhysicsProcess(double delta)
	{
		var velocity = Velocity;
		var motion = velocity * (float)delta;
		var collision = MoveAndCollide(Velocity * (float)delta);

		if (collision != null)
		{
			Random rnd = new Random();
			int num = rnd.Next(-70, 70);
			velocity.X = MathF.Round(num);
			Velocity = Velocity.Bounce(collision.GetNormal());
			var reflect = collision.GetRemainder().Bounce(collision.GetNormal());
			MoveAndCollide(reflect * 69);
			_count += 1;
		}

		velocity.Y += (float)delta * Gravity;
		Velocity = velocity;

		MoveAndCollide(motion);
	}
}
