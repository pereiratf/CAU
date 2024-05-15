using Godot;
using System;

public partial class raposa : CharacterBody2D
{
	private float velocidade=300f, pulo=-400f, gravidade=10f;
	private Vector2 movimento;
	
	public override void _PhysicsProcess(double delta)
	{
		movimento = Velocity;

		// gravidade
		if (IsOnFloor() == false) {
			movimento.Y += gravidade;
		}
		// pular
		if (Input.IsActionJustPressed("pula") && IsOnFloor()) {
			movimento.Y = pulo;
		}
		if (Input.IsActionPressed("direita")) {
			movimento.X = velocidade;
		} else if (Input.IsActionPressed("esquerda")) {
			movimento.X = -velocidade;
		} else {
			movimento.X = 0;
		}
		

		Velocity = movimento;
		MoveAndSlide();
	}
}
