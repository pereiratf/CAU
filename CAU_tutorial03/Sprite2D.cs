using Godot;
using System;

public partial class Sprite2D : Godot.Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		uint aleatorio = GD.Randi() % 4; // 0 ~ 3
		switch(aleatorio) {
			case 0: //cima
				GlobalPosition = GlobalPosition + new Vector2(0,-4);
			break;
			
			case 1: //baixo
				GlobalPosition = GlobalPosition + new Vector2(0,4);
			break;
			
			case 2: //esquerda
				GlobalPosition = GlobalPosition + new Vector2(-4,0);
			break;
			
			case 3: //direita
				GlobalPosition = GlobalPosition + new Vector2(4,0);
			break;
		}
	}
}

