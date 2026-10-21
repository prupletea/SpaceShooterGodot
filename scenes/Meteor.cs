using Godot;
using System;

public partial class Meteor : Area2D {
	private void OnBodyEntered(Node2D body) {
		GD.Print("body entered");
	}
}
