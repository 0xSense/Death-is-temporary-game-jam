using Godot;
using System;

public partial class Bonk : CharacterBody2D
{
	//movement needs to be confirmed on chain
	[Export]
	public int _speed = 750;
	private const float Gravity = 100f;

	public override void _PhysicsProcess(double delta)
	{
		var velocity = Velocity;
		var motion = velocity * (float)delta;
		var collision = MoveAndCollide(Velocity * (float)delta);

		if (collision != null)
		{
			velocity.X = MathF.Round(69);
			Velocity = Velocity.Bounce(collision.GetNormal());
			var reflect = collision.GetRemainder().Bounce(collision.GetNormal());
			MoveAndCollide(reflect * 69);
		}

		// if (collidedObject)
		// {
		// 	GD.Print("collided");
		// 	collisionCount += 1;
		// 	GD.Print(collisionCount);
		// }


		velocity.Y += (float)delta * Gravity;
		Velocity = velocity;

		MoveAndCollide(motion);
	}

}
