using Godot;
using System;

public partial class GameScene : Node2D
{
	public int health = 5, mana = 5, attack = 5, defence = 5; 

	public bool melee = false, ranged = false;
	
	//Init values for class that is pressed currently 
	private void OnClassButtonPressed()
	{
		GD.Print("Class Button Pressed");
		SetBerserkerClass();
		//GD.Print(health);
		
	}
	
	private void OnClassButton2Pressed()
	{
		GD.Print("Class Button 2 Pressed");
		SetGunnerClass();
		
	}
	
	private void OnClassButton3Pressed()
	{
		GD.Print("Class Button 3 Pressed");
	}
	
	public void SetBerserkerClass()
	{
		health = 8;
		mana = 5;
		attack = 1;
		defence = 15;
		
		melee = true;
	}

	public void SetGunnerClass()
	{
		//do not set health
		mana = 8;
		attack = 10;
		//do not set defense
		
		ranged = true;
	}
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var button = GetNode<Button>("Class Button");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
