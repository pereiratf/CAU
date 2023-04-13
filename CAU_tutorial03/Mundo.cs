using Godot;
using System;

public partial class Mundo : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

    public override void _UnhandledInput(InputEvent @event)
    {
        if (@event is InputEventMouseButton mouseEvent){
            // create instance of Sprite scene
			var sprite = GD.Load<PackedScene>("res://sprite_2d.tscn"); 
			var inst = sprite.Instantiate(); 
			AddChild(inst);
        }
    }
}
