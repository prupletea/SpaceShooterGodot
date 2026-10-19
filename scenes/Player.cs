using Godot;
using System;

public partial class Player : Node2D {
	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		Position = new Vector2(640, 640);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		//Position += new Vector2(1, 0) * 42 * (float) delta;
		var playerImageNode = GetNode<Node2D>("PlayerImage");
		//playerImageNode.Rotation += (float) 5 * (float) delta;

		var direction = Input.GetVector("left", "right", "up", "down");
		playerImageNode.Position += direction * 250 * (float) delta;
	}

}
