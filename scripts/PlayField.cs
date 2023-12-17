using Godot;
using System;

public partial class PlayField : Node2D
{
	private CharacterBody2D _bonk2D;
	private Label _button;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_bonk2D = GetNode<CharacterBody2D>("Bonk");
		_button = GetNode<Label>("Text");
	}
}
