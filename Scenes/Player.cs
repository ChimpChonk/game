using Godot;
using System;

public class Player : KinematicBody2D
{

    Vector2 direction;
    float movementSpeed = 500;
    public override void _Ready()
    {
        
    }


    public override void _PhysicsProcess(float delta)
    {
        direction.x = Input.GetActionStrength("move_right") -Input.GetActionStrength("move_left");
        direction.x *= movementSpeed;
        direction =  MoveAndSlide(direction, Vector2.Up);
    }

}
